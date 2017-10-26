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
private string VKTIM_COMPONENT_DT_FAQ_GETALL = "DT_FAQ_SelectAll";
private string VKTIM_COMPONENT_DT_FAQ_GETBYID = "DT_FAQ_SelectById";
private string VKTIM_COMPONENT_DT_FAQ_INSERT = "DT_FAQ_Insert";
private string VKTIM_COMPONENT_DT_FAQ_UPDATE = "DT_FAQ_Update";
private string VKTIM_COMPONENT_DT_FAQ_DELETE = "DT_FAQ_Delete";
#endregion

#region "Public Methods"
public virtual IDataReader DT_FAQ_GetById(int ID)
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_FAQ_GETBYID, ID);
}

public virtual IDataReader DT_FAQ_GetAll()
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_FAQ_GETALL);
}

public virtual DataSet DT_FAQ_GetAll_DS()
{
	return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_FAQ_GETALL);
}

public virtual object DT_FAQ_Insert(DTFAQInfo objInfo)
{
	return SqlHelper.ExecuteScalar(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_FAQ_INSERT, DB_GetNull(objInfo.FORM_ID), DB_GetNull(objInfo.FORM_NAME), DB_GetNull(objInfo.QUESTION), DB_GetNull(objInfo.ANSWER), DB_GetNull(objInfo.SHORTCUT_KEY), DB_GetNull(objInfo.LONG_ANSWER), DB_GetNull(objInfo.KEYWORD), DB_GetNull(objInfo.GROUP), DB_GetNull(objInfo.REMARKS));
}

public virtual int DT_FAQ_Update(DTFAQInfo objInfo)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_FAQ_UPDATE, DB_GetNull(objInfo.ID), DB_GetNull(objInfo.FORM_ID), DB_GetNull(objInfo.FORM_NAME), DB_GetNull(objInfo.QUESTION), DB_GetNull(objInfo.ANSWER), DB_GetNull(objInfo.SHORTCUT_KEY), DB_GetNull(objInfo.LONG_ANSWER), DB_GetNull(objInfo.KEYWORD), DB_GetNull(objInfo.GROUP), DB_GetNull(objInfo.REMARKS));
}

public virtual int DT_FAQ_Delete(int ID)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_FAQ_DELETE, ID);
}
#endregion

}

}