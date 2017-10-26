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

public partial class DMPRODUCTCATEGORYController
{

#region "Instances"
private static DMPRODUCTCATEGORYController _instance;

protected DMPRODUCTCATEGORYController()
{
}

protected void Dispose()
{
	_instance = null;
}

private static object _syncLock = new object();

public static DMPRODUCTCATEGORYController Instance()
{
	if (_instance == null) {
		lock (_syncLock) {
			if (_instance == null) {
				_instance = new DMPRODUCTCATEGORYController();
			}
		}
	}
	return _instance;
}

#endregion

#region "Public Methods"

public DMPRODUCTCATEGORYInfo Insert(DMPRODUCTCATEGORYInfo objInfo)
{
	objInfo.ID = Convert.ToInt32(DataProvider.Instance().DM_PRODUCTCATEGORY_Insert(objInfo));
	return objInfo;
}

public int Update(DMPRODUCTCATEGORYInfo objInfo)
{
	return DataProvider.Instance().DM_PRODUCTCATEGORY_Update(objInfo);
}

public int Delete(int ID)
{
	return DataProvider.Instance().DM_PRODUCTCATEGORY_Delete(ID);
}

public DMPRODUCTCATEGORYInfo GetById(int ID)
{
	return (DMPRODUCTCATEGORYInfo)CBO.FillObject(DataProvider.Instance().DM_PRODUCTCATEGORY_GetById(ID), typeof(DMPRODUCTCATEGORYInfo));
}

public List<DMPRODUCTCATEGORYInfo> GetAll()
{
	List<DMPRODUCTCATEGORYInfo> list = new List<DMPRODUCTCATEGORYInfo>();
	ArrayList arr = CBO.FillCollection(DataProvider.Instance().DM_PRODUCTCATEGORY_GetAll(), typeof(DMPRODUCTCATEGORYInfo));
	foreach (object objItem in arr)
	{
		list.Add((DMPRODUCTCATEGORYInfo)objItem);
	}
	return list;
}

public DataSet GetAll_DS()
{
	return DataProvider.Instance().DM_PRODUCTCATEGORY_GetAll_DS();
}

#endregion

}

}