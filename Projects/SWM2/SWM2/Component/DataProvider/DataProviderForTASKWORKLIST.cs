//*************************************************************
//Author           : Tien NQ
//Created Date     : 8/22/2017
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
private string VKTIM_COMPONENT_TASK_WORKLIST_GETALL = "TASK_WORKLIST_SelectAll";
private string VKTIM_COMPONENT_TASK_WORKLIST_GETBYID = "TASK_WORKLIST_SelectById";
private string VKTIM_COMPONENT_TASK_WORKLIST_INSERT = "TASK_WORKLIST_Insert";
private string VKTIM_COMPONENT_TASK_WORKLIST_UPDATE = "TASK_WORKLIST_Update";
private string VKTIM_COMPONENT_TASK_WORKLIST_DELETE = "TASK_WORKLIST_Delete";
#endregion

#region "Public Methods"
public virtual IDataReader TASK_WORKLIST_GetById(int ID)
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_TASK_WORKLIST_GETBYID, ID);
}

public virtual IDataReader TASK_WORKLIST_GetAll()
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_TASK_WORKLIST_GETALL);
}

public virtual DataSet TASK_WORKLIST_GetAll_DS()
{
	return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, VKTIM_COMPONENT_TASK_WORKLIST_GETALL);
}

public virtual int TASK_WORKLIST_Insert(TASKWORKLISTInfo objInfo)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_TASK_WORKLIST_INSERT, DB_GetNull(objInfo.ID), DB_GetNull(objInfo.CODE), DB_GetNull(objInfo.CONTENTS), DB_GetNull(objInfo.CONTROL), DB_GetNull(objInfo.STARTDATE), DB_GetNull(objInfo.ENDDATE), DB_GetNull(objInfo.STATUS), DB_GetNull(objInfo.FINISHED), DB_GetNull(objInfo.REMARKS));
}

public virtual int TASK_WORKLIST_Update(TASKWORKLISTInfo objInfo)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_TASK_WORKLIST_UPDATE, DB_GetNull(objInfo.ID), DB_GetNull(objInfo.CODE), DB_GetNull(objInfo.CONTENTS), DB_GetNull(objInfo.CONTROL), DB_GetNull(objInfo.STARTDATE), DB_GetNull(objInfo.ENDDATE), DB_GetNull(objInfo.STATUS), DB_GetNull(objInfo.FINISHED), DB_GetNull(objInfo.REMARKS));
}

public virtual int TASK_WORKLIST_Delete(int ID)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_TASK_WORKLIST_DELETE, ID);
}
#endregion

}

}