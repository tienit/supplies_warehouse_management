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
private string VKTIM_COMPONENT_HT_USER_EMPLOYER_GETALL = "HT_USER_EMPLOYER_SelectAll";
private string VKTIM_COMPONENT_HT_USER_EMPLOYER_GETBYID = "HT_USER_EMPLOYER_SelectById";
private string VKTIM_COMPONENT_HT_USER_EMPLOYER_INSERT = "HT_USER_EMPLOYER_Insert";
private string VKTIM_COMPONENT_HT_USER_EMPLOYER_UPDATE = "HT_USER_EMPLOYER_Update";
private string VKTIM_COMPONENT_HT_USER_EMPLOYER_DELETE = "HT_USER_EMPLOYER_Delete";
#endregion

#region "Public Methods"
public virtual IDataReader HT_USER_EMPLOYER_GetById(int ID)
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_HT_USER_EMPLOYER_GETBYID, ID);
}

public virtual IDataReader HT_USER_EMPLOYER_GetAll()
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_HT_USER_EMPLOYER_GETALL);
}

public virtual DataSet HT_USER_EMPLOYER_GetAll_DS()
{
	return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, VKTIM_COMPONENT_HT_USER_EMPLOYER_GETALL);
}

public virtual object HT_USER_EMPLOYER_Insert(HTUSEREMPLOYERInfo objInfo)
{
	return SqlHelper.ExecuteScalar(SqlConnect.ConnectionString, VKTIM_COMPONENT_HT_USER_EMPLOYER_INSERT, DB_GetNull(objInfo.USER_ID), DB_GetNull(objInfo.EMPLOYER_ID));
}

public virtual int HT_USER_EMPLOYER_Update(HTUSEREMPLOYERInfo objInfo)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_HT_USER_EMPLOYER_UPDATE, DB_GetNull(objInfo.ID), DB_GetNull(objInfo.USER_ID), DB_GetNull(objInfo.EMPLOYER_ID));
}

public virtual int HT_USER_EMPLOYER_Delete(int ID)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_HT_USER_EMPLOYER_DELETE, ID);
}
#endregion

}

}