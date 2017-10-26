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

public partial class DMUNITInfo
{

#region "Private Members"
private int _ID;
private string _UNIT_NAME;
private string _UNIT_SHORT_NAME;
private string _UNIT_DESCRIPTION;
#endregion

#region "Public Properties"
		public int ID {
			get { return _ID; }
			set { _ID = value; }
		}

		public string UNIT_NAME {
			get { return _UNIT_NAME; }
			set { _UNIT_NAME = value; }
		}

		public string UNIT_SHORT_NAME {
			get { return _UNIT_SHORT_NAME; }
			set { _UNIT_SHORT_NAME = value; }
		}

		public string UNIT_DESCRIPTION {
			get { return _UNIT_DESCRIPTION; }
			set { _UNIT_DESCRIPTION = value; }
		}
#endregion

#region "Constructors"
public DMUNITInfo()
{
}

public DMUNITInfo(int ID, string UNIT_NAME, string UNIT_SHORT_NAME, string UNIT_DESCRIPTION)
{
	this.ID = ID;
	this.UNIT_NAME = UNIT_NAME;
	this.UNIT_SHORT_NAME = UNIT_SHORT_NAME;
	this.UNIT_DESCRIPTION = UNIT_DESCRIPTION;
}
#endregion

}

}