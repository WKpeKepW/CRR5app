namespace CRR5app
{
    public partial class Form1 : Form
    {
        string path;
        ExcelWorker ew;
        bool ewWorked = false;
        double CommissionforChange;
        double NewCommissionforChange;
        public Form1()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\Download";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    path = openFileDialog.FileName;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool pass = false; // проверка всех переменных для программы
            if (path == null)
                MessageBox.Show("Сначала выберите файл");
            else if (textBox1.Text == "" || textBox2.Text == "")
                MessageBox.Show("Выберите промежуток корректирования");
            else if (int.Parse(textBox1.Text) > int.Parse(textBox2.Text))
                MessageBox.Show("Начальное значение не может быть больше конечного значение");
            else
            {
                if (ewWorked)
                {
                    ewWorked = false;
                    ew.Dispose();
                }
                try
                {
                    CommissionforChange = Convert.ToDouble(textBoxOldComiss1.Text);
                    NewCommissionforChange = Convert.ToDouble(textBoxNewComiss1.Text);
                    pass = true;// проверка прошла успешно
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Произошла ошибка ввода данных, в столбцах %Комиссий. Корректная запись должна производиться с знаком ','Подробнее: "+ ex);
                }
                if (pass)
                {
                    ew = new ExcelWorker(path, 1);
                    SetManyProcent(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text),
                             int.Parse(textBox5.Text), int.Parse(textBox6.Text), int.Parse(textBox7.Text), int.Parse(textBox8.Text),
                             int.Parse(textBox9.Text), int.Parse(textBox10.Text), int.Parse(textBox11.Text), int.Parse(textBox12.Text),
                             int.Parse(textBox13.Text), int.Parse(textBox14.Text), int.Parse(textBox15.Text));
                    ew.SaveAs("Откорректированный файл.xlsx");
                    ewWorked = true;
                }
            }
        }
        private void SetManyProcent(int Start, int Finish, int OldProcentColumCommission, int NewProcentColumCommission, int PriceSalesman, int PriceImplement, int AmountGoods, int NewTotalSum, int Oldcomission, int NewModifiedComission, int surchargeOZON, int returnSign, int returnOzon, int returnCommision, int returnTotal)
        {
            
            int CommissionColumn;
            if (checkBox2.Checked) // Пересчитывает по столбцу с процентом комиссии по умолчанию, или же по новосозданному столбцу новой комиссии
                CommissionColumn = NewProcentColumCommission;
            else
                CommissionColumn = OldProcentColumCommission;
            for (int i = Start; i <= Finish; i++)// смотрим только те строки которые находяться в промежутке
            {
                if (ew.ReadCellDouble(i, CommissionColumn) == CommissionforChange && ew.ReadCellDouble(i, OldProcentColumCommission + 2) != 0.0d) //если в строке старой комисии 15% и при этом остальные строки прописаны начинаем менять или если включен параметр менять по новой комиссии то меняем
                {
                    if(!checkBox2.Checked)
                        ew.WriteToCell(i, NewProcentColumCommission, Valuedouble: NewCommissionforChange); //изменяем цену комисии
                    if (ew.ReadCellDouble(i, PriceSalesman) == ew.ReadCellDouble(i, PriceImplement)) // если цена продавца та же что и реализации
                    {
                        double priceS = ew.ReadCellDouble(i, PriceSalesman);
                        double amount; // если в приоритете новое "количество" 
                        if (checkBox1.Checked && ew.ReadCellDouble(i, AmountGoods + 1) != 0.0d)
                            amount = ew.ReadCellDouble(i, AmountGoods + 1);
                        else
                        {
                            if (ew.ReadCellDouble(i, AmountGoods) == 0)
                                MessageBox.Show("В ячейке обнаружено количество товара 0 по этому программа просчитает данные столбцы как 0");
                            amount = ew.ReadCellDouble(i, AmountGoods);
                        }    // конец условия приоритета
                        double commission = priceS * NewCommissionforChange * amount;
                        double total = priceS * amount - commission;
                        ew.WriteToCell(i, NewTotalSum, Valuedouble: total); //цена итого
                        ew.WriteToCell(i, NewModifiedComission, Valuedouble: commission);//новая комиссия
                        if (ew.ReadCell(i, returnSign) != "") //проверяем на возврат
                        { ew.WriteToCell(i, returnCommision, Valuedouble: commission); ew.WriteToCell(i, returnTotal, Valuedouble: total); }
                    }
                    else if (ew.ReadCellDouble(i, PriceSalesman) > ew.ReadCellDouble(i, PriceImplement)) // если цена продавца больше цены реализации
                    {
                        double priceS = ew.ReadCellDouble(i, PriceSalesman);
                        double priceP = ew.ReadCellDouble(i, PriceImplement);
                        double amount; // если в приоритете нужна новое количество являеться 
                        if (checkBox1.Checked && ew.ReadCellDouble(i, AmountGoods + 1) != 0.0d)
                            amount = ew.ReadCellDouble(i, AmountGoods + 1);
                        else
                        {
                            if (ew.ReadCellDouble(i, AmountGoods) == 0)
                                MessageBox.Show("В ячейке обнаружено количество товара 0 по этому программа просчитает данные столбцы как 0");
                            amount = ew.ReadCellDouble(i, AmountGoods);
                        }    // конец условия приоритета
                        double difference = priceS - priceP;
                        double commission = priceS * NewCommissionforChange;
                        double total = priceS * amount - commission * amount;
                        ew.WriteToCell(i, NewTotalSum, Valuedouble: total); //цена итого
                        if (commission > difference) // если комиссия покрывает разницу
                        {
                            if (commission - difference <= 0.12d)// доплата нужна если размер комиссии не позволяет сделать иначе
                            {
                                double surOzon = ((commission - difference) + 0.12d) * amount;
                                double newcomiss = 0.12d * amount;
                                ew.WriteToCell(i, surchargeOZON, Valuedouble: surOzon);
                                ew.WriteToCell(i, NewModifiedComission, Valuedouble: newcomiss);//новая комиссия
                                if (ew.ReadCell(i, returnSign) != "") //проверяем на возврат
                                {
                                    if (ew.ReadCellDouble(i, Oldcomission) != newcomiss)
                                        ew.WriteToCell(i, returnCommision, Valuedouble: newcomiss);
                                    ew.WriteToCell(i, returnOzon, Valuedouble: surOzon);
                                    ew.WriteToCell(i, returnTotal, Valuedouble: total);
                                }//новая комиссия
                            }
                            else //если комиссия покрывает разницу
                            {
                                double newcomiss = (commission - difference) * amount;
                                ew.WriteToCell(i, NewModifiedComission, Valuedouble: newcomiss);
                                if (ew.ReadCell(i, returnSign) != "") //проверяем на возврат
                                {
                                    if (ew.ReadCellDouble(i, Oldcomission) != newcomiss)
                                        ew.WriteToCell(i, returnCommision, Valuedouble: newcomiss);
                                    ew.WriteToCell(i, returnTotal, Valuedouble: total);
                                }//новая комиссия
                            }
                        }
                        else // если комиссия не покрывает разницу
                        {
                            double surOzon = ((difference - commission) + 0.12d) * amount;
                            double newcomiss = 0.12d * amount;
                            ew.WriteToCell(i, surchargeOZON, Valuedouble: surOzon);// цена доплаты
                            if (ew.ReadCellDouble(i, Oldcomission) != newcomiss)//заполняем только если комиссия изменилась
                                ew.WriteToCell(i, NewModifiedComission, Valuedouble: newcomiss); //новая комиссия
                            if (ew.ReadCell(i, returnSign) != "") //проверяем на возврат
                            {
                                if (ew.ReadCellDouble(i, Oldcomission) != newcomiss)
                                    ew.WriteToCell(i, returnCommision, Valuedouble: newcomiss);
                                ew.WriteToCell(i, returnOzon, Valuedouble: surOzon);
                                ew.WriteToCell(i, returnTotal, Valuedouble: total);
                            }
                        }
                    }
                    else // если цена продавца меньше цены реализации
                    {
                        double priceS = ew.ReadCellDouble(i, PriceSalesman);
                        double priceP = ew.ReadCellDouble(i, PriceImplement);
                        double amount; // если в приоритете нужна новое количество являеться 
                        if (checkBox1.Checked && ew.ReadCellDouble(i, AmountGoods + 1) != 0.0d)
                            amount = ew.ReadCellDouble(i, AmountGoods + 1);
                        else
                        {
                            if (ew.ReadCellDouble(i, AmountGoods) == 0)
                                MessageBox.Show("В ячейке обнаружено количество товара 0 по этому программа просчитает данные столбцы как 0");
                            amount = ew.ReadCellDouble(i, AmountGoods);
                        }    
                           // конец условия приоритета
                        double difference = (priceP - priceS) * amount;
                        double commission = priceS * NewCommissionforChange * amount;
                        double newcomiss = difference + commission;
                        double total = priceS * amount - commission;
                        ew.WriteToCell(i, NewTotalSum, Valuedouble: total);
                        ew.WriteToCell(i, NewModifiedComission, Valuedouble: newcomiss);
                        if (ew.ReadCell(i, returnSign) != "") //проверяем на возврат
                        { ew.WriteToCell(i, returnCommision, Valuedouble: newcomiss); ew.WriteToCell(i, returnTotal, Valuedouble: total); }
                    }
                }
                //if ((ew.ReadCellDouble(i, OldProcentColumCommission) == 0.15d && ew.ReadCellDouble(i, OldProcentColumCommission + 2) != 0.0d) || (checkBox2.Checked && ew.ReadCellDouble(i, NewProcentColumCommission) == 0.08d && ew.ReadCellDouble(i, OldProcentColumCommission + 2) != 0.0d))
                
                //if (ew.ReadCellDouble(i, CommissionColumn) == CommissionforChange && ew.ReadCellDouble(i, OldProcentColumCommission + 2) != 0.0d)
               

                //сейчас он удаляет нужные строки где была котеровка количиства, нужно сравнивать по полю ниже есть ли там 8% процетов в новой комисии и нет ли в старой комиссии 15%
                else if (checkBox2.Checked && checkBox3.Checked && ew.ReadCellDouble(i, NewProcentColumCommission) == 0d)//очищаем значения в случае если ктото случайно заполнил не те значения
                {
                    if (ew.ReadCellDouble(i + 1, NewProcentColumCommission) == NewCommissionforChange && ew.ReadCellDouble(i + 1, OldProcentColumCommission) == 0)//бывают случаи когда люди забывают сменить 8% в строку корректировки количиства и тогда программа стерает новую строку нада разабраться пример 345
                    {/*заглушка чтобы не обнулял строки где идет котеровка количества товара*/ }
                    else
                    {
                        ew.WriteToCell(i, NewProcentColumCommission, "null");
                        ew.WriteToCell(i, AmountGoods + 1, "null");
                        ew.WriteToCell(i, AmountGoods + 3, "null");
                        ew.WriteToCell(i, surchargeOZON, "null");
                        ew.WriteToCell(i, NewModifiedComission, "null");
                        ew.WriteToCell(i, NewTotalSum, "null");
                        ew.WriteToCell(i, returnOzon, "null");
                        ew.WriteToCell(i, returnCommision, "null");
                        ew.WriteToCell(i, returnTotal, "null");
                    }
                }
            }
        }

        private void PassNumber(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | e.KeyChar == '\b') return;
            else
                e.Handled = true;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ewWorked)
            {
                ew.Dispose();
            }
        }
    }
}