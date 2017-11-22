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

public partial class DMDRUGInfo
{
	// Add custom code here
}

public partial class DMDRUGController
{
public object DB_GetNull(object Field)
{
return tienit.core.Null.GetNull(Field, DBNull.Value);
}
	// Add custom code here
    public List<string> GetDmDrugColumnName()
        {
            List<string> result = new List<string>();
            DataTable drugTable = SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, "DM_DRUG_GetTop0Row").Tables[0];
            foreach (DataColumn  item in drugTable.Columns)
            {
                result.Add(item.ColumnName);
            }

            return result;
        }

        public DataTable Search(string KeyWord)
        {
            return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, "DM_DRUG_Search", KeyWord).Tables[0];
        }

        public DataTable SearchWithParameter(string ColumnName, string KeyWord)
        {
            return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, "DM_DUG_SearchWithParameter", ColumnName, KeyWord).Tables[0];
        }

        public DataTable SearchWithParameterCustomColumn(string ColumnName, string KeyWord)
        {
            return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, "DM_DUG_SearchWithParameterCustomColumn", ColumnName, KeyWord).Tables[0];
        }

        public DataTable SelectAllWithCustomColumn()
        {
            return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, "DM_DRUG_SelectAllCustomColumn").Tables[0];
        }

        public virtual int SaveStore(int ID, double Quantity)
        {
            return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, "DM_DRUG_SaveStore", DB_GetNull(ID),  DB_GetNull(Quantity));
        }
    }

public partial class DataProvider
{
	// Add custom code here
}

}