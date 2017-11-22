//*************************************************************
//Author           : Tien NQ
//Created Date     : 10/26/2017
//Comment          : Base class for access to database.
//History          : 
//*************************************************************

using tienit.core;
using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;

namespace VKTIM.Component
{

public partial class DTDRUGINPUTLISTInfo
    {
	// Add custom code here
}

public partial class DTDRUGINPUTLISTController
    {
public object DB_GetNull(object Field)
{
return tienit.core.Null.GetNull(Field, DBNull.Value);
}
	// Add custom code here
    public DataTable GetDrugListByInputID(int InputID)
        {
            return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, "DT_DRUG_INPUTLIST_SelectByInputID", InputID).Tables[0];
        }

        public DataTable GetTop0Row()
        {
            return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, "DT_DRUG_INPUTLIST_GetTop0Row").Tables[0];
        }
}

public partial class DataProvider
{
	// Add custom code here
}

}