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

public partial class DMORGANIZATIONInfo
{

#region "Private Members"
private int _ID;
private string _ORGANIZATION_TITLE;
private string _ORGANIZATION_NAME;
private string _ORGANIZATION_CODE;
private string _ORGANIZATION_DESCRIPTION;
private int _SPECIAL_ID;
private int _ORGANIZATION_LEVEL;
#endregion

#region "Public Properties"
		public int ID {
			get { return _ID; }
			set { _ID = value; }
		}

		public string ORGANIZATION_TITLE {
			get { return _ORGANIZATION_TITLE; }
			set { _ORGANIZATION_TITLE = value; }
		}

		public string ORGANIZATION_NAME {
			get { return _ORGANIZATION_NAME; }
			set { _ORGANIZATION_NAME = value; }
		}

		public string ORGANIZATION_CODE {
			get { return _ORGANIZATION_CODE; }
			set { _ORGANIZATION_CODE = value; }
		}

		public string ORGANIZATION_DESCRIPTION {
			get { return _ORGANIZATION_DESCRIPTION; }
			set { _ORGANIZATION_DESCRIPTION = value; }
		}

		public int SPECIAL_ID {
			get { return _SPECIAL_ID; }
			set { _SPECIAL_ID = value; }
		}

		public int ORGANIZATION_LEVEL {
			get { return _ORGANIZATION_LEVEL; }
			set { _ORGANIZATION_LEVEL = value; }
		}
#endregion

#region "Constructors"
public DMORGANIZATIONInfo()
{
}

public DMORGANIZATIONInfo(int ID, string ORGANIZATION_TITLE, string ORGANIZATION_NAME, string ORGANIZATION_CODE, string ORGANIZATION_DESCRIPTION, int SPECIAL_ID, int ORGANIZATION_LEVEL)
{
	this.ID = ID;
	this.ORGANIZATION_TITLE = ORGANIZATION_TITLE;
	this.ORGANIZATION_NAME = ORGANIZATION_NAME;
	this.ORGANIZATION_CODE = ORGANIZATION_CODE;
	this.ORGANIZATION_DESCRIPTION = ORGANIZATION_DESCRIPTION;
	this.SPECIAL_ID = SPECIAL_ID;
	this.ORGANIZATION_LEVEL = ORGANIZATION_LEVEL;
}
#endregion

}

}