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

    public partial class DMUNITInfo
    {
	    // Add custom code here
    }

    public partial class DMUNITController
    {
        public object DB_GetNull(object Field)
        {
            return tienit.core.Null.GetNull(Field, DBNull.Value);
        }
        // Add custom code here

        public List<DMUNITInfo> Search(string keyword)
        {
            List<DMUNITInfo> list = new List<DMUNITInfo>();
            ArrayList arr = CBO.FillCollection(SqlHelper.ExecuteReader(SqlConnect.ConnectionString, "DM_UNIT_Search", DB_GetNull(keyword)), typeof(DMUNITInfo));
            foreach (object objItem in arr)
            {
                list.Add((DMUNITInfo)objItem);
            }
            return list;
        }

        public DataTable Search_DS(string keyword)
        {
            return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, "DM_UNIT_Search", DB_GetNull(keyword)).Tables[0];
        }
    }

    public partial class DataProvider
    {
	    // Add custom code here
    }

}