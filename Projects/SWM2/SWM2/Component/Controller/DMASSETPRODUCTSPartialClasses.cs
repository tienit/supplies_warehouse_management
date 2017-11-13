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

public partial class DMASSETPRODUCTSInfo
{
	// Add custom code here
}

public partial class DMASSETPRODUCTSController
{
public object DB_GetNull(object Field)
{
return tienit.core.Null.GetNull(Field, DBNull.Value);
}
        // Add custom code here
        public DataTable GetASProductByCode(string CODE)
        {
            return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, "DM_ASSETPRODUCTS_GETBYCODE", DB_GetNull(CODE)).Tables[0];
        }

        public DataTable GetTop0Row()
        {
            return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, "DM_ASSETPRODUCTS_TOP0ROW").Tables[0];
        }

        public List<DMASSETPRODUCTSInfo> GetProductByCode(string CODE)
        {
            List<DMASSETPRODUCTSInfo> list = new List<DMASSETPRODUCTSInfo>();
            ArrayList arr = CBO.FillCollection(SqlHelper.ExecuteReader(SqlConnect.ConnectionString, "DM_ASSETPRODUCTS_GETBYCODE", DB_GetNull(CODE)), typeof(DMASSETPRODUCTSInfo));
            foreach (object objItem in arr)
            {
                list.Add((DMASSETPRODUCTSInfo)objItem);
            }
            return list;
        }
    }

public partial class DataProvider
{
        // Add custom code here

    }

}