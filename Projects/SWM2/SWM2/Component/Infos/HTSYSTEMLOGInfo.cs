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

public partial class HTSYSTEMLOGInfo
{

#region "Private Members"
private int _ID;
private string _TABLE_NAME;
private int _ROW_NUMBER;
private DateTime _CREATE_AT;
private string _CREATE_BY_USERNAME;
private DateTime _LAST_MODIFIED;
private string _MODIFIED_BY_USERNAME;
private DateTime _DELETE_AT;
private string _DELETE_BY_USERNAME;
private string _REMARKS;
#endregion

#region "Public Properties"
		public int ID {
			get { return _ID; }
			set { _ID = value; }
		}

		public string TABLE_NAME {
			get { return _TABLE_NAME; }
			set { _TABLE_NAME = value; }
		}

		public int ROW_NUMBER {
			get { return _ROW_NUMBER; }
			set { _ROW_NUMBER = value; }
		}

		public DateTime CREATE_AT {
			get { return _CREATE_AT; }
			set { _CREATE_AT = value; }
		}

		public string CREATE_BY_USERNAME {
			get { return _CREATE_BY_USERNAME; }
			set { _CREATE_BY_USERNAME = value; }
		}

		public DateTime LAST_MODIFIED {
			get { return _LAST_MODIFIED; }
			set { _LAST_MODIFIED = value; }
		}

		public string MODIFIED_BY_USERNAME {
			get { return _MODIFIED_BY_USERNAME; }
			set { _MODIFIED_BY_USERNAME = value; }
		}

		public DateTime DELETE_AT {
			get { return _DELETE_AT; }
			set { _DELETE_AT = value; }
		}

		public string DELETE_BY_USERNAME {
			get { return _DELETE_BY_USERNAME; }
			set { _DELETE_BY_USERNAME = value; }
		}

		public string REMARKS {
			get { return _REMARKS; }
			set { _REMARKS = value; }
		}
#endregion

#region "Constructors"
public HTSYSTEMLOGInfo()
{
}

public HTSYSTEMLOGInfo(int ID, string TABLE_NAME, int ROW_NUMBER, DateTime CREATE_AT, string CREATE_BY_USERNAME, DateTime LAST_MODIFIED, string MODIFIED_BY_USERNAME, DateTime DELETE_AT, string DELETE_BY_USERNAME, string REMARKS)
{
	this.ID = ID;
	this.TABLE_NAME = TABLE_NAME;
	this.ROW_NUMBER = ROW_NUMBER;
	this.CREATE_AT = CREATE_AT;
	this.CREATE_BY_USERNAME = CREATE_BY_USERNAME;
	this.LAST_MODIFIED = LAST_MODIFIED;
	this.MODIFIED_BY_USERNAME = MODIFIED_BY_USERNAME;
	this.DELETE_AT = DELETE_AT;
	this.DELETE_BY_USERNAME = DELETE_BY_USERNAME;
	this.REMARKS = REMARKS;
}
#endregion

}

}