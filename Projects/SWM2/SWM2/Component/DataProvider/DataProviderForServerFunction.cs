//*************************************************************
//Author           : Tien NQ
//Created Date     : 7/7/2017
//Comment          : Base class for access to database.
//History          : 
//*************************************************************

using tienit.core;
using System;
using System.Data;
namespace VKTIM.Component
{
    public partial class DataProvider : CommonDataProvider
    {
        #region "Stored Procedure Name"
        private string VKTIM_COMPONENT_SERVER_FUNCTION_GETDATETIME = "SERVER_FUNCTION_GetDateTime";

        #endregion

        #region "Public Methods"
        public virtual DataSet SERVER_FUNCTION_GetDateTime()
        {
            return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, VKTIM_COMPONENT_SERVER_FUNCTION_GETDATETIME);
        }

        #endregion

    }
}
