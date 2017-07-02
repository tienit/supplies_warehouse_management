//*************************************************************
//Author           : Tien NQ
//Created Date     : 3/7/2014
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

    public partial class TMLOGEVENTInfo
    {
	    // Add custom code here
    }

    public partial class TMLOGEVENTController
    {
        public object DB_GetNull(object Field)
        {
            return tienit.core.Null.GetNull(Field, DBNull.Value);
        }
	    // Add custom code here
        public DataSet Search_DS(int type, int facID, DateTime dtFrom, DateTime dtTo)
        {
            return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, "TM_LOG_EVENT_Search", type, facID, DB_GetNull(dtFrom), DB_GetNull(dtTo));
        }

        public DataSet SearchAll_DS(int type, DateTime dtFrom, DateTime dtTo)
        {
            return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, "TM_LOG_EVENT_SearchAll", type, DB_GetNull(dtFrom), DB_GetNull(dtTo));
        }

        public DataTable SearchOption_DS(int type, int facID, string goodsCode, string goodsName, string lotNo, DateTime dtFrom, DateTime dtTo)
        {
            return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, "TM_LOG_VIEWER", type, DB_GetNull(facID), DB_GetNull(goodsCode), DB_GetNull(goodsName), DB_GetNull(lotNo), DB_GetNull(dtFrom), DB_GetNull(dtTo)).Tables[0];
        }
    }

    public partial class DataProvider
    {
	    // Add custom code here
    }

}