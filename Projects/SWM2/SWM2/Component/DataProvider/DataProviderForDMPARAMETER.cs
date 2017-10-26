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
private string VKTIM_COMPONENT_DM_PARAMETER_GETALL = "DM_PARAMETER_SelectAll";
private string VKTIM_COMPONENT_DM_PARAMETER_GETBYID = "DM_PARAMETER_SelectById";
private string VKTIM_COMPONENT_DM_PARAMETER_INSERT = "DM_PARAMETER_Insert";
private string VKTIM_COMPONENT_DM_PARAMETER_UPDATE = "DM_PARAMETER_Update";
private string VKTIM_COMPONENT_DM_PARAMETER_DELETE = "DM_PARAMETER_Delete";
#endregion

#region "Public Methods"
public virtual IDataReader DM_PARAMETER_GetById(int ID)
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_PARAMETER_GETBYID, ID);
}

public virtual IDataReader DM_PARAMETER_GetAll()
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_PARAMETER_GETALL);
}

public virtual DataSet DM_PARAMETER_GetAll_DS()
{
	return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_PARAMETER_GETALL);
}

public virtual object DM_PARAMETER_Insert(DMPARAMETERInfo objInfo)
{
	return SqlHelper.ExecuteScalar(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_PARAMETER_INSERT, DB_GetNull(objInfo.PARAMETER_NAME), DB_GetNull(objInfo.PARAMETER_VALUE), DB_GetNull(objInfo.PARAMETER_UNIT), DB_GetNull(objInfo.PARAMETER_CODE), DB_GetNull(objInfo.PARAMETER_DESCRIPTION));
}

public virtual int DM_PARAMETER_Update(DMPARAMETERInfo objInfo)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_PARAMETER_UPDATE, DB_GetNull(objInfo.ID), DB_GetNull(objInfo.PARAMETER_NAME), DB_GetNull(objInfo.PARAMETER_VALUE), DB_GetNull(objInfo.PARAMETER_UNIT), DB_GetNull(objInfo.PARAMETER_CODE), DB_GetNull(objInfo.PARAMETER_DESCRIPTION));
}

public virtual int DM_PARAMETER_Delete(int ID)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_PARAMETER_DELETE, ID);
}
#endregion

}

}