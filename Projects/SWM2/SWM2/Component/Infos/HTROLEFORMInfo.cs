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

public partial class HTROLEFORMInfo
{

#region "Private Members"
private int _ID;
private int _ROLE_ID;
private int _FORM_ID;
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

		public int FORM_ID {
			get { return _FORM_ID; }
			set { _FORM_ID = value; }
		}
#endregion

#region "Constructors"
public HTROLEFORMInfo()
{
}

public HTROLEFORMInfo(int ID, int ROLE_ID, int FORM_ID)
{
	this.ID = ID;
	this.ROLE_ID = ROLE_ID;
	this.FORM_ID = FORM_ID;
}
#endregion

}

}