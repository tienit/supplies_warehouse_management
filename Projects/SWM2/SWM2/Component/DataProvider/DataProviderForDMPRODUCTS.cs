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
private string VKTIM_COMPONENT_DM_PRODUCTS_GETALL = "DM_PRODUCTS_SelectAll";
private string VKTIM_COMPONENT_DM_PRODUCTS_GETBYID = "DM_PRODUCTS_SelectById";
private string VKTIM_COMPONENT_DM_PRODUCTS_INSERT = "DM_PRODUCTS_Insert";
private string VKTIM_COMPONENT_DM_PRODUCTS_UPDATE = "DM_PRODUCTS_Update";
private string VKTIM_COMPONENT_DM_PRODUCTS_DELETE = "DM_PRODUCTS_Delete";
#endregion

#region "Public Methods"
public virtual IDataReader DM_PRODUCTS_GetById(int ID)
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_PRODUCTS_GETBYID, ID);
}

public virtual IDataReader DM_PRODUCTS_GetAll()
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_PRODUCTS_GETALL);
}

public virtual DataSet DM_PRODUCTS_GetAll_DS()
{
	return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_PRODUCTS_GETALL);
}

public virtual object DM_PRODUCTS_Insert(DMPRODUCTSInfo objInfo)
{
	return SqlHelper.ExecuteScalar(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_PRODUCTS_INSERT, DB_GetNull(objInfo.PRODUCTS_NAME), DB_GetNull(objInfo.PRODUCTS_NAME_OTHER), DB_GetNull(objInfo.PRODUCTS_CODE), DB_GetNull(objInfo.PRODUCTS_DESCRIPTION), DB_GetNull(objInfo.PRODUCTS_SHORT_DESCRIPTION), DB_GetNull(objInfo.ORIGIN_ID), DB_GetNull(objInfo.ORIGIN_NAME), DB_GetNull(objInfo.UNIT_ID), DB_GetNull(objInfo.UNIT_NAME), DB_GetNull(objInfo.SUPPLIER_ID), DB_GetNull(objInfo.SUPPLIER_NAME), DB_GetNull(objInfo.PRICE_ID), DB_GetNull(objInfo.PRICE_NAME), DB_GetNull(objInfo.PRODUCTCATEGORY_ID), DB_GetNull(objInfo.PRODUCTCATEGORY_NAME), DB_GetNull(objInfo.PRICE_DEFAULT));
}

public virtual int DM_PRODUCTS_Update(DMPRODUCTSInfo objInfo)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_PRODUCTS_UPDATE, DB_GetNull(objInfo.ID), DB_GetNull(objInfo.PRODUCTS_NAME), DB_GetNull(objInfo.PRODUCTS_NAME_OTHER), DB_GetNull(objInfo.PRODUCTS_CODE), DB_GetNull(objInfo.PRODUCTS_DESCRIPTION), DB_GetNull(objInfo.PRODUCTS_SHORT_DESCRIPTION), DB_GetNull(objInfo.ORIGIN_ID), DB_GetNull(objInfo.ORIGIN_NAME), DB_GetNull(objInfo.UNIT_ID), DB_GetNull(objInfo.UNIT_NAME), DB_GetNull(objInfo.SUPPLIER_ID), DB_GetNull(objInfo.SUPPLIER_NAME), DB_GetNull(objInfo.PRICE_ID), DB_GetNull(objInfo.PRICE_NAME), DB_GetNull(objInfo.PRODUCTCATEGORY_ID), DB_GetNull(objInfo.PRODUCTCATEGORY_NAME), DB_GetNull(objInfo.PRICE_DEFAULT));
}

public virtual int DM_PRODUCTS_Delete(int ID)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_PRODUCTS_DELETE, ID);
}
#endregion

}

}