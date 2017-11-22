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

public partial class DTDRUGINPUTLISTInfo
{

#region "Private Members"
private int _ID;
private int _DRUG_ID; 
private string _DRUG_NAME; 
private string _DRUG_CODE; 
private string _UNIT_NAME; 
private double _UNIT_PRICE; 
private double _QUANTITY; 
private string _DRUG_DESCRIPTION; 
private string _CATEGORY_NAME; 
private bool _STATUS; 
private DateTime _EXPERIED_DATE;
private DateTime _PRODUCT_DATE; 
private string _COMPANY; 
private string _COUNTRY; 
private string _IMAGE; 
private int _DRUG_INPUT_ID; 
private double _INPUT_VALUE; 
private double _TOTAL_VALUE;
        private int _SORT;
        private DateTime _CREATED_DATE;
        private double _TOTAL_INPUT;
        private double _TOTAL_AFTER;
        private bool _SAVE_STORE_SUCCESS;
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
		
		public int DRUG_ID
        {
			get { return _DRUG_ID; }
			set { _DRUG_ID = value; }
		}
		
				public string UNIT_NAME
        {
            get { return _UNIT_NAME; }
            set { _UNIT_NAME = value; }
        }

        public double  UNIT_PRICE
        {
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
		

		public string CATEGORY_NAME {
			get { return _CATEGORY_NAME; }
			set { _CATEGORY_NAME = value; }
		}
		
				public bool STATUS {
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
        public string COUNTRY
        {
            get { return _COUNTRY; }
            set { _COUNTRY = value; }
        }

        public string IMAGE
        {
            get { return _IMAGE; }
            set { _IMAGE = value; }
        }
        
        public int DRUG_INPUT_ID
        {
			get { return _DRUG_INPUT_ID; }
			set { _DRUG_INPUT_ID = value; }
		}			
		

				public double INPUT_VALUE
        {
			get { return _INPUT_VALUE; }
			set { _INPUT_VALUE = value; }
		}


		
				public double TOTAL_VALUE
        {
			get { return _TOTAL_VALUE; }
			set { _TOTAL_VALUE = value; }
		}

		public int  SORT {
			get { return _SORT; }
			set { _SORT = value; }
		}

        public DateTime CREATED_DATE
        {
            get { return _CREATED_DATE; }
            set { _CREATED_DATE = value; }
        }
        public double TOTAL_INPUT
        {
            get { return _TOTAL_INPUT; }
            set { _TOTAL_INPUT = value; }
        }
        public double TOTAL_AFTER
        {
            get { return _TOTAL_AFTER; }
            set { _TOTAL_AFTER = value; }
        }

        public bool SAVE_STORE_SUCCESS
        {
            get { return _SAVE_STORE_SUCCESS; }
            set { _SAVE_STORE_SUCCESS = value; }
        }
        
        #endregion

        #region "Constructors"
        public DTDRUGINPUTLISTInfo()
{
}

public DTDRUGINPUTLISTInfo(int ID,int DRUG_ID,string DRUG_NAME,string DRUG_CODE,string UNIT_NAME,double UNIT_PRICE,double QUANTITY,string DRUG_DESCRIPTION,string CATEGORY_NAME,bool STATUS,DateTime EXPERIED_DATE,DateTime PRODUCT_DATE,string COMPANY,string COUNTRY,string IMAGE,int DRUG_INPUT_ID,double INPUT_VALUE,double TOTAL_VALUE,int SORT, double TOTAL_INPUT, double TOTAL_AFTER, bool SAVE_STORE_SUCCESS)
{
	this.ID = ID;
            this.CATEGORY_NAME = CATEGORY_NAME;
            this.COMPANY = COMPANY;
            this.COUNTRY = COUNTRY;
            this.CREATED_DATE = CREATED_DATE;
            this.DRUG_CODE = DRUG_CODE;
            this.DRUG_DESCRIPTION = DRUG_DESCRIPTION;
            this.DRUG_ID = DRUG_ID;
            this.DRUG_INPUT_ID = DRUG_INPUT_ID;
            this.DRUG_NAME = DRUG_NAME;
            this.EXPERIED_DATE = EXPERIED_DATE;
            this.IMAGE = IMAGE;
            this.INPUT_VALUE = INPUT_VALUE;
            this.PRODUCT_DATE = PRODUCT_DATE;
            this.QUANTITY = QUANTITY;
            this.SORT = SORT;
            this.STATUS = STATUS;
            this.TOTAL_VALUE = TOTAL_VALUE;
            this.UNIT_NAME = UNIT_NAME;
            this.UNIT_PRICE = UNIT_PRICE;
            this.TOTAL_INPUT = TOTAL_INPUT;
            this.TOTAL_AFTER = TOTAL_AFTER;
            this.SAVE_STORE_SUCCESS = SAVE_STORE_SUCCESS;
}
#endregion

}

}