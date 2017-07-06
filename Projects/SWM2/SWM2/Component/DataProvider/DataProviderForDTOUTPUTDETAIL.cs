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
private string VKTIM_COMPONENT_DT_OUTPUTDETAIL_GETALL = "DT_OUTPUTDETAIL_SelectAll";
private string VKTIM_COMPONENT_DT_OUTPUTDETAIL_GETBYID = "DT_OUTPUTDETAIL_SelectById";
private string VKTIM_COMPONENT_DT_OUTPUTDETAIL_INSERT = "DT_OUTPUTDETAIL_Insert";
private string VKTIM_COMPONENT_DT_OUTPUTDETAIL_UPDATE = "DT_OUTPUTDETAIL_Update";
private string VKTIM_COMPONENT_DT_OUTPUTDETAIL_DELETE = "DT_OUTPUTDETAIL_Delete";
#endregion

#region "Public Methods"
public virtual IDataReader DT_OUTPUTDETAIL_GetById(int ID)
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_OUTPUTDETAIL_GETBYID, ID);
}

public virtual IDataReader DT_OUTPUTDETAIL_GetAll()
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_OUTPUTDETAIL_GETALL);
}

public virtual DataSet DT_OUTPUTDETAIL_GetAll_DS()
{
	return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_OUTPUTDETAIL_GETALL);
}

public virtual object DT_OUTPUTDETAIL_Insert(DTOUTPUTDETAILInfo objInfo)
{
	return SqlHelper.ExecuteScalar(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_OUTPUTDETAIL_INSERT, DB_GetNull(objInfo.OUTPUT_ID), DB_GetNull(objInfo.PRODUCT_ID), DB_GetNull(objInfo.PRODUCT_NAME), DB_GetNull(objInfo.PRODUCT_OTHER_NAME), DB_GetNull(objInfo.PRODUCT_CODE), DB_GetNull(objInfo.PRODUCTS_DESCRIPTION), DB_GetNull(objInfo.PRODUCTS_SHORT_DESCRIPTION), DB_GetNull(objInfo.ORIGIN_ID), DB_GetNull(objInfo.ORIGIN_NAME), DB_GetNull(objInfo.UNIT_ID), DB_GetNull(objInfo.UNIT_NAME), DB_GetNull(objInfo.SUPPLIER_ID), DB_GetNull(objInfo.SUPPLIER_NAME), DB_GetNull(objInfo.PRICE_ID), DB_GetNull(objInfo.PRICE_NAME), DB_GetNull(objInfo.PRODUCTCATEGORY_ID), DB_GetNull(objInfo.PRODUCTCATEGORY_NAME), DB_GetNull(objInfo.PRICE_DEFAULT), DB_GetNull(objInfo.OUTPUT_PRICE), DB_GetNull(objInfo.QUANTITY), DB_GetNull(objInfo.WAREHOUSE_ID), DB_GetNull(objInfo.PRODUCT_STATUS), DB_GetNull(objInfo.IS_BUY), DB_GetNull(objInfo.TOTAL), DB_GetNull(objInfo.OUTPUT_DATE), DB_GetNull(objInfo.RETURN_DATE));
}

public virtual int DT_OUTPUTDETAIL_Update(DTOUTPUTDETAILInfo objInfo)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_OUTPUTDETAIL_UPDATE, DB_GetNull(objInfo.ID), DB_GetNull(objInfo.OUTPUT_ID), DB_GetNull(objInfo.PRODUCT_ID), DB_GetNull(objInfo.PRODUCT_NAME), DB_GetNull(objInfo.PRODUCT_OTHER_NAME), DB_GetNull(objInfo.PRODUCT_CODE), DB_GetNull(objInfo.PRODUCTS_DESCRIPTION), DB_GetNull(objInfo.PRODUCTS_SHORT_DESCRIPTION), DB_GetNull(objInfo.ORIGIN_ID), DB_GetNull(objInfo.ORIGIN_NAME), DB_GetNull(objInfo.UNIT_ID), DB_GetNull(objInfo.UNIT_NAME), DB_GetNull(objInfo.SUPPLIER_ID), DB_GetNull(objInfo.SUPPLIER_NAME), DB_GetNull(objInfo.PRICE_ID), DB_GetNull(objInfo.PRICE_NAME), DB_GetNull(objInfo.PRODUCTCATEGORY_ID), DB_GetNull(objInfo.PRODUCTCATEGORY_NAME), DB_GetNull(objInfo.PRICE_DEFAULT), DB_GetNull(objInfo.OUTPUT_PRICE), DB_GetNull(objInfo.QUANTITY), DB_GetNull(objInfo.WAREHOUSE_ID), DB_GetNull(objInfo.PRODUCT_STATUS), DB_GetNull(objInfo.IS_BUY), DB_GetNull(objInfo.TOTAL), DB_GetNull(objInfo.OUTPUT_DATE), DB_GetNull(objInfo.RETURN_DATE));
}

public virtual int DT_OUTPUTDETAIL_Delete(int ID)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_OUTPUTDETAIL_DELETE, ID);
}
#endregion

}

}