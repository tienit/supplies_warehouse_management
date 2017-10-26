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

public partial class DTUSERCONFIGInfo
{

#region "Private Members"
private int _ID;
private int _USER_ID;
private int _CONFIG_ID;
private string _CONFIG_CODE;
private string _CONFIG_VALUE;
#endregion

#region "Public Properties"
		public int ID {
			get { return _ID; }
			set { _ID = value; }
		}

		public int USER_ID {
			get { return _USER_ID; }
			set { _USER_ID = value; }
		}

		public int CONFIG_ID {
			get { return _CONFIG_ID; }
			set { _CONFIG_ID = value; }
		}

		public string CONFIG_CODE {
			get { return _CONFIG_CODE; }
			set { _CONFIG_CODE = value; }
		}

		public string CONFIG_VALUE {
			get { return _CONFIG_VALUE; }
			set { _CONFIG_VALUE = value; }
		}
#endregion

#region "Constructors"
public DTUSERCONFIGInfo()
{
}

public DTUSERCONFIGInfo(int ID, int USER_ID, int CONFIG_ID, string CONFIG_CODE, string CONFIG_VALUE)
{
	this.ID = ID;
	this.USER_ID = USER_ID;
	this.CONFIG_ID = CONFIG_ID;
	this.CONFIG_CODE = CONFIG_CODE;
	this.CONFIG_VALUE = CONFIG_VALUE;
}
#endregion

}

}