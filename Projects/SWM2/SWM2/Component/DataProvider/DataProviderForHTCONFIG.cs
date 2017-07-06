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
private string VKTIM_COMPONENT_HT_CONFIG_GETALL = "HT_CONFIG_SelectAll";
private string VKTIM_COMPONENT_HT_CONFIG_GETBYID = "HT_CONFIG_SelectById";
private string VKTIM_COMPONENT_HT_CONFIG_INSERT = "HT_CONFIG_Insert";
private string VKTIM_COMPONENT_HT_CONFIG_UPDATE = "HT_CONFIG_Update";
private string VKTIM_COMPONENT_HT_CONFIG_DELETE = "HT_CONFIG_Delete";
#endregion

#region "Public Methods"
public virtual IDataReader HT_CONFIG_GetById(int ID)
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_HT_CONFIG_GETBYID, ID);
}

public virtual IDataReader HT_CONFIG_GetAll()
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_HT_CONFIG_GETALL);
}

public virtual DataSet HT_CONFIG_GetAll_DS()
{
	return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, VKTIM_COMPONENT_HT_CONFIG_GETALL);
}

public virtual object HT_CONFIG_Insert(HTCONFIGInfo objInfo)
{
	return SqlHelper.ExecuteScalar(SqlConnect.ConnectionString, VKTIM_COMPONENT_HT_CONFIG_INSERT, DB_GetNull(objInfo.CONFIG_CODE), DB_GetNull(objInfo.CONFIG_NAME), DB_GetNull(objInfo.CONFIG_VALUE), DB_GetNull(objInfo.CONFIG_DESCRIPTION));
}

public virtual int HT_CONFIG_Update(HTCONFIGInfo objInfo)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_HT_CONFIG_UPDATE, DB_GetNull(objInfo.ID), DB_GetNull(objInfo.CONFIG_CODE), DB_GetNull(objInfo.CONFIG_NAME), DB_GetNull(objInfo.CONFIG_VALUE), DB_GetNull(objInfo.CONFIG_DESCRIPTION));
}

public virtual int HT_CONFIG_Delete(int ID)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_HT_CONFIG_DELETE, ID);
}
#endregion

}

}