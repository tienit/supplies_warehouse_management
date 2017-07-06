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
private string VKTIM_COMPONENT_HT_SYSTEM_LOG_GETALL = "HT_SYSTEM_LOG_SelectAll";
private string VKTIM_COMPONENT_HT_SYSTEM_LOG_GETBYID = "HT_SYSTEM_LOG_SelectById";
private string VKTIM_COMPONENT_HT_SYSTEM_LOG_INSERT = "HT_SYSTEM_LOG_Insert";
private string VKTIM_COMPONENT_HT_SYSTEM_LOG_UPDATE = "HT_SYSTEM_LOG_Update";
private string VKTIM_COMPONENT_HT_SYSTEM_LOG_DELETE = "HT_SYSTEM_LOG_Delete";
#endregion

#region "Public Methods"
public virtual IDataReader HT_SYSTEM_LOG_GetById(int ID)
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_HT_SYSTEM_LOG_GETBYID, ID);
}

public virtual IDataReader HT_SYSTEM_LOG_GetAll()
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_HT_SYSTEM_LOG_GETALL);
}

public virtual DataSet HT_SYSTEM_LOG_GetAll_DS()
{
	return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, VKTIM_COMPONENT_HT_SYSTEM_LOG_GETALL);
}

public virtual object HT_SYSTEM_LOG_Insert(HTSYSTEMLOGInfo objInfo)
{
	return SqlHelper.ExecuteScalar(SqlConnect.ConnectionString, VKTIM_COMPONENT_HT_SYSTEM_LOG_INSERT, DB_GetNull(objInfo.TABLE_NAME), DB_GetNull(objInfo.ROW_NUMBER), DB_GetNull(objInfo.CREATE_AT), DB_GetNull(objInfo.CREATE_BY_USERNAME), DB_GetNull(objInfo.LAST_MODIFIED), DB_GetNull(objInfo.MODIFIED_BY_USERNAME), DB_GetNull(objInfo.DELETE_AT), DB_GetNull(objInfo.DELETE_BY_USERNAME), DB_GetNull(objInfo.REMARKS));
}

public virtual int HT_SYSTEM_LOG_Update(HTSYSTEMLOGInfo objInfo)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_HT_SYSTEM_LOG_UPDATE, DB_GetNull(objInfo.ID), DB_GetNull(objInfo.TABLE_NAME), DB_GetNull(objInfo.ROW_NUMBER), DB_GetNull(objInfo.CREATE_AT), DB_GetNull(objInfo.CREATE_BY_USERNAME), DB_GetNull(objInfo.LAST_MODIFIED), DB_GetNull(objInfo.MODIFIED_BY_USERNAME), DB_GetNull(objInfo.DELETE_AT), DB_GetNull(objInfo.DELETE_BY_USERNAME), DB_GetNull(objInfo.REMARKS));
}

public virtual int HT_SYSTEM_LOG_Delete(int ID)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_HT_SYSTEM_LOG_DELETE, ID);
}
#endregion

}

}