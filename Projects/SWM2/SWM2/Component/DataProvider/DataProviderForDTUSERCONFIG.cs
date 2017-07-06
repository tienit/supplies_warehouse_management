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
private string VKTIM_COMPONENT_DT_USER_CONFIG_GETALL = "DT_USER_CONFIG_SelectAll";
private string VKTIM_COMPONENT_DT_USER_CONFIG_GETBYID = "DT_USER_CONFIG_SelectById";
private string VKTIM_COMPONENT_DT_USER_CONFIG_INSERT = "DT_USER_CONFIG_Insert";
private string VKTIM_COMPONENT_DT_USER_CONFIG_UPDATE = "DT_USER_CONFIG_Update";
private string VKTIM_COMPONENT_DT_USER_CONFIG_DELETE = "DT_USER_CONFIG_Delete";
#endregion

#region "Public Methods"
public virtual IDataReader DT_USER_CONFIG_GetById(int ID)
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_USER_CONFIG_GETBYID, ID);
}

public virtual IDataReader DT_USER_CONFIG_GetAll()
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_USER_CONFIG_GETALL);
}

public virtual DataSet DT_USER_CONFIG_GetAll_DS()
{
	return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_USER_CONFIG_GETALL);
}

public virtual int DT_USER_CONFIG_Insert(DTUSERCONFIGInfo objInfo)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_USER_CONFIG_INSERT, DB_GetNull(objInfo.ID), DB_GetNull(objInfo.USER_ID), DB_GetNull(objInfo.CONFIG_ID), DB_GetNull(objInfo.CONFIG_CODE), DB_GetNull(objInfo.CONFIG_VALUE));
}

public virtual int DT_USER_CONFIG_Update(DTUSERCONFIGInfo objInfo)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_USER_CONFIG_UPDATE, DB_GetNull(objInfo.ID), DB_GetNull(objInfo.USER_ID), DB_GetNull(objInfo.CONFIG_ID), DB_GetNull(objInfo.CONFIG_CODE), DB_GetNull(objInfo.CONFIG_VALUE));
}

public virtual int DT_USER_CONFIG_Delete(int ID)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_USER_CONFIG_DELETE, ID);
}
#endregion

}

}