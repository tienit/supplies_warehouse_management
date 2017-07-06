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

public partial class HTROLEUSERInfo
{

#region "Private Members"
private int _ID;
private int _ROLE_ID;
private int _USER_ID;
#endregion

#region "Public Properties"
		public int ID {
			get { return _ID; }
			set { _ID = value; }
		}

		public int ROLE_ID {
			get { return _ROLE_ID; }
			set { _ROLE_ID = value; }
		}

		public int USER_ID {
			get { return _USER_ID; }
			set { _USER_ID = value; }
		}
#endregion

#region "Constructors"
public HTROLEUSERInfo()
{
}

public HTROLEUSERInfo(int ID, int ROLE_ID, int USER_ID)
{
	this.ID = ID;
	this.ROLE_ID = ROLE_ID;
	this.USER_ID = USER_ID;
}
#endregion

}

}