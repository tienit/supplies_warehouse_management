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
private string VKTIM_COMPONENT_DT_STORES_GETALL = "DT_STORES_SelectAll";
private string VKTIM_COMPONENT_DT_STORES_GETBYID = "DT_STORES_SelectById";
private string VKTIM_COMPONENT_DT_STORES_INSERT = "DT_STORES_Insert";
private string VKTIM_COMPONENT_DT_STORES_UPDATE = "DT_STORES_Update";
private string VKTIM_COMPONENT_DT_STORES_DELETE = "DT_STORES_Delete";
#endregion

#region "Public Methods"
public virtual IDataReader DT_STORES_GetById(int ID)
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_STORES_GETBYID, ID);
}

public virtual IDataReader DT_STORES_GetAll()
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_STORES_GETALL);
}

public virtual DataSet DT_STORES_GetAll_DS()
{
	return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_STORES_GETALL);
}

public virtual object DT_STORES_Insert(DTSTORESInfo objInfo)
{
	return SqlHelper.ExecuteScalar(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_STORES_INSERT, DB_GetNull(objInfo.PRODUCT_ID), DB_GetNull(objInfo.QUANTITY), DB_GetNull(objInfo.WAREHOUSE_ID), DB_GetNull(objInfo.SHORT), DB_GetNull(objInfo.REMARKS), DB_GetNull(objInfo.DATE_IN), DB_GetNull(objInfo.DATE_OUT), DB_GetNull(objInfo.USER_ID), DB_GetNull(objInfo.STORE_TYPE), DB_GetNull(objInfo.REMIND), DB_GetNull(objInfo.DATE_REMIND));
}

public virtual int DT_STORES_Update(DTSTORESInfo objInfo)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_STORES_UPDATE, DB_GetNull(objInfo.ID), DB_GetNull(objInfo.PRODUCT_ID), DB_GetNull(objInfo.QUANTITY), DB_GetNull(objInfo.WAREHOUSE_ID), DB_GetNull(objInfo.SHORT), DB_GetNull(objInfo.REMARKS), DB_GetNull(objInfo.DATE_IN), DB_GetNull(objInfo.DATE_OUT), DB_GetNull(objInfo.USER_ID), DB_GetNull(objInfo.STORE_TYPE), DB_GetNull(objInfo.REMIND), DB_GetNull(objInfo.DATE_REMIND));
}

public virtual int DT_STORES_Delete(int ID)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_STORES_DELETE, ID);
}
#endregion

}

}