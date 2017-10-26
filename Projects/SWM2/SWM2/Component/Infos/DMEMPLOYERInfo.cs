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

public partial class DMEMPLOYERInfo
{

#region "Private Members"
private int _ID;
private string _CODE;
private string _EMPLOYER_NAME;
private string _EMPLOYER_SEX;
private DateTime _BIRTHDAY;
private int _TINH_LOCATION_ID;
private string _TINH_LOCATION_NAME;
private int _HUYEN_LOCATION_ID;
private string _HUYEN_LOCATION_NAME;
private int _XA_LOCATION_ID;
private string _XA_LOCATION_NAME;
private int _RANK_ID;
private int _TITLE_ID;
private int _ORGANIZATION_ID;
private string _PHONE1;
private string _PHONE2;
private string _EMAIL;
private string _AVATAR;
private string _ADDRESS;
private bool _RETRIED;
#endregion

#region "Public Properties"
		public int ID {
			get { return _ID; }
			set { _ID = value; }
		}

		public string CODE {
			get { return _CODE; }
			set { _CODE = value; }
		}

		public string EMPLOYER_NAME {
			get { return _EMPLOYER_NAME; }
			set { _EMPLOYER_NAME = value; }
		}

		public string EMPLOYER_SEX {
			get { return _EMPLOYER_SEX; }
			set { _EMPLOYER_SEX = value; }
		}

		public DateTime BIRTHDAY {
			get { return _BIRTHDAY; }
			set { _BIRTHDAY = value; }
		}

		public int TINH_LOCATION_ID {
			get { return _TINH_LOCATION_ID; }
			set { _TINH_LOCATION_ID = value; }
		}

		public string TINH_LOCATION_NAME {
			get { return _TINH_LOCATION_NAME; }
			set { _TINH_LOCATION_NAME = value; }
		}

		public int HUYEN_LOCATION_ID {
			get { return _HUYEN_LOCATION_ID; }
			set { _HUYEN_LOCATION_ID = value; }
		}

		public string HUYEN_LOCATION_NAME {
			get { return _HUYEN_LOCATION_NAME; }
			set { _HUYEN_LOCATION_NAME = value; }
		}

		public int XA_LOCATION_ID {
			get { return _XA_LOCATION_ID; }
			set { _XA_LOCATION_ID = value; }
		}

		public string XA_LOCATION_NAME {
			get { return _XA_LOCATION_NAME; }
			set { _XA_LOCATION_NAME = value; }
		}

		public int RANK_ID {
			get { return _RANK_ID; }
			set { _RANK_ID = value; }
		}

		public int TITLE_ID {
			get { return _TITLE_ID; }
			set { _TITLE_ID = value; }
		}

		public int ORGANIZATION_ID {
			get { return _ORGANIZATION_ID; }
			set { _ORGANIZATION_ID = value; }
		}

		public string PHONE1 {
			get { return _PHONE1; }
			set { _PHONE1 = value; }
		}

		public string PHONE2 {
			get { return _PHONE2; }
			set { _PHONE2 = value; }
		}

		public string EMAIL {
			get { return _EMAIL; }
			set { _EMAIL = value; }
		}

		public string AVATAR {
			get { return _AVATAR; }
			set { _AVATAR = value; }
		}

		public string ADDRESS {
			get { return _ADDRESS; }
			set { _ADDRESS = value; }
		}

		public bool RETRIED {
			get { return _RETRIED; }
			set { _RETRIED = value; }
		}
#endregion

#region "Constructors"
public DMEMPLOYERInfo()
{
}

public DMEMPLOYERInfo(int ID, string CODE, string EMPLOYER_NAME, string EMPLOYER_SEX, DateTime BIRTHDAY, int TINH_LOCATION_ID, string TINH_LOCATION_NAME, int HUYEN_LOCATION_ID, string HUYEN_LOCATION_NAME, int XA_LOCATION_ID, string XA_LOCATION_NAME, int RANK_ID, int TITLE_ID, int ORGANIZATION_ID, string PHONE1, string PHONE2, string EMAIL, string AVATAR, string ADDRESS, bool RETRIED)
{
	this.ID = ID;
	this.CODE = CODE;
	this.EMPLOYER_NAME = EMPLOYER_NAME;
	this.EMPLOYER_SEX = EMPLOYER_SEX;
	this.BIRTHDAY = BIRTHDAY;
	this.TINH_LOCATION_ID = TINH_LOCATION_ID;
	this.TINH_LOCATION_NAME = TINH_LOCATION_NAME;
	this.HUYEN_LOCATION_ID = HUYEN_LOCATION_ID;
	this.HUYEN_LOCATION_NAME = HUYEN_LOCATION_NAME;
	this.XA_LOCATION_ID = XA_LOCATION_ID;
	this.XA_LOCATION_NAME = XA_LOCATION_NAME;
	this.RANK_ID = RANK_ID;
	this.TITLE_ID = TITLE_ID;
	this.ORGANIZATION_ID = ORGANIZATION_ID;
	this.PHONE1 = PHONE1;
	this.PHONE2 = PHONE2;
	this.EMAIL = EMAIL;
	this.AVATAR = AVATAR;
	this.ADDRESS = ADDRESS;
	this.RETRIED = RETRIED;
}
#endregion

}

}