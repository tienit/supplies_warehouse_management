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

public partial class DTPRODUCTPARAMETERInfo
{

#region "Private Members"
private int _ID;
private int _PRODUCT_ID;
private int _PARAMETER_ID;
#endregion

#region "Public Properties"
		public int ID {
			get { return _ID; }
			set { _ID = value; }
		}

		public int PRODUCT_ID {
			get { return _PRODUCT_ID; }
			set { _PRODUCT_ID = value; }
		}

		public int PARAMETER_ID {
			get { return _PARAMETER_ID; }
			set { _PARAMETER_ID = value; }
		}
#endregion

#region "Constructors"
public DTPRODUCTPARAMETERInfo()
{
}

public DTPRODUCTPARAMETERInfo(int ID, int PRODUCT_ID, int PARAMETER_ID)
{
	this.ID = ID;
	this.PRODUCT_ID = PRODUCT_ID;
	this.PARAMETER_ID = PARAMETER_ID;
}
#endregion

}

}