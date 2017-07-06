//*************************************************************
//Author           : Tien NQ
//Created Date     : 7/7/2017
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

public partial class HTROLEController
{

#region "Instances"
private static HTROLEController _instance;

protected HTROLEController()
{
}

protected void Dispose()
{
	_instance = null;
}

private static object _syncLock = new object();

public static HTROLEController Instance()
{
	if (_instance == null) {
		lock (_syncLock) {
			if (_instance == null) {
				_instance = new HTROLEController();
			}
		}
	}
	return _instance;
}

#endregion

#region "Public Methods"

public HTROLEInfo Insert(HTROLEInfo objInfo)
{
	objInfo.ID = Convert.ToInt32(DataProvider.Instance().HT_ROLE_Insert(objInfo));
	return objInfo;
}

public int Update(HTROLEInfo objInfo)
{
	return DataProvider.Instance().HT_ROLE_Update(objInfo);
}

public int Delete(int ID)
{
	return DataProvider.Instance().HT_ROLE_Delete(ID);
}

public HTROLEInfo GetById(int ID)
{
	return (HTROLEInfo)CBO.FillObject(DataProvider.Instance().HT_ROLE_GetById(ID), typeof(HTROLEInfo));
}

public List<HTROLEInfo> GetAll()
{
	List<HTROLEInfo> list = new List<HTROLEInfo>();
	ArrayList arr = CBO.FillCollection(DataProvider.Instance().HT_ROLE_GetAll(), typeof(HTROLEInfo));
	foreach (object objItem in arr)
	{
		list.Add((HTROLEInfo)objItem);
	}
	return list;
}

public DataSet GetAll_DS()
{
	return DataProvider.Instance().HT_ROLE_GetAll_DS();
}

#endregion

}

}