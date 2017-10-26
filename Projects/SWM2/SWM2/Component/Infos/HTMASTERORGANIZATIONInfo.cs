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

public partial class HTMASTERORGANIZATIONInfo
{

#region "Private Members"
private int _ID;
private int _EMPLOYER_ID;
private int _ORGANIZATION_ID;
private int _ORGANIZATION_LEVEL;
#endregion

#region "Public Properties"
		public int ID {
			get { return _ID; }
			set { _ID = value; }
		}

		public int EMPLOYER_ID {
			get { return _EMPLOYER_ID; }
			set { _EMPLOYER_ID = value; }
		}

		public int ORGANIZATION_ID {
			get { return _ORGANIZATION_ID; }
			set { _ORGANIZATION_ID = value; }
		}

		public int ORGANIZATION_LEVEL {
			get { return _ORGANIZATION_LEVEL; }
			set { _ORGANIZATION_LEVEL = value; }
		}
#endregion

#region "Constructors"
public HTMASTERORGANIZATIONInfo()
{
}

public HTMASTERORGANIZATIONInfo(int ID, int EMPLOYER_ID, int ORGANIZATION_ID, int ORGANIZATION_LEVEL)
{
	this.ID = ID;
	this.EMPLOYER_ID = EMPLOYER_ID;
	this.ORGANIZATION_ID = ORGANIZATION_ID;
	this.ORGANIZATION_LEVEL = ORGANIZATION_LEVEL;
}
#endregion

}

}