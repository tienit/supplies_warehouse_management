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

public partial class DMDRUGInfo
{

#region "Private Members"
private int _ID;
private string _DRUG_NAME;
private string _DRUG_CODE;
private int _UNIT_ID;
private string _UNIT_NAME;
private double _UNIT_PRICE;
private double _QUANTITY;
private string _DRUG_DESCRIPTION;
private int _CATEGORY_ID;
private string _CATEGORY_NAME;
private string _STATUS;
private DateTime _EXPERIED_DATE;
private DateTime _PRODUCT_DATE;
private string _COMPANY;
private string _DRUG_DOSE;
private string _DRUG_COMPONENT;
private string _COUNTRY;
private int _USER_ID;
private string _USER_NAME;
private DateTime _CREATED_DATE;
private bool _IS_USED;
private string _IMAGE;
#endregion

#region "Public Properties"
		public int ID {
			get { return _ID; }
			set { _ID = value; }
		}

		public string DRUG_NAME {
			get { return _DRUG_NAME; }
			set { _DRUG_NAME = value; }
		}

		public string DRUG_CODE {
			get { return _DRUG_CODE; }
			set { _DRUG_CODE = value; }
		}
		
		public int UNIT_ID {
			get { return _UNIT_ID; }
			set { _UNIT_ID = value; }
		}
		
				public string UNIT_NAME
        {
            get { return _UNIT_NAME; }
            set { _UNIT_NAME = value; }
        }
		
				public double UNIT_PRICE {
			get { return _UNIT_PRICE; }
			set { _UNIT_PRICE = value; }
		}
		
				public double QUANTITY {
			get { return _QUANTITY; }
			set { _QUANTITY = value; }
		}		
		
		public string DRUG_DESCRIPTION {
			get { return _DRUG_DESCRIPTION; }
			set { _DRUG_DESCRIPTION = value; }
		}
		
				public int CATEGORY_ID {
			get { return _CATEGORY_ID; }
			set { _CATEGORY_ID = value; }
		}

		public string CATEGORY_NAME {
			get { return _CATEGORY_NAME; }
			set { _CATEGORY_NAME = value; }
		}
		
				public string STATUS {
			get { return _STATUS; }
			set { _STATUS = value; }
		}
		
				public DateTime EXPERIED_DATE {
			get { return _EXPERIED_DATE; }
			set { _EXPERIED_DATE = value; }
		}
		
				public DateTime PRODUCT_DATE {
			get { return _PRODUCT_DATE; }
			set { _PRODUCT_DATE = value; }
		}
		
				public string COMPANY {
			get { return _COMPANY; }
			set { _COMPANY = value; }
		}		
		
				public string DRUG_DOSE
        {
			get { return _DRUG_DOSE; }
			set { _DRUG_DOSE = value; }
		}			
		
				public string DRUG_COMPONENT {
			get { return _DRUG_COMPONENT; }
			set { _DRUG_COMPONENT = value; }
		}

						public string COUNTRY {
			get { return _COUNTRY; }
			set { _COUNTRY = value; }
		}
		
				public int USER_ID {
			get { return _USER_ID; }
			set { _USER_ID = value; }
		}

		public string USER_NAME {
			get { return _USER_NAME; }
			set { _USER_NAME = value; }
		}
		
				public DateTime CREATED_DATE {
			get { return _CREATED_DATE; }
			set { _CREATED_DATE = value; }
		}
		
				public bool IS_USED {
			get { return _IS_USED; }
			set { _IS_USED = value; }
		}
			public string IMAGE {
			get { return _IMAGE; }
			set { _IMAGE = value; }
		}	

#endregion

#region "Constructors"
public DMDRUGInfo()
{
}

public DMDRUGInfo(int ID,string DRUG_NAME,string DRUG_CODE,int UNIT_ID,string UNIT_NAME,double UNIT_PRICE,double QUANTITY,string DRUG_DESCRIPTION,int CATEGORY_ID,string CATEGORY_NAME,string STATUS,DateTime EXPERIED_DATE, DateTime PRODUCT_DATE,string COMPANY,string DRUG_DOSE,string DRUG_COMPONENT,string COUNTRY,int USER_ID,string USER_NAME,DateTime CREATED_DATE,bool IS_USED,string IMAGE)
{
	this.ID = ID;
            this.CATEGORY_ID = CATEGORY_ID;
            this.CATEGORY_NAME = CATEGORY_NAME;
            this.COMPANY = COMPANY;
            this.COUNTRY = COUNTRY;
            this.CREATED_DATE = CREATED_DATE;
            this.DRUG_CODE = DRUG_CODE;
            this.DRUG_COMPONENT = DRUG_COMPONENT;
            this.DRUG_DOSE = DRUG_DOSE;
            this.DRUG_DESCRIPTION = DRUG_DESCRIPTION;
            this.DRUG_NAME = DRUG_NAME;
            this.EXPERIED_DATE = EXPERIED_DATE;
            this.IMAGE = IMAGE;
            this.PRODUCT_DATE = PRODUCT_DATE;
            this.QUANTITY = QUANTITY;
            this.UNIT_ID = UNIT_ID;
            this.UNIT_NAME = UNIT_NAME;
            this.UNIT_PRICE = UNIT_PRICE;
            this.USER_ID = USER_ID;
            this.USER_NAME = USER_NAME;
}
#endregion

}

}