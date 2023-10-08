using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Wallet
{
    public partial class MainForm : Form
    {
        private static int trader_ID;
        public MainForm()
        {
            InitializeComponent();
        }

        //Заполнение данными полей имя фамилия и тд.
        //=====================================================================
        private void Load_Data_Trad(string login)
        {
            Table<Traders> Trader = db.GetTable<Traders>();
            var Data_Trad =
                (from trad in Trader
                 where trad.UserLogin == RegForm.txt1
                 select trad);
            foreach (var trad in Data_Trad)
            {
                txtLogin.Text = trad.UserLogin;
                txtFName.Text = trad.FirstName;
                txtLName.Text = trad.LastName;
                txtPhone.Text = trad.Phone;
                trader_ID = trad.TradersID;
            }
        }
        //=====================================================================

        //Получение баланса на счете 
        //=====================================================================================
        private decimal Load_Quantity(int currID, int tradID)
        {
            Table<Currencies_Traders> Currencies_Traders = db.GetTable<Currencies_Traders>();
            var Quan =
               (from quantity in Currencies_Traders
                where quantity.CurrenciesID == currID & quantity.TradersID == tradID
                select quantity);
            decimal quant = 0;
            foreach (var quantity in Quan)
            {
                quant = (decimal)quantity.Quantity;
            }
            return quant;
        }
        //=======================================================================================

        //Получение CurrenciesID для валюты в comboBox
        //=====================================================================
        private int Load_Curr_ID(string value)
        {
            Table<Currencies> Currencies = db.GetTable<Currencies>();
            var CurrID =
                (from curr in Currencies
                 where curr.CurrencyDesignation == value
                 select curr);
            int Curr_ID = 0;
            foreach (var curr in CurrID)
            {
                Curr_ID = curr.CurrenciesID;
            }
            return Curr_ID;
        }
        //======================================================================


        //Получение Cost для валюты в comboBox
        //=====================================================================
        private decimal Load_Cost_Curr(DateTime tran_Date, int currID)
        {
            Table<ExchangeRate> Ex_Rate = db.GetTable<ExchangeRate>();
            var valueCost =
                (from cst in Ex_Rate
                 where cst.TransactionDate == tran_Date & cst.CurrenciesID == currID
                 select cst);
            decimal cost_Value = 0;
            foreach (var cst in valueCost)
            {
                cost_Value = cst.Cost;
            }
            return cost_Value;
        }
        //======================================================================


        //Получение количества валюты 2 купленную за валюту 1
        //=======================================================================================
        private decimal Load_New_Curr2(string valuecmb1, string valuecmb2)
        {
            decimal bonus1 = Load_Cost_Curr(DateTime.Now, Load_Curr_ID(valuecmb1));
            decimal bonus2 = Load_Cost_Curr(DateTime.Now, Load_Curr_ID(valuecmb2));
            decimal val_Cost = 0;
            if (valuecmb1 == "RUB")
            {
                val_Cost = Math.Round(Decimal.Parse(txtQuantity.Text) / bonus2, 4);
            }
            else
            {
                if (valuecmb2 == "RUB")
                {
                    val_Cost = Math.Round(Decimal.Parse(txtQuantity.Text) * bonus1, 4);
                }
                else
                {
                    val_Cost = Math.Round(Decimal.Parse(txtQuantity.Text) * bonus1 / bonus2, 4);
                }
            }
            return val_Cost;
        }
        //====================================================================================================

        //Получение количества валют в корзине
        //=====================================================================
        private int Load_Count_Curr()
        {
            Table<Currencies> Currencies = db.GetTable<Currencies>();
            var CountCurr =
                (from curr in Currencies
                 select curr).Count();
            return CountCurr;
        }
        //=====================================================================

        //Коллекция для Сombobox2
        //======================================================================
        private string[] Arr(string text)
        {
            Table<Currencies> Currencies = db.GetTable<Currencies>();
            var CurrDes =
                (from curr in Currencies
                 where curr.CurrencyDesignation != text
                 select curr);
            string[] cmb2 = new string[Load_Count_Curr() - 1];
            int i = 0;
            foreach (var curr in CurrDes)
            {
                cmb2[i] = curr.CurrencyDesignation;
                i++;
            }
            return cmb2;
        }
        //======================================================================

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "wallet_DBDataSet.Currencies". При необходимости она может быть перемещена или удалена.
            this.currenciesTableAdapter.Fill(this.wallet_DBDataSet.Currencies);
            string login = RegForm.txt1;
            Load_Data_Trad(login);
        }
        DataContext db = new DataContext(@"Data Source=DESKTOP-TT3JANN\SQLEXPRESS;Initial Catalog=Wallet_DB;Persist Security Info=True;User ID=admin;Password=admin2");

        private void btnAddMoney_Click(object sender, EventArgs e)
        {
            ExchangeOperation operation = new ExchangeOperation
            {
                CurrenciesID = 10,
                Quantity = int.Parse(txtAddMoney.Text),
                ExchangeOperationTypeID = 2,
                TradersID = trader_ID,
                TransactionDate = DateTime.Now
            };
            db.GetTable<ExchangeOperation>().InsertOnSubmit(operation);
            try
            {
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            decimal Balance = Math.Round(Load_Quantity(10, trader_ID), 4);
            Table<Currencies_Traders> Currencies_Traders = db.GetTable<Currencies_Traders>();
            var Quan =
                            (from quantity in Currencies_Traders
                             where quantity.CurrenciesID == operation.CurrenciesID & quantity.TradersID == operation.TradersID
                             select quantity);
            foreach (var quantity in Quan)
            {
                quantity.Quantity = operation.Quantity + Balance;
            }
            try
            {
                db.SubmitChanges();
                MessageBox.Show("Баланс пополнен");
            }
            catch (Exception except)
            {
                MessageBox.Show(except.Message);
            }
        }

        private void btnRate_Click(object sender, EventArgs e)
        {
            lsvRate.Items.Clear();
            var db = new DataClassesProcDataContext();
            foreach (var r in db.Today_Cost())
            {
                ListViewItem item = lsvRate.Items.Add(r.NameCurrency.ToString());
                item.SubItems.Add(r.CurrencyDesignation.ToString());
                item.SubItems.Add(r.Cost.ToString());
            }

        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            lsvBalance.Items.Clear();
            var db = new DataClassesProcDataContext();
            foreach (var r in db.Balance(trader_ID))
            {
                ListViewItem item = lsvBalance.Items.Add(r.NameCurrency.ToString());
                item.SubItems.Add(r.CurrencyDesignation.ToString());
                item.SubItems.Add(r.Quantity.ToString());
            }
        }

        private void btnExchange_Click(object sender, EventArgs e)
        {
            string valuecmb1 = cmbExchange.Text;
            string valuecmb2 = cmbPurchase.Text;
            decimal Balance1 = Math.Round(Load_Quantity(Load_Curr_ID(valuecmb1), 2), 4);
            decimal Balance2 = Math.Round(Load_Quantity(Load_Curr_ID(valuecmb2), 2), 4);
            //Проверка баланса валюты 1
            //=======================================================================
            if (Balance1 < Decimal.Parse(txtQuantity.Text))
            {
                MessageBox.Show("Данной валюты недостаточно для обмена!!!");
            }
            else
            //=======================================================================
            {
                Balance1 = Balance1 - Math.Round(Decimal.Parse(txtQuantity.Text), 4);
                Balance2 = Balance2 + Load_New_Curr2(valuecmb1, valuecmb2);
                ExchangeOperation oper1 = new ExchangeOperation
                {
                    CurrenciesID = Load_Curr_ID(valuecmb1),
                    Quantity = Math.Round(Decimal.Parse(txtQuantity.Text), 4),
                    ExchangeOperationTypeID = 1,
                    TradersID = 2,
                    TransactionDate = DateTime.Parse("2023-09-24")
                };
                db.GetTable<ExchangeOperation>().InsertOnSubmit(oper1);
                try
                {
                    db.SubmitChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                Table<Currencies_Traders> Currencies_Traders = db.GetTable<Currencies_Traders>();
                var Quan1 =
               (from quantity in Currencies_Traders
                where quantity.CurrenciesID == oper1.CurrenciesID & quantity.TradersID == oper1.TradersID
                select quantity);
                foreach (var quantity in Quan1)
                {
                    quantity.Quantity = Balance1;
                }
                try
                {
                    db.SubmitChanges();
                }
                catch (Exception excep)
                {
                    MessageBox.Show(excep.Message);
                }

                ExchangeOperation oper2 = new ExchangeOperation
                {
                    CurrenciesID = Load_Curr_ID(valuecmb2),
                    Quantity = Load_New_Curr2(valuecmb1, valuecmb2),
                    ExchangeOperationTypeID = 2,
                    TradersID = 2,
                    TransactionDate = DateTime.Parse("2023-09-24")
                };
                db.GetTable<ExchangeOperation>().InsertOnSubmit(oper2);
                try
                {
                    db.SubmitChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                var Quan2 =
                (from quantity in Currencies_Traders
                 where quantity.CurrenciesID == oper2.CurrenciesID & quantity.TradersID == oper2.TradersID
                 select quantity);
                foreach (var quantity in Quan2)
                {
                    quantity.Quantity = Balance2;
                }
                try
                {
                    db.SubmitChanges();
                    MessageBox.Show("Обмен выполнен успешно");
                }
                catch (Exception except)
                {
                    MessageBox.Show(except.Message);
                }
            }
        }

        private void cmbPurchase_Enter(object sender, EventArgs e)
        {
            cmbPurchase.Items.Clear();
            cmbPurchase.Items.AddRange(Arr(cmbExchange.Text));
            this.Controls.Add(this.cmbPurchase);
        }
    }

}
