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
private string VKTIM_COMPONENT_DM_SPECIAL_GETALL = "DM_SPECIAL_SelectAll";
private string VKTIM_COMPONENT_DM_SPECIAL_GETBYID = "DM_SPECIAL_SelectById";
private string VKTIM_COMPONENT_DM_SPECIAL_INSERT = "DM_SPECIAL_Insert";
private string VKTIM_COMPONENT_DM_SPECIAL_UPDATE = "DM_SPECIAL_Update";
private string VKTIM_COMPONENT_DM_SPECIAL_DELETE = "DM_SPECIAL_Delete";
#endregion

#region "Public Methods"
public virtual IDataReader DM_SPECIAL_GetById(int ID)
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_SPECIAL_GETBYID, ID);
}

public virtual IDataReader DM_SPECIAL_GetAll()
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_SPECIAL_GETALL);
}

public virtual DataSet DM_SPECIAL_GetAll_DS()
{
	return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_SPECIAL_GETALL);
}

public virtual object DM_SPECIAL_Insert(DMSPECIALInfo objInfo)
{
	return SqlHelper.ExecuteScalar(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_SPECIAL_INSERT, DB_GetNull(objInfo.SPECIAL_NAME), DB_GetNull(objInfo.SPECIAL_DESCRIPTION));
}

public virtual int DM_SPECIAL_Update(DMSPECIALInfo objInfo)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_SPECIAL_UPDATE, DB_GetNull(objInfo.ID), DB_GetNull(objInfo.SPECIAL_NAME), DB_GetNull(objInfo.SPECIAL_DESCRIPTION));
}

public virtual int DM_SPECIAL_Delete(int ID)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_SPECIAL_DELETE, ID);
}
#endregion

}

}