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

public partial class DMRANKInfo
{

#region "Private Members"
private int _ID;
private string _RANK_NAME;
private string _RANK_DESCRIPTION;
#endregion

#region "Public Properties"
		public int ID {
			get { return _ID; }
			set { _ID = value; }
		}

		public string RANK_NAME {
			get { return _RANK_NAME; }
			set { _RANK_NAME = value; }
		}

		public string RANK_DESCRIPTION {
			get { return _RANK_DESCRIPTION; }
			set { _RANK_DESCRIPTION = value; }
		}
#endregion

#region "Constructors"
public DMRANKInfo()
{
}

public DMRANKInfo(int ID, string RANK_NAME, string RANK_DESCRIPTION)
{
	this.ID = ID;
	this.RANK_NAME = RANK_NAME;
	this.RANK_DESCRIPTION = RANK_DESCRIPTION;
}
#endregion

}

}