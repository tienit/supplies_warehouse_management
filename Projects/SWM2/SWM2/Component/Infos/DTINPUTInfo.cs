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

public partial class DTINPUTInfo
{

#region "Private Members"
private int _ID;
private string _INPUT_NAME;
private string _INPUT_CODE;
private int _WAREHOUSE_ID;
private string _WAREHOUSE_NAME;
private int _ORGANIZATION_ID;
private string _ORGANIZATION_NAME;
private DateTime _EXPIRED_DATE;
private bool _IS_ASSET;
private int _USER_ID;
private string _USER_NAME;
private int _IDNUMBER;
private int _IDBOOK;
private string _CAUSE_DESCRIPTION;
private int _FUNDS_ID;
private string _FUNDS_NAME;
private double _TOTAL_VALUE;
private DateTime _DATE_CREATED;
#endregion

#region "Public Properties"
		public int ID {
			get { return _ID; }
			set { _ID = value; }
		}

		public string INPUT_NAME {
			get { return _INPUT_NAME; }
			set { _INPUT_NAME = value; }
		}

		public string INPUT_CODE {
			get { return _INPUT_CODE; }
			set { _INPUT_CODE = value; }
		}

		public int WAREHOUSE_ID {
			get { return _WAREHOUSE_ID; }
			set { _WAREHOUSE_ID = value; }
		}

		public string WAREHOUSE_NAME {
			get { return _WAREHOUSE_NAME; }
			set { _WAREHOUSE_NAME = value; }
		}

		public int ORGANIZATION_ID {
			get { return _ORGANIZATION_ID; }
			set { _ORGANIZATION_ID = value; }
		}

		public string ORGANIZATION_NAME {
			get { return _ORGANIZATION_NAME; }
			set { _ORGANIZATION_NAME = value; }
		}

		public DateTime EXPIRED_DATE {
			get { return _EXPIRED_DATE; }
			set { _EXPIRED_DATE = value; }
		}

		public bool IS_ASSET {
			get { return _IS_ASSET; }
			set { _IS_ASSET = value; }
		}

		public int USER_ID {
			get { return _USER_ID; }
			set { _USER_ID = value; }
		}

		public string USER_NAME {
			get { return _USER_NAME; }
			set { _USER_NAME = value; }
		}

		public int IDNUMBER {
			get { return _IDNUMBER; }
			set { _IDNUMBER = value; }
		}

		public int IDBOOK {
			get { return _IDBOOK; }
			set { _IDBOOK = value; }
		}

		public string CAUSE_DESCRIPTION {
			get { return _CAUSE_DESCRIPTION; }
			set { _CAUSE_DESCRIPTION = value; }
		}

		public int FUNDS_ID {
			get { return _FUNDS_ID; }
			set { _FUNDS_ID = value; }
		}

		public string FUNDS_NAME {
			get { return _FUNDS_NAME; }
			set { _FUNDS_NAME = value; }
		}

		public double TOTAL_VALUE {
			get { return _TOTAL_VALUE; }
			set { _TOTAL_VALUE = value; }
		}

		public DateTime DATE_CREATED {
			get { return _DATE_CREATED; }
			set { _DATE_CREATED = value; }
		}
#endregion

#region "Constructors"
public DTINPUTInfo()
{
}

public DTINPUTInfo(int ID, string INPUT_NAME, string INPUT_CODE, int WAREHOUSE_ID, string WAREHOUSE_NAME, int ORGANIZATION_ID, string ORGANIZATION_NAME, DateTime EXPIRED_DATE, bool IS_ASSET, int USER_ID, string USER_NAME, int IDNUMBER, int IDBOOK, string CAUSE_DESCRIPTION, int FUNDS_ID, string FUNDS_NAME, double TOTAL_VALUE, DateTime DATE_CREATED)
{
	this.ID = ID;
	this.INPUT_NAME = INPUT_NAME;
	this.INPUT_CODE = INPUT_CODE;
	this.WAREHOUSE_ID = WAREHOUSE_ID;
	this.WAREHOUSE_NAME = WAREHOUSE_NAME;
	this.ORGANIZATION_ID = ORGANIZATION_ID;
	this.ORGANIZATION_NAME = ORGANIZATION_NAME;
	this.EXPIRED_DATE = EXPIRED_DATE;
	this.IS_ASSET = IS_ASSET;
	this.USER_ID = USER_ID;
	this.USER_NAME = USER_NAME;
	this.IDNUMBER = IDNUMBER;
	this.IDBOOK = IDBOOK;
	this.CAUSE_DESCRIPTION = CAUSE_DESCRIPTION;
	this.FUNDS_ID = FUNDS_ID;
	this.FUNDS_NAME = FUNDS_NAME;
	this.TOTAL_VALUE = TOTAL_VALUE;
	this.DATE_CREATED = DATE_CREATED;
}
#endregion

}

}