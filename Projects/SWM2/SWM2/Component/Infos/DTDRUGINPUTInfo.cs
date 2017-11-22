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

public partial class DTDRUGINPUTInfo
{

#region "Private Members"
private int _ID;
        private string _INPUT_NAME;
private string _DRUG_INPUT_CODE;
private string _DRUG_WAREHOUSE_NAME;
private int _ORGANIZATION_ID;
private string _ORGANIZATION_NAME;
private int _USER_ID;
        private string _USER_NAME;
private double _TOTAL;
private int _FUNDS_ID;
private string _FUNDS_NAME;
private DateTime _CREATED_DATE;
        #endregion

        #region "Public Properties"
        public int ID {
			get { return _ID; }
			set { _ID = value; }
		}

		public string INPUT_NAME
        {
			get { return _INPUT_NAME; }
			set { _INPUT_NAME = value; }
		}

		public string DRUG_INPUT_CODE
        {
			get { return _DRUG_INPUT_CODE; }
			set { _DRUG_INPUT_CODE = value; }
		}
		
		public string DRUG_WAREHOUSE_NAME
        {
			get { return _DRUG_WAREHOUSE_NAME; }
			set { _DRUG_WAREHOUSE_NAME = value; }
		}

        public string ORGANIZATION_NAME
        {
            get { return _ORGANIZATION_NAME; }
            set { _ORGANIZATION_NAME = value; }
        }
        public int ORGANIZATION_ID
        {
            get { return _ORGANIZATION_ID; }
            set { _ORGANIZATION_ID = value; }
        }


        
                public string USER_NAME
        {
			get { return _USER_NAME; }
			set { _USER_NAME = value; }
		}
		
				public int USER_ID
        {
			get { return _USER_ID; }
			set { _USER_ID = value; }
		}		
		
		public double TOTAL
        {
			get { return _TOTAL; }
			set { _TOTAL = value; }
		}
		
				public int FUNDS_ID
        {
			get { return _FUNDS_ID; }
			set { _FUNDS_ID = value; }
		}

		public string FUNDS_NAME
        {
			get { return _FUNDS_NAME; }
			set { _FUNDS_NAME = value; }
		}
		
		
				public DateTime CREATED_DATE {
			get { return _CREATED_DATE; }
			set { _CREATED_DATE = value; }
		}
		


#endregion

#region "Constructors"
public DTDRUGINPUTInfo()
{
}

public DTDRUGINPUTInfo(int ID,string INPUT_NAME,string DRUG_INPUT_CODE,string DRUG_WAREHOUSE_NAME,int ORGANIZATION_ID,string ORGANIZATION_NAME,int USER_ID,string USER_NAME,double TOTAL,int FUNDS_ID,string FUNDS_NAME,DateTime CREATED_DATE)
{
	this.ID = ID;
            this.CREATED_DATE = CREATED_DATE;
            this.DRUG_INPUT_CODE = DRUG_INPUT_CODE;
            this.DRUG_WAREHOUSE_NAME = DRUG_WAREHOUSE_NAME;
            this.FUNDS_NAME = FUNDS_NAME;
            this.FUNDS_ID = FUNDS_ID;
            this.FUNDS_NAME = FUNDS_NAME;
            this.INPUT_NAME = INPUT_NAME;
            this.ORGANIZATION_ID = ORGANIZATION_ID;
            this.ORGANIZATION_NAME = ORGANIZATION_NAME;
            this.TOTAL = TOTAL;
            this.USER_ID = USER_ID;
            this.USER_NAME = USER_NAME;

}
#endregion

}

}