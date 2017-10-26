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
private string VKTIM_COMPONENT_DT_INPUT_GETALL = "DT_INPUT_SelectAll";
private string VKTIM_COMPONENT_DT_INPUT_GETBYID = "DT_INPUT_SelectById";
private string VKTIM_COMPONENT_DT_INPUT_INSERT = "DT_INPUT_Insert";
private string VKTIM_COMPONENT_DT_INPUT_UPDATE = "DT_INPUT_Update";
private string VKTIM_COMPONENT_DT_INPUT_DELETE = "DT_INPUT_Delete";
#endregion

#region "Public Methods"
public virtual IDataReader DT_INPUT_GetById(int ID)
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_INPUT_GETBYID, ID);
}

public virtual IDataReader DT_INPUT_GetAll()
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_INPUT_GETALL);
}

public virtual DataSet DT_INPUT_GetAll_DS()
{
	return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_INPUT_GETALL);
}

public virtual object DT_INPUT_Insert(DTINPUTInfo objInfo)
{
	return SqlHelper.ExecuteScalar(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_INPUT_INSERT, DB_GetNull(objInfo.INPUT_NAME), DB_GetNull(objInfo.INPUT_CODE), DB_GetNull(objInfo.WAREHOUSE_ID), DB_GetNull(objInfo.WAREHOUSE_NAME), DB_GetNull(objInfo.ORGANIZATION_ID), DB_GetNull(objInfo.ORGANIZATION_NAME), DB_GetNull(objInfo.EXPIRED_DATE), DB_GetNull(objInfo.IS_ASSET), DB_GetNull(objInfo.USER_ID), DB_GetNull(objInfo.USER_NAME), DB_GetNull(objInfo.IDNUMBER), DB_GetNull(objInfo.IDBOOK), DB_GetNull(objInfo.CAUSE_DESCRIPTION), DB_GetNull(objInfo.FUNDS_ID), DB_GetNull(objInfo.FUNDS_NAME), DB_GetNull(objInfo.TOTAL_VALUE), DB_GetNull(objInfo.DATE_CREATED));
}

public virtual int DT_INPUT_Update(DTINPUTInfo objInfo)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_INPUT_UPDATE, DB_GetNull(objInfo.ID), DB_GetNull(objInfo.INPUT_NAME), DB_GetNull(objInfo.INPUT_CODE), DB_GetNull(objInfo.WAREHOUSE_ID), DB_GetNull(objInfo.WAREHOUSE_NAME), DB_GetNull(objInfo.ORGANIZATION_ID), DB_GetNull(objInfo.ORGANIZATION_NAME), DB_GetNull(objInfo.EXPIRED_DATE), DB_GetNull(objInfo.IS_ASSET), DB_GetNull(objInfo.USER_ID), DB_GetNull(objInfo.USER_NAME), DB_GetNull(objInfo.IDNUMBER), DB_GetNull(objInfo.IDBOOK), DB_GetNull(objInfo.CAUSE_DESCRIPTION), DB_GetNull(objInfo.FUNDS_ID), DB_GetNull(objInfo.FUNDS_NAME), DB_GetNull(objInfo.TOTAL_VALUE), DB_GetNull(objInfo.DATE_CREATED));
}

public virtual int DT_INPUT_Delete(int ID)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_INPUT_DELETE, ID);
}
#endregion

}

}