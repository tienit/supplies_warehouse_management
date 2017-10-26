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

public partial class DMASSETLEVELInfo
{

#region "Private Members"
private int _ID;
private string _ASSET_LEVEL_NAME;
private int _LEVEL_VALUE;
private int _REMARKS;
#endregion

#region "Public Properties"
		public int ID {
			get { return _ID; }
			set { _ID = value; }
		}

		public string ASSET_LEVEL_NAME {
			get { return _ASSET_LEVEL_NAME; }
			set { _ASSET_LEVEL_NAME = value; }
		}

		public int LEVEL_VALUE {
			get { return _LEVEL_VALUE; }
			set { _LEVEL_VALUE = value; }
		}

		public int REMARKS {
			get { return _REMARKS; }
			set { _REMARKS = value; }
		}
#endregion

#region "Constructors"
public DMASSETLEVELInfo()
{
}

public DMASSETLEVELInfo(int ID, string ASSET_LEVEL_NAME, int LEVEL_VALUE, int REMARKS)
{
	this.ID = ID;
	this.ASSET_LEVEL_NAME = ASSET_LEVEL_NAME;
	this.LEVEL_VALUE = LEVEL_VALUE;
	this.REMARKS = REMARKS;
}
#endregion

}

}