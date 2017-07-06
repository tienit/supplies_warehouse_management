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
private string VKTIM_COMPONENT_DT_OUTPUT_GETALL = "DT_OUTPUT_SelectAll";
private string VKTIM_COMPONENT_DT_OUTPUT_GETBYID = "DT_OUTPUT_SelectById";
private string VKTIM_COMPONENT_DT_OUTPUT_INSERT = "DT_OUTPUT_Insert";
private string VKTIM_COMPONENT_DT_OUTPUT_UPDATE = "DT_OUTPUT_Update";
private string VKTIM_COMPONENT_DT_OUTPUT_DELETE = "DT_OUTPUT_Delete";
#endregion

#region "Public Methods"
public virtual IDataReader DT_OUTPUT_GetById(int ID)
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_OUTPUT_GETBYID, ID);
}

public virtual IDataReader DT_OUTPUT_GetAll()
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_OUTPUT_GETALL);
}

public virtual DataSet DT_OUTPUT_GetAll_DS()
{
	return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_OUTPUT_GETALL);
}

public virtual object DT_OUTPUT_Insert(DTOUTPUTInfo objInfo)
{
	return SqlHelper.ExecuteScalar(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_OUTPUT_INSERT, DB_GetNull(objInfo.OUTPUT_NAME), DB_GetNull(objInfo.OUTPUT_CODE), DB_GetNull(objInfo.WAREHOUSE_ID), DB_GetNull(objInfo.WAREHOUSE_NAME), DB_GetNull(objInfo.ORGANIZATION_ID), DB_GetNull(objInfo.ORGANIZATION_NAME), DB_GetNull(objInfo.EXPIRED_DATE), DB_GetNull(objInfo.IS_ASSET), DB_GetNull(objInfo.USER_ID), DB_GetNull(objInfo.USER_NAME), DB_GetNull(objInfo.IDNUMBER), DB_GetNull(objInfo.IDBOOK), DB_GetNull(objInfo.CAUSE_DESCRIPTION), DB_GetNull(objInfo.FUNDS_ID), DB_GetNull(objInfo.FUNDS_NAME), DB_GetNull(objInfo.TOTAL_VALUE), DB_GetNull(objInfo.OUTPUT_TYPE), DB_GetNull(objInfo.OUTPUT_TYPE_NAME));
}

public virtual int DT_OUTPUT_Update(DTOUTPUTInfo objInfo)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_OUTPUT_UPDATE, DB_GetNull(objInfo.ID), DB_GetNull(objInfo.OUTPUT_NAME), DB_GetNull(objInfo.OUTPUT_CODE), DB_GetNull(objInfo.WAREHOUSE_ID), DB_GetNull(objInfo.WAREHOUSE_NAME), DB_GetNull(objInfo.ORGANIZATION_ID), DB_GetNull(objInfo.ORGANIZATION_NAME), DB_GetNull(objInfo.EXPIRED_DATE), DB_GetNull(objInfo.IS_ASSET), DB_GetNull(objInfo.USER_ID), DB_GetNull(objInfo.USER_NAME), DB_GetNull(objInfo.IDNUMBER), DB_GetNull(objInfo.IDBOOK), DB_GetNull(objInfo.CAUSE_DESCRIPTION), DB_GetNull(objInfo.FUNDS_ID), DB_GetNull(objInfo.FUNDS_NAME), DB_GetNull(objInfo.TOTAL_VALUE), DB_GetNull(objInfo.OUTPUT_TYPE), DB_GetNull(objInfo.OUTPUT_TYPE_NAME));
}

public virtual int DT_OUTPUT_Delete(int ID)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_OUTPUT_DELETE, ID);
}
#endregion

}

}