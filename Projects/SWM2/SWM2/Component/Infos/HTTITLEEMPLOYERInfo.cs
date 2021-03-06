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

public partial class HTTITLEEMPLOYERInfo
{

#region "Private Members"
private int _ID;
private int _TITLE_ID;
private int _EMPLOYER_ID;
#endregion

#region "Public Properties"
		public int ID {
			get { return _ID; }
			set { _ID = value; }
		}

		public int TITLE_ID {
			get { return _TITLE_ID; }
			set { _TITLE_ID = value; }
		}

		public int EMPLOYER_ID {
			get { return _EMPLOYER_ID; }
			set { _EMPLOYER_ID = value; }
		}
#endregion

#region "Constructors"
public HTTITLEEMPLOYERInfo()
{
}

public HTTITLEEMPLOYERInfo(int ID, int TITLE_ID, int EMPLOYER_ID)
{
	this.ID = ID;
	this.TITLE_ID = TITLE_ID;
	this.EMPLOYER_ID = EMPLOYER_ID;
}
#endregion

}

}