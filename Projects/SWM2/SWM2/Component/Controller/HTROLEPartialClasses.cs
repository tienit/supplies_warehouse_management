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

public partial class HTROLEInfo
{
	// Add custom code here
}

public partial class HTROLEController
{
    public object DB_GetNull(object Field)
    {
        return tienit.core.Null.GetNull(Field, DBNull.Value);
    }
        // Add custom code here

        public bool CheckExisted(string name)
        {
            HTROLEInfo objInfo = (HTROLEInfo)CBO.FillObject(SqlHelper.ExecuteReader(SqlConnect.ConnectionString, "HT_ROLE_SelectByName", name), typeof(HTROLEInfo));
            if (objInfo != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public HTROLEInfo GetByUser(int userID)
        {
            return (HTROLEInfo)CBO.FillObject(SqlHelper.ExecuteReader(SqlConnect.ConnectionString, "HT_ROLE_SelectByUser", userID), typeof(HTROLEInfo));
        }
    }

public partial class DataProvider
{
	// Add custom code here
}

}