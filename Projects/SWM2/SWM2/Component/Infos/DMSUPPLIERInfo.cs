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

public partial class DMSUPPLIERInfo
{

#region "Private Members"
private int _ID;
private string _SUPPLIER_NAME;
private string _SUPPLIER_DESCRIPTION;
private int _PARENT_ID;
private string _SUPPLIER_SHORTNAME;
private string _SUPPLIER_ADDRESS;
private string _SUPPLIER_DIRECTOR;
private string _SUPPLIER_MST;
#endregion

#region "Public Properties"
		public int ID {
			get { return _ID; }
			set { _ID = value; }
		}

		public string SUPPLIER_NAME {
			get { return _SUPPLIER_NAME; }
			set { _SUPPLIER_NAME = value; }
		}

		public string SUPPLIER_DESCRIPTION {
			get { return _SUPPLIER_DESCRIPTION; }
			set { _SUPPLIER_DESCRIPTION = value; }
		}

		public int PARENT_ID {
			get { return _PARENT_ID; }
			set { _PARENT_ID = value; }
		}

		public string SUPPLIER_SHORTNAME {
			get { return _SUPPLIER_SHORTNAME; }
			set { _SUPPLIER_SHORTNAME = value; }
		}

		public string SUPPLIER_ADDRESS {
			get { return _SUPPLIER_ADDRESS; }
			set { _SUPPLIER_ADDRESS = value; }
		}

		public string SUPPLIER_DIRECTOR {
			get { return _SUPPLIER_DIRECTOR; }
			set { _SUPPLIER_DIRECTOR = value; }
		}

		public string SUPPLIER_MST {
			get { return _SUPPLIER_MST; }
			set { _SUPPLIER_MST = value; }
		}
#endregion

#region "Constructors"
public DMSUPPLIERInfo()
{
}

public DMSUPPLIERInfo(int ID, string SUPPLIER_NAME, string SUPPLIER_DESCRIPTION, int PARENT_ID, string SUPPLIER_SHORTNAME, string SUPPLIER_ADDRESS, string SUPPLIER_DIRECTOR, string SUPPLIER_MST)
{
	this.ID = ID;
	this.SUPPLIER_NAME = SUPPLIER_NAME;
	this.SUPPLIER_DESCRIPTION = SUPPLIER_DESCRIPTION;
	this.PARENT_ID = PARENT_ID;
	this.SUPPLIER_SHORTNAME = SUPPLIER_SHORTNAME;
	this.SUPPLIER_ADDRESS = SUPPLIER_ADDRESS;
	this.SUPPLIER_DIRECTOR = SUPPLIER_DIRECTOR;
	this.SUPPLIER_MST = SUPPLIER_MST;
}
#endregion

}

}