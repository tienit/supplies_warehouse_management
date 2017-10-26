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
private string VKTIM_COMPONENT_DM_ORGANIZATION_GETALL = "DM_ORGANIZATION_SelectAll";
private string VKTIM_COMPONENT_DM_ORGANIZATION_GETBYID = "DM_ORGANIZATION_SelectById";
private string VKTIM_COMPONENT_DM_ORGANIZATION_INSERT = "DM_ORGANIZATION_Insert";
private string VKTIM_COMPONENT_DM_ORGANIZATION_UPDATE = "DM_ORGANIZATION_Update";
private string VKTIM_COMPONENT_DM_ORGANIZATION_DELETE = "DM_ORGANIZATION_Delete";
#endregion

#region "Public Methods"
public virtual IDataReader DM_ORGANIZATION_GetById(int ID)
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_ORGANIZATION_GETBYID, ID);
}

public virtual IDataReader DM_ORGANIZATION_GetAll()
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_ORGANIZATION_GETALL);
}

public virtual DataSet DM_ORGANIZATION_GetAll_DS()
{
	return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_ORGANIZATION_GETALL);
}

public virtual object DM_ORGANIZATION_Insert(DMORGANIZATIONInfo objInfo)
{
	return SqlHelper.ExecuteScalar(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_ORGANIZATION_INSERT, DB_GetNull(objInfo.ORGANIZATION_TITLE), DB_GetNull(objInfo.ORGANIZATION_NAME), DB_GetNull(objInfo.ORGANIZATION_CODE), DB_GetNull(objInfo.ORGANIZATION_DESCRIPTION), DB_GetNull(objInfo.SPECIAL_ID), DB_GetNull(objInfo.ORGANIZATION_LEVEL));
}

public virtual int DM_ORGANIZATION_Update(DMORGANIZATIONInfo objInfo)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_ORGANIZATION_UPDATE, DB_GetNull(objInfo.ID), DB_GetNull(objInfo.ORGANIZATION_TITLE), DB_GetNull(objInfo.ORGANIZATION_NAME), DB_GetNull(objInfo.ORGANIZATION_CODE), DB_GetNull(objInfo.ORGANIZATION_DESCRIPTION), DB_GetNull(objInfo.SPECIAL_ID), DB_GetNull(objInfo.ORGANIZATION_LEVEL));
}

public virtual int DM_ORGANIZATION_Delete(int ID)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_ORGANIZATION_DELETE, ID);
}
#endregion

}

}