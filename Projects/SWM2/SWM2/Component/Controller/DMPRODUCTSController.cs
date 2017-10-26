//*************************************************************
//Author           : Tien NQ
//Created Date     : 10/26/2017
//Comment          : Base class for access to database.
//History          : 
//*************************************************************

using tienit.core;
using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;

namespace VKTIM.Component
{

public partial class DMPRODUCTSController
{

#region "Instances"
private static DMPRODUCTSController _instance;

protected DMPRODUCTSController()
{
}

protected void Dispose()
{
	_instance = null;
}

private static object _syncLock = new object();

public static DMPRODUCTSController Instance()
{
	if (_instance == null) {
		lock (_syncLock) {
			if (_instance == null) {
				_instance = new DMPRODUCTSController();
			}
		}
	}
	return _instance;
}

#endregion

#region "Public Methods"

public DMPRODUCTSInfo Insert(DMPRODUCTSInfo objInfo)
{
	objInfo.ID = Convert.ToInt32(DataProvider.Instance().DM_PRODUCTS_Insert(objInfo));
	return objInfo;
}

public int Update(DMPRODUCTSInfo objInfo)
{
	return DataProvider.Instance().DM_PRODUCTS_Update(objInfo);
}

public int Delete(int ID)
{
	return DataProvider.Instance().DM_PRODUCTS_Delete(ID);
}

public DMPRODUCTSInfo GetById(int ID)
{
	return (DMPRODUCTSInfo)CBO.FillObject(DataProvider.Instance().DM_PRODUCTS_GetById(ID), typeof(DMPRODUCTSInfo));
}

public List<DMPRODUCTSInfo> GetAll()
{
	List<DMPRODUCTSInfo> list = new List<DMPRODUCTSInfo>();
	ArrayList arr = CBO.FillCollection(DataProvider.Instance().DM_PRODUCTS_GetAll(), typeof(DMPRODUCTSInfo));
	foreach (object objItem in arr)
	{
		list.Add((DMPRODUCTSInfo)objItem);
	}
	return list;
}

public DataSet GetAll_DS()
{
	return DataProvider.Instance().DM_PRODUCTS_GetAll_DS();
}

#endregion

}

}