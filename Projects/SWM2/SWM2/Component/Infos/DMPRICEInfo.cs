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

public partial class DMPRICEInfo
{

#region "Private Members"
private int _ID;
private string _PRICE_NAME;
private string _PRICE_SYMBOL;
private string _PRICE_CODE;
private double _PRICE_MIN_VALUE;
private bool _IS_DEFAULT;
#endregion

#region "Public Properties"
		public int ID {
			get { return _ID; }
			set { _ID = value; }
		}

		public string PRICE_NAME {
			get { return _PRICE_NAME; }
			set { _PRICE_NAME = value; }
		}

		public string PRICE_SYMBOL {
			get { return _PRICE_SYMBOL; }
			set { _PRICE_SYMBOL = value; }
		}

		public string PRICE_CODE {
			get { return _PRICE_CODE; }
			set { _PRICE_CODE = value; }
		}

		public double PRICE_MIN_VALUE {
			get { return _PRICE_MIN_VALUE; }
			set { _PRICE_MIN_VALUE = value; }
		}

		public bool IS_DEFAULT {
			get { return _IS_DEFAULT; }
			set { _IS_DEFAULT = value; }
		}
#endregion

#region "Constructors"
public DMPRICEInfo()
{
}

public DMPRICEInfo(int ID, string PRICE_NAME, string PRICE_SYMBOL, string PRICE_CODE, double PRICE_MIN_VALUE, bool IS_DEFAULT)
{
	this.ID = ID;
	this.PRICE_NAME = PRICE_NAME;
	this.PRICE_SYMBOL = PRICE_SYMBOL;
	this.PRICE_CODE = PRICE_CODE;
	this.PRICE_MIN_VALUE = PRICE_MIN_VALUE;
	this.IS_DEFAULT = IS_DEFAULT;
}
#endregion

}

}