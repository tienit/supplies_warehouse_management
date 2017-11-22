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
private string VKTIM_COMPONENT_DM_DRUG_INPUT_GETALL = "DT_DRUG_INPUT_SelectAll";
private string VKTIM_COMPONENT_DM_DRUG_INPUT_GETBYID = "DT_DRUG_INPUT_SelectById";
private string VKTIM_COMPONENT_DM_DRUG_INPUT_INSERT = "DT_DRUG_INPUT_Insert";
private string VKTIM_COMPONENT_DM_DRUG_INPUT_UPDATE = "DT_DRUG_INPUT_Update";
private string VKTIM_COMPONENT_DM_DRUG_INPUT_DELETE = "DT_DRUG_INPUT_Delete";
#endregion

#region "Public Methods"
public virtual IDataReader DM_DRUG_INPUT_GetById(int ID)
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_DRUG_INPUT_GETBYID, ID);
}

public virtual IDataReader DM_DRUG_INPUT_GetAll()
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_DRUG_INPUT_GETALL);
}

public virtual DataSet DM_DRUG_INPUT_GetAll_DS()
{
	return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_DRUG_INPUT_GETALL);
}

public virtual object DM_DRUG_INPUT_Insert(DTDRUGINPUTInfo objInfo)
{
	return SqlHelper.ExecuteScalar(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_DRUG_INPUT_INSERT, DB_GetNull(objInfo.ID), DB_GetNull(objInfo.INPUT_NAME), DB_GetNull(objInfo.DRUG_INPUT_CODE), DB_GetNull(objInfo.DRUG_WAREHOUSE_NAME), DB_GetNull(objInfo.ORGANIZATION_ID), DB_GetNull(objInfo.ORGANIZATION_NAME), DB_GetNull(objInfo.USER_ID), DB_GetNull(objInfo.USER_NAME), DB_GetNull(objInfo.TOTAL), DB_GetNull(objInfo.FUNDS_ID), DB_GetNull(objInfo.FUNDS_NAME), DB_GetNull(objInfo.CREATED_DATE));
}

public virtual int DM_DRUG_INPUT_Update(DTDRUGINPUTInfo objInfo)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_DRUG_INPUT_UPDATE, DB_GetNull(objInfo.ID), DB_GetNull(objInfo.INPUT_NAME), DB_GetNull(objInfo.DRUG_INPUT_CODE), DB_GetNull(objInfo.DRUG_WAREHOUSE_NAME), DB_GetNull(objInfo.ORGANIZATION_ID), DB_GetNull(objInfo.ORGANIZATION_NAME), DB_GetNull(objInfo.USER_ID), DB_GetNull(objInfo.USER_NAME), DB_GetNull(objInfo.TOTAL), DB_GetNull(objInfo.FUNDS_ID), DB_GetNull(objInfo.FUNDS_NAME), DB_GetNull(objInfo.CREATED_DATE));
}

public virtual int DM_DRUG_INPUT_Delete(int ID)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_DRUG_INPUT_DELETE, ID);
}
#endregion

}

}