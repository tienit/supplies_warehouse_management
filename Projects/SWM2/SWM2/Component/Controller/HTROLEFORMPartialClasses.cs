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

public partial class HTROLEFORMInfo
{
	// Add custom code here
}

public partial class HTROLEFORMController
{
        public object DB_GetNull(object Field)
        {
            return tienit.core.Null.GetNull(Field, DBNull.Value);
        }
        // Add custom code here

        public int DeleteByRole(int roleID)
        {
            return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, "HT_ROLE_FORM_DeleteByRole", roleID);
        }

    }

    public partial class DataProvider
{
	// Add custom code here
}

}