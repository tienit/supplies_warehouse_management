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
private string VKTIM_COMPONENT_DM_ASSETLEVEL_GETALL = "DM_ASSETLEVEL_SelectAll";
private string VKTIM_COMPONENT_DM_ASSETLEVEL_GETBYID = "DM_ASSETLEVEL_SelectById";
private string VKTIM_COMPONENT_DM_ASSETLEVEL_INSERT = "DM_ASSETLEVEL_Insert";
private string VKTIM_COMPONENT_DM_ASSETLEVEL_UPDATE = "DM_ASSETLEVEL_Update";
private string VKTIM_COMPONENT_DM_ASSETLEVEL_DELETE = "DM_ASSETLEVEL_Delete";
#endregion

#region "Public Methods"
public virtual IDataReader DM_ASSETLEVEL_GetById(int ID)
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_ASSETLEVEL_GETBYID, ID);
}

public virtual IDataReader DM_ASSETLEVEL_GetAll()
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_ASSETLEVEL_GETALL);
}

public virtual DataSet DM_ASSETLEVEL_GetAll_DS()
{
	return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_ASSETLEVEL_GETALL);
}

public virtual object DM_ASSETLEVEL_Insert(DMASSETLEVELInfo objInfo)
{
	return SqlHelper.ExecuteScalar(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_ASSETLEVEL_INSERT, DB_GetNull(objInfo.ASSET_LEVEL_NAME), DB_GetNull(objInfo.LEVEL_VALUE), DB_GetNull(objInfo.REMARKS));
}

public virtual int DM_ASSETLEVEL_Update(DMASSETLEVELInfo objInfo)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_ASSETLEVEL_UPDATE, DB_GetNull(objInfo.ID), DB_GetNull(objInfo.ASSET_LEVEL_NAME), DB_GetNull(objInfo.LEVEL_VALUE), DB_GetNull(objInfo.REMARKS));
}

public virtual int DM_ASSETLEVEL_Delete(int ID)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_ASSETLEVEL_DELETE, ID);
}
#endregion

}

}