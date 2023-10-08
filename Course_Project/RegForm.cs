using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Wallet
{
    public partial class RegForm : Form
    {
        public static string txt1;
        public RegForm()
        {
            InitializeComponent();
        }
        DataContext db = new DataContext(@"Data Source=DESKTOP-TT3JANN\SQLEXPRESS;Initial Catalog=Wallet_DB;Persist Security Info=True;User ID=admin;Password=admin2");
       
        //Проверка есть ли данный пользователь в базе
        //=====================================================================
        private int Load_Count_Trad()
        {
            Table<Traders> Trader = db.GetTable<Traders>();
            var CountTrad =
                (from trad in Trader
                 where trad.UserLogin == txtLogin.Text
                 select trad).Count();
            return CountTrad;
        }
        //=====================================================================

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

        private void btnEnter_Click(object sender, EventArgs e)
        {
            int count;

            if (Load_Count_Trad() == 1)
            {
                txt1 = txtLogin.Text;
                MainForm MForm = new MainForm();
                this.Hide();
                MForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Данного пользователя нет в базе!");
            }

        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            if (Load_Count_Trad() != 1)
            {
                Traders trader = new Traders
                {
                    FirstName = txtFName.Text,
                    LastName = txtLName.Text,
                    UserLogin = txtLogin.Text,
                    Phone = txtPhone.Text
                };
                db.GetTable<Traders>().InsertOnSubmit(trader);
                try
                {
                    db.SubmitChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                int countCurr = Load_Count_Curr();
                for (int i = 1; i <= countCurr; i++)
                {
                    Currencies_Traders cur_trad = new Currencies_Traders();
                    cur_trad.CurrenciesID = i;
                    cur_trad.TradersID = trader.TradersID;
                    cur_trad.Quantity = 0;
                    db.GetTable<Currencies_Traders>().InsertOnSubmit(cur_trad);
                    try
                    {
                        db.SubmitChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Пользователь с данным Login уже существует!");
            }
           
        }
    }
}
