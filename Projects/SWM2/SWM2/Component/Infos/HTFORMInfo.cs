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

public partial class HTFORMInfo
{

#region "Private Members"
private int _ID;
private string _FORM_NAME;
private string _FORM_TITLE;
private string _MENU_NAME;
private bool _IS_SHOW_DIALOG;
private string _SHORTCUT_KEY;
private bool _IS_USED;
private int _FORM_ORDER;
#endregion

#region "Public Properties"
		public int ID {
			get { return _ID; }
			set { _ID = value; }
		}

		public string FORM_NAME {
			get { return _FORM_NAME; }
			set { _FORM_NAME = value; }
		}

		public string FORM_TITLE {
			get { return _FORM_TITLE; }
			set { _FORM_TITLE = value; }
		}

		public string MENU_NAME {
			get { return _MENU_NAME; }
			set { _MENU_NAME = value; }
		}

		public bool IS_SHOW_DIALOG {
			get { return _IS_SHOW_DIALOG; }
			set { _IS_SHOW_DIALOG = value; }
		}

		public string SHORTCUT_KEY {
			get { return _SHORTCUT_KEY; }
			set { _SHORTCUT_KEY = value; }
		}

		public bool IS_USED {
			get { return _IS_USED; }
			set { _IS_USED = value; }
		}

		public int FORM_ORDER {
			get { return _FORM_ORDER; }
			set { _FORM_ORDER = value; }
		}
#endregion

#region "Constructors"
public HTFORMInfo()
{
}

public HTFORMInfo(int ID, string FORM_NAME, string FORM_TITLE, string MENU_NAME, bool IS_SHOW_DIALOG, string SHORTCUT_KEY, bool IS_USED, int FORM_ORDER)
{
	this.ID = ID;
	this.FORM_NAME = FORM_NAME;
	this.FORM_TITLE = FORM_TITLE;
	this.MENU_NAME = MENU_NAME;
	this.IS_SHOW_DIALOG = IS_SHOW_DIALOG;
	this.SHORTCUT_KEY = SHORTCUT_KEY;
	this.IS_USED = IS_USED;
	this.FORM_ORDER = FORM_ORDER;
}
#endregion

}

}