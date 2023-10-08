namespace Wallet
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblLog = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnAddMoney = new System.Windows.Forms.Button();
            this.lbl2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAddMoney = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbExchange = new System.Windows.Forms.ComboBox();
            this.currenciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.walletDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wallet_DBDataSet = new Wallet.Wallet_DBDataSet();
            this.cmbPurchase = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExchange = new System.Windows.Forms.Button();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.currenciesTableAdapter = new Wallet.Wallet_DBDataSetTableAdapters.CurrenciesTableAdapter();
            this.lsvRate = new System.Windows.Forms.ListView();
            this.NameCurrency = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CurrencyDesignation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRate = new System.Windows.Forms.Button();
            this.lsvBalance = new System.Windows.Forms.ListView();
            this.NameCurrencie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DesignationCurrency = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Balance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnBalance = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.currenciesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.walletDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallet_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(12, 19);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(36, 13);
            this.lblLog.TabIndex = 0;
            this.lblLog.Text = "Login:";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(12, 58);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(60, 13);
            this.lblFName.TabIndex = 1;
            this.lblFName.Text = "First Name:";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Location = new System.Drawing.Point(12, 105);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(61, 13);
            this.lblLName.TabIndex = 2;
            this.lblLName.Text = "Last Name:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(12, 152);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(41, 13);
            this.lblPhone.TabIndex = 3;
            this.lblPhone.Text = "Phone:";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(78, 12);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.ReadOnly = true;
            this.txtLogin.Size = new System.Drawing.Size(109, 20);
            this.txtLogin.TabIndex = 4;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(78, 51);
            this.txtFName.Name = "txtFName";
            this.txtFName.ReadOnly = true;
            this.txtFName.Size = new System.Drawing.Size(111, 20);
            this.txtFName.TabIndex = 5;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(79, 99);
            this.txtLName.Name = "txtLName";
            this.txtLName.ReadOnly = true;
            this.txtLName.Size = new System.Drawing.Size(110, 20);
            this.txtLName.TabIndex = 6;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(78, 145);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(110, 20);
            this.txtPhone.TabIndex = 7;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(30, 285);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(104, 13);
            this.lbl1.TabIndex = 9;
            this.lbl1.Text = "Пополнить баланс:";
            // 
            // btnAddMoney
            // 
            this.btnAddMoney.Location = new System.Drawing.Point(234, 312);
            this.btnAddMoney.Name = "btnAddMoney";
            this.btnAddMoney.Size = new System.Drawing.Size(75, 23);
            this.btnAddMoney.TabIndex = 10;
            this.btnAddMoney.Text = "Пополнить";
            this.btnAddMoney.UseVisualStyleBackColor = true;
            this.btnAddMoney.Click += new System.EventHandler(this.btnAddMoney_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(30, 317);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(43, 13);
            this.lbl2.TabIndex = 11;
            this.lbl2.Text = "Внести";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "руб.";
            // 
            // txtAddMoney
            // 
            this.txtAddMoney.Location = new System.Drawing.Point(79, 314);
            this.txtAddMoney.Name = "txtAddMoney";
            this.txtAddMoney.Size = new System.Drawing.Size(89, 20);
            this.txtAddMoney.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Обмен валюты:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(500, 314);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(91, 20);
            this.txtQuantity.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Обменять";
            // 
            // cmbExchange
            // 
            this.cmbExchange.DataSource = this.currenciesBindingSource;
            this.cmbExchange.DisplayMember = "CurrencyDesignation";
            this.cmbExchange.FormattingEnabled = true;
            this.cmbExchange.Location = new System.Drawing.Point(608, 313);
            this.cmbExchange.Name = "cmbExchange";
            this.cmbExchange.Size = new System.Drawing.Size(56, 21);
            this.cmbExchange.TabIndex = 17;
            // 
            // currenciesBindingSource
            // 
            this.currenciesBindingSource.DataMember = "Currencies";
            this.currenciesBindingSource.DataSource = this.walletDBDataSetBindingSource;
            // 
            // walletDBDataSetBindingSource
            // 
            this.walletDBDataSetBindingSource.DataSource = this.wallet_DBDataSet;
            this.walletDBDataSetBindingSource.Position = 0;
            // 
            // wallet_DBDataSet
            // 
            this.wallet_DBDataSet.DataSetName = "Wallet_DBDataSet";
            this.wallet_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbPurchase
            // 
            this.cmbPurchase.FormattingEnabled = true;
            this.cmbPurchase.Location = new System.Drawing.Point(727, 314);
            this.cmbPurchase.Name = "cmbPurchase";
            this.cmbPurchase.Size = new System.Drawing.Size(56, 21);
            this.cmbPurchase.TabIndex = 18;
            this.cmbPurchase.Enter += new System.EventHandler(this.cmbPurchase_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(686, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "на";
            // 
            // btnExchange
            // 
            this.btnExchange.Location = new System.Drawing.Point(805, 311);
            this.btnExchange.Name = "btnExchange";
            this.btnExchange.Size = new System.Drawing.Size(95, 23);
            this.btnExchange.TabIndex = 20;
            this.btnExchange.Text = "Обменять";
            this.btnExchange.UseVisualStyleBackColor = true;
            this.btnExchange.Click += new System.EventHandler(this.btnExchange_Click);
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // currenciesTableAdapter
            // 
            this.currenciesTableAdapter.ClearBeforeFill = true;
            // 
            // lsvRate
            // 
            this.lsvRate.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameCurrency,
            this.CurrencyDesignation,
            this.Rate});
            this.lsvRate.HideSelection = false;
            this.lsvRate.Location = new System.Drawing.Point(578, 19);
            this.lsvRate.Name = "lsvRate";
            this.lsvRate.Size = new System.Drawing.Size(317, 205);
            this.lsvRate.TabIndex = 21;
            this.lsvRate.UseCompatibleStateImageBehavior = false;
            this.lsvRate.View = System.Windows.Forms.View.Details;
            // 
            // NameCurrency
            // 
            this.NameCurrency.Text = "Name Currency";
            this.NameCurrency.Width = 108;
            // 
            // CurrencyDesignation
            // 
            this.CurrencyDesignation.Text = "Currency Designation";
            this.CurrencyDesignation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CurrencyDesignation.Width = 114;
            // 
            // Rate
            // 
            this.Rate.Text = "Rate";
            this.Rate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Rate.Width = 86;
            // 
            // btnRate
            // 
            this.btnRate.Location = new System.Drawing.Point(785, 230);
            this.btnRate.Name = "btnRate";
            this.btnRate.Size = new System.Drawing.Size(110, 23);
            this.btnRate.TabIndex = 22;
            this.btnRate.Text = "Обновить курс";
            this.btnRate.UseVisualStyleBackColor = true;
            this.btnRate.Click += new System.EventHandler(this.btnRate_Click);
            // 
            // lsvBalance
            // 
            this.lsvBalance.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameCurrencie,
            this.DesignationCurrency,
            this.Balance});
            this.lsvBalance.HideSelection = false;
            this.lsvBalance.Location = new System.Drawing.Point(221, 19);
            this.lsvBalance.Name = "lsvBalance";
            this.lsvBalance.Size = new System.Drawing.Size(301, 205);
            this.lsvBalance.TabIndex = 23;
            this.lsvBalance.UseCompatibleStateImageBehavior = false;
            this.lsvBalance.View = System.Windows.Forms.View.Details;
            // 
            // NameCurrencie
            // 
            this.NameCurrencie.Text = "Name Currency";
            this.NameCurrencie.Width = 101;
            // 
            // DesignationCurrency
            // 
            this.DesignationCurrency.Text = "Designation Currency";
            this.DesignationCurrency.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DesignationCurrency.Width = 115;
            // 
            // Balance
            // 
            this.Balance.Text = "Balance";
            this.Balance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Balance.Width = 71;
            // 
            // btnBalance
            // 
            this.btnBalance.Location = new System.Drawing.Point(415, 230);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(110, 23);
            this.btnBalance.TabIndex = 24;
            this.btnBalance.Text = "Обновить баланс";
            this.btnBalance.UseVisualStyleBackColor = true;
            this.btnBalance.Click += new System.EventHandler(this.btnBalance_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 373);
            this.Controls.Add(this.btnBalance);
            this.Controls.Add(this.lsvBalance);
            this.Controls.Add(this.btnRate);
            this.Controls.Add(this.lsvRate);
            this.Controls.Add(this.btnExchange);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbPurchase);
            this.Controls.Add(this.cmbExchange);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAddMoney);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.btnAddMoney);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblLName);
            this.Controls.Add(this.lblFName);
            this.Controls.Add(this.lblLog);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.currenciesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.walletDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallet_DBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnAddMoney;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAddMoney;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbExchange;
        private System.Windows.Forms.ComboBox cmbPurchase;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExchange;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private System.Windows.Forms.BindingSource walletDBDataSetBindingSource;
        private Wallet_DBDataSet wallet_DBDataSet;
        private System.Windows.Forms.BindingSource currenciesBindingSource;
        private Wallet_DBDataSetTableAdapters.CurrenciesTableAdapter currenciesTableAdapter;
        private System.Windows.Forms.ListView lsvRate;
        private System.Windows.Forms.ColumnHeader NameCurrency;
        private System.Windows.Forms.ColumnHeader CurrencyDesignation;
        private System.Windows.Forms.ColumnHeader Rate;
        private System.Windows.Forms.Button btnRate;
        private System.Windows.Forms.ListView lsvBalance;
        private System.Windows.Forms.ColumnHeader NameCurrencie;
        private System.Windows.Forms.ColumnHeader DesignationCurrency;
        private System.Windows.Forms.ColumnHeader Balance;
        private System.Windows.Forms.Button btnBalance;
    }
}