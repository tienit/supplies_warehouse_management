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
private string VKTIM_COMPONENT_DT_FUNDS_GETALL = "DT_FUNDS_SelectAll";
private string VKTIM_COMPONENT_DT_FUNDS_GETBYID = "DT_FUNDS_SelectById";
private string VKTIM_COMPONENT_DT_FUNDS_INSERT = "DT_FUNDS_Insert";
private string VKTIM_COMPONENT_DT_FUNDS_UPDATE = "DT_FUNDS_Update";
private string VKTIM_COMPONENT_DT_FUNDS_DELETE = "DT_FUNDS_Delete";
#endregion

#region "Public Methods"
public virtual IDataReader DT_FUNDS_GetById(int ID)
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_FUNDS_GETBYID, ID);
}

public virtual IDataReader DT_FUNDS_GetAll()
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_FUNDS_GETALL);
}

public virtual DataSet DT_FUNDS_GetAll_DS()
{
	return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_FUNDS_GETALL);
}

public virtual object DT_FUNDS_Insert(DTFUNDSInfo objInfo)
{
	return SqlHelper.ExecuteScalar(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_FUNDS_INSERT, DB_GetNull(objInfo.FUNDS_NAME), DB_GetNull(objInfo.FUNDS_DESCRIPTION), DB_GetNull(objInfo.FUNDS_VALUE));
}

public virtual int DT_FUNDS_Update(DTFUNDSInfo objInfo)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_FUNDS_UPDATE, DB_GetNull(objInfo.ID), DB_GetNull(objInfo.FUNDS_NAME), DB_GetNull(objInfo.FUNDS_DESCRIPTION), DB_GetNull(objInfo.FUNDS_VALUE));
}

public virtual int DT_FUNDS_Delete(int ID)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_FUNDS_DELETE, ID);
}
#endregion

}

}