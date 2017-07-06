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
private string VKTIM_COMPONENT_DM_SUPPLIER_GETALL = "DM_SUPPLIER_SelectAll";
private string VKTIM_COMPONENT_DM_SUPPLIER_GETBYID = "DM_SUPPLIER_SelectById";
private string VKTIM_COMPONENT_DM_SUPPLIER_INSERT = "DM_SUPPLIER_Insert";
private string VKTIM_COMPONENT_DM_SUPPLIER_UPDATE = "DM_SUPPLIER_Update";
private string VKTIM_COMPONENT_DM_SUPPLIER_DELETE = "DM_SUPPLIER_Delete";
#endregion

#region "Public Methods"
public virtual IDataReader DM_SUPPLIER_GetById(int ID)
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_SUPPLIER_GETBYID, ID);
}

public virtual IDataReader DM_SUPPLIER_GetAll()
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_SUPPLIER_GETALL);
}

public virtual DataSet DM_SUPPLIER_GetAll_DS()
{
	return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_SUPPLIER_GETALL);
}

public virtual object DM_SUPPLIER_Insert(DMSUPPLIERInfo objInfo)
{
	return SqlHelper.ExecuteScalar(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_SUPPLIER_INSERT, DB_GetNull(objInfo.SUPPLIER_NAME), DB_GetNull(objInfo.SUPPLIER_DESCRIPTION), DB_GetNull(objInfo.PARENT_ID), DB_GetNull(objInfo.SUPPLIER_SHORTNAME), DB_GetNull(objInfo.SUPPLIER_ADDRESS), DB_GetNull(objInfo.SUPPLIER_DIRECTOR), DB_GetNull(objInfo.SUPPLIER_MST));
}

public virtual int DM_SUPPLIER_Update(DMSUPPLIERInfo objInfo)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_SUPPLIER_UPDATE, DB_GetNull(objInfo.ID), DB_GetNull(objInfo.SUPPLIER_NAME), DB_GetNull(objInfo.SUPPLIER_DESCRIPTION), DB_GetNull(objInfo.PARENT_ID), DB_GetNull(objInfo.SUPPLIER_SHORTNAME), DB_GetNull(objInfo.SUPPLIER_ADDRESS), DB_GetNull(objInfo.SUPPLIER_DIRECTOR), DB_GetNull(objInfo.SUPPLIER_MST));
}

public virtual int DM_SUPPLIER_Delete(int ID)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_SUPPLIER_DELETE, ID);
}
#endregion

}

}