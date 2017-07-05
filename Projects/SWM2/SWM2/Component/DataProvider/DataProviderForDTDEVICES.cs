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
private string BUHINSOKO_COMPONENT_DT_DEVICES_GETALL = "TM_LOG_EVENT_SelectAll";
private string BUHINSOKO_COMPONENT_DT_DEVICES_GETBYID = "TM_LOG_EVENT_SelectById";
private string BUHINSOKO_COMPONENT_DT_DEVICES_INSERT = "TM_LOG_EVENT_Insert";
private string BUHINSOKO_COMPONENT_DT_DEVICES_UPDATE = "TM_LOG_EVENT_Update";
private string BUHINSOKO_COMPONENT_DT_DEVICES_DELETE = "TM_LOG_EVENT_Delete";
#endregion

#region "Public Methods"
public virtual IDataReader DT_DEVICES_GetById(int ID)
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, BUHINSOKO_COMPONENT_DT_DEVICES_GETBYID, ID);
}

public virtual IDataReader DT_DEVICES_GetAll()
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, BUHINSOKO_COMPONENT_DT_DEVICES_GETALL);
}

public virtual DataSet DT_DEVICES_GetAll_DS()
{
	return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, BUHINSOKO_COMPONENT_TM_LOG_EVENT_GETALL);
}

public virtual object DT_DEVICES_Insert(DTDEVICESInfo objInfo)
{
            return null;
}

public virtual void DT_DEVICES_Update(DTDEVICESInfo objInfo)
{
	
}

public virtual void DT_DEVICES_Delete(int ID)
{
	SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, BUHINSOKO_COMPONENT_TM_LOG_EVENT_DELETE, ID);
}
#endregion

}

}