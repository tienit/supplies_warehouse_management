//*************************************************************
//Author           : Tien NQ
//Created Date     : 10/26/2017
//Comment          : Base class for access to database.
//History          : 
//*************************************************************

using System;
using System.Data;

namespace VKTIM.Component
{

public partial class DMASSETPRODUCTSInfo
{

#region "Private Members"
private int _ID;
private string _ASSET_NAME;
private string _ASSET_ONAME;
private string _ASSET_CODE;
private string _ASSET_DESCRIPTION;
private string _MANUFACTURER_NAME;
private int _MANUFACTURER_ID;
private string _UNIT_NAME;
private int _UNIT_ID;
private double _PRICE;
private int _CATEGORY_ID;
private string _CATEGORY_NAME;
private DateTime _EXPIRED_DATE;
private DateTime _STARTED_DATE;
private DateTime _CREATED_DATE;
private int _USER_ID;
private string _USER_NAME;
private double _QUANTITY;
private DateTime _LAST_IN;
private DateTime _LAST_OUT;
private int _ASSET_LEVEL_ID;
private string _ASSET_LEVEL_NAME;
private string _COUNTRY;
private double _WEIGHT;
#endregion

#region "Public Properties"
		public int ID {
			get { return _ID; }
			set { _ID = value; }
		}

		public string ASSET_NAME {
			get { return _ASSET_NAME; }
			set { _ASSET_NAME = value; }
		}

		public string ASSET_ONAME {
			get { return _ASSET_ONAME; }
			set { _ASSET_ONAME = value; }
		}

		public string ASSET_CODE {
			get { return _ASSET_CODE; }
			set { _ASSET_CODE = value; }
		}

		public string ASSET_DESCRIPTION {
			get { return _ASSET_DESCRIPTION; }
			set { _ASSET_DESCRIPTION = value; }
		}

		public string MANUFACTURER_NAME {
			get { return _MANUFACTURER_NAME; }
			set { _MANUFACTURER_NAME = value; }
		}

		public int MANUFACTURER_ID {
			get { return _MANUFACTURER_ID; }
			set { _MANUFACTURER_ID = value; }
		}

		public string UNIT_NAME {
			get { return _UNIT_NAME; }
			set { _UNIT_NAME = value; }
		}

		public int UNIT_ID {
			get { return _UNIT_ID; }
			set { _UNIT_ID = value; }
		}

		public double PRICE {
			get { return _PRICE; }
			set { _PRICE = value; }
		}

		public int CATEGORY_ID {
			get { return _CATEGORY_ID; }
			set { _CATEGORY_ID = value; }
		}

		public string CATEGORY_NAME {
			get { return _CATEGORY_NAME; }
			set { _CATEGORY_NAME = value; }
		}

		public DateTime EXPIRED_DATE {
			get { return _EXPIRED_DATE; }
			set { _EXPIRED_DATE = value; }
		}

		public DateTime STARTED_DATE {
			get { return _STARTED_DATE; }
			set { _STARTED_DATE = value; }
		}

		public DateTime CREATED_DATE {
			get { return _CREATED_DATE; }
			set { _CREATED_DATE = value; }
		}

		public int USER_ID {
			get { return _USER_ID; }
			set { _USER_ID = value; }
		}

		public string USER_NAME {
			get { return _USER_NAME; }
			set { _USER_NAME = value; }
		}

		public double QUANTITY {
			get { return _QUANTITY; }
			set { _QUANTITY = value; }
		}

		public DateTime LAST_IN {
			get { return _LAST_IN; }
			set { _LAST_IN = value; }
		}

		public DateTime LAST_OUT {
			get { return _LAST_OUT; }
			set { _LAST_OUT = value; }
		}

		public int ASSET_LEVEL_ID {
			get { return _ASSET_LEVEL_ID; }
			set { _ASSET_LEVEL_ID = value; }
		}

		public string ASSET_LEVEL_NAME {
			get { return _ASSET_LEVEL_NAME; }
			set { _ASSET_LEVEL_NAME = value; }
		}

		public string COUNTRY {
			get { return _COUNTRY; }
			set { _COUNTRY = value; }
		}

		public double WEIGHT {
			get { return _WEIGHT; }
			set { _WEIGHT = value; }
		}
#endregion

#region "Constructors"
public DMASSETPRODUCTSInfo()
{
}

public DMASSETPRODUCTSInfo(int ID, string ASSET_NAME, string ASSET_ONAME, string ASSET_CODE, string ASSET_DESCRIPTION, string MANUFACTURER_NAME, int MANUFACTURER_ID, string UNIT_NAME, int UNIT_ID, double PRICE, int CATEGORY_ID, string CATEGORY_NAME, DateTime EXPIRED_DATE, DateTime STARTED_DATE, DateTime CREATED_DATE, int USER_ID, string USER_NAME, double QUANTITY, DateTime LAST_IN, DateTime LAST_OUT, int ASSET_LEVEL_ID, string ASSET_LEVEL_NAME, string COUNTRY, double WEIGHT)
{
	this.ID = ID;
	this.ASSET_NAME = ASSET_NAME;
	this.ASSET_ONAME = ASSET_ONAME;
	this.ASSET_CODE = ASSET_CODE;
	this.ASSET_DESCRIPTION = ASSET_DESCRIPTION;
	this.MANUFACTURER_NAME = MANUFACTURER_NAME;
	this.MANUFACTURER_ID = MANUFACTURER_ID;
	this.UNIT_NAME = UNIT_NAME;
	this.UNIT_ID = UNIT_ID;
	this.PRICE = PRICE;
	this.CATEGORY_ID = CATEGORY_ID;
	this.CATEGORY_NAME = CATEGORY_NAME;
	this.EXPIRED_DATE = EXPIRED_DATE;
	this.STARTED_DATE = STARTED_DATE;
	this.CREATED_DATE = CREATED_DATE;
	this.USER_ID = USER_ID;
	this.USER_NAME = USER_NAME;
	this.QUANTITY = QUANTITY;
	this.LAST_IN = LAST_IN;
	this.LAST_OUT = LAST_OUT;
	this.ASSET_LEVEL_ID = ASSET_LEVEL_ID;
	this.ASSET_LEVEL_NAME = ASSET_LEVEL_NAME;
	this.COUNTRY = COUNTRY;
	this.WEIGHT = WEIGHT;
}
#endregion

}

}