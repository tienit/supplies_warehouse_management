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
private string VKTIM_COMPONENT_DM_DRUG_GETALL = "DM_DRUG_SelectAll";
private string VKTIM_COMPONENT_DM_DRUG_GETBYID = "DM_DRUG_SelectById";
private string VKTIM_COMPONENT_DM_DRUG_INSERT = "DM_DRUG_Insert";
private string VKTIM_COMPONENT_DM_DRUG_UPDATE = "DM_DRUG_Update";
private string VKTIM_COMPONENT_DM_DRUG_DELETE = "DM_DRUG_Delete";
#endregion

#region "Public Methods"
public virtual IDataReader DM_DRUG_GetById(int ID)
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_DRUG_GETBYID, ID);
}

public virtual IDataReader DM_DRUG_GetAll()
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_DRUG_GETALL);
}

public virtual DataSet DM_DRUG_GetAll_DS()
{
	return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_DRUG_GETALL);
}

public virtual object DM_DRUG_Insert(DMDRUGInfo objInfo)
{
	return SqlHelper.ExecuteScalar(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_DRUG_INSERT, DB_GetNull(objInfo.ID), DB_GetNull(objInfo.DRUG_NAME), DB_GetNull(objInfo.DRUG_CODE), DB_GetNull(objInfo.UNIT_ID), DB_GetNull(objInfo.UNIT_NAME), DB_GetNull(objInfo.UNIT_PRICE), DB_GetNull(objInfo.QUANTITY), DB_GetNull(objInfo.DRUG_DESCRIPTION), DB_GetNull(objInfo.CATEGORY_ID), DB_GetNull(objInfo.CATEGORY_NAME), DB_GetNull(objInfo.STATUS), DB_GetNull(objInfo.EXPERIED_DATE), DB_GetNull(objInfo.PRODUCT_DATE), DB_GetNull(objInfo.COMPANY), DB_GetNull(objInfo.DRUG_DOSE), DB_GetNull(objInfo.DRUG_COMPONENT), DB_GetNull(objInfo.COUNTRY), DB_GetNull(objInfo.USER_ID), DB_GetNull(objInfo.USER_NAME), DB_GetNull(objInfo.CREATED_DATE), DB_GetNull(objInfo.IS_USED), DB_GetNull(objInfo.IMAGE));
}

public virtual int DM_DRUG_Update(DMDRUGInfo objInfo)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_DRUG_UPDATE, DB_GetNull(objInfo.ID), DB_GetNull(objInfo.DRUG_NAME), DB_GetNull(objInfo.DRUG_CODE), DB_GetNull(objInfo.UNIT_ID), DB_GetNull(objInfo.UNIT_NAME), DB_GetNull(objInfo.UNIT_PRICE), DB_GetNull(objInfo.QUANTITY), DB_GetNull(objInfo.DRUG_DESCRIPTION), DB_GetNull(objInfo.CATEGORY_ID), DB_GetNull(objInfo.CATEGORY_NAME), DB_GetNull(objInfo.STATUS), DB_GetNull(objInfo.EXPERIED_DATE), DB_GetNull(objInfo.PRODUCT_DATE), DB_GetNull(objInfo.COMPANY), DB_GetNull(objInfo.DRUG_DOSE), DB_GetNull(objInfo.DRUG_COMPONENT), DB_GetNull(objInfo.COUNTRY), DB_GetNull(objInfo.USER_ID), DB_GetNull(objInfo.USER_NAME), DB_GetNull(objInfo.CREATED_DATE), DB_GetNull(objInfo.IS_USED), DB_GetNull(objInfo.IMAGE));
}

public virtual int DM_DRUG_Delete(int ID)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_DRUG_DELETE, ID);
}
#endregion

}

}