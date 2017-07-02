//*************************************************************
//Author           : Tien NQ
//Created Date     : 20/03/2014
//Comment          : Base class for access to database.
//History          : 
//*************************************************************

using System;
using System.Data;

namespace VKTIM.Component
{

public partial class TMLOGEVENTInfo
{

#region "Private Members"
private int _ID;
private string _CHR_CONTENT;
private string _CHR_TYPE;
private DateTime _DAT_CREATED;
private int _INT_USER_ID;
private string _CHR_USERNAME;
private int _INT_USERGROUP_ID;
private int _INT_FACTORY_ID;
private string _CHR_FACTORY_NAME;
private string _CHR_REMARK;
#endregion

#region "Public Properties"
		public int ID {
			get { return _ID; }
			set { _ID = value; }
		}

		public string CHR_CONTENT {
			get { return _CHR_CONTENT; }
			set { _CHR_CONTENT = value; }
		}

		public string CHR_TYPE {
			get { return _CHR_TYPE; }
			set { _CHR_TYPE = value; }
		}

		public DateTime DAT_CREATED {
			get { return _DAT_CREATED; }
			set { _DAT_CREATED = value; }
		}

		public int INT_USER_ID {
			get { return _INT_USER_ID; }
			set { _INT_USER_ID = value; }
		}

		public string CHR_USERNAME {
			get { return _CHR_USERNAME; }
			set { _CHR_USERNAME = value; }
		}

		public int INT_USERGROUP_ID {
			get { return _INT_USERGROUP_ID; }
			set { _INT_USERGROUP_ID = value; }
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
#endregion

#region "Constructors"
public TMLOGEVENTInfo()
{
}

public TMLOGEVENTInfo(int ID, string CHR_CONTENT, string CHR_TYPE, DateTime DAT_CREATED, int INT_USER_ID, string CHR_USERNAME, int INT_USERGROUP_ID, int INT_FACTORY_ID, string CHR_FACTORY_NAME, string CHR_REMARK)
{
	this.ID = ID;
	this.CHR_CONTENT = CHR_CONTENT;
	this.CHR_TYPE = CHR_TYPE;
	this.DAT_CREATED = DAT_CREATED;
	this.INT_USER_ID = INT_USER_ID;
	this.CHR_USERNAME = CHR_USERNAME;
	this.INT_USERGROUP_ID = INT_USERGROUP_ID;
	this.INT_FACTORY_ID = INT_FACTORY_ID;
	this.CHR_FACTORY_NAME = CHR_FACTORY_NAME;
	this.CHR_REMARK = CHR_REMARK;
}
#endregion

}

}