//*************************************************************
//Author           : Tien NQ
//Created Date     : 9/6/2016
//Comment          : Base class for access to database.
//History          : 
//*************************************************************

using System;
using System.Data;

namespace VKTIM.Component
{

public partial class TMLOGLOGINInfo
{

#region "Private Members"
private int _ID;
private int _INT_USER_ID;
private string _CHR_USERNAME;
private int _INT_USERGROUP;
private DateTime _DAT_CREATED;
private string _CHR_CONTENT;
private string _CHR_DOMAIN;
private string _CHR_MACHINE;
private string _CHR_COM_USER;
private string _CHR_DIRECTORY;
private int _INT_FACTORY_ID;
private string _CHR_FACTORY_NAME;
private string _CHR_REMARK;
private string _CHR_NOTE1;
private string _CHR_NOTE2;
private string _CHR_NOTE3;
#endregion

#region "Public Properties"
		public int ID {
			get { return _ID; }
			set { _ID = value; }
		}

		public int INT_USER_ID {
			get { return _INT_USER_ID; }
			set { _INT_USER_ID = value; }
		}

		public string CHR_USERNAME {
			get { return _CHR_USERNAME; }
			set { _CHR_USERNAME = value; }
		}

		public int INT_USERGROUP {
			get { return _INT_USERGROUP; }
			set { _INT_USERGROUP = value; }
		}

		public DateTime DAT_CREATED {
			get { return _DAT_CREATED; }
			set { _DAT_CREATED = value; }
		}

		public string CHR_CONTENT {
			get { return _CHR_CONTENT; }
			set { _CHR_CONTENT = value; }
		}

		public string CHR_DOMAIN {
			get { return _CHR_DOMAIN; }
			set { _CHR_DOMAIN = value; }
		}

		public string CHR_MACHINE {
			get { return _CHR_MACHINE; }
			set { _CHR_MACHINE = value; }
		}

		public string CHR_COM_USER {
			get { return _CHR_COM_USER; }
			set { _CHR_COM_USER = value; }
		}

		public string CHR_DIRECTORY {
			get { return _CHR_DIRECTORY; }
			set { _CHR_DIRECTORY = value; }
		}

		public int INT_FACTORY_ID {
			get { return _INT_FACTORY_ID; }
			set { _INT_FACTORY_ID = value; }
		}

		public string CHR_FACTORY_NAME {
			get { return _CHR_FACTORY_NAME; }
			set { _CHR_FACTORY_NAME = value; }
		}

		public string CHR_REMARK {
			get { return _CHR_REMARK; }
			set { _CHR_REMARK = value; }
		}

		public string CHR_NOTE1 {
			get { return _CHR_NOTE1; }
			set { _CHR_NOTE1 = value; }
		}

		public string CHR_NOTE2 {
			get { return _CHR_NOTE2; }
			set { _CHR_NOTE2 = value; }
		}

		public string CHR_NOTE3 {
			get { return _CHR_NOTE3; }
			set { _CHR_NOTE3 = value; }
		}
#endregion

#region "Constructors"
public TMLOGLOGINInfo()
{
}

public TMLOGLOGINInfo(int ID, int INT_USER_ID, string CHR_USERNAME, int INT_USERGROUP, DateTime DAT_CREATED, string CHR_CONTENT, string CHR_DOMAIN, string CHR_MACHINE, string CHR_COM_USER, string CHR_DIRECTORY, int INT_FACTORY_ID, string CHR_FACTORY_NAME, string CHR_REMARK, string CHR_NOTE1, string CHR_NOTE2, string CHR_NOTE3)
{
	this.ID = ID;
	this.INT_USER_ID = INT_USER_ID;
	this.CHR_USERNAME = CHR_USERNAME;
	this.INT_USERGROUP = INT_USERGROUP;
	this.DAT_CREATED = DAT_CREATED;
	this.CHR_CONTENT = CHR_CONTENT;
	this.CHR_DOMAIN = CHR_DOMAIN;
	this.CHR_MACHINE = CHR_MACHINE;
	this.CHR_COM_USER = CHR_COM_USER;
	this.CHR_DIRECTORY = CHR_DIRECTORY;
	this.INT_FACTORY_ID = INT_FACTORY_ID;
	this.CHR_FACTORY_NAME = CHR_FACTORY_NAME;
	this.CHR_REMARK = CHR_REMARK;
	this.CHR_NOTE1 = CHR_NOTE1;
	this.CHR_NOTE2 = CHR_NOTE2;
	this.CHR_NOTE3 = CHR_NOTE3;
}
#endregion

}

}