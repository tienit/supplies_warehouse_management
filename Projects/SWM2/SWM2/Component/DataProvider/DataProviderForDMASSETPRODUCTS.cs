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
private string VKTIM_COMPONENT_DM_ASSETPRODUCTS_GETALL = "DM_ASSETPRODUCTS_SelectAll";
private string VKTIM_COMPONENT_DM_ASSETPRODUCTS_GETBYID = "DM_ASSETPRODUCTS_SelectById";
private string VKTIM_COMPONENT_DM_ASSETPRODUCTS_INSERT = "DM_ASSETPRODUCTS_Insert";
private string VKTIM_COMPONENT_DM_ASSETPRODUCTS_UPDATE = "DM_ASSETPRODUCTS_Update";
private string VKTIM_COMPONENT_DM_ASSETPRODUCTS_DELETE = "DM_ASSETPRODUCTS_Delete";
#endregion

#region "Public Methods"
public virtual IDataReader DM_ASSETPRODUCTS_GetById(int ID)
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_ASSETPRODUCTS_GETBYID, ID);
}

public virtual IDataReader DM_ASSETPRODUCTS_GetAll()
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_ASSETPRODUCTS_GETALL);
}

public virtual DataSet DM_ASSETPRODUCTS_GetAll_DS()
{
	return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_ASSETPRODUCTS_GETALL);
}

public virtual object DM_ASSETPRODUCTS_Insert(DMASSETPRODUCTSInfo objInfo)
{
	return SqlHelper.ExecuteScalar(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_ASSETPRODUCTS_INSERT, DB_GetNull(objInfo.ASSET_NAME), DB_GetNull(objInfo.ASSET_ONAME), DB_GetNull(objInfo.ASSET_CODE), DB_GetNull(objInfo.ASSET_DESCRIPTION), DB_GetNull(objInfo.MANUFACTURER_NAME), DB_GetNull(objInfo.MANUFACTURER_ID), DB_GetNull(objInfo.UNIT_NAME), DB_GetNull(objInfo.UNIT_ID), DB_GetNull(objInfo.PRICE), DB_GetNull(objInfo.CATEGORY_ID), DB_GetNull(objInfo.CATEGORY_NAME), DB_GetNull(objInfo.EXPIRED_DATE), DB_GetNull(objInfo.STARTED_DATE), DB_GetNull(objInfo.CREATED_DATE), DB_GetNull(objInfo.USER_ID), DB_GetNull(objInfo.USER_NAME), DB_GetNull(objInfo.QUANTITY), DB_GetNull(objInfo.LAST_IN), DB_GetNull(objInfo.LAST_OUT), DB_GetNull(objInfo.ASSET_LEVEL_ID), DB_GetNull(objInfo.ASSET_LEVEL_NAME), DB_GetNull(objInfo.COUNTRY), DB_GetNull(objInfo.WEIGHT));
}

public virtual int DM_ASSETPRODUCTS_Update(DMASSETPRODUCTSInfo objInfo)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_ASSETPRODUCTS_UPDATE, DB_GetNull(objInfo.ID), DB_GetNull(objInfo.ASSET_NAME), DB_GetNull(objInfo.ASSET_ONAME), DB_GetNull(objInfo.ASSET_CODE), DB_GetNull(objInfo.ASSET_DESCRIPTION), DB_GetNull(objInfo.MANUFACTURER_NAME), DB_GetNull(objInfo.MANUFACTURER_ID), DB_GetNull(objInfo.UNIT_NAME), DB_GetNull(objInfo.UNIT_ID), DB_GetNull(objInfo.PRICE), DB_GetNull(objInfo.CATEGORY_ID), DB_GetNull(objInfo.CATEGORY_NAME), DB_GetNull(objInfo.EXPIRED_DATE), DB_GetNull(objInfo.STARTED_DATE), DB_GetNull(objInfo.CREATED_DATE), DB_GetNull(objInfo.USER_ID), DB_GetNull(objInfo.USER_NAME), DB_GetNull(objInfo.QUANTITY), DB_GetNull(objInfo.LAST_IN), DB_GetNull(objInfo.LAST_OUT), DB_GetNull(objInfo.ASSET_LEVEL_ID), DB_GetNull(objInfo.ASSET_LEVEL_NAME), DB_GetNull(objInfo.COUNTRY), DB_GetNull(objInfo.WEIGHT));
}

public virtual int DM_ASSETPRODUCTS_Delete(int ID)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_ASSETPRODUCTS_DELETE, ID);
}
#endregion

}

}