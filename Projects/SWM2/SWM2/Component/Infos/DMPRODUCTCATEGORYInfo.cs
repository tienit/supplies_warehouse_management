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

public partial class DMPRODUCTCATEGORYInfo
{

#region "Private Members"
private int _ID;
private string _PRODUCTCATEGORY_NAME;
private string _PRODUCTCATEGORY_DESCRIPTION;
#endregion

#region "Public Properties"
		public int ID {
			get { return _ID; }
			set { _ID = value; }
		}

		public string PRODUCTCATEGORY_NAME {
			get { return _PRODUCTCATEGORY_NAME; }
			set { _PRODUCTCATEGORY_NAME = value; }
		}

		public string PRODUCTCATEGORY_DESCRIPTION {
			get { return _PRODUCTCATEGORY_DESCRIPTION; }
			set { _PRODUCTCATEGORY_DESCRIPTION = value; }
		}
#endregion

#region "Constructors"
public DMPRODUCTCATEGORYInfo()
{
}

public DMPRODUCTCATEGORYInfo(int ID, string PRODUCTCATEGORY_NAME, string PRODUCTCATEGORY_DESCRIPTION)
{
	this.ID = ID;
	this.PRODUCTCATEGORY_NAME = PRODUCTCATEGORY_NAME;
	this.PRODUCTCATEGORY_DESCRIPTION = PRODUCTCATEGORY_DESCRIPTION;
}
#endregion

}

}