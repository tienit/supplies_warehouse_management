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

public partial class DMTITLEInfo
{

#region "Private Members"
private int _ID;
private string _TITLE_NAME;
private string _TITLE_SHORT_NAME;
private string _TITLE_DESCRIPTION;
#endregion

#region "Public Properties"
		public int ID {
			get { return _ID; }
			set { _ID = value; }
		}

		public string TITLE_NAME {
			get { return _TITLE_NAME; }
			set { _TITLE_NAME = value; }
		}

		public string TITLE_SHORT_NAME {
			get { return _TITLE_SHORT_NAME; }
			set { _TITLE_SHORT_NAME = value; }
		}

		public string TITLE_DESCRIPTION {
			get { return _TITLE_DESCRIPTION; }
			set { _TITLE_DESCRIPTION = value; }
		}
#endregion

#region "Constructors"
public DMTITLEInfo()
{
}

public DMTITLEInfo(int ID, string TITLE_NAME, string TITLE_SHORT_NAME, string TITLE_DESCRIPTION)
{
	this.ID = ID;
	this.TITLE_NAME = TITLE_NAME;
	this.TITLE_SHORT_NAME = TITLE_SHORT_NAME;
	this.TITLE_DESCRIPTION = TITLE_DESCRIPTION;
}
#endregion

}

}