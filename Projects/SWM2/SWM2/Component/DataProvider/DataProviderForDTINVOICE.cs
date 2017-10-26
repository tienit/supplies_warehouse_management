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
private string VKTIM_COMPONENT_DT_INVOICE_GETALL = "DT_INVOICE_SelectAll";
private string VKTIM_COMPONENT_DT_INVOICE_GETBYID = "DT_INVOICE_SelectById";
private string VKTIM_COMPONENT_DT_INVOICE_INSERT = "DT_INVOICE_Insert";
private string VKTIM_COMPONENT_DT_INVOICE_UPDATE = "DT_INVOICE_Update";
private string VKTIM_COMPONENT_DT_INVOICE_DELETE = "DT_INVOICE_Delete";
#endregion

#region "Public Methods"
public virtual IDataReader DT_INVOICE_GetById(int ID)
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_INVOICE_GETBYID, ID);
}

public virtual IDataReader DT_INVOICE_GetAll()
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_INVOICE_GETALL);
}

public virtual DataSet DT_INVOICE_GetAll_DS()
{
	return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_INVOICE_GETALL);
}

public virtual object DT_INVOICE_Insert(DTINVOICEInfo objInfo)
{
	return SqlHelper.ExecuteScalar(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_INVOICE_INSERT, DB_GetNull(objInfo.INPUT_ID), DB_GetNull(objInfo.INVOICE_INPUT), DB_GetNull(objInfo.INVOICE_CODE), DB_GetNull(objInfo.INVOICE_NAME), DB_GetNull(objInfo.INVOICE_NUMBER), DB_GetNull(objInfo.INVOICE_CONTENTS), DB_GetNull(objInfo.DATE_CREATED), DB_GetNull(objInfo.DATE_MODIFILED), DB_GetNull(objInfo.REMARKS), DB_GetNull(objInfo.INVOICE_PATH), DB_GetNull(objInfo.INVOICE_EXT), DB_GetNull(objInfo.INVOICE_IMG));
}

public virtual int DT_INVOICE_Update(DTINVOICEInfo objInfo)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_INVOICE_UPDATE, DB_GetNull(objInfo.ID), DB_GetNull(objInfo.INPUT_ID), DB_GetNull(objInfo.INVOICE_INPUT), DB_GetNull(objInfo.INVOICE_CODE), DB_GetNull(objInfo.INVOICE_NAME), DB_GetNull(objInfo.INVOICE_NUMBER), DB_GetNull(objInfo.INVOICE_CONTENTS), DB_GetNull(objInfo.DATE_CREATED), DB_GetNull(objInfo.DATE_MODIFILED), DB_GetNull(objInfo.REMARKS), DB_GetNull(objInfo.INVOICE_PATH), DB_GetNull(objInfo.INVOICE_EXT), DB_GetNull(objInfo.INVOICE_IMG));
}

public virtual int DT_INVOICE_Delete(int ID)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_INVOICE_DELETE, ID);
}
#endregion

}

}