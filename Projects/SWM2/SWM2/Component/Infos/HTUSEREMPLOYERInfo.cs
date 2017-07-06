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

public partial class HTUSEREMPLOYERInfo
{

#region "Private Members"
private int _ID;
private int _USER_ID;
private int _EMPLOYER_ID;
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

		public int EMPLOYER_ID {
			get { return _EMPLOYER_ID; }
			set { _EMPLOYER_ID = value; }
		}
#endregion

#region "Constructors"
public HTUSEREMPLOYERInfo()
{
}

public HTUSEREMPLOYERInfo(int ID, int USER_ID, int EMPLOYER_ID)
{
	this.ID = ID;
	this.USER_ID = USER_ID;
	this.EMPLOYER_ID = EMPLOYER_ID;
}
#endregion

}

}