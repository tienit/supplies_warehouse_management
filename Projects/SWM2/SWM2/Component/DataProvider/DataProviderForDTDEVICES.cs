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
private string VKTIM_COMPONENT_DT_DEVICES_GETALL = "DT_DEVICES_SelectAll";
private string VKTIM_COMPONENT_DT_DEVICES_GETBYID = "DT_DEVICES_SelectById";
private string VKTIM_COMPONENT_DT_DEVICES_INSERT = "DT_DEVICES_Insert";
private string VKTIM_COMPONENT_DT_DEVICES_UPDATE = "DT_DEVICES_Update";
private string VKTIM_COMPONENT_DT_DEVICES_DELETE = "DT_DEVICES_Delete";
#endregion

#region "Public Methods"
public virtual IDataReader DT_DEVICES_GetById(int ID)
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_DEVICES_GETBYID, ID);
}

public virtual IDataReader DT_DEVICES_GetAll()
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_DEVICES_GETALL);
}

public virtual DataSet DT_DEVICES_GetAll_DS()
{
	return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_DEVICES_GETALL);
}

public virtual object DT_DEVICES_Insert(DTDEVICESInfo objInfo)
{
	return SqlHelper.ExecuteScalar(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_DEVICES_INSERT, DB_GetNull(objInfo.NAME), DB_GetNull(objInfo.IPv4), DB_GetNull(objInfo.IPv6), DB_GetNull(objInfo.ORGANIZATION_ID), DB_GetNull(objInfo.ORGANIZATION_NAME), DB_GetNull(objInfo.LOCKED), DB_GetNull(objInfo.REMARK));
}

public virtual int DT_DEVICES_Update(DTDEVICESInfo objInfo)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_DEVICES_UPDATE, DB_GetNull(objInfo.ID), DB_GetNull(objInfo.NAME), DB_GetNull(objInfo.IPv4), DB_GetNull(objInfo.IPv6), DB_GetNull(objInfo.ORGANIZATION_ID), DB_GetNull(objInfo.ORGANIZATION_NAME), DB_GetNull(objInfo.LOCKED), DB_GetNull(objInfo.REMARK));
}

public virtual int DT_DEVICES_Delete(int ID)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_DEVICES_DELETE, ID);
}
#endregion

}

}