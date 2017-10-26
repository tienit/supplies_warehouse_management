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
private string VKTIM_COMPONENT_HT_USER_GETALL = "HT_USER_SelectAll";
private string VKTIM_COMPONENT_HT_USER_GETBYID = "HT_USER_SelectById";
private string VKTIM_COMPONENT_HT_USER_INSERT = "HT_USER_Insert";
private string VKTIM_COMPONENT_HT_USER_UPDATE = "HT_USER_Update";
private string VKTIM_COMPONENT_HT_USER_DELETE = "HT_USER_Delete";
#endregion

#region "Public Methods"
public virtual IDataReader HT_USER_GetById(int ID)
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_HT_USER_GETBYID, ID);
}

public virtual IDataReader HT_USER_GetAll()
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_HT_USER_GETALL);
}

public virtual DataSet HT_USER_GetAll_DS()
{
	return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, VKTIM_COMPONENT_HT_USER_GETALL);
}

public virtual object HT_USER_Insert(HTUSERInfo objInfo)
{
	return SqlHelper.ExecuteScalar(SqlConnect.ConnectionString, VKTIM_COMPONENT_HT_USER_INSERT, DB_GetNull(objInfo.USER_NAME), DB_GetNull(objInfo.PASSWORD), DB_GetNull(objInfo.LAST_LOGIN), DB_GetNull(objInfo.IP_LOGIN), DB_GetNull(objInfo.NUMBER_LOGIN), DB_GetNull(objInfo.IS_BLOCKED), DB_GetNull(objInfo.REMARKS));
}

public virtual int HT_USER_Update(HTUSERInfo objInfo)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_HT_USER_UPDATE, DB_GetNull(objInfo.ID), DB_GetNull(objInfo.USER_NAME), DB_GetNull(objInfo.PASSWORD), DB_GetNull(objInfo.LAST_LOGIN), DB_GetNull(objInfo.IP_LOGIN), DB_GetNull(objInfo.NUMBER_LOGIN), DB_GetNull(objInfo.IS_BLOCKED), DB_GetNull(objInfo.REMARKS));
}

public virtual int HT_USER_Delete(int ID)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_HT_USER_DELETE, ID);
}
#endregion

}

}