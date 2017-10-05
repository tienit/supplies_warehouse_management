//*************************************************************
//Author           : Tien NQ
//Created Date     : 7/7/2017
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

public partial class DTINPUTInfo
{
	// Add custom code here
}

public partial class DTINPUTController
{
public object DB_GetNull(object Field)
{
return tienit.core.Null.GetNull(Field, DBNull.Value);
}
        // Add custom code here
        public DataSet GetInputInfo(int ID)
        {
            return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, "DT_INPUT_GetByID", ID);
        }

        public DataTable GetTop0Row()
        {
            return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, "DT_INPUT_Get0Row").Tables[0];
    }
    }

public partial class DataProvider
{
	// Add custom code here
}

}