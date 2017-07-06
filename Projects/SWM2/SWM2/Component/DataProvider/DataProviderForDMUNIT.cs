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
private string VKTIM_COMPONENT_DM_UNIT_GETALL = "DM_UNIT_SelectAll";
private string VKTIM_COMPONENT_DM_UNIT_GETBYID = "DM_UNIT_SelectById";
private string VKTIM_COMPONENT_DM_UNIT_INSERT = "DM_UNIT_Insert";
private string VKTIM_COMPONENT_DM_UNIT_UPDATE = "DM_UNIT_Update";
private string VKTIM_COMPONENT_DM_UNIT_DELETE = "DM_UNIT_Delete";
#endregion

#region "Public Methods"
public virtual IDataReader DM_UNIT_GetById(int ID)
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_UNIT_GETBYID, ID);
}

public virtual IDataReader DM_UNIT_GetAll()
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_UNIT_GETALL);
}

public virtual DataSet DM_UNIT_GetAll_DS()
{
	return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_UNIT_GETALL);
}

public virtual object DM_UNIT_Insert(DMUNITInfo objInfo)
{
	return SqlHelper.ExecuteScalar(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_UNIT_INSERT, DB_GetNull(objInfo.UNIT_NAME), DB_GetNull(objInfo.UNIT_SHORT_NAME), DB_GetNull(objInfo.UNIT_DESCRIPTION));
}

public virtual int DM_UNIT_Update(DMUNITInfo objInfo)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_UNIT_UPDATE, DB_GetNull(objInfo.ID), DB_GetNull(objInfo.UNIT_NAME), DB_GetNull(objInfo.UNIT_SHORT_NAME), DB_GetNull(objInfo.UNIT_DESCRIPTION));
}

public virtual int DM_UNIT_Delete(int ID)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_UNIT_DELETE, ID);
}
#endregion

}

}