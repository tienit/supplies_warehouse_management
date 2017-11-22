//*************************************************************
//Author           : Tien NQ
//Created Date     : 10/26/2017
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
        private string VKTIM_COMPONENT_DM_DRUG_INPUTLISTGETALL = "DT_DRUG_INPUTLIST_SelectAll";
        private string VKTIM_COMPONENT_DM_DRUG_INPUTLISTGETBYID = "DT_DRUG_INPUTLIST_SelectById";
        private string VKTIM_COMPONENT_DM_DRUG_INPUTLISTINSERT = "DT_DRUG_INPUTLIST_Insert";
        private string VKTIM_COMPONENT_DM_DRUG_INPUTLISTUPDATE = "DT_DRUG_INPUTLIST_Update";
        private string VKTIM_COMPONENT_DM_DRUG_INPUTLISTDELETE = "DT_DRUG_INPUTLIST_Delete";
        #endregion

        #region "Public Methods"
        public virtual IDataReader DM_DRUG_INPUTLIST_GetById(int ID)
        {
            return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_DRUG_INPUTLISTGETBYID, ID);
        }

        public virtual IDataReader DM_DRUG_INPUTLIST_GetAll()
        {
            return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_DRUG_INPUTLISTGETALL);
        }

        public virtual DataSet DM_DRUG_INPUTLIST_GetAll_DS()
        {
            return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_DRUG_INPUTLISTGETALL);
        }

        public virtual object DM_DRUG_INPUTLIST_Insert(DTDRUGINPUTLISTInfo objInfo)
        {
            return SqlHelper.ExecuteScalar(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_DRUG_INPUTLISTINSERT, DB_GetNull(objInfo.ID), DB_GetNull(objInfo.DRUG_ID), DB_GetNull(objInfo.DRUG_NAME), DB_GetNull(objInfo.DRUG_CODE), DB_GetNull(objInfo.UNIT_NAME), DB_GetNull(objInfo.UNIT_PRICE), DB_GetNull(objInfo.QUANTITY), DB_GetNull(objInfo.DRUG_DESCRIPTION), DB_GetNull(objInfo.CATEGORY_NAME), DB_GetNull(objInfo.STATUS), DB_GetNull(objInfo.EXPERIED_DATE), DB_GetNull(objInfo.PRODUCT_DATE), DB_GetNull(objInfo.COMPANY), DB_GetNull(objInfo.COUNTRY), DB_GetNull(objInfo.IMAGE), DB_GetNull(objInfo.DRUG_INPUT_ID), DB_GetNull(objInfo.INPUT_VALUE), DB_GetNull(objInfo.TOTAL_VALUE), DB_GetNull(objInfo.SORT), DB_GetNull(objInfo.TOTAL_INPUT), DB_GetNull(objInfo.TOTAL_AFTER), DB_GetNull(objInfo.SAVE_STORE_SUCCESS));
        }

        public virtual int DM_DRUG_INPUTLIST_Update(DTDRUGINPUTLISTInfo objInfo)
        {
            return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_DRUG_INPUTLISTUPDATE, DB_GetNull(objInfo.ID), DB_GetNull(objInfo.DRUG_ID), DB_GetNull(objInfo.DRUG_NAME), DB_GetNull(objInfo.DRUG_CODE), DB_GetNull(objInfo.UNIT_NAME), DB_GetNull(objInfo.UNIT_PRICE), DB_GetNull(objInfo.QUANTITY), DB_GetNull(objInfo.DRUG_DESCRIPTION), DB_GetNull(objInfo.CATEGORY_NAME), DB_GetNull(objInfo.STATUS), DB_GetNull(objInfo.EXPERIED_DATE), DB_GetNull(objInfo.PRODUCT_DATE), DB_GetNull(objInfo.COMPANY), DB_GetNull(objInfo.COUNTRY), DB_GetNull(objInfo.IMAGE), DB_GetNull(objInfo.DRUG_INPUT_ID), DB_GetNull(objInfo.INPUT_VALUE), DB_GetNull(objInfo.TOTAL_VALUE), DB_GetNull(objInfo.SORT), DB_GetNull(objInfo.TOTAL_INPUT), DB_GetNull(objInfo.TOTAL_AFTER), DB_GetNull(objInfo.SAVE_STORE_SUCCESS));
        }

        public virtual int DM_DRUG_INPUTLIST_Delete(int ID)
        {
            return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_DRUG_INPUTLISTDELETE, ID);
        }
        #endregion

    }

}