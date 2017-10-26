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

public partial class DTFAQInfo
{

#region "Private Members"
private int _ID;
private int _FORM_ID;
private string _FORM_NAME;
private string _QUESTION;
private string _ANSWER;
private string _SHORTCUT_KEY;
private string _LONG_ANSWER;
private string _KEYWORD;
private string _GROUP;
private string _REMARKS;
#endregion

#region "Public Properties"
		public int ID {
			get { return _ID; }
			set { _ID = value; }
		}

		public int FORM_ID {
			get { return _FORM_ID; }
			set { _FORM_ID = value; }
		}

		public string FORM_NAME {
			get { return _FORM_NAME; }
			set { _FORM_NAME = value; }
		}

		public string QUESTION {
			get { return _QUESTION; }
			set { _QUESTION = value; }
		}

		public string ANSWER {
			get { return _ANSWER; }
			set { _ANSWER = value; }
		}

		public string SHORTCUT_KEY {
			get { return _SHORTCUT_KEY; }
			set { _SHORTCUT_KEY = value; }
		}

		public string LONG_ANSWER {
			get { return _LONG_ANSWER; }
			set { _LONG_ANSWER = value; }
		}

		public string KEYWORD {
			get { return _KEYWORD; }
			set { _KEYWORD = value; }
		}

		public string GROUP {
			get { return _GROUP; }
			set { _GROUP = value; }
		}

		public string REMARKS {
			get { return _REMARKS; }
			set { _REMARKS = value; }
		}
#endregion

#region "Constructors"
public DTFAQInfo()
{
}

public DTFAQInfo(int ID, int FORM_ID, string FORM_NAME, string QUESTION, string ANSWER, string SHORTCUT_KEY, string LONG_ANSWER, string KEYWORD, string GROUP, string REMARKS)
{
	this.ID = ID;
	this.FORM_ID = FORM_ID;
	this.FORM_NAME = FORM_NAME;
	this.QUESTION = QUESTION;
	this.ANSWER = ANSWER;
	this.SHORTCUT_KEY = SHORTCUT_KEY;
	this.LONG_ANSWER = LONG_ANSWER;
	this.KEYWORD = KEYWORD;
	this.GROUP = GROUP;
	this.REMARKS = REMARKS;
}
#endregion

}

}