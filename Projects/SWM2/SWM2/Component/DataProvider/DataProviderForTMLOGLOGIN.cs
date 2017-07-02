//*************************************************************
//Author           : Tien NQ
//Created Date     : 9/6/2016
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
private string ESWS_COMPONENT_TM_LOG_LOGIN_GETALL = "TM_LOG_LOGIN_SelectAll";
private string ESWS_COMPONENT_TM_LOG_LOGIN_GETBYID = "TM_LOG_LOGIN_SelectById";
private string ESWS_COMPONENT_TM_LOG_LOGIN_INSERT = "TM_LOG_LOGIN_Insert";
private string ESWS_COMPONENT_TM_LOG_LOGIN_UPDATE = "TM_LOG_LOGIN_Update";
private string ESWS_COMPONENT_TM_LOG_LOGIN_DELETE = "TM_LOG_LOGIN_Delete";
#endregion

#region "Public Methods"
public virtual IDataReader TM_LOG_LOGIN_GetById(int ID)
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, ESWS_COMPONENT_TM_LOG_LOGIN_GETBYID, ID);
}

public virtual IDataReader TM_LOG_LOGIN_GetAll()
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, ESWS_COMPONENT_TM_LOG_LOGIN_GETALL);
}

public virtual DataSet TM_LOG_LOGIN_GetAll_DS()
{
	return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, ESWS_COMPONENT_TM_LOG_LOGIN_GETALL);
}

public virtual object TM_LOG_LOGIN_Insert(TMLOGLOGINInfo objInfo)
{
	return SqlHelper.ExecuteScalar(SqlConnect.ConnectionString, ESWS_COMPONENT_TM_LOG_LOGIN_INSERT, DB_GetNull(objInfo.INT_USER_ID), DB_GetNull(objInfo.CHR_USERNAME), DB_GetNull(objInfo.INT_USERGROUP), DB_GetNull(objInfo.DAT_CREATED), DB_GetNull(objInfo.CHR_CONTENT), DB_GetNull(objInfo.CHR_DOMAIN), DB_GetNull(objInfo.CHR_MACHINE), DB_GetNull(objInfo.CHR_COM_USER), DB_GetNull(objInfo.CHR_DIRECTORY), DB_GetNull(objInfo.INT_FACTORY_ID), DB_GetNull(objInfo.CHR_FACTORY_NAME), DB_GetNull(objInfo.CHR_REMARK), DB_GetNull(objInfo.CHR_NOTE1), DB_GetNull(objInfo.CHR_NOTE2), DB_GetNull(objInfo.CHR_NOTE3));
}

public virtual int TM_LOG_LOGIN_Update(TMLOGLOGINInfo objInfo)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, ESWS_COMPONENT_TM_LOG_LOGIN_UPDATE, DB_GetNull(objInfo.ID), DB_GetNull(objInfo.INT_USER_ID), DB_GetNull(objInfo.CHR_USERNAME), DB_GetNull(objInfo.INT_USERGROUP), DB_GetNull(objInfo.DAT_CREATED), DB_GetNull(objInfo.CHR_CONTENT), DB_GetNull(objInfo.CHR_DOMAIN), DB_GetNull(objInfo.CHR_MACHINE), DB_GetNull(objInfo.CHR_COM_USER), DB_GetNull(objInfo.CHR_DIRECTORY), DB_GetNull(objInfo.INT_FACTORY_ID), DB_GetNull(objInfo.CHR_FACTORY_NAME), DB_GetNull(objInfo.CHR_REMARK), DB_GetNull(objInfo.CHR_NOTE1), DB_GetNull(objInfo.CHR_NOTE2), DB_GetNull(objInfo.CHR_NOTE3));
}

public virtual int TM_LOG_LOGIN_Delete(int ID)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, ESWS_COMPONENT_TM_LOG_LOGIN_DELETE, ID);
}
#endregion

}

}