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
private string VKTIM_COMPONENT_DT_PRODUCT_PARAMETER_GETALL = "DT_PRODUCT_PARAMETER_SelectAll";
private string VKTIM_COMPONENT_DT_PRODUCT_PARAMETER_GETBYID = "DT_PRODUCT_PARAMETER_SelectById";
private string VKTIM_COMPONENT_DT_PRODUCT_PARAMETER_INSERT = "DT_PRODUCT_PARAMETER_Insert";
private string VKTIM_COMPONENT_DT_PRODUCT_PARAMETER_UPDATE = "DT_PRODUCT_PARAMETER_Update";
private string VKTIM_COMPONENT_DT_PRODUCT_PARAMETER_DELETE = "DT_PRODUCT_PARAMETER_Delete";
#endregion

#region "Public Methods"
public virtual IDataReader DT_PRODUCT_PARAMETER_GetById(int ID)
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_PRODUCT_PARAMETER_GETBYID, ID);
}

public virtual IDataReader DT_PRODUCT_PARAMETER_GetAll()
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_PRODUCT_PARAMETER_GETALL);
}

public virtual DataSet DT_PRODUCT_PARAMETER_GetAll_DS()
{
	return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_PRODUCT_PARAMETER_GETALL);
}

public virtual object DT_PRODUCT_PARAMETER_Insert(DTPRODUCTPARAMETERInfo objInfo)
{
	return SqlHelper.ExecuteScalar(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_PRODUCT_PARAMETER_INSERT, DB_GetNull(objInfo.PRODUCT_ID), DB_GetNull(objInfo.PARAMETER_ID));
}

public virtual int DT_PRODUCT_PARAMETER_Update(DTPRODUCTPARAMETERInfo objInfo)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_PRODUCT_PARAMETER_UPDATE, DB_GetNull(objInfo.ID), DB_GetNull(objInfo.PRODUCT_ID), DB_GetNull(objInfo.PARAMETER_ID));
}

public virtual int DT_PRODUCT_PARAMETER_Delete(int ID)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_PRODUCT_PARAMETER_DELETE, ID);
}
#endregion

}

}