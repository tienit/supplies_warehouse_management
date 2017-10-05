//*************************************************************
//Author           : Tien NQ
//Created Date     : 7/7/2017
//Comment          : Base class for access to database.
//History          : 
//*************************************************************

using System;
using System.Data;

namespace VKTIM.Component
{

public partial class DTINPUTDETAILInfo
{

#region "Private Members"
private int _ID;
private int _INPUT_ID;
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
private double _PRICE_DEFAULT;
private double _INPUT_PRICE;
private double _QUANTITY;
        private double _INPUT_VALUE;
        private int _WAREHOUSE_ID;
private string _PRODUCT_STATUS;
private bool _IS_BUY;
private double _TOTAL;
        private int _Sort;
#endregion

#region "Public Properties"
		public int ID {
			get { return _ID; }
			set { _ID = value; }
		}

		public int INPUT_ID {
			get { return _INPUT_ID; }
			set { _INPUT_ID = value; }
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

		public double PRICE_DEFAULT {
			get { return _PRICE_DEFAULT; }
			set { _PRICE_DEFAULT = value; }
		}

		public double INPUT_PRICE {
			get { return _INPUT_PRICE; }
			set { _INPUT_PRICE = value; }
		}

		public double QUANTITY {
			get { return _QUANTITY; }
			set { _QUANTITY = value; }
		}

        public double INPUT_VALUE
        {
            get { return _INPUT_VALUE; }
            set { _INPUT_VALUE = value; }
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

        public int Sort
        {
            get { return _Sort; }
            set { _Sort = value; }
        }
        #endregion

        #region "Constructors"
        public DTINPUTDETAILInfo()
{
}

public DTINPUTDETAILInfo(int ID, int INPUT_ID, int PRODUCT_ID, string PRODUCT_NAME, string PRODUCT_OTHER_NAME, string PRODUCT_CODE, string PRODUCTS_DESCRIPTION, string PRODUCTS_SHORT_DESCRIPTION, int ORIGIN_ID, string ORIGIN_NAME, int UNIT_ID, string UNIT_NAME, int SUPPLIER_ID, string SUPPLIER_NAME, int PRICE_ID, string PRICE_NAME, int PRODUCTCATEGORY_ID, string PRODUCTCATEGORY_NAME, double PRICE_DEFAULT, double INPUT_PRICE, double QUANTITY, double INPUT_VALUE, int WAREHOUSE_ID, string PRODUCT_STATUS, bool IS_BUY, double TOTAL, int Sort)
{
	this.ID = ID;
	this.INPUT_ID = INPUT_ID;
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
	this.INPUT_PRICE = INPUT_PRICE;
	this.QUANTITY = QUANTITY;
            this.INPUT_VALUE = _INPUT_VALUE;
	this.WAREHOUSE_ID = WAREHOUSE_ID;
	this.PRODUCT_STATUS = PRODUCT_STATUS;
	this.IS_BUY = IS_BUY;
	this.TOTAL = TOTAL;
            this.Sort = Sort;
}
#endregion

}

}