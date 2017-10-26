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
private string VKTIM_COMPONENT_DT_PRICEHISTORY_GETALL = "DT_PRICEHISTORY_SelectAll";
private string VKTIM_COMPONENT_DT_PRICEHISTORY_GETBYID = "DT_PRICEHISTORY_SelectById";
private string VKTIM_COMPONENT_DT_PRICEHISTORY_INSERT = "DT_PRICEHISTORY_Insert";
private string VKTIM_COMPONENT_DT_PRICEHISTORY_UPDATE = "DT_PRICEHISTORY_Update";
private string VKTIM_COMPONENT_DT_PRICEHISTORY_DELETE = "DT_PRICEHISTORY_Delete";
#endregion

#region "Public Methods"
public virtual IDataReader DT_PRICEHISTORY_GetById(int ID)
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_PRICEHISTORY_GETBYID, ID);
}

public virtual IDataReader DT_PRICEHISTORY_GetAll()
{
	return SqlHelper.ExecuteReader(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_PRICEHISTORY_GETALL);
}

public virtual DataSet DT_PRICEHISTORY_GetAll_DS()
{
	return SqlHelper.ExecuteDataset(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_PRICEHISTORY_GETALL);
}

public virtual object DT_PRICEHISTORY_Insert(DTPRICEHISTORYInfo objInfo)
{
	return SqlHelper.ExecuteScalar(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_PRICEHISTORY_INSERT, DB_GetNull(objInfo.PRODUCT_ID), DB_GetNull(objInfo.PRICE_VALUE), DB_GetNull(objInfo.PRICE_ID));
}

public virtual int DT_PRICEHISTORY_Update(DTPRICEHISTORYInfo objInfo)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_PRICEHISTORY_UPDATE, DB_GetNull(objInfo.ID), DB_GetNull(objInfo.PRODUCT_ID), DB_GetNull(objInfo.PRICE_VALUE), DB_GetNull(objInfo.PRICE_ID));
}

public virtual int DT_PRICEHISTORY_Delete(int ID)
{
	return SqlHelper.ExecuteNonQuery(SqlConnect.ConnectionString, VKTIM_COMPONENT_DT_PRICEHISTORY_DELETE, ID);
}
#endregion

}

}