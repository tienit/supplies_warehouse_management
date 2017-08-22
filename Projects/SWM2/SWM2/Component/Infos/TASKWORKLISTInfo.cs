//*************************************************************
//Author           : Tien NQ
//Created Date     : 8/22/2017
//Comment          : Base class for access to database.
//History          : 
//*************************************************************

using System;
using System.Data;

namespace VKTIM.Component
{

public partial class TASKWORKLISTInfo
{

#region "Private Members"
private int _ID;
private string _CODE;
private string _CONTENTS;
private string _CONTROL;
private string _STARTDATE;
private string _ENDDATE;
private string _STATUS;
private bool _FINISHED;
private string _REMARKS;
#endregion

#region "Public Properties"
		public int ID {
			get { return _ID; }
			set { _ID = value; }
		}

		public string CODE {
			get { return _CODE; }
			set { _CODE = value; }
		}

		public string CONTENTS {
			get { return _CONTENTS; }
			set { _CONTENTS = value; }
		}

		public string CONTROL {
			get { return _CONTROL; }
			set { _CONTROL = value; }
		}

		public string STARTDATE {
			get { return _STARTDATE; }
			set { _STARTDATE = value; }
		}

		public string ENDDATE {
			get { return _ENDDATE; }
			set { _ENDDATE = value; }
		}

		public string STATUS {
			get { return _STATUS; }
			set { _STATUS = value; }
		}

		public bool FINISHED {
			get { return _FINISHED; }
			set { _FINISHED = value; }
		}

		public string REMARKS {
			get { return _REMARKS; }
			set { _REMARKS = value; }
		}
#endregion

#region "Constructors"
public TASKWORKLISTInfo()
{
}

public TASKWORKLISTInfo(int ID, string CODE, string CONTENTS, string CONTROL, string STARTDATE, string ENDDATE, string STATUS, bool FINISHED, string REMARKS)
{
	this.ID = ID;
	this.CODE = CODE;
	this.CONTENTS = CONTENTS;
	this.CONTROL = CONTROL;
	this.STARTDATE = STARTDATE;
	this.ENDDATE = ENDDATE;
	this.STATUS = STATUS;
	this.FINISHED = FINISHED;
	this.REMARKS = REMARKS;
}
#endregion

}

}