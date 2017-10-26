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
private string VKTIM_COMPONENT_DM_OUTPUTTYPE_GETALL = "DM_OUTPUTTYPE_SelectAll";
private string VKTIM_COMPONENT_DM_OUTPUTTYPE_GETBYID = "DM_OUTPUTTYPE_SelectById";
private string VKTIM_COMPONENT_DM_OUTPUTTYPE_INSERT = "DM_OUTPUTTYPE_Insert";
private string VKTIM_COMPONENT_DM_OUTPUTTYPE_UPDATE = "DM_OUTPUTTYPE_Update";
private string VKTIM_COMPONENT_DM_OUTPUTTYPE_DELETE = "DM_OUTPUTTYPE_Delete";
#endregion

#region "Public Methods"
public virtual IDataReader DM_OUTPUTTYPE_GetById(int ID)
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_OUTPUTTYPE_GETBYID, ID);
}

public virtual IDataReader DM_OUTPUTTYPE_GetAll()
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_OUTPUTTYPE_GETALL);
}

public virtual DataSet DM_OUTPUTTYPE_GetAll_DS()
{
	return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_OUTPUTTYPE_GETALL);
}

public virtual object DM_OUTPUTTYPE_Insert(DMOUTPUTTYPEInfo objInfo)
{
	return SqlHelper.ExecuteScalar(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_OUTPUTTYPE_INSERT, DB_GetNull(objInfo.OUTPUTTYPE_NAME), DB_GetNull(objInfo.ISUSED));
}

public virtual int DM_OUTPUTTYPE_Update(DMOUTPUTTYPEInfo objInfo)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_OUTPUTTYPE_UPDATE, DB_GetNull(objInfo.ID), DB_GetNull(objInfo.OUTPUTTYPE_NAME), DB_GetNull(objInfo.ISUSED));
}

public virtual int DM_OUTPUTTYPE_Delete(int ID)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_DM_OUTPUTTYPE_DELETE, ID);
}
#endregion

}

}