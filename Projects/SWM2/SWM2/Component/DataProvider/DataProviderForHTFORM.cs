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
private string VKTIM_COMPONENT_HT_FORM_GETALL = "HT_FORM_SelectAll";
private string VKTIM_COMPONENT_HT_FORM_GETBYID = "HT_FORM_SelectById";
private string VKTIM_COMPONENT_HT_FORM_INSERT = "HT_FORM_Insert";
private string VKTIM_COMPONENT_HT_FORM_UPDATE = "HT_FORM_Update";
private string VKTIM_COMPONENT_HT_FORM_DELETE = "HT_FORM_Delete";
#endregion

#region "Public Methods"
public virtual IDataReader HT_FORM_GetById(int ID)
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_HT_FORM_GETBYID, ID);
}

public virtual IDataReader HT_FORM_GetAll()
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_HT_FORM_GETALL);
}

public virtual DataSet HT_FORM_GetAll_DS()
{
	return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, VKTIM_COMPONENT_HT_FORM_GETALL);
}

public virtual object HT_FORM_Insert(HTFORMInfo objInfo)
{
	return SqlHelper.ExecuteScalar(SqlConnect.ConnectionString, VKTIM_COMPONENT_HT_FORM_INSERT, DB_GetNull(objInfo.FORM_NAME), DB_GetNull(objInfo.FORM_TITLE), DB_GetNull(objInfo.FORM_TITLE_EN), DB_GetNull(objInfo.MENU_NAME), objInfo.IS_SHOW_DIALOG, DB_GetNull(objInfo.SHORTCUT_KEY), objInfo.IS_USED, DB_GetNull(objInfo.FORM_ORDER));
}

public virtual int HT_FORM_Update(HTFORMInfo objInfo)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_HT_FORM_UPDATE, DB_GetNull(objInfo.ID), DB_GetNull(objInfo.FORM_NAME), DB_GetNull(objInfo.FORM_TITLE), DB_GetNull(objInfo.FORM_TITLE_EN), DB_GetNull(objInfo.MENU_NAME), objInfo.IS_SHOW_DIALOG, DB_GetNull(objInfo.SHORTCUT_KEY), objInfo.IS_USED, DB_GetNull(objInfo.FORM_ORDER));
}

public virtual int HT_FORM_Delete(int ID)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_HT_FORM_DELETE, ID);
}
#endregion

}

}