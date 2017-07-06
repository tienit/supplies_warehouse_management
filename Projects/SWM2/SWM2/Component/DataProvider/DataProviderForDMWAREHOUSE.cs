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
private string VKTIM_COMPONENT_DM_WAREHOUSE_GETALL = "DM_WAREHOUSE_SelectAll";
private string VKTIM_COMPONENT_DM_WAREHOUSE_GETBYID = "DM_WAREHOUSE_SelectById";
private string VKTIM_COMPONENT_DM_WAREHOUSE_INSERT = "DM_WAREHOUSE_Insert";
private string VKTIM_COMPONENT_DM_WAREHOUSE_UPDATE = "DM_WAREHOUSE_Update";
private string VKTIM_COMPONENT_DM_WAREHOUSE_DELETE = "DM_WAREHOUSE_Delete";
#endregion

#region "Public Methods"
public virtual IDataReader DM_WAREHOUSE_GetById(int ID)
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_WAREHOUSE_GETBYID, ID);
}

public virtual IDataReader DM_WAREHOUSE_GetAll()
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_WAREHOUSE_GETALL);
}

public virtual DataSet DM_WAREHOUSE_GetAll_DS()
{
	return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_WAREHOUSE_GETALL);
}

public virtual object DM_WAREHOUSE_Insert(DMWAREHOUSEInfo objInfo)
{
	return SqlHelper.ExecuteScalar(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_WAREHOUSE_INSERT, DB_GetNull(objInfo.WAREHOUSE_NAME), DB_GetNull(objInfo.PARENT_ID), DB_GetNull(objInfo.WAREHOUSE_DESCRIPTION));
}

public virtual int DM_WAREHOUSE_Update(DMWAREHOUSEInfo objInfo)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_WAREHOUSE_UPDATE, DB_GetNull(objInfo.ID), DB_GetNull(objInfo.WAREHOUSE_NAME), DB_GetNull(objInfo.PARENT_ID), DB_GetNull(objInfo.WAREHOUSE_DESCRIPTION));
}

public virtual int DM_WAREHOUSE_Delete(int ID)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_WAREHOUSE_DELETE, ID);
}
#endregion

}

}