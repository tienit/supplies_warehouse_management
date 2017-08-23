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
    public partial class SERVERFUNCTIONController
    {
        #region "Instances"
        private static SERVERFUNCTIONController _instance;

        protected SERVERFUNCTIONController()
        {
        }

        protected void Dispose()
        {
            _instance = null;
        }

        private static object _syncLock = new object();

        public static SERVERFUNCTIONController Instance()
        {
            if (_instance == null)
            {
                lock (_syncLock)
                {
                    if (_instance == null)
                    {
                        _instance = new SERVERFUNCTIONController();
                    }
                }
            }
            return _instance;
        }

        #endregion

        #region "Public Methods"
        //Get datetime from server
        public DateTime GetServerDateTime()
        {
            DateTime _now = DateTime.Now;
            try
            {
                _now = DateTime.Parse(DataProvider.Instance().SERVER_FUNCTION_GetDateTime().Tables[0].Rows[0][0].ToString());
            }
            catch (Exception)
            {

            }

            return _now;
        }
        #endregion
    }
}
