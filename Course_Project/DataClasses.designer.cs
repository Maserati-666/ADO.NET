﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Wallet
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Wallet_DB")]
	public partial class DataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Определения метода расширяемости
    partial void OnCreated();
    partial void InsertCurrencies(Currencies instance);
    partial void UpdateCurrencies(Currencies instance);
    partial void DeleteCurrencies(Currencies instance);
    partial void InsertCurrencies_Traders(Currencies_Traders instance);
    partial void UpdateCurrencies_Traders(Currencies_Traders instance);
    partial void DeleteCurrencies_Traders(Currencies_Traders instance);
    partial void InsertExchangeOperation(ExchangeOperation instance);
    partial void UpdateExchangeOperation(ExchangeOperation instance);
    partial void DeleteExchangeOperation(ExchangeOperation instance);
    partial void InsertExchangeOperationType(ExchangeOperationType instance);
    partial void UpdateExchangeOperationType(ExchangeOperationType instance);
    partial void DeleteExchangeOperationType(ExchangeOperationType instance);
    partial void InsertExchangeRate(ExchangeRate instance);
    partial void UpdateExchangeRate(ExchangeRate instance);
    partial void DeleteExchangeRate(ExchangeRate instance);
    partial void InsertTraders(Traders instance);
    partial void UpdateTraders(Traders instance);
    partial void DeleteTraders(Traders instance);
    #endregion
		
		public DataClassesDataContext() : 
				base(global::Wallet.Properties.Settings.Default.Wallet_DBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Currencies> Currencies
		{
			get
			{
				return this.GetTable<Currencies>();
			}
		}
		
		public System.Data.Linq.Table<Currencies_Traders> Currencies_Traders
		{
			get
			{
				return this.GetTable<Currencies_Traders>();
			}
		}
		
		public System.Data.Linq.Table<ExchangeOperation> ExchangeOperation
		{
			get
			{
				return this.GetTable<ExchangeOperation>();
			}
		}
		
		public System.Data.Linq.Table<ExchangeOperationType> ExchangeOperationType
		{
			get
			{
				return this.GetTable<ExchangeOperationType>();
			}
		}
		
		public System.Data.Linq.Table<ExchangeRate> ExchangeRate
		{
			get
			{
				return this.GetTable<ExchangeRate>();
			}
		}
		
		public System.Data.Linq.Table<Traders> Traders
		{
			get
			{
				return this.GetTable<Traders>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Currencies")]
	public partial class Currencies : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CurrenciesID;
		
		private string _CurrencyDesignation;
		
		private string _NameCurrency;
		
		private EntitySet<Currencies_Traders> _Currencies_Traders;
		
		private EntitySet<ExchangeRate> _ExchangeRate;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCurrenciesIDChanging(int value);
    partial void OnCurrenciesIDChanged();
    partial void OnCurrencyDesignationChanging(string value);
    partial void OnCurrencyDesignationChanged();
    partial void OnNameCurrencyChanging(string value);
    partial void OnNameCurrencyChanged();
    #endregion
		
		public Currencies()
		{
			this._Currencies_Traders = new EntitySet<Currencies_Traders>(new Action<Currencies_Traders>(this.attach_Currencies_Traders), new Action<Currencies_Traders>(this.detach_Currencies_Traders));
			this._ExchangeRate = new EntitySet<ExchangeRate>(new Action<ExchangeRate>(this.attach_ExchangeRate), new Action<ExchangeRate>(this.detach_ExchangeRate));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CurrenciesID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int CurrenciesID
		{
			get
			{
				return this._CurrenciesID;
			}
			set
			{
				if ((this._CurrenciesID != value))
				{
					this.OnCurrenciesIDChanging(value);
					this.SendPropertyChanging();
					this._CurrenciesID = value;
					this.SendPropertyChanged("CurrenciesID");
					this.OnCurrenciesIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CurrencyDesignation", DbType="NChar(3) NOT NULL", CanBeNull=false)]
		public string CurrencyDesignation
		{
			get
			{
				return this._CurrencyDesignation;
			}
			set
			{
				if ((this._CurrencyDesignation != value))
				{
					this.OnCurrencyDesignationChanging(value);
					this.SendPropertyChanging();
					this._CurrencyDesignation = value;
					this.SendPropertyChanged("CurrencyDesignation");
					this.OnCurrencyDesignationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NameCurrency", DbType="NVarChar(40) NOT NULL", CanBeNull=false)]
		public string NameCurrency
		{
			get
			{
				return this._NameCurrency;
			}
			set
			{
				if ((this._NameCurrency != value))
				{
					this.OnNameCurrencyChanging(value);
					this.SendPropertyChanging();
					this._NameCurrency = value;
					this.SendPropertyChanged("NameCurrency");
					this.OnNameCurrencyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Currencies_Currencies_Traders", Storage="_Currencies_Traders", ThisKey="CurrenciesID", OtherKey="CurrenciesID")]
		public EntitySet<Currencies_Traders> Currencies_Traders
		{
			get
			{
				return this._Currencies_Traders;
			}
			set
			{
				this._Currencies_Traders.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Currencies_ExchangeRate", Storage="_ExchangeRate", ThisKey="CurrenciesID", OtherKey="CurrenciesID")]
		public EntitySet<ExchangeRate> ExchangeRate
		{
			get
			{
				return this._ExchangeRate;
			}
			set
			{
				this._ExchangeRate.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Currencies_Traders(Currencies_Traders entity)
		{
			this.SendPropertyChanging();
			entity.Currencies = this;
		}
		
		private void detach_Currencies_Traders(Currencies_Traders entity)
		{
			this.SendPropertyChanging();
			entity.Currencies = null;
		}
		
		private void attach_ExchangeRate(ExchangeRate entity)
		{
			this.SendPropertyChanging();
			entity.Currencies = this;
		}
		
		private void detach_ExchangeRate(ExchangeRate entity)
		{
			this.SendPropertyChanging();
			entity.Currencies = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Currencies_Traders")]
	public partial class Currencies_Traders : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CurrenciesID;
		
		private int _TradersID;
		
		private System.Nullable<decimal> _Quantity;
		
		private EntityRef<Currencies> _Currencies;
		
		private EntityRef<Traders> _Traders;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCurrenciesIDChanging(int value);
    partial void OnCurrenciesIDChanged();
    partial void OnTradersIDChanging(int value);
    partial void OnTradersIDChanged();
    partial void OnQuantityChanging(System.Nullable<decimal> value);
    partial void OnQuantityChanged();
    #endregion
		
		public Currencies_Traders()
		{
			this._Currencies = default(EntityRef<Currencies>);
			this._Traders = default(EntityRef<Traders>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CurrenciesID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int CurrenciesID
		{
			get
			{
				return this._CurrenciesID;
			}
			set
			{
				if ((this._CurrenciesID != value))
				{
					if (this._Currencies.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCurrenciesIDChanging(value);
					this.SendPropertyChanging();
					this._CurrenciesID = value;
					this.SendPropertyChanged("CurrenciesID");
					this.OnCurrenciesIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TradersID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int TradersID
		{
			get
			{
				return this._TradersID;
			}
			set
			{
				if ((this._TradersID != value))
				{
					if (this._Traders.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnTradersIDChanging(value);
					this.SendPropertyChanging();
					this._TradersID = value;
					this.SendPropertyChanged("TradersID");
					this.OnTradersIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quantity", DbType="Decimal(16,4)")]
		public System.Nullable<decimal> Quantity
		{
			get
			{
				return this._Quantity;
			}
			set
			{
				if ((this._Quantity != value))
				{
					this.OnQuantityChanging(value);
					this.SendPropertyChanging();
					this._Quantity = value;
					this.SendPropertyChanged("Quantity");
					this.OnQuantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Currencies_Currencies_Traders", Storage="_Currencies", ThisKey="CurrenciesID", OtherKey="CurrenciesID", IsForeignKey=true)]
		public Currencies Currencies
		{
			get
			{
				return this._Currencies.Entity;
			}
			set
			{
				Currencies previousValue = this._Currencies.Entity;
				if (((previousValue != value) 
							|| (this._Currencies.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Currencies.Entity = null;
						previousValue.Currencies_Traders.Remove(this);
					}
					this._Currencies.Entity = value;
					if ((value != null))
					{
						value.Currencies_Traders.Add(this);
						this._CurrenciesID = value.CurrenciesID;
					}
					else
					{
						this._CurrenciesID = default(int);
					}
					this.SendPropertyChanged("Currencies");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Traders_Currencies_Traders", Storage="_Traders", ThisKey="TradersID", OtherKey="TradersID", IsForeignKey=true)]
		public Traders Traders
		{
			get
			{
				return this._Traders.Entity;
			}
			set
			{
				Traders previousValue = this._Traders.Entity;
				if (((previousValue != value) 
							|| (this._Traders.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Traders.Entity = null;
						previousValue.Currencies_Traders.Remove(this);
					}
					this._Traders.Entity = value;
					if ((value != null))
					{
						value.Currencies_Traders.Add(this);
						this._TradersID = value.TradersID;
					}
					else
					{
						this._TradersID = default(int);
					}
					this.SendPropertyChanged("Traders");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ExchangeOperation")]
	public partial class ExchangeOperation : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ExchangeOperationID;
		
		private int _CurrenciesID;
		
		private decimal _Quantity;
		
		private short _ExchangeOperationTypeID;
		
		private int _TradersID;
		
		private System.DateTime _TransactionDate;
		
		private EntityRef<ExchangeOperationType> _ExchangeOperationType;
		
		private EntityRef<Traders> _Traders;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnExchangeOperationIDChanging(int value);
    partial void OnExchangeOperationIDChanged();
    partial void OnCurrenciesIDChanging(int value);
    partial void OnCurrenciesIDChanged();
    partial void OnQuantityChanging(decimal value);
    partial void OnQuantityChanged();
    partial void OnExchangeOperationTypeIDChanging(short value);
    partial void OnExchangeOperationTypeIDChanged();
    partial void OnTradersIDChanging(int value);
    partial void OnTradersIDChanged();
    partial void OnTransactionDateChanging(System.DateTime value);
    partial void OnTransactionDateChanged();
    #endregion
		
		public ExchangeOperation()
		{
			this._ExchangeOperationType = default(EntityRef<ExchangeOperationType>);
			this._Traders = default(EntityRef<Traders>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ExchangeOperationID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ExchangeOperationID
		{
			get
			{
				return this._ExchangeOperationID;
			}
			set
			{
				if ((this._ExchangeOperationID != value))
				{
					this.OnExchangeOperationIDChanging(value);
					this.SendPropertyChanging();
					this._ExchangeOperationID = value;
					this.SendPropertyChanged("ExchangeOperationID");
					this.OnExchangeOperationIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CurrenciesID", DbType="Int NOT NULL")]
		public int CurrenciesID
		{
			get
			{
				return this._CurrenciesID;
			}
			set
			{
				if ((this._CurrenciesID != value))
				{
					this.OnCurrenciesIDChanging(value);
					this.SendPropertyChanging();
					this._CurrenciesID = value;
					this.SendPropertyChanged("CurrenciesID");
					this.OnCurrenciesIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quantity", DbType="Decimal(16,4) NOT NULL")]
		public decimal Quantity
		{
			get
			{
				return this._Quantity;
			}
			set
			{
				if ((this._Quantity != value))
				{
					this.OnQuantityChanging(value);
					this.SendPropertyChanging();
					this._Quantity = value;
					this.SendPropertyChanged("Quantity");
					this.OnQuantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ExchangeOperationTypeID", DbType="SmallInt NOT NULL")]
		public short ExchangeOperationTypeID
		{
			get
			{
				return this._ExchangeOperationTypeID;
			}
			set
			{
				if ((this._ExchangeOperationTypeID != value))
				{
					if (this._ExchangeOperationType.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnExchangeOperationTypeIDChanging(value);
					this.SendPropertyChanging();
					this._ExchangeOperationTypeID = value;
					this.SendPropertyChanged("ExchangeOperationTypeID");
					this.OnExchangeOperationTypeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TradersID", DbType="Int NOT NULL")]
		public int TradersID
		{
			get
			{
				return this._TradersID;
			}
			set
			{
				if ((this._TradersID != value))
				{
					if (this._Traders.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnTradersIDChanging(value);
					this.SendPropertyChanging();
					this._TradersID = value;
					this.SendPropertyChanged("TradersID");
					this.OnTradersIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TransactionDate", DbType="Date NOT NULL")]
		public System.DateTime TransactionDate
		{
			get
			{
				return this._TransactionDate;
			}
			set
			{
				if ((this._TransactionDate != value))
				{
					this.OnTransactionDateChanging(value);
					this.SendPropertyChanging();
					this._TransactionDate = value;
					this.SendPropertyChanged("TransactionDate");
					this.OnTransactionDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ExchangeOperationType_ExchangeOperation", Storage="_ExchangeOperationType", ThisKey="ExchangeOperationTypeID", OtherKey="ExchangeOperationTypeID", IsForeignKey=true)]
		public ExchangeOperationType ExchangeOperationType
		{
			get
			{
				return this._ExchangeOperationType.Entity;
			}
			set
			{
				ExchangeOperationType previousValue = this._ExchangeOperationType.Entity;
				if (((previousValue != value) 
							|| (this._ExchangeOperationType.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._ExchangeOperationType.Entity = null;
						previousValue.ExchangeOperation.Remove(this);
					}
					this._ExchangeOperationType.Entity = value;
					if ((value != null))
					{
						value.ExchangeOperation.Add(this);
						this._ExchangeOperationTypeID = value.ExchangeOperationTypeID;
					}
					else
					{
						this._ExchangeOperationTypeID = default(short);
					}
					this.SendPropertyChanged("ExchangeOperationType");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Traders_ExchangeOperation", Storage="_Traders", ThisKey="TradersID", OtherKey="TradersID", IsForeignKey=true)]
		public Traders Traders
		{
			get
			{
				return this._Traders.Entity;
			}
			set
			{
				Traders previousValue = this._Traders.Entity;
				if (((previousValue != value) 
							|| (this._Traders.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Traders.Entity = null;
						previousValue.ExchangeOperation.Remove(this);
					}
					this._Traders.Entity = value;
					if ((value != null))
					{
						value.ExchangeOperation.Add(this);
						this._TradersID = value.TradersID;
					}
					else
					{
						this._TradersID = default(int);
					}
					this.SendPropertyChanged("Traders");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ExchangeOperationType")]
	public partial class ExchangeOperationType : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private short _ExchangeOperationTypeID;
		
		private string _Descriptions;
		
		private EntitySet<ExchangeOperation> _ExchangeOperation;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnExchangeOperationTypeIDChanging(short value);
    partial void OnExchangeOperationTypeIDChanged();
    partial void OnDescriptionsChanging(string value);
    partial void OnDescriptionsChanged();
    #endregion
		
		public ExchangeOperationType()
		{
			this._ExchangeOperation = new EntitySet<ExchangeOperation>(new Action<ExchangeOperation>(this.attach_ExchangeOperation), new Action<ExchangeOperation>(this.detach_ExchangeOperation));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ExchangeOperationTypeID", DbType="SmallInt NOT NULL", IsPrimaryKey=true)]
		public short ExchangeOperationTypeID
		{
			get
			{
				return this._ExchangeOperationTypeID;
			}
			set
			{
				if ((this._ExchangeOperationTypeID != value))
				{
					this.OnExchangeOperationTypeIDChanging(value);
					this.SendPropertyChanging();
					this._ExchangeOperationTypeID = value;
					this.SendPropertyChanged("ExchangeOperationTypeID");
					this.OnExchangeOperationTypeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Descriptions", DbType="NVarChar(40) NOT NULL", CanBeNull=false)]
		public string Descriptions
		{
			get
			{
				return this._Descriptions;
			}
			set
			{
				if ((this._Descriptions != value))
				{
					this.OnDescriptionsChanging(value);
					this.SendPropertyChanging();
					this._Descriptions = value;
					this.SendPropertyChanged("Descriptions");
					this.OnDescriptionsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="ExchangeOperationType_ExchangeOperation", Storage="_ExchangeOperation", ThisKey="ExchangeOperationTypeID", OtherKey="ExchangeOperationTypeID")]
		public EntitySet<ExchangeOperation> ExchangeOperation
		{
			get
			{
				return this._ExchangeOperation;
			}
			set
			{
				this._ExchangeOperation.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_ExchangeOperation(ExchangeOperation entity)
		{
			this.SendPropertyChanging();
			entity.ExchangeOperationType = this;
		}
		
		private void detach_ExchangeOperation(ExchangeOperation entity)
		{
			this.SendPropertyChanging();
			entity.ExchangeOperationType = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ExchangeRate")]
	public partial class ExchangeRate : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.DateTime _TransactionDate;
		
		private int _CurrenciesID;
		
		private decimal _Cost;
		
		private EntityRef<Currencies> _Currencies;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTransactionDateChanging(System.DateTime value);
    partial void OnTransactionDateChanged();
    partial void OnCurrenciesIDChanging(int value);
    partial void OnCurrenciesIDChanged();
    partial void OnCostChanging(decimal value);
    partial void OnCostChanged();
    #endregion
		
		public ExchangeRate()
		{
			this._Currencies = default(EntityRef<Currencies>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TransactionDate", DbType="Date NOT NULL", IsPrimaryKey=true)]
		public System.DateTime TransactionDate
		{
			get
			{
				return this._TransactionDate;
			}
			set
			{
				if ((this._TransactionDate != value))
				{
					this.OnTransactionDateChanging(value);
					this.SendPropertyChanging();
					this._TransactionDate = value;
					this.SendPropertyChanged("TransactionDate");
					this.OnTransactionDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CurrenciesID", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int CurrenciesID
		{
			get
			{
				return this._CurrenciesID;
			}
			set
			{
				if ((this._CurrenciesID != value))
				{
					if (this._Currencies.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnCurrenciesIDChanging(value);
					this.SendPropertyChanging();
					this._CurrenciesID = value;
					this.SendPropertyChanged("CurrenciesID");
					this.OnCurrenciesIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cost", DbType="Decimal(16,4) NOT NULL")]
		public decimal Cost
		{
			get
			{
				return this._Cost;
			}
			set
			{
				if ((this._Cost != value))
				{
					this.OnCostChanging(value);
					this.SendPropertyChanging();
					this._Cost = value;
					this.SendPropertyChanged("Cost");
					this.OnCostChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Currencies_ExchangeRate", Storage="_Currencies", ThisKey="CurrenciesID", OtherKey="CurrenciesID", IsForeignKey=true)]
		public Currencies Currencies
		{
			get
			{
				return this._Currencies.Entity;
			}
			set
			{
				Currencies previousValue = this._Currencies.Entity;
				if (((previousValue != value) 
							|| (this._Currencies.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Currencies.Entity = null;
						previousValue.ExchangeRate.Remove(this);
					}
					this._Currencies.Entity = value;
					if ((value != null))
					{
						value.ExchangeRate.Add(this);
						this._CurrenciesID = value.CurrenciesID;
					}
					else
					{
						this._CurrenciesID = default(int);
					}
					this.SendPropertyChanged("Currencies");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Traders")]
	public partial class Traders : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _TradersID;
		
		private string _FirstName;
		
		private string _LastName;
		
		private string _UserLogin;
		
		private string _Phone;
		
		private EntitySet<Currencies_Traders> _Currencies_Traders;
		
		private EntitySet<ExchangeOperation> _ExchangeOperation;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTradersIDChanging(int value);
    partial void OnTradersIDChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnUserLoginChanging(string value);
    partial void OnUserLoginChanged();
    partial void OnPhoneChanging(string value);
    partial void OnPhoneChanged();
    #endregion
		
		public Traders()
		{
			this._Currencies_Traders = new EntitySet<Currencies_Traders>(new Action<Currencies_Traders>(this.attach_Currencies_Traders), new Action<Currencies_Traders>(this.detach_Currencies_Traders));
			this._ExchangeOperation = new EntitySet<ExchangeOperation>(new Action<ExchangeOperation>(this.attach_ExchangeOperation), new Action<ExchangeOperation>(this.detach_ExchangeOperation));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TradersID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int TradersID
		{
			get
			{
				return this._TradersID;
			}
			set
			{
				if ((this._TradersID != value))
				{
					this.OnTradersIDChanging(value);
					this.SendPropertyChanging();
					this._TradersID = value;
					this.SendPropertyChanged("TradersID");
					this.OnTradersIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserLogin", DbType="NVarChar(25) NOT NULL", CanBeNull=false)]
		public string UserLogin
		{
			get
			{
				return this._UserLogin;
			}
			set
			{
				if ((this._UserLogin != value))
				{
					this.OnUserLoginChanging(value);
					this.SendPropertyChanging();
					this._UserLogin = value;
					this.SendPropertyChanged("UserLogin");
					this.OnUserLoginChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="NVarChar(24)")]
		public string Phone
		{
			get
			{
				return this._Phone;
			}
			set
			{
				if ((this._Phone != value))
				{
					this.OnPhoneChanging(value);
					this.SendPropertyChanging();
					this._Phone = value;
					this.SendPropertyChanged("Phone");
					this.OnPhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Traders_Currencies_Traders", Storage="_Currencies_Traders", ThisKey="TradersID", OtherKey="TradersID")]
		public EntitySet<Currencies_Traders> Currencies_Traders
		{
			get
			{
				return this._Currencies_Traders;
			}
			set
			{
				this._Currencies_Traders.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Traders_ExchangeOperation", Storage="_ExchangeOperation", ThisKey="TradersID", OtherKey="TradersID")]
		public EntitySet<ExchangeOperation> ExchangeOperation
		{
			get
			{
				return this._ExchangeOperation;
			}
			set
			{
				this._ExchangeOperation.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Currencies_Traders(Currencies_Traders entity)
		{
			this.SendPropertyChanging();
			entity.Traders = this;
		}
		
		private void detach_Currencies_Traders(Currencies_Traders entity)
		{
			this.SendPropertyChanging();
			entity.Traders = null;
		}
		
		private void attach_ExchangeOperation(ExchangeOperation entity)
		{
			this.SendPropertyChanging();
			entity.Traders = this;
		}
		
		private void detach_ExchangeOperation(ExchangeOperation entity)
		{
			this.SendPropertyChanging();
			entity.Traders = null;
		}
	}
}
#pragma warning restore 1591
