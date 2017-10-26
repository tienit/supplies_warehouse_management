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

public partial class DTSTORESInfo
{

#region "Private Members"
private int _ID;
private int _PRODUCT_ID;
private double _QUANTITY;
private int _WAREHOUSE_ID;
private int _SHORT;
private string _REMARKS;
private DateTime _DATE_IN;
private DateTime _DATE_OUT;
private string _USER_ID;
private bool _STORE_TYPE;
private bool _REMIND;
private DateTime _DATE_REMIND;
#endregion

#region "Public Properties"
		public int ID {
			get { return _ID; }
			set { _ID = value; }
		}

		public int PRODUCT_ID {
			get { return _PRODUCT_ID; }
			set { _PRODUCT_ID = value; }
		}

		public double QUANTITY {
			get { return _QUANTITY; }
			set { _QUANTITY = value; }
		}

		public int WAREHOUSE_ID {
			get { return _WAREHOUSE_ID; }
			set { _WAREHOUSE_ID = value; }
		}

		public int SHORT {
			get { return _SHORT; }
			set { _SHORT = value; }
		}

		public string REMARKS {
			get { return _REMARKS; }
			set { _REMARKS = value; }
		}

		public DateTime DATE_IN {
			get { return _DATE_IN; }
			set { _DATE_IN = value; }
		}

		public DateTime DATE_OUT {
			get { return _DATE_OUT; }
			set { _DATE_OUT = value; }
		}

		public string USER_ID {
			get { return _USER_ID; }
			set { _USER_ID = value; }
		}

		public bool STORE_TYPE {
			get { return _STORE_TYPE; }
			set { _STORE_TYPE = value; }
		}

		public bool REMIND {
			get { return _REMIND; }
			set { _REMIND = value; }
		}

		public DateTime DATE_REMIND {
			get { return _DATE_REMIND; }
			set { _DATE_REMIND = value; }
		}
#endregion

#region "Constructors"
public DTSTORESInfo()
{
}

public DTSTORESInfo(int ID, int PRODUCT_ID, double QUANTITY, int WAREHOUSE_ID, int SHORT, string REMARKS, DateTime DATE_IN, DateTime DATE_OUT, string USER_ID, bool STORE_TYPE, bool REMIND, DateTime DATE_REMIND)
{
	this.ID = ID;
	this.PRODUCT_ID = PRODUCT_ID;
	this.QUANTITY = QUANTITY;
	this.WAREHOUSE_ID = WAREHOUSE_ID;
	this.SHORT = SHORT;
	this.REMARKS = REMARKS;
	this.DATE_IN = DATE_IN;
	this.DATE_OUT = DATE_OUT;
	this.USER_ID = USER_ID;
	this.STORE_TYPE = STORE_TYPE;
	this.REMIND = REMIND;
	this.DATE_REMIND = DATE_REMIND;
}
#endregion

}

}