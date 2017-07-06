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

public partial class HTROLEInfo
{

#region "Private Members"
private int _ID;
private string _ROLE_NAME;
private string _ROLE_DESCRIPTION;
private bool _IS_DEFAULT;
#endregion

#region "Public Properties"
		public int ID {
			get { return _ID; }
			set { _ID = value; }
		}

		public string ROLE_NAME {
			get { return _ROLE_NAME; }
			set { _ROLE_NAME = value; }
		}

		public string ROLE_DESCRIPTION {
			get { return _ROLE_DESCRIPTION; }
			set { _ROLE_DESCRIPTION = value; }
		}

		public bool IS_DEFAULT {
			get { return _IS_DEFAULT; }
			set { _IS_DEFAULT = value; }
		}
#endregion

#region "Constructors"
public HTROLEInfo()
{
}

public HTROLEInfo(int ID, string ROLE_NAME, string ROLE_DESCRIPTION, bool IS_DEFAULT)
{
	this.ID = ID;
	this.ROLE_NAME = ROLE_NAME;
	this.ROLE_DESCRIPTION = ROLE_DESCRIPTION;
	this.IS_DEFAULT = IS_DEFAULT;
}
#endregion

}

}