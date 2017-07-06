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

public partial class DTFUNDSInfo
{

#region "Private Members"
private int _ID;
private string _FUNDS_NAME;
private string _FUNDS_DESCRIPTION;
private double _FUNDS_VALUE;
#endregion

#region "Public Properties"
		public int ID {
			get { return _ID; }
			set { _ID = value; }
		}

		public string FUNDS_NAME {
			get { return _FUNDS_NAME; }
			set { _FUNDS_NAME = value; }
		}

		public string FUNDS_DESCRIPTION {
			get { return _FUNDS_DESCRIPTION; }
			set { _FUNDS_DESCRIPTION = value; }
		}

		public double FUNDS_VALUE {
			get { return _FUNDS_VALUE; }
			set { _FUNDS_VALUE = value; }
		}
#endregion

#region "Constructors"
public DTFUNDSInfo()
{
}

public DTFUNDSInfo(int ID, string FUNDS_NAME, string FUNDS_DESCRIPTION, double FUNDS_VALUE)
{
	this.ID = ID;
	this.FUNDS_NAME = FUNDS_NAME;
	this.FUNDS_DESCRIPTION = FUNDS_DESCRIPTION;
	this.FUNDS_VALUE = FUNDS_VALUE;
}
#endregion

}

}