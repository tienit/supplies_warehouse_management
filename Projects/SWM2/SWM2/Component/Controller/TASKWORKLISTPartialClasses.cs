//*************************************************************
//Author           : Tien NQ
//Created Date     : 8/22/2017
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

public partial class TASKWORKLISTInfo
{
	// Add custom code here
}

public partial class TASKWORKLISTController
{
public object DB_GetNull(object Field)
{
return tienit.core.Null.GetNull(Field, DBNull.Value);
}
        // Add custom code here

        public List<TASKWORKLISTInfo> getListRemind()
        {
            List<TASKWORKLISTInfo> list = new List<TASKWORKLISTInfo>();
            ArrayList arr = CBO.FillCollection(SqlHelper.ExecuteReader(SqlConnect.ConnectionString, "TASK_WORKLIST_GET_REMIND_LIST"), typeof(TASKWORKLISTInfo));
            foreach (object objItem in arr)
            {
                list.Add((TASKWORKLISTInfo)objItem);
            }
            return list;
        }
    }

public partial class DataProvider
{
	// Add custom code here
}

}