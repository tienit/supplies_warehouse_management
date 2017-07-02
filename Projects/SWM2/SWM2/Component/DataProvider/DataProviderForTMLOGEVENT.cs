//*************************************************************
//Author           : Tien NQ
//Created Date     : 20/03/2014
//Comment          : Base class for access to database.
//History          : 
//*************************************************************

using tienit.core;
using System.Data;

namespace VKTIM.Component
{

public partial class DataProvider : CommonDataProvider
{

#region "Stored Procedure Name"
private string BUHINSOKO_COMPONENT_TM_LOG_EVENT_GETALL = "TM_LOG_EVENT_SelectAll";
private string BUHINSOKO_COMPONENT_TM_LOG_EVENT_GETBYID = "TM_LOG_EVENT_SelectById";
private string BUHINSOKO_COMPONENT_TM_LOG_EVENT_INSERT = "TM_LOG_EVENT_Insert";
private string BUHINSOKO_COMPONENT_TM_LOG_EVENT_UPDATE = "TM_LOG_EVENT_Update";
private string BUHINSOKO_COMPONENT_TM_LOG_EVENT_DELETE = "TM_LOG_EVENT_Delete";
#endregion

#region "Public Methods"
public virtual IDataReader TM_LOG_EVENT_GetById(int ID)
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, BUHINSOKO_COMPONENT_TM_LOG_EVENT_GETBYID, ID);
}

public virtual IDataReader TM_LOG_EVENT_GetAll()
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, BUHINSOKO_COMPONENT_TM_LOG_EVENT_GETALL);
}

public virtual DataSet TM_LOG_EVENT_GetAll_DS()
{
	return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, BUHINSOKO_COMPONENT_TM_LOG_EVENT_GETALL);
}

public virtual object TM_LOG_EVENT_Insert(TMLOGEVENTInfo objInfo)
{
	return SqlHelper.ExecuteScalar(SqlConnect.ConnectionString, BUHINSOKO_COMPONENT_TM_LOG_EVENT_INSERT, DB_GetNull(objInfo.CHR_CONTENT), DB_GetNull(objInfo.CHR_TYPE), DB_GetNull(objInfo.DAT_CREATED), DB_GetNull(objInfo.INT_USER_ID), DB_GetNull(objInfo.CHR_USERNAME), DB_GetNull(objInfo.INT_USERGROUP_ID), DB_GetNull(objInfo.INT_FACTORY_ID), DB_GetNull(objInfo.CHR_FACTORY_NAME), DB_GetNull(objInfo.CHR_REMARK));
}

public virtual void TM_LOG_EVENT_Update(TMLOGEVENTInfo objInfo)
{
	SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, BUHINSOKO_COMPONENT_TM_LOG_EVENT_UPDATE, DB_GetNull(objInfo.ID), DB_GetNull(objInfo.CHR_CONTENT), DB_GetNull(objInfo.CHR_TYPE), DB_GetNull(objInfo.DAT_CREATED), DB_GetNull(objInfo.INT_USER_ID), DB_GetNull(objInfo.CHR_USERNAME), DB_GetNull(objInfo.INT_USERGROUP_ID), DB_GetNull(objInfo.INT_FACTORY_ID), DB_GetNull(objInfo.CHR_FACTORY_NAME), DB_GetNull(objInfo.CHR_REMARK));
}

public virtual void TM_LOG_EVENT_Delete(int ID)
{
	SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, BUHINSOKO_COMPONENT_TM_LOG_EVENT_DELETE, ID);
}
#endregion

}

}