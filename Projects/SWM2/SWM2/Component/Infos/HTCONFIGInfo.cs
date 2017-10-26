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

public partial class HTCONFIGInfo
{

#region "Private Members"
private int _ID;
private string _CONFIG_CODE;
private string _CONFIG_NAME;
private string _CONFIG_VALUE;
private string _CONFIG_DESCRIPTION;
#endregion

#region "Public Properties"
		public int ID {
			get { return _ID; }
			set { _ID = value; }
		}

		public string CONFIG_CODE {
			get { return _CONFIG_CODE; }
			set { _CONFIG_CODE = value; }
		}

		public string CONFIG_NAME {
			get { return _CONFIG_NAME; }
			set { _CONFIG_NAME = value; }
		}

		public string CONFIG_VALUE {
			get { return _CONFIG_VALUE; }
			set { _CONFIG_VALUE = value; }
		}

		public string CONFIG_DESCRIPTION {
			get { return _CONFIG_DESCRIPTION; }
			set { _CONFIG_DESCRIPTION = value; }
		}
#endregion

#region "Constructors"
public HTCONFIGInfo()
{
}

public HTCONFIGInfo(int ID, string CONFIG_CODE, string CONFIG_NAME, string CONFIG_VALUE, string CONFIG_DESCRIPTION)
{
	this.ID = ID;
	this.CONFIG_CODE = CONFIG_CODE;
	this.CONFIG_NAME = CONFIG_NAME;
	this.CONFIG_VALUE = CONFIG_VALUE;
	this.CONFIG_DESCRIPTION = CONFIG_DESCRIPTION;
}
#endregion

}

}