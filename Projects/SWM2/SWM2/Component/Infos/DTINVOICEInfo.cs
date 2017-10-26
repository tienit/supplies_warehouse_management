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

public partial class DTINVOICEInfo
{

#region "Private Members"
private int _ID;
private int _INPUT_ID;
private bool _INVOICE_INPUT;
private string _INVOICE_CODE;
private string _INVOICE_NAME;
private string _INVOICE_NUMBER;
private string _INVOICE_CONTENTS;
private DateTime _DATE_CREATED;
private DateTime _DATE_MODIFILED;
private string _REMARKS;
private string _INVOICE_PATH;
private string _INVOICE_EXT;
private string _INVOICE_IMG;
#endregion

#region "Public Properties"
		public int ID {
			get { return _ID; }
			set { _ID = value; }
		}

		public int INPUT_ID {
			get { return _INPUT_ID; }
			set { _INPUT_ID = value; }
		}

		public bool INVOICE_INPUT {
			get { return _INVOICE_INPUT; }
			set { _INVOICE_INPUT = value; }
		}

		public string INVOICE_CODE {
			get { return _INVOICE_CODE; }
			set { _INVOICE_CODE = value; }
		}

		public string INVOICE_NAME {
			get { return _INVOICE_NAME; }
			set { _INVOICE_NAME = value; }
		}

		public string INVOICE_NUMBER {
			get { return _INVOICE_NUMBER; }
			set { _INVOICE_NUMBER = value; }
		}

		public string INVOICE_CONTENTS {
			get { return _INVOICE_CONTENTS; }
			set { _INVOICE_CONTENTS = value; }
		}

		public DateTime DATE_CREATED {
			get { return _DATE_CREATED; }
			set { _DATE_CREATED = value; }
		}

		public DateTime DATE_MODIFILED {
			get { return _DATE_MODIFILED; }
			set { _DATE_MODIFILED = value; }
		}

		public string REMARKS {
			get { return _REMARKS; }
			set { _REMARKS = value; }
		}

		public string INVOICE_PATH {
			get { return _INVOICE_PATH; }
			set { _INVOICE_PATH = value; }
		}

		public string INVOICE_EXT {
			get { return _INVOICE_EXT; }
			set { _INVOICE_EXT = value; }
		}

		public string INVOICE_IMG {
			get { return _INVOICE_IMG; }
			set { _INVOICE_IMG = value; }
		}
#endregion

#region "Constructors"
public DTINVOICEInfo()
{
}

public DTINVOICEInfo(int ID, int INPUT_ID, bool INVOICE_INPUT, string INVOICE_CODE, string INVOICE_NAME, string INVOICE_NUMBER, string INVOICE_CONTENTS, DateTime DATE_CREATED, DateTime DATE_MODIFILED, string REMARKS, string INVOICE_PATH, string INVOICE_EXT, string INVOICE_IMG)
{
	this.ID = ID;
	this.INPUT_ID = INPUT_ID;
	this.INVOICE_INPUT = INVOICE_INPUT;
	this.INVOICE_CODE = INVOICE_CODE;
	this.INVOICE_NAME = INVOICE_NAME;
	this.INVOICE_NUMBER = INVOICE_NUMBER;
	this.INVOICE_CONTENTS = INVOICE_CONTENTS;
	this.DATE_CREATED = DATE_CREATED;
	this.DATE_MODIFILED = DATE_MODIFILED;
	this.REMARKS = REMARKS;
	this.INVOICE_PATH = INVOICE_PATH;
	this.INVOICE_EXT = INVOICE_EXT;
	this.INVOICE_IMG = INVOICE_IMG;
}
#endregion

}

}