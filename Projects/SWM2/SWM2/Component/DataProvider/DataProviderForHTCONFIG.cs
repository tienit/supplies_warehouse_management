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
private string BUHINSOKO_COMPONENT_HT_CONFIG_GETALL = "TM_LOG_EVENT_SelectAll";
private string BUHINSOKO_COMPONENT_HT_CONFIG_GETBYID = "TM_LOG_EVENT_SelectById";
private string BUHINSOKO_COMPONENT_HT_CONFIG_INSERT = "TM_LOG_EVENT_Insert";
private string BUHINSOKO_COMPONENT_HT_CONFIG_UPDATE = "TM_LOG_EVENT_Update";
private string BUHINSOKO_COMPONENT_HT_CONFIG_DELETE = "TM_LOG_EVENT_Delete";
#endregion

#region "Public Methods"
public virtual IDataReader HT_CONFIG_GetById(int ID)
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, BUHINSOKO_COMPONENT_TM_LOG_EVENT_GETBYID, ID);
}

public virtual IDataReader HT_CONFIG_GetAll()
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, BUHINSOKO_COMPONENT_TM_LOG_EVENT_GETALL);
}

public virtual DataSet HT_CONFIG_GetAll_DS()
{
	return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, BUHINSOKO_COMPONENT_TM_LOG_EVENT_GETALL);
}

public virtual object HT_CONFIG_Insert(HTCONFIGInfo objInfo)
{
            return null;
}

public virtual void HT_CONFIG_Update(HTCONFIGInfo objInfo)
{
	
}

public virtual void HT_CONFIG_Delete(int ID)
{
	SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, BUHINSOKO_COMPONENT_TM_LOG_EVENT_DELETE, ID);
}
#endregion

}

}