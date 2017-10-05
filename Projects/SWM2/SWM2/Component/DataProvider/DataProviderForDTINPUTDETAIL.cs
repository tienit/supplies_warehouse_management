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
private string VKTIM_COMPONENT_DT_INPUTDETAIL_GETALL = "DT_INPUTDETAIL_SelectAll";
private string VKTIM_COMPONENT_DT_INPUTDETAIL_GETBYID = "DT_INPUTDETAIL_SelectById";
private string VKTIM_COMPONENT_DT_INPUTDETAIL_INSERT = "DT_INPUTDETAIL_Insert";
private string VKTIM_COMPONENT_DT_INPUTDETAIL_UPDATE = "DT_INPUTDETAIL_Update";
private string VKTIM_COMPONENT_DT_INPUTDETAIL_DELETE = "DT_INPUTDETAIL_Delete";
        private string VKTIM_COMPONENT_DT_INPUTDETAIL_GETTOP0ROW = "DT_INPUTDETAIL_Select0Row";
#endregion

        #region "Public Methods"
        public virtual IDataReader DT_INPUTDETAIL_GetById(int ID)
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_INPUTDETAIL_GETBYID, ID);
}

public virtual IDataReader DT_INPUTDETAIL_GetAll()
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_INPUTDETAIL_GETALL);
}

public virtual DataSet DT_INPUTDETAIL_GetAll_DS()
{
	return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_INPUTDETAIL_GETALL);
}

public virtual object DT_INPUTDETAIL_Insert(DTINPUTDETAILInfo objInfo)
{
	return SqlHelper.ExecuteScalar(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_INPUTDETAIL_INSERT, DB_GetNull(objInfo.INPUT_ID), DB_GetNull(objInfo.PRODUCT_ID), DB_GetNull(objInfo.PRODUCT_NAME), DB_GetNull(objInfo.PRODUCT_OTHER_NAME), DB_GetNull(objInfo.PRODUCT_CODE), DB_GetNull(objInfo.PRODUCTS_DESCRIPTION), DB_GetNull(objInfo.PRODUCTS_SHORT_DESCRIPTION), DB_GetNull(objInfo.ORIGIN_ID), DB_GetNull(objInfo.ORIGIN_NAME), DB_GetNull(objInfo.UNIT_ID), DB_GetNull(objInfo.UNIT_NAME), DB_GetNull(objInfo.SUPPLIER_ID), DB_GetNull(objInfo.SUPPLIER_NAME), DB_GetNull(objInfo.PRICE_ID), DB_GetNull(objInfo.PRICE_NAME), DB_GetNull(objInfo.PRODUCTCATEGORY_ID), DB_GetNull(objInfo.PRODUCTCATEGORY_NAME), DB_GetNull(objInfo.PRICE_DEFAULT), DB_GetNull(objInfo.INPUT_PRICE), DB_GetNull(objInfo.QUANTITY), DB_GetNull(objInfo.INPUT_VALUE), DB_GetNull(objInfo.WAREHOUSE_ID), DB_GetNull(objInfo.PRODUCT_STATUS), DB_GetNull(objInfo.IS_BUY), DB_GetNull(objInfo.TOTAL), DB_GetNull(objInfo.Sort));
}

public virtual int DT_INPUTDETAIL_Update(DTINPUTDETAILInfo objInfo)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_INPUTDETAIL_UPDATE, DB_GetNull(objInfo.ID), DB_GetNull(objInfo.INPUT_ID), DB_GetNull(objInfo.PRODUCT_ID), DB_GetNull(objInfo.PRODUCT_NAME), DB_GetNull(objInfo.PRODUCT_OTHER_NAME), DB_GetNull(objInfo.PRODUCT_CODE), DB_GetNull(objInfo.PRODUCTS_DESCRIPTION), DB_GetNull(objInfo.PRODUCTS_SHORT_DESCRIPTION), DB_GetNull(objInfo.ORIGIN_ID), DB_GetNull(objInfo.ORIGIN_NAME), DB_GetNull(objInfo.UNIT_ID), DB_GetNull(objInfo.UNIT_NAME), DB_GetNull(objInfo.SUPPLIER_ID), DB_GetNull(objInfo.SUPPLIER_NAME), DB_GetNull(objInfo.PRICE_ID), DB_GetNull(objInfo.PRICE_NAME), DB_GetNull(objInfo.PRODUCTCATEGORY_ID), DB_GetNull(objInfo.PRODUCTCATEGORY_NAME), DB_GetNull(objInfo.PRICE_DEFAULT), DB_GetNull(objInfo.INPUT_PRICE), DB_GetNull(objInfo.QUANTITY), DB_GetNull(objInfo.INPUT_VALUE), DB_GetNull(objInfo.WAREHOUSE_ID), DB_GetNull(objInfo.PRODUCT_STATUS), DB_GetNull(objInfo.IS_BUY), DB_GetNull(objInfo.TOTAL), DB_GetNull(objInfo.Sort));
}

public virtual int DT_INPUTDETAIL_Delete(int ID)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_INPUTDETAIL_DELETE, ID);
}

        public virtual DataSet DT_INPUTDETAIL_GetTop0Row()
        {
            return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_INPUTDETAIL_GETTOP0ROW);
        }
        #endregion

    }

}