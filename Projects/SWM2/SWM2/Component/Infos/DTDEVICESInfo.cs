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

public partial class DTDEVICESInfo
{

#region "Private Members"
private int _ID;
private string _NAME;
private string _IPv4;
private string _IPv6;
private int _ORGANIZATION_ID;
private string _ORGANIZATION_NAME;
private bool _LOCKED;
private string _REMARK;
#endregion

#region "Public Properties"
		public int ID {
			get { return _ID; }
			set { _ID = value; }
		}

		public string NAME {
			get { return _NAME; }
			set { _NAME = value; }
		}

		public string IPv4 {
			get { return _IPv4; }
			set { _IPv4 = value; }
		}

		public string IPv6 {
			get { return _IPv6; }
			set { _IPv6 = value; }
		}

		public int ORGANIZATION_ID {
			get { return _ORGANIZATION_ID; }
			set { _ORGANIZATION_ID = value; }
		}

		public string ORGANIZATION_NAME {
			get { return _ORGANIZATION_NAME; }
			set { _ORGANIZATION_NAME = value; }
		}

		public bool LOCKED {
			get { return _LOCKED; }
			set { _LOCKED = value; }
		}

		public string REMARK {
			get { return _REMARK; }
			set { _REMARK = value; }
		}
#endregion

#region "Constructors"
public DTDEVICESInfo()
{
}

public DTDEVICESInfo(int ID, string NAME, string IPv4, string IPv6, int ORGANIZATION_ID, string ORGANIZATION_NAME, bool LOCKED, string REMARK)
{
	this.ID = ID;
	this.NAME = NAME;
	this.IPv4 = IPv4;
	this.IPv6 = IPv6;
	this.ORGANIZATION_ID = ORGANIZATION_ID;
	this.ORGANIZATION_NAME = ORGANIZATION_NAME;
	this.LOCKED = LOCKED;
	this.REMARK = REMARK;
}
#endregion

}

}