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
private string VKTIM_COMPONENT_HT_ROLE_FORM_GETALL = "HT_ROLE_FORM_SelectAll";
private string VKTIM_COMPONENT_HT_ROLE_FORM_GETBYID = "HT_ROLE_FORM_SelectById";
private string VKTIM_COMPONENT_HT_ROLE_FORM_INSERT = "HT_ROLE_FORM_Insert";
private string VKTIM_COMPONENT_HT_ROLE_FORM_UPDATE = "HT_ROLE_FORM_Update";
private string VKTIM_COMPONENT_HT_ROLE_FORM_DELETE = "HT_ROLE_FORM_Delete";
#endregion

#region "Public Methods"
public virtual IDataReader HT_ROLE_FORM_GetById(int ID)
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_HT_ROLE_FORM_GETBYID, ID);
}

public virtual IDataReader HT_ROLE_FORM_GetAll()
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_HT_ROLE_FORM_GETALL);
}

public virtual DataSet HT_ROLE_FORM_GetAll_DS()
{
	return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, VKTIM_COMPONENT_HT_ROLE_FORM_GETALL);
}

public virtual object HT_ROLE_FORM_Insert(HTROLEFORMInfo objInfo)
{
	return SqlHelper.ExecuteScalar(SqlConnect.ConnectionString, VKTIM_COMPONENT_HT_ROLE_FORM_INSERT, DB_GetNull(objInfo.ROLE_ID), DB_GetNull(objInfo.FORM_ID));
}

public virtual int HT_ROLE_FORM_Update(HTROLEFORMInfo objInfo)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_HT_ROLE_FORM_UPDATE, DB_GetNull(objInfo.ID), DB_GetNull(objInfo.ROLE_ID), DB_GetNull(objInfo.FORM_ID));
}

public virtual int HT_ROLE_FORM_Delete(int ID)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_HT_ROLE_FORM_DELETE, ID);
}
#endregion

}

}