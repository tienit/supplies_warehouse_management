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
private string VKTIM_COMPONENT_DM_ORIGIN_GETALL = "DM_ORIGIN_SelectAll";
private string VKTIM_COMPONENT_DM_ORIGIN_GETBYID = "DM_ORIGIN_SelectById";
private string VKTIM_COMPONENT_DM_ORIGIN_INSERT = "DM_ORIGIN_Insert";
private string VKTIM_COMPONENT_DM_ORIGIN_UPDATE = "DM_ORIGIN_Update";
private string VKTIM_COMPONENT_DM_ORIGIN_DELETE = "DM_ORIGIN_Delete";
#endregion

#region "Public Methods"
public virtual IDataReader DM_ORIGIN_GetById(int ID)
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_ORIGIN_GETBYID, ID);
}

public virtual IDataReader DM_ORIGIN_GetAll()
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_ORIGIN_GETALL);
}

public virtual DataSet DM_ORIGIN_GetAll_DS()
{
	return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_ORIGIN_GETALL);
}

public virtual object DM_ORIGIN_Insert(DMORIGINInfo objInfo)
{
	return SqlHelper.ExecuteScalar(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_ORIGIN_INSERT, DB_GetNull(objInfo.ORIGIN_NAME), DB_GetNull(objInfo.ORIGIN_DESCRIPTION));
}

public virtual int DM_ORIGIN_Update(DMORIGINInfo objInfo)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_ORIGIN_UPDATE, DB_GetNull(objInfo.ID), DB_GetNull(objInfo.ORIGIN_NAME), DB_GetNull(objInfo.ORIGIN_DESCRIPTION));
}

public virtual int DM_ORIGIN_Delete(int ID)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_ORIGIN_DELETE, ID);
}
#endregion

}

}