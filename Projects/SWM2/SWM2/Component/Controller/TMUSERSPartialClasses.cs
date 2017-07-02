//*************************************************************
//Author           : Tien, Nguyen Quyet
//Created Date     : 2/6/2014
//Comment          : Base class for access to database.
//History          : 
//*************************************************************

using tienit.core;
using System.Collections.Generic;
using System.Collections;
using System.Data;
using System;

namespace VKTIM.Component
{

    public partial class TMUSERSInfo
    {
	    // Add custom code here
    }

    public partial class TMUSERSController
    {
        public object DB_GetNull(object val)
        {
            return tienit.core.Null.GetNull(val, DBNull.Value);
        }
	    // Add custom code here
        public DataTable GetByGroup(int groupID)
        {
            return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, "TM_USERS_SelectByGroup", groupID).Tables[0];
        }

        public TMUSERSInfo GetByUserPass(string userName, string passWord)
        {
            return (TMUSERSInfo)CBO.FillObject(SqlHelper.ExecuteReader(SqlConnect.ConnectionString, "TM_USERS_SelectByUsernamePass", userName, passWord), typeof(TMUSERSInfo));
        }

        public TMUSERSInfo GetByOption(string userName, string passWord, int factoryID)
        {
            return (TMUSERSInfo)CBO.FillObject(SqlHelper.ExecuteReader(SqlConnect.ConnectionString, "TM_USERS_SelectByOption", userName, passWord, factoryID), typeof(TMUSERSInfo));
        }

        public void LockUser(int userID, bool bLocked)
        {
            SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, "TM_USERS_Lock", userID, bLocked);
        }

        public void ChangePassword(string userName, string passWord)
        {
            SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, "TM_USERS_ChangePassword", userName, passWord);
        }

        public void ChangePass(int userID, string passWord)
        {
            SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, "TM_USERS_ChangePassByUserID", userID, passWord);
        }

        public DateTime SERVER_NOW()
        {
            return (DateTime)SqlHelper.ExecuteScalar(SqlConnect.ConnectionString, "SERVER_NOW");
        }
    }

    public partial class DataProvider
    {
	    // Add custom code here
    }

}