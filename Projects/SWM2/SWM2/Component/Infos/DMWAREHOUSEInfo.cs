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

public partial class DMWAREHOUSEInfo
{

#region "Private Members"
private int _ID;
private string _WAREHOUSE_NAME;
private int _PARENT_ID;
private string _WAREHOUSE_DESCRIPTION;
#endregion

#region "Public Properties"
		public int ID {
			get { return _ID; }
			set { _ID = value; }
		}

		public string WAREHOUSE_NAME {
			get { return _WAREHOUSE_NAME; }
			set { _WAREHOUSE_NAME = value; }
		}

		public int PARENT_ID {
			get { return _PARENT_ID; }
			set { _PARENT_ID = value; }
		}

		public string WAREHOUSE_DESCRIPTION {
			get { return _WAREHOUSE_DESCRIPTION; }
			set { _WAREHOUSE_DESCRIPTION = value; }
		}
#endregion

#region "Constructors"
public DMWAREHOUSEInfo()
{
}

public DMWAREHOUSEInfo(int ID, string WAREHOUSE_NAME, int PARENT_ID, string WAREHOUSE_DESCRIPTION)
{
	this.ID = ID;
	this.WAREHOUSE_NAME = WAREHOUSE_NAME;
	this.PARENT_ID = PARENT_ID;
	this.WAREHOUSE_DESCRIPTION = WAREHOUSE_DESCRIPTION;
}
#endregion

}

}