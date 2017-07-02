//*************************************************************
//Author           : Tien NQ
//Created Date     : 9/10/2016
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
private string ESWS_COMPONENT_TM_USERS_GETALL = "TM_USERS_SelectAll";
private string ESWS_COMPONENT_TM_USERS_GETBYID = "TM_USERS_SelectById";
private string ESWS_COMPONENT_TM_USERS_INSERT = "TM_USERS_Insert";
private string ESWS_COMPONENT_TM_USERS_UPDATE = "TM_USERS_Update";
private string ESWS_COMPONENT_TM_USERS_DELETE = "TM_USERS_Delete";
#endregion

#region "Public Methods"
public virtual IDataReader TM_USERS_GetById(int ID)
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, ESWS_COMPONENT_TM_USERS_GETBYID, ID);
}

public virtual IDataReader TM_USERS_GetAll()
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, ESWS_COMPONENT_TM_USERS_GETALL);
}

public virtual DataSet TM_USERS_GetAll_DS()
{
	return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, ESWS_COMPONENT_TM_USERS_GETALL);
}

public virtual object TM_USERS_Insert(TMUSERSInfo objInfo)
{
	return SqlHelper.ExecuteScalar(SqlConnect.ConnectionString, ESWS_COMPONENT_TM_USERS_INSERT, DB_GetNull(objInfo.CHR_USERNAME), DB_GetNull(objInfo.CHR_PASSWORD), DB_GetNull(objInfo.INT_USERGROUP), DB_GetNull(objInfo.INT_FACTORY_ID), objInfo.BIT_LOCKED, DB_GetNull(objInfo.CHR_OPERATOR_CODE), DB_GetNull(objInfo.CHR_POSITION), DB_GetNull(objInfo.DAT_DOB), DB_GetNull(objInfo.CHR_ADDRESS), DB_GetNull(objInfo.CHR_MOBILE), DB_GetNull(objInfo.CHR_EMAIL), DB_GetNull(objInfo.CHR_REMARK));
}

public virtual int TM_USERS_Update(TMUSERSInfo objInfo)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, ESWS_COMPONENT_TM_USERS_UPDATE, DB_GetNull(objInfo.ID), DB_GetNull(objInfo.CHR_USERNAME), DB_GetNull(objInfo.CHR_PASSWORD), DB_GetNull(objInfo.INT_USERGROUP), DB_GetNull(objInfo.INT_FACTORY_ID), objInfo.BIT_LOCKED, DB_GetNull(objInfo.CHR_OPERATOR_CODE), DB_GetNull(objInfo.CHR_POSITION), DB_GetNull(objInfo.DAT_DOB), DB_GetNull(objInfo.CHR_ADDRESS), DB_GetNull(objInfo.CHR_MOBILE), DB_GetNull(objInfo.CHR_EMAIL), DB_GetNull(objInfo.CHR_REMARK));
}

public virtual int TM_USERS_Delete(int ID)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, ESWS_COMPONENT_TM_USERS_DELETE, ID);
}
#endregion

}

}