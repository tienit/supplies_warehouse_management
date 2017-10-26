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

public partial class DMUNITController
{

#region "Instances"
private static DMUNITController _instance;

protected DMUNITController()
{
}

protected void Dispose()
{
	_instance = null;
}

private static object _syncLock = new object();

public static DMUNITController Instance()
{
	if (_instance == null) {
		lock (_syncLock) {
			if (_instance == null) {
				_instance = new DMUNITController();
			}
		}
	}
	return _instance;
}

#endregion

#region "Public Methods"

public DMUNITInfo Insert(DMUNITInfo objInfo)
{
	objInfo.ID = Convert.ToInt32(DataProvider.Instance().DM_UNIT_Insert(objInfo));
	return objInfo;
}

public int Update(DMUNITInfo objInfo)
{
	return DataProvider.Instance().DM_UNIT_Update(objInfo);
}

public int Delete(int ID)
{
	return DataProvider.Instance().DM_UNIT_Delete(ID);
}

public DMUNITInfo GetById(int ID)
{
	return (DMUNITInfo)CBO.FillObject(DataProvider.Instance().DM_UNIT_GetById(ID), typeof(DMUNITInfo));
}

public List<DMUNITInfo> GetAll()
{
	List<DMUNITInfo> list = new List<DMUNITInfo>();
	ArrayList arr = CBO.FillCollection(DataProvider.Instance().DM_UNIT_GetAll(), typeof(DMUNITInfo));
	foreach (object objItem in arr)
	{
		list.Add((DMUNITInfo)objItem);
	}
	return list;
}

public DataSet GetAll_DS()
{
	return DataProvider.Instance().DM_UNIT_GetAll_DS();
}

#endregion

}

}