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

public partial class HTUSERInfo
{

#region "Private Members"
private int _ID;
private string _USER_NAME;
private string _PASSWORD;
private DateTime _LAST_LOGIN;
private string _IP_LOGIN;
private int _NUMBER_LOGIN;
private bool _IS_BLOCKED;
private string _REMARKS;
#endregion

#region "Public Properties"
		public int ID {
			get { return _ID; }
			set { _ID = value; }
		}

		public string USER_NAME {
			get { return _USER_NAME; }
			set { _USER_NAME = value; }
		}

		public string PASSWORD {
			get { return _PASSWORD; }
			set { _PASSWORD = value; }
		}

		public DateTime LAST_LOGIN {
			get { return _LAST_LOGIN; }
			set { _LAST_LOGIN = value; }
		}

		public string IP_LOGIN {
			get { return _IP_LOGIN; }
			set { _IP_LOGIN = value; }
		}

		public int NUMBER_LOGIN {
			get { return _NUMBER_LOGIN; }
			set { _NUMBER_LOGIN = value; }
		}

		public bool IS_BLOCKED {
			get { return _IS_BLOCKED; }
			set { _IS_BLOCKED = value; }
		}

		public string REMARKS {
			get { return _REMARKS; }
			set { _REMARKS = value; }
		}
#endregion

#region "Constructors"
public HTUSERInfo()
{
}

public HTUSERInfo(int ID, string USER_NAME, string PASSWORD, DateTime LAST_LOGIN, string IP_LOGIN, int NUMBER_LOGIN, bool IS_BLOCKED, string REMARKS)
{
	this.ID = ID;
	this.USER_NAME = USER_NAME;
	this.PASSWORD = PASSWORD;
	this.LAST_LOGIN = LAST_LOGIN;
	this.IP_LOGIN = IP_LOGIN;
	this.NUMBER_LOGIN = NUMBER_LOGIN;
	this.IS_BLOCKED = IS_BLOCKED;
	this.REMARKS = REMARKS;
}
#endregion

}

}