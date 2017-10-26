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

public partial class DTLOGEVENTInfo
{

#region "Private Members"
private int _ID;
private string _EVENT_CODE;
private string _TYPE;
private string _EVENT_CONTENT;
private DateTime _CREATED_DATE;
private int _USER_ID;
private string _USER_NAME;
private string _COM_USER;
private string _COM_MACHINE;
private string _COM_DOMAIN;
private string _COM_DIR;
private string _REMARK;
#endregion

#region "Public Properties"
		public int ID {
			get { return _ID; }
			set { _ID = value; }
		}

		public string EVENT_CODE {
			get { return _EVENT_CODE; }
			set { _EVENT_CODE = value; }
		}

		public string TYPE {
			get { return _TYPE; }
			set { _TYPE = value; }
		}

		public string EVENT_CONTENT {
			get { return _EVENT_CONTENT; }
			set { _EVENT_CONTENT = value; }
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

		public string COM_USER {
			get { return _COM_USER; }
			set { _COM_USER = value; }
		}

		public string COM_MACHINE {
			get { return _COM_MACHINE; }
			set { _COM_MACHINE = value; }
		}

		public string COM_DOMAIN {
			get { return _COM_DOMAIN; }
			set { _COM_DOMAIN = value; }
		}

		public string COM_DIR {
			get { return _COM_DIR; }
			set { _COM_DIR = value; }
		}

		public string REMARK {
			get { return _REMARK; }
			set { _REMARK = value; }
		}
#endregion

#region "Constructors"
public DTLOGEVENTInfo()
{
}

public DTLOGEVENTInfo(int ID, string EVENT_CODE, string TYPE, string EVENT_CONTENT, DateTime CREATED_DATE, int USER_ID, string USER_NAME, string COM_USER, string COM_MACHINE, string COM_DOMAIN, string COM_DIR, string REMARK)
{
	this.ID = ID;
	this.EVENT_CODE = EVENT_CODE;
	this.TYPE = TYPE;
	this.EVENT_CONTENT = EVENT_CONTENT;
	this.CREATED_DATE = CREATED_DATE;
	this.USER_ID = USER_ID;
	this.USER_NAME = USER_NAME;
	this.COM_USER = COM_USER;
	this.COM_MACHINE = COM_MACHINE;
	this.COM_DOMAIN = COM_DOMAIN;
	this.COM_DIR = COM_DIR;
	this.REMARK = REMARK;
}
#endregion

}

}