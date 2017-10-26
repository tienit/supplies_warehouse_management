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
private string VKTIM_COMPONENT_DT_LOG_LOGIN_GETALL = "DT_LOG_LOGIN_SelectAll";
private string VKTIM_COMPONENT_DT_LOG_LOGIN_GETBYID = "DT_LOG_LOGIN_SelectById";
private string VKTIM_COMPONENT_DT_LOG_LOGIN_INSERT = "DT_LOG_LOGIN_Insert";
private string VKTIM_COMPONENT_DT_LOG_LOGIN_UPDATE = "DT_LOG_LOGIN_Update";
private string VKTIM_COMPONENT_DT_LOG_LOGIN_DELETE = "DT_LOG_LOGIN_Delete";
#endregion

#region "Public Methods"
public virtual IDataReader DT_LOG_LOGIN_GetById(int ID)
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_LOG_LOGIN_GETBYID, ID);
}

public virtual IDataReader DT_LOG_LOGIN_GetAll()
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_LOG_LOGIN_GETALL);
}

public virtual DataSet DT_LOG_LOGIN_GetAll_DS()
{
	return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_LOG_LOGIN_GETALL);
}

public virtual object DT_LOG_LOGIN_Insert(DTLOGLOGINInfo objInfo)
{
	return SqlHelper.ExecuteScalar(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_LOG_LOGIN_INSERT, DB_GetNull(objInfo.CODE), DB_GetNull(objInfo.ACTION), DB_GetNull(objInfo.TYPE), DB_GetNull(objInfo.CONTENTS), DB_GetNull(objInfo.CREATED_DATE), DB_GetNull(objInfo.USER_ID), DB_GetNull(objInfo.USER_NAME), DB_GetNull(objInfo.COM_USER), DB_GetNull(objInfo.COM_MACHINE), DB_GetNull(objInfo.COM_DOMAIN), DB_GetNull(objInfo.COM_DIR), DB_GetNull(objInfo.REMARK));
}

public virtual int DT_LOG_LOGIN_Update(DTLOGLOGINInfo objInfo)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_LOG_LOGIN_UPDATE, DB_GetNull(objInfo.ID), DB_GetNull(objInfo.CODE), DB_GetNull(objInfo.ACTION), DB_GetNull(objInfo.TYPE), DB_GetNull(objInfo.CONTENTS), DB_GetNull(objInfo.CREATED_DATE), DB_GetNull(objInfo.USER_ID), DB_GetNull(objInfo.USER_NAME), DB_GetNull(objInfo.COM_USER), DB_GetNull(objInfo.COM_MACHINE), DB_GetNull(objInfo.COM_DOMAIN), DB_GetNull(objInfo.COM_DIR), DB_GetNull(objInfo.REMARK));
}

public virtual int DT_LOG_LOGIN_Delete(int ID)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_LOG_LOGIN_DELETE, ID);
}
#endregion

}

}