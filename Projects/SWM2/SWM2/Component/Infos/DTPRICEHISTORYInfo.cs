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

public partial class DTPRICEHISTORYInfo
{

#region "Private Members"
private int _ID;
private int _PRODUCT_ID;
private double _PRICE_VALUE;
private int _PRICE_ID;
#endregion

#region "Public Properties"
		public int ID {
			get { return _ID; }
			set { _ID = value; }
		}

		public int PRODUCT_ID {
			get { return _PRODUCT_ID; }
			set { _PRODUCT_ID = value; }
		}

		public double PRICE_VALUE {
			get { return _PRICE_VALUE; }
			set { _PRICE_VALUE = value; }
		}

		public int PRICE_ID {
			get { return _PRICE_ID; }
			set { _PRICE_ID = value; }
		}
#endregion

#region "Constructors"
public DTPRICEHISTORYInfo()
{
}

public DTPRICEHISTORYInfo(int ID, int PRODUCT_ID, double PRICE_VALUE, int PRICE_ID)
{
	this.ID = ID;
	this.PRODUCT_ID = PRODUCT_ID;
	this.PRICE_VALUE = PRICE_VALUE;
	this.PRICE_ID = PRICE_ID;
}
#endregion

}

}