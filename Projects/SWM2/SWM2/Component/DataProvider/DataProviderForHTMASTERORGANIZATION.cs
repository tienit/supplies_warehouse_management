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
private string VKTIM_COMPONENT_HT_MASTER_ORGANIZATION_GETALL = "HT_MASTER_ORGANIZATION_SelectAll";
private string VKTIM_COMPONENT_HT_MASTER_ORGANIZATION_GETBYID = "HT_MASTER_ORGANIZATION_SelectById";
private string VKTIM_COMPONENT_HT_MASTER_ORGANIZATION_INSERT = "HT_MASTER_ORGANIZATION_Insert";
private string VKTIM_COMPONENT_HT_MASTER_ORGANIZATION_UPDATE = "HT_MASTER_ORGANIZATION_Update";
private string VKTIM_COMPONENT_HT_MASTER_ORGANIZATION_DELETE = "HT_MASTER_ORGANIZATION_Delete";
#endregion

#region "Public Methods"
public virtual IDataReader HT_MASTER_ORGANIZATION_GetById(int ID)
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_HT_MASTER_ORGANIZATION_GETBYID, ID);
}

public virtual IDataReader HT_MASTER_ORGANIZATION_GetAll()
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_HT_MASTER_ORGANIZATION_GETALL);
}

public virtual DataSet HT_MASTER_ORGANIZATION_GetAll_DS()
{
	return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, VKTIM_COMPONENT_HT_MASTER_ORGANIZATION_GETALL);
}

public virtual object HT_MASTER_ORGANIZATION_Insert(HTMASTERORGANIZATIONInfo objInfo)
{
	return SqlHelper.ExecuteScalar(SqlConnect.ConnectionString, VKTIM_COMPONENT_HT_MASTER_ORGANIZATION_INSERT, DB_GetNull(objInfo.EMPLOYER_ID), DB_GetNull(objInfo.ORGANIZATION_ID), DB_GetNull(objInfo.ORGANIZATION_LEVEL));
}

public virtual int HT_MASTER_ORGANIZATION_Update(HTMASTERORGANIZATIONInfo objInfo)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_HT_MASTER_ORGANIZATION_UPDATE, DB_GetNull(objInfo.ID), DB_GetNull(objInfo.EMPLOYER_ID), DB_GetNull(objInfo.ORGANIZATION_ID), DB_GetNull(objInfo.ORGANIZATION_LEVEL));
}

public virtual int HT_MASTER_ORGANIZATION_Delete(int ID)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_HT_MASTER_ORGANIZATION_DELETE, ID);
}
#endregion

}

}