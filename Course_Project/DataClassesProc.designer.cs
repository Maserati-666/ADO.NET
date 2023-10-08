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
	public partial class DataClassesProcDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Определения метода расширяемости
    partial void OnCreated();
    #endregion
		
		public DataClassesProcDataContext() : 
				base(global::Wallet.Properties.Settings.Default.Wallet_DBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesProcDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesProcDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesProcDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesProcDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.Today_Cost")]
		public ISingleResult<Today_CostResult> Today_Cost()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<Today_CostResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.Balance")]
		public ISingleResult<BalanceResult> Balance([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Trader_ID", DbType="Int")] System.Nullable<int> trader_ID)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), trader_ID);
			return ((ISingleResult<BalanceResult>)(result.ReturnValue));
		}
	}
	
	public partial class Today_CostResult
	{
		
		private string _NameCurrency;
		
		private string _CurrencyDesignation;
		
		private decimal _Cost;
		
		public Today_CostResult()
		{
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
					this._NameCurrency = value;
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
					this._CurrencyDesignation = value;
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
					this._Cost = value;
				}
			}
		}
	}
	
	public partial class BalanceResult
	{
		
		private string _NameCurrency;
		
		private string _CurrencyDesignation;
		
		private decimal _Quantity;
		
		public BalanceResult()
		{
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
					this._NameCurrency = value;
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
					this._CurrencyDesignation = value;
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
					this._Quantity = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
