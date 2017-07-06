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

public partial class DMOUTPUTTYPEInfo
{

#region "Private Members"
private int _ID;
private string _OUTPUTTYPE_NAME;
private bool _ISUSED;
#endregion

#region "Public Properties"
		public int ID {
			get { return _ID; }
			set { _ID = value; }
		}

		public string OUTPUTTYPE_NAME {
			get { return _OUTPUTTYPE_NAME; }
			set { _OUTPUTTYPE_NAME = value; }
		}

		public bool ISUSED {
			get { return _ISUSED; }
			set { _ISUSED = value; }
		}
#endregion

#region "Constructors"
public DMOUTPUTTYPEInfo()
{
}

public DMOUTPUTTYPEInfo(int ID, string OUTPUTTYPE_NAME, bool ISUSED)
{
	this.ID = ID;
	this.OUTPUTTYPE_NAME = OUTPUTTYPE_NAME;
	this.ISUSED = ISUSED;
}
#endregion

}

}