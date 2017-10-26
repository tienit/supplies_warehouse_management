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
private string VKTIM_COMPONENT_DM_RANK_GETALL = "DM_RANK_SelectAll";
private string VKTIM_COMPONENT_DM_RANK_GETBYID = "DM_RANK_SelectById";
private string VKTIM_COMPONENT_DM_RANK_INSERT = "DM_RANK_Insert";
private string VKTIM_COMPONENT_DM_RANK_UPDATE = "DM_RANK_Update";
private string VKTIM_COMPONENT_DM_RANK_DELETE = "DM_RANK_Delete";
#endregion

#region "Public Methods"
public virtual IDataReader DM_RANK_GetById(int ID)
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_RANK_GETBYID, ID);
}

public virtual IDataReader DM_RANK_GetAll()
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_RANK_GETALL);
}

public virtual DataSet DM_RANK_GetAll_DS()
{
	return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_RANK_GETALL);
}

public virtual object DM_RANK_Insert(DMRANKInfo objInfo)
{
	return SqlHelper.ExecuteScalar(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_RANK_INSERT, DB_GetNull(objInfo.RANK_NAME), DB_GetNull(objInfo.RANK_DESCRIPTION));
}

public virtual int DM_RANK_Update(DMRANKInfo objInfo)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_RANK_UPDATE, DB_GetNull(objInfo.ID), DB_GetNull(objInfo.RANK_NAME), DB_GetNull(objInfo.RANK_DESCRIPTION));
}

public virtual int DM_RANK_Delete(int ID)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_RANK_DELETE, ID);
}
#endregion

}

}