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

public partial class DMLOCATIONInfo
{

#region "Private Members"
private int _ID;
private string _LOCATION_NAME;
private int _LOCATION_ORDER;
private int _LOCATION_PARENT_ID;
private int _LOCATION_LEVEL;
#endregion

#region "Public Properties"
		public int ID {
			get { return _ID; }
			set { _ID = value; }
		}

		public string LOCATION_NAME {
			get { return _LOCATION_NAME; }
			set { _LOCATION_NAME = value; }
		}

		public int LOCATION_ORDER {
			get { return _LOCATION_ORDER; }
			set { _LOCATION_ORDER = value; }
		}

		public int LOCATION_PARENT_ID {
			get { return _LOCATION_PARENT_ID; }
			set { _LOCATION_PARENT_ID = value; }
		}

		public int LOCATION_LEVEL {
			get { return _LOCATION_LEVEL; }
			set { _LOCATION_LEVEL = value; }
		}
#endregion

#region "Constructors"
public DMLOCATIONInfo()
{
}

public DMLOCATIONInfo(int ID, string LOCATION_NAME, int LOCATION_ORDER, int LOCATION_PARENT_ID, int LOCATION_LEVEL)
{
	this.ID = ID;
	this.LOCATION_NAME = LOCATION_NAME;
	this.LOCATION_ORDER = LOCATION_ORDER;
	this.LOCATION_PARENT_ID = LOCATION_PARENT_ID;
	this.LOCATION_LEVEL = LOCATION_LEVEL;
}
#endregion

}

}