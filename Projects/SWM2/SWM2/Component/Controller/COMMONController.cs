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


    public  class COMMONController
    {
        #region "Instances"
        private static COMMONController _instance;

        protected COMMONController()
        {
        }

        protected void Dispose()
        {
            _instance = null;
        }

        private static object _syncLock = new object();

        public static COMMONController Instance()
        {
            if (_instance == null)
            {
                lock (_syncLock)
                {
                    if (_instance == null)
                    {
                        _instance = new COMMONController();
                    }
                }
            }
            return _instance;
        }

        #endregion

        public object DB_GetNull(object Field)
        {
            return tienit.core.Null.GetNull(Field, DBNull.Value);
        }
        // Add custom code here

        public DataTable GetDataByTableName(string tableName)
        {
            return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, "DM_COMMON_SelectAll", tableName).Tables[0];
        }

        public DataTable GetDataByTableNameOrderBY(string tableName, string orderByField, string orderByType)
        {
            return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, "DM_COMMON_SelectAll_OrderBy", tableName, orderByField, orderByType).Tables[0];
        }
    }


}