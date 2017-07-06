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
private string VKTIM_COMPONENT_DM_PRODUCTCATEGORY_GETALL = "DM_PRODUCTCATEGORY_SelectAll";
private string VKTIM_COMPONENT_DM_PRODUCTCATEGORY_GETBYID = "DM_PRODUCTCATEGORY_SelectById";
private string VKTIM_COMPONENT_DM_PRODUCTCATEGORY_INSERT = "DM_PRODUCTCATEGORY_Insert";
private string VKTIM_COMPONENT_DM_PRODUCTCATEGORY_UPDATE = "DM_PRODUCTCATEGORY_Update";
private string VKTIM_COMPONENT_DM_PRODUCTCATEGORY_DELETE = "DM_PRODUCTCATEGORY_Delete";
#endregion

#region "Public Methods"
public virtual IDataReader DM_PRODUCTCATEGORY_GetById(int ID)
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_PRODUCTCATEGORY_GETBYID, ID);
}

public virtual IDataReader DM_PRODUCTCATEGORY_GetAll()
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_PRODUCTCATEGORY_GETALL);
}

public virtual DataSet DM_PRODUCTCATEGORY_GetAll_DS()
{
	return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_PRODUCTCATEGORY_GETALL);
}

public virtual object DM_PRODUCTCATEGORY_Insert(DMPRODUCTCATEGORYInfo objInfo)
{
	return SqlHelper.ExecuteScalar(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_PRODUCTCATEGORY_INSERT, DB_GetNull(objInfo.PRODUCTCATEGORY_NAME), DB_GetNull(objInfo.PRODUCTCATEGORY_DESCRIPTION));
}

public virtual int DM_PRODUCTCATEGORY_Update(DMPRODUCTCATEGORYInfo objInfo)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_PRODUCTCATEGORY_UPDATE, DB_GetNull(objInfo.ID), DB_GetNull(objInfo.PRODUCTCATEGORY_NAME), DB_GetNull(objInfo.PRODUCTCATEGORY_DESCRIPTION));
}

public virtual int DM_PRODUCTCATEGORY_Delete(int ID)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_PRODUCTCATEGORY_DELETE, ID);
}
#endregion

}

}