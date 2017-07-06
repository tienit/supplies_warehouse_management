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
private string VKTIM_COMPONENT_HT_ROLE_USER_GETALL = "HT_ROLE_USER_SelectAll";
private string VKTIM_COMPONENT_HT_ROLE_USER_GETBYID = "HT_ROLE_USER_SelectById";
private string VKTIM_COMPONENT_HT_ROLE_USER_INSERT = "HT_ROLE_USER_Insert";
private string VKTIM_COMPONENT_HT_ROLE_USER_UPDATE = "HT_ROLE_USER_Update";
private string VKTIM_COMPONENT_HT_ROLE_USER_DELETE = "HT_ROLE_USER_Delete";
#endregion

#region "Public Methods"
public virtual IDataReader HT_ROLE_USER_GetById(int ID)
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_HT_ROLE_USER_GETBYID, ID);
}

public virtual IDataReader HT_ROLE_USER_GetAll()
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_HT_ROLE_USER_GETALL);
}

public virtual DataSet HT_ROLE_USER_GetAll_DS()
{
	return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, VKTIM_COMPONENT_HT_ROLE_USER_GETALL);
}

public virtual object HT_ROLE_USER_Insert(HTROLEUSERInfo objInfo)
{
	return SqlHelper.ExecuteScalar(SqlConnect.ConnectionString, VKTIM_COMPONENT_HT_ROLE_USER_INSERT, DB_GetNull(objInfo.ROLE_ID), DB_GetNull(objInfo.USER_ID));
}

public virtual int HT_ROLE_USER_Update(HTROLEUSERInfo objInfo)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_HT_ROLE_USER_UPDATE, DB_GetNull(objInfo.ID), DB_GetNull(objInfo.ROLE_ID), DB_GetNull(objInfo.USER_ID));
}

public virtual int HT_ROLE_USER_Delete(int ID)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_HT_ROLE_USER_DELETE, ID);
}
#endregion

}

}