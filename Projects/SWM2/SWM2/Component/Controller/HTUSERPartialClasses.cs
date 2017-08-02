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

    public partial class HTUSERInfo
    {
	    // Add custom code here
    }

    public partial class HTUSERController
    {
        public object DB_GetNull(object Field)
        {
            return tienit.core.Null.GetNull(Field, DBNull.Value);
        }
        // Add custom code here

        public DateTime SERVER_NOW()
        {
            return Convert.ToDateTime(SqlHelper.ExecuteScalar(SqlConnect.ConnectionString, "SERVER_NOW"));
        }

        public List<HTUSERInfo> GetByRole(int roleID)
        {
            List<HTUSERInfo> list = new List<HTUSERInfo>();
            ArrayList arr = CBO.FillCollection(SqlHelper.ExecuteReader(SqlConnect.ConnectionString, "HT_USER_SelectByRole", roleID), typeof(HTUSERInfo));
            foreach (object objItem in arr)
            {
                list.Add((HTUSERInfo)objItem);
            }
            return list;
        }

        public DataTable GetByRole_DS(int roleID)
        {
            return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, "HT_USER_SelectByRole", roleID).Tables[0];
        }

        public HTUSERInfo GetOption(string userName, string passWord)
        {
            return (HTUSERInfo)CBO.FillObject(SqlHelper.ExecuteReader(SqlConnect.ConnectionString, "HT_USER_SelectOption", userName, passWord), typeof(HTUSERInfo));
        }

        public int UpdatePassword(string userName, string passWord)
        {
            return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, "HT_USER_UpdatePassword", userName, passWord);
        }

        public int UpdateLog(string userName, string ipAddress)
        {
            return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, "HT_USER_UpdateLog", userName, ipAddress);
        }
    }

    public partial class DataProvider
    {
	    // Add custom code here
    }

}