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

public partial class DMORIGINInfo
{

#region "Private Members"
private int _ID;
private string _ORIGIN_NAME;
private string _ORIGIN_DESCRIPTION;
#endregion

#region "Public Properties"
		public int ID {
			get { return _ID; }
			set { _ID = value; }
		}

		public string ORIGIN_NAME {
			get { return _ORIGIN_NAME; }
			set { _ORIGIN_NAME = value; }
		}

		public string ORIGIN_DESCRIPTION {
			get { return _ORIGIN_DESCRIPTION; }
			set { _ORIGIN_DESCRIPTION = value; }
		}
#endregion

#region "Constructors"
public DMORIGINInfo()
{
}

public DMORIGINInfo(int ID, string ORIGIN_NAME, string ORIGIN_DESCRIPTION)
{
	this.ID = ID;
	this.ORIGIN_NAME = ORIGIN_NAME;
	this.ORIGIN_DESCRIPTION = ORIGIN_DESCRIPTION;
}
#endregion

}

}