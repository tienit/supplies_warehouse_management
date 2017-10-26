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
private string VKTIM_COMPONENT_DM_PRICE_GETALL = "DM_PRICE_SelectAll";
private string VKTIM_COMPONENT_DM_PRICE_GETBYID = "DM_PRICE_SelectById";
private string VKTIM_COMPONENT_DM_PRICE_INSERT = "DM_PRICE_Insert";
private string VKTIM_COMPONENT_DM_PRICE_UPDATE = "DM_PRICE_Update";
private string VKTIM_COMPONENT_DM_PRICE_DELETE = "DM_PRICE_Delete";
#endregion

#region "Public Methods"
public virtual IDataReader DM_PRICE_GetById(int ID)
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_PRICE_GETBYID, ID);
}

public virtual IDataReader DM_PRICE_GetAll()
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_PRICE_GETALL);
}

public virtual DataSet DM_PRICE_GetAll_DS()
{
	return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_PRICE_GETALL);
}

public virtual object DM_PRICE_Insert(DMPRICEInfo objInfo)
{
	return SqlHelper.ExecuteScalar(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_PRICE_INSERT, DB_GetNull(objInfo.PRICE_NAME), DB_GetNull(objInfo.PRICE_SYMBOL), DB_GetNull(objInfo.PRICE_CODE), DB_GetNull(objInfo.PRICE_MIN_VALUE), DB_GetNull(objInfo.IS_DEFAULT));
}

public virtual int DM_PRICE_Update(DMPRICEInfo objInfo)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_PRICE_UPDATE, DB_GetNull(objInfo.ID), DB_GetNull(objInfo.PRICE_NAME), DB_GetNull(objInfo.PRICE_SYMBOL), DB_GetNull(objInfo.PRICE_CODE), DB_GetNull(objInfo.PRICE_MIN_VALUE), DB_GetNull(objInfo.IS_DEFAULT));
}

public virtual int DM_PRICE_Delete(int ID)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_PRICE_DELETE, ID);
}
#endregion

}

}