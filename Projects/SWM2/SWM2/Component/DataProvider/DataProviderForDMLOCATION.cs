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
private string VKTIM_COMPONENT_DM_LOCATION_GETALL = "DM_LOCATION_SelectAll";
private string VKTIM_COMPONENT_DM_LOCATION_GETBYID = "DM_LOCATION_SelectById";
private string VKTIM_COMPONENT_DM_LOCATION_INSERT = "DM_LOCATION_Insert";
private string VKTIM_COMPONENT_DM_LOCATION_UPDATE = "DM_LOCATION_Update";
private string VKTIM_COMPONENT_DM_LOCATION_DELETE = "DM_LOCATION_Delete";
#endregion

#region "Public Methods"
public virtual IDataReader DM_LOCATION_GetById(int ID)
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_LOCATION_GETBYID, ID);
}

public virtual IDataReader DM_LOCATION_GetAll()
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_LOCATION_GETALL);
}

public virtual DataSet DM_LOCATION_GetAll_DS()
{
	return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_LOCATION_GETALL);
}

public virtual object DM_LOCATION_Insert(DMLOCATIONInfo objInfo)
{
	return SqlHelper.ExecuteScalar(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_LOCATION_INSERT, DB_GetNull(objInfo.LOCATION_NAME), DB_GetNull(objInfo.LOCATION_ORDER), DB_GetNull(objInfo.LOCATION_PARENT_ID), DB_GetNull(objInfo.LOCATION_LEVEL));
}

public virtual int DM_LOCATION_Update(DMLOCATIONInfo objInfo)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_LOCATION_UPDATE, DB_GetNull(objInfo.ID), DB_GetNull(objInfo.LOCATION_NAME), DB_GetNull(objInfo.LOCATION_ORDER), DB_GetNull(objInfo.LOCATION_PARENT_ID), DB_GetNull(objInfo.LOCATION_LEVEL));
}

public virtual int DM_LOCATION_Delete(int ID)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_LOCATION_DELETE, ID);
}
#endregion

}

}