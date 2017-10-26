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
private string VKTIM_COMPONENT_DM_TITLE_GETALL = "DM_TITLE_SelectAll";
private string VKTIM_COMPONENT_DM_TITLE_GETBYID = "DM_TITLE_SelectById";
private string VKTIM_COMPONENT_DM_TITLE_INSERT = "DM_TITLE_Insert";
private string VKTIM_COMPONENT_DM_TITLE_UPDATE = "DM_TITLE_Update";
private string VKTIM_COMPONENT_DM_TITLE_DELETE = "DM_TITLE_Delete";
#endregion

#region "Public Methods"
public virtual IDataReader DM_TITLE_GetById(int ID)
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_TITLE_GETBYID, ID);
}

public virtual IDataReader DM_TITLE_GetAll()
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_TITLE_GETALL);
}

public virtual DataSet DM_TITLE_GetAll_DS()
{
	return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_TITLE_GETALL);
}

public virtual object DM_TITLE_Insert(DMTITLEInfo objInfo)
{
	return SqlHelper.ExecuteScalar(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_TITLE_INSERT, DB_GetNull(objInfo.TITLE_NAME), DB_GetNull(objInfo.TITLE_SHORT_NAME), DB_GetNull(objInfo.TITLE_DESCRIPTION));
}

public virtual int DM_TITLE_Update(DMTITLEInfo objInfo)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_TITLE_UPDATE, DB_GetNull(objInfo.ID), DB_GetNull(objInfo.TITLE_NAME), DB_GetNull(objInfo.TITLE_SHORT_NAME), DB_GetNull(objInfo.TITLE_DESCRIPTION));
}

public virtual int DM_TITLE_Delete(int ID)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_TITLE_DELETE, ID);
}
#endregion

}

}