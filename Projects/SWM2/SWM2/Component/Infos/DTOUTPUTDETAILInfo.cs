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

public partial class DTOUTPUTDETAILInfo
{

#region "Private Members"
private int _ID;
private int _OUTPUT_ID;
private int _PRODUCT_ID;
private string _PRODUCT_NAME;
private string _PRODUCT_OTHER_NAME;
private string _PRODUCT_CODE;
private string _PRODUCTS_DESCRIPTION;
private string _PRODUCTS_SHORT_DESCRIPTION;
private int _ORIGIN_ID;
private string _ORIGIN_NAME;
private int _UNIT_ID;
private string _UNIT_NAME;
private int _SUPPLIER_ID;
private string _SUPPLIER_NAME;
private int _PRICE_ID;
private string _PRICE_NAME;
private int _PRODUCTCATEGORY_ID;
private string _PRODUCTCATEGORY_NAME;
private bool _PRICE_DEFAULT;
private string _OUTPUT_PRICE;
private double _QUANTITY;
private int _WAREHOUSE_ID;
private string _PRODUCT_STATUS;
private bool _IS_BUY;
private double _TOTAL;
private DateTime _OUTPUT_DATE;
private DateTime _RETURN_DATE;
#endregion

#region "Public Properties"
		public int ID {
			get { return _ID; }
			set { _ID = value; }
		}

		public int OUTPUT_ID {
			get { return _OUTPUT_ID; }
			set { _OUTPUT_ID = value; }
		}

		public int PRODUCT_ID {
			get { return _PRODUCT_ID; }
			set { _PRODUCT_ID = value; }
		}

		public string PRODUCT_NAME {
			get { return _PRODUCT_NAME; }
			set { _PRODUCT_NAME = value; }
		}

		public string PRODUCT_OTHER_NAME {
			get { return _PRODUCT_OTHER_NAME; }
			set { _PRODUCT_OTHER_NAME = value; }
		}

		public string PRODUCT_CODE {
			get { return _PRODUCT_CODE; }
			set { _PRODUCT_CODE = value; }
		}

		public string PRODUCTS_DESCRIPTION {
			get { return _PRODUCTS_DESCRIPTION; }
			set { _PRODUCTS_DESCRIPTION = value; }
		}

		public string PRODUCTS_SHORT_DESCRIPTION {
			get { return _PRODUCTS_SHORT_DESCRIPTION; }
			set { _PRODUCTS_SHORT_DESCRIPTION = value; }
		}

		public int ORIGIN_ID {
			get { return _ORIGIN_ID; }
			set { _ORIGIN_ID = value; }
		}

		public string ORIGIN_NAME {
			get { return _ORIGIN_NAME; }
			set { _ORIGIN_NAME = value; }
		}

		public int UNIT_ID {
			get { return _UNIT_ID; }
			set { _UNIT_ID = value; }
		}

		public string UNIT_NAME {
			get { return _UNIT_NAME; }
			set { _UNIT_NAME = value; }
		}

		public int SUPPLIER_ID {
			get { return _SUPPLIER_ID; }
			set { _SUPPLIER_ID = value; }
		}

		public string SUPPLIER_NAME {
			get { return _SUPPLIER_NAME; }
			set { _SUPPLIER_NAME = value; }
		}

		public int PRICE_ID {
			get { return _PRICE_ID; }
			set { _PRICE_ID = value; }
		}

		public string PRICE_NAME {
			get { return _PRICE_NAME; }
			set { _PRICE_NAME = value; }
		}

		public int PRODUCTCATEGORY_ID {
			get { return _PRODUCTCATEGORY_ID; }
			set { _PRODUCTCATEGORY_ID = value; }
		}

		public string PRODUCTCATEGORY_NAME {
			get { return _PRODUCTCATEGORY_NAME; }
			set { _PRODUCTCATEGORY_NAME = value; }
		}

		public bool PRICE_DEFAULT {
			get { return _PRICE_DEFAULT; }
			set { _PRICE_DEFAULT = value; }
		}

		public string OUTPUT_PRICE {
			get { return _OUTPUT_PRICE; }
			set { _OUTPUT_PRICE = value; }
		}

		public double QUANTITY {
			get { return _QUANTITY; }
			set { _QUANTITY = value; }
		}

		public int WAREHOUSE_ID {
			get { return _WAREHOUSE_ID; }
			set { _WAREHOUSE_ID = value; }
		}

		public string PRODUCT_STATUS {
			get { return _PRODUCT_STATUS; }
			set { _PRODUCT_STATUS = value; }
		}

		public bool IS_BUY {
			get { return _IS_BUY; }
			set { _IS_BUY = value; }
		}

		public double TOTAL {
			get { return _TOTAL; }
			set { _TOTAL = value; }
		}

		public DateTime OUTPUT_DATE {
			get { return _OUTPUT_DATE; }
			set { _OUTPUT_DATE = value; }
		}

		public DateTime RETURN_DATE {
			get { return _RETURN_DATE; }
			set { _RETURN_DATE = value; }
		}
#endregion

#region "Constructors"
public DTOUTPUTDETAILInfo()
{
}

public DTOUTPUTDETAILInfo(int ID, int OUTPUT_ID, int PRODUCT_ID, string PRODUCT_NAME, string PRODUCT_OTHER_NAME, string PRODUCT_CODE, string PRODUCTS_DESCRIPTION, string PRODUCTS_SHORT_DESCRIPTION, int ORIGIN_ID, string ORIGIN_NAME, int UNIT_ID, string UNIT_NAME, int SUPPLIER_ID, string SUPPLIER_NAME, int PRICE_ID, string PRICE_NAME, int PRODUCTCATEGORY_ID, string PRODUCTCATEGORY_NAME, bool PRICE_DEFAULT, string OUTPUT_PRICE, double QUANTITY, int WAREHOUSE_ID, string PRODUCT_STATUS, bool IS_BUY, double TOTAL, DateTime OUTPUT_DATE, DateTime RETURN_DATE)
{
	this.ID = ID;
	this.OUTPUT_ID = OUTPUT_ID;
	this.PRODUCT_ID = PRODUCT_ID;
	this.PRODUCT_NAME = PRODUCT_NAME;
	this.PRODUCT_OTHER_NAME = PRODUCT_OTHER_NAME;
	this.PRODUCT_CODE = PRODUCT_CODE;
	this.PRODUCTS_DESCRIPTION = PRODUCTS_DESCRIPTION;
	this.PRODUCTS_SHORT_DESCRIPTION = PRODUCTS_SHORT_DESCRIPTION;
	this.ORIGIN_ID = ORIGIN_ID;
	this.ORIGIN_NAME = ORIGIN_NAME;
	this.UNIT_ID = UNIT_ID;
	this.UNIT_NAME = UNIT_NAME;
	this.SUPPLIER_ID = SUPPLIER_ID;
	this.SUPPLIER_NAME = SUPPLIER_NAME;
	this.PRICE_ID = PRICE_ID;
	this.PRICE_NAME = PRICE_NAME;
	this.PRODUCTCATEGORY_ID = PRODUCTCATEGORY_ID;
	this.PRODUCTCATEGORY_NAME = PRODUCTCATEGORY_NAME;
	this.PRICE_DEFAULT = PRICE_DEFAULT;
	this.OUTPUT_PRICE = OUTPUT_PRICE;
	this.QUANTITY = QUANTITY;
	this.WAREHOUSE_ID = WAREHOUSE_ID;
	this.PRODUCT_STATUS = PRODUCT_STATUS;
	this.IS_BUY = IS_BUY;
	this.TOTAL = TOTAL;
	this.OUTPUT_DATE = OUTPUT_DATE;
	this.RETURN_DATE = RETURN_DATE;
}
#endregion

}

}