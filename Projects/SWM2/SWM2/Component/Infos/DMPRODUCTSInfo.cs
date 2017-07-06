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

public partial class DMPRODUCTSInfo
{

#region "Private Members"
private int _ID;
private string _PRODUCTS_NAME;
private string _PRODUCTS_NAME_OTHER;
private string _PRODUCTS_CODE;
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
#endregion

#region "Public Properties"
		public int ID {
			get { return _ID; }
			set { _ID = value; }
		}

		public string PRODUCTS_NAME {
			get { return _PRODUCTS_NAME; }
			set { _PRODUCTS_NAME = value; }
		}

		public string PRODUCTS_NAME_OTHER {
			get { return _PRODUCTS_NAME_OTHER; }
			set { _PRODUCTS_NAME_OTHER = value; }
		}

		public string PRODUCTS_CODE {
			get { return _PRODUCTS_CODE; }
			set { _PRODUCTS_CODE = value; }
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
#endregion

#region "Constructors"
public DMPRODUCTSInfo()
{
}

public DMPRODUCTSInfo(int ID, string PRODUCTS_NAME, string PRODUCTS_NAME_OTHER, string PRODUCTS_CODE, string PRODUCTS_DESCRIPTION, string PRODUCTS_SHORT_DESCRIPTION, int ORIGIN_ID, string ORIGIN_NAME, int UNIT_ID, string UNIT_NAME, int SUPPLIER_ID, string SUPPLIER_NAME, int PRICE_ID, string PRICE_NAME, int PRODUCTCATEGORY_ID, string PRODUCTCATEGORY_NAME, bool PRICE_DEFAULT)
{
	this.ID = ID;
	this.PRODUCTS_NAME = PRODUCTS_NAME;
	this.PRODUCTS_NAME_OTHER = PRODUCTS_NAME_OTHER;
	this.PRODUCTS_CODE = PRODUCTS_CODE;
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
}
#endregion

}

}