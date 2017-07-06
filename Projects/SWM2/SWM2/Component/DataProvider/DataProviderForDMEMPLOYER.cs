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
private string VKTIM_COMPONENT_DM_EMPLOYER_GETALL = "DM_EMPLOYER_SelectAll";
private string VKTIM_COMPONENT_DM_EMPLOYER_GETBYID = "DM_EMPLOYER_SelectById";
private string VKTIM_COMPONENT_DM_EMPLOYER_INSERT = "DM_EMPLOYER_Insert";
private string VKTIM_COMPONENT_DM_EMPLOYER_UPDATE = "DM_EMPLOYER_Update";
private string VKTIM_COMPONENT_DM_EMPLOYER_DELETE = "DM_EMPLOYER_Delete";
#endregion

#region "Public Methods"
public virtual IDataReader DM_EMPLOYER_GetById(int ID)
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_EMPLOYER_GETBYID, ID);
}

public virtual IDataReader DM_EMPLOYER_GetAll()
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_EMPLOYER_GETALL);
}

public virtual DataSet DM_EMPLOYER_GetAll_DS()
{
	return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_EMPLOYER_GETALL);
}

public virtual object DM_EMPLOYER_Insert(DMEMPLOYERInfo objInfo)
{
	return SqlHelper.ExecuteScalar(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_EMPLOYER_INSERT, DB_GetNull(objInfo.CODE), DB_GetNull(objInfo.EMPLOYER_NAME), DB_GetNull(objInfo.EMPLOYER_SEX), DB_GetNull(objInfo.BIRTHDAY), DB_GetNull(objInfo.TINH_LOCATION_ID), DB_GetNull(objInfo.TINH_LOCATION_NAME), DB_GetNull(objInfo.HUYEN_LOCATION_ID), DB_GetNull(objInfo.HUYEN_LOCATION_NAME), DB_GetNull(objInfo.XA_LOCATION_ID), DB_GetNull(objInfo.XA_LOCATION_NAME), DB_GetNull(objInfo.RANK_ID), DB_GetNull(objInfo.TITLE_ID), DB_GetNull(objInfo.ORGANIZATION_ID), DB_GetNull(objInfo.PHONE1), DB_GetNull(objInfo.PHONE2), DB_GetNull(objInfo.EMAIL), DB_GetNull(objInfo.AVATAR), DB_GetNull(objInfo.ADDRESS), DB_GetNull(objInfo.RETRIED));
}

public virtual int DM_EMPLOYER_Update(DMEMPLOYERInfo objInfo)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_EMPLOYER_UPDATE, DB_GetNull(objInfo.ID), DB_GetNull(objInfo.CODE), DB_GetNull(objInfo.EMPLOYER_NAME), DB_GetNull(objInfo.EMPLOYER_SEX), DB_GetNull(objInfo.BIRTHDAY), DB_GetNull(objInfo.TINH_LOCATION_ID), DB_GetNull(objInfo.TINH_LOCATION_NAME), DB_GetNull(objInfo.HUYEN_LOCATION_ID), DB_GetNull(objInfo.HUYEN_LOCATION_NAME), DB_GetNull(objInfo.XA_LOCATION_ID), DB_GetNull(objInfo.XA_LOCATION_NAME), DB_GetNull(objInfo.RANK_ID), DB_GetNull(objInfo.TITLE_ID), DB_GetNull(objInfo.ORGANIZATION_ID), DB_GetNull(objInfo.PHONE1), DB_GetNull(objInfo.PHONE2), DB_GetNull(objInfo.EMAIL), DB_GetNull(objInfo.AVATAR), DB_GetNull(objInfo.ADDRESS), DB_GetNull(objInfo.RETRIED));
}

public virtual int DM_EMPLOYER_Delete(int ID)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_EMPLOYER_DELETE, ID);
}
#endregion

}

}