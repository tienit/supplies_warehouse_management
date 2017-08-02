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

    public partial class HTFORMInfo
    {
	    // Add custom code here
    }

    public partial class HTFORMController
    {
        public object DB_GetNull(object Field)
        {
            return tienit.core.Null.GetNull(Field, DBNull.Value);
        }
        // Add custom code here

        public List<HTFORMInfo> Search(string keyword)
        {
            List<HTFORMInfo> list = new List<HTFORMInfo>();
            ArrayList arr = CBO.FillCollection(SqlHelper.ExecuteReader(SqlConnect.ConnectionString, "HT_FORM_Search", DB_GetNull(keyword)), typeof(HTFORMInfo));
            foreach (object objItem in arr)
            {
                list.Add((HTFORMInfo)objItem);
            }
            return list;
        }

        public DataTable Search_DS(string keyword)
        {
            return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, "HT_FORM_Search", DB_GetNull(keyword)).Tables[0];
        }

        public List<HTFORMInfo> GetUsed()
        {
            List<HTFORMInfo> list = new List<HTFORMInfo>();
            ArrayList arr = CBO.FillCollection(SqlHelper.ExecuteReader(SqlConnect.ConnectionString, "HT_FORM_SelectUsed"), typeof(HTFORMInfo));
            foreach (object objItem in arr)
            {
                list.Add((HTFORMInfo)objItem);
            }
            return list;
        }

        public DataTable GetUsed_DS()
        {
            return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, "HT_FORM_SelectUsed").Tables[0];
        }

        public List<HTFORMInfo> GetByRole(int roleID)
        {
            List<HTFORMInfo> list = new List<HTFORMInfo>();
            ArrayList arr = CBO.FillCollection(SqlHelper.ExecuteReader(SqlConnect.ConnectionString, "HT_FORM_SelectByRole", roleID), typeof(HTFORMInfo));
            foreach (object objItem in arr)
            {
                list.Add((HTFORMInfo)objItem);
            }
            return list;
        }

        public DataTable GetByRole_DS(int roleID)
        {
            return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, "HT_FORM_SelectByRole", roleID).Tables[0];
        }
    }

    public partial class DataProvider
    {
	    // Add custom code here
    }

}