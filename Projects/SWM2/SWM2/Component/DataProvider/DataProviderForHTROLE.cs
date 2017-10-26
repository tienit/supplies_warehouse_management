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
private string VKTIM_COMPONENT_HT_ROLE_GETALL = "HT_ROLE_SelectAll";
private string VKTIM_COMPONENT_HT_ROLE_GETBYID = "HT_ROLE_SelectById";
private string VKTIM_COMPONENT_HT_ROLE_INSERT = "HT_ROLE_Insert";
private string VKTIM_COMPONENT_HT_ROLE_UPDATE = "HT_ROLE_Update";
private string VKTIM_COMPONENT_HT_ROLE_DELETE = "HT_ROLE_Delete";
#endregion

#region "Public Methods"
public virtual IDataReader HT_ROLE_GetById(int ID)
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_HT_ROLE_GETBYID, ID);
}

public virtual IDataReader HT_ROLE_GetAll()
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_HT_ROLE_GETALL);
}

public virtual DataSet HT_ROLE_GetAll_DS()
{
	return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, VKTIM_COMPONENT_HT_ROLE_GETALL);
}

public virtual object HT_ROLE_Insert(HTROLEInfo objInfo)
{
	return SqlHelper.ExecuteScalar(SqlConnect.ConnectionString, VKTIM_COMPONENT_HT_ROLE_INSERT, DB_GetNull(objInfo.ROLE_NAME), DB_GetNull(objInfo.ROLE_DESCRIPTION), DB_GetNull(objInfo.IS_DEFAULT));
}

public virtual int HT_ROLE_Update(HTROLEInfo objInfo)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_HT_ROLE_UPDATE, DB_GetNull(objInfo.ID), DB_GetNull(objInfo.ROLE_NAME), DB_GetNull(objInfo.ROLE_DESCRIPTION), DB_GetNull(objInfo.IS_DEFAULT));
}

public virtual int HT_ROLE_Delete(int ID)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_HT_ROLE_DELETE, ID);
}
#endregion

}

}