//*************************************************************
//Author           : Tien NQ
//Created Date     : 9/10/2016
//Comment          : Base class for access to database.
//History          : 
//*************************************************************

using System;
using System.Data;

namespace VKTIM.Component
{

public partial class HTUSERnfo
    {

#region "Private Members"
private int _ID;
private string _CHR_USERNAME;
private string _CHR_PASSWORD;
private int _INT_USERGROUP;
private int _INT_FACTORY_ID;
private bool _BIT_LOCKED;
private string _CHR_OPERATOR_CODE;
private string _CHR_POSITION;
private DateTime _DAT_DOB;
private string _CHR_ADDRESS;
private string _CHR_MOBILE;
private string _CHR_EMAIL;
private string _CHR_REMARK;
#endregion

#region "Public Properties"
		public int ID {
			get { return _ID; }
			set { _ID = value; }
		}

		public string CHR_USERNAME {
			get { return _CHR_USERNAME; }
			set { _CHR_USERNAME = value; }
		}

		public string CHR_PASSWORD {
			get { return _CHR_PASSWORD; }
			set { _CHR_PASSWORD = value; }
		}

		public int INT_USERGROUP {
			get { return _INT_USERGROUP; }
			set { _INT_USERGROUP = value; }
		}

		public int INT_FACTORY_ID {
			get { return _INT_FACTORY_ID; }
			set { _INT_FACTORY_ID = value; }
		}

		public bool BIT_LOCKED {
			get { return _BIT_LOCKED; }
			set { _BIT_LOCKED = value; }
		}

		public string CHR_OPERATOR_CODE {
			get { return _CHR_OPERATOR_CODE; }
			set { _CHR_OPERATOR_CODE = value; }
		}

		public string CHR_POSITION {
			get { return _CHR_POSITION; }
			set { _CHR_POSITION = value; }
		}

		public DateTime DAT_DOB {
			get { return _DAT_DOB; }
			set { _DAT_DOB = value; }
		}

		public string CHR_ADDRESS {
			get { return _CHR_ADDRESS; }
			set { _CHR_ADDRESS = value; }
		}

		public string CHR_MOBILE {
			get { return _CHR_MOBILE; }
			set { _CHR_MOBILE = value; }
		}

		public string CHR_EMAIL {
			get { return _CHR_EMAIL; }
			set { _CHR_EMAIL = value; }
		}

		public string CHR_REMARK {
			get { return _CHR_REMARK; }
			set { _CHR_REMARK = value; }
		}
#endregion

#region "Constructors"
public HTUSERnfo()
{
}

public HTUSERnfo(int ID, string CHR_USERNAME, string CHR_PASSWORD, int INT_USERGROUP, int INT_FACTORY_ID, bool BIT_LOCKED, string CHR_OPERATOR_CODE, string CHR_POSITION, DateTime DAT_DOB, string CHR_ADDRESS, string CHR_MOBILE, string CHR_EMAIL, string CHR_REMARK)
{
	this.ID = ID;
	this.CHR_USERNAME = CHR_USERNAME;
	this.CHR_PASSWORD = CHR_PASSWORD;
	this.INT_USERGROUP = INT_USERGROUP;
	this.INT_FACTORY_ID = INT_FACTORY_ID;
	this.BIT_LOCKED = BIT_LOCKED;
	this.CHR_OPERATOR_CODE = CHR_OPERATOR_CODE;
	this.CHR_POSITION = CHR_POSITION;
	this.DAT_DOB = DAT_DOB;
	this.CHR_ADDRESS = CHR_ADDRESS;
	this.CHR_MOBILE = CHR_MOBILE;
	this.CHR_EMAIL = CHR_EMAIL;
	this.CHR_REMARK = CHR_REMARK;
}
#endregion

}

}