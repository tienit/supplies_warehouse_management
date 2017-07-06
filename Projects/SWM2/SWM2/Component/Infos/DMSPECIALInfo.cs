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

public partial class DMSPECIALInfo
{

#region "Private Members"
private int _ID;
private string _SPECIAL_NAME;
private string _SPECIAL_DESCRIPTION;
#endregion

#region "Public Properties"
		public int ID {
			get { return _ID; }
			set { _ID = value; }
		}

		public string SPECIAL_NAME {
			get { return _SPECIAL_NAME; }
			set { _SPECIAL_NAME = value; }
		}

		public string SPECIAL_DESCRIPTION {
			get { return _SPECIAL_DESCRIPTION; }
			set { _SPECIAL_DESCRIPTION = value; }
		}
#endregion

#region "Constructors"
public DMSPECIALInfo()
{
}

public DMSPECIALInfo(int ID, string SPECIAL_NAME, string SPECIAL_DESCRIPTION)
{
	this.ID = ID;
	this.SPECIAL_NAME = SPECIAL_NAME;
	this.SPECIAL_DESCRIPTION = SPECIAL_DESCRIPTION;
}
#endregion

}

}