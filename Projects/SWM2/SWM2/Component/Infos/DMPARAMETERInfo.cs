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

public partial class DMPARAMETERInfo
{

#region "Private Members"
private int _ID;
private string _PARAMETER_NAME;
private string _PARAMETER_VALUE;
private string _PARAMETER_UNIT;
private string _PARAMETER_CODE;
private string _PARAMETER_DESCRIPTION;
#endregion

#region "Public Properties"
		public int ID {
			get { return _ID; }
			set { _ID = value; }
		}

		public string PARAMETER_NAME {
			get { return _PARAMETER_NAME; }
			set { _PARAMETER_NAME = value; }
		}

		public string PARAMETER_VALUE {
			get { return _PARAMETER_VALUE; }
			set { _PARAMETER_VALUE = value; }
		}

		public string PARAMETER_UNIT {
			get { return _PARAMETER_UNIT; }
			set { _PARAMETER_UNIT = value; }
		}

		public string PARAMETER_CODE {
			get { return _PARAMETER_CODE; }
			set { _PARAMETER_CODE = value; }
		}

		public string PARAMETER_DESCRIPTION {
			get { return _PARAMETER_DESCRIPTION; }
			set { _PARAMETER_DESCRIPTION = value; }
		}
#endregion

#region "Constructors"
public DMPARAMETERInfo()
{
}

public DMPARAMETERInfo(int ID, string PARAMETER_NAME, string PARAMETER_VALUE, string PARAMETER_UNIT, string PARAMETER_CODE, string PARAMETER_DESCRIPTION)
{
	this.ID = ID;
	this.PARAMETER_NAME = PARAMETER_NAME;
	this.PARAMETER_VALUE = PARAMETER_VALUE;
	this.PARAMETER_UNIT = PARAMETER_UNIT;
	this.PARAMETER_CODE = PARAMETER_CODE;
	this.PARAMETER_DESCRIPTION = PARAMETER_DESCRIPTION;
}
#endregion

}

}