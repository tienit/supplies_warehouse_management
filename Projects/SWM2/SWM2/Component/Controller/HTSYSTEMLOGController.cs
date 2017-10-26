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

public partial class HTSYSTEMLOGController
{

#region "Instances"
private static HTSYSTEMLOGController _instance;

protected HTSYSTEMLOGController()
{
}

protected void Dispose()
{
	_instance = null;
}

private static object _syncLock = new object();

public static HTSYSTEMLOGController Instance()
{
	if (_instance == null) {
		lock (_syncLock) {
			if (_instance == null) {
				_instance = new HTSYSTEMLOGController();
			}
		}
	}
	return _instance;
}

#endregion

#region "Public Methods"

public HTSYSTEMLOGInfo Insert(HTSYSTEMLOGInfo objInfo)
{
	objInfo.ID = Convert.ToInt32(DataProvider.Instance().HT_SYSTEM_LOG_Insert(objInfo));
	return objInfo;
}

public int Update(HTSYSTEMLOGInfo objInfo)
{
	return DataProvider.Instance().HT_SYSTEM_LOG_Update(objInfo);
}

public int Delete(int ID)
{
	return DataProvider.Instance().HT_SYSTEM_LOG_Delete(ID);
}

public HTSYSTEMLOGInfo GetById(int ID)
{
	return (HTSYSTEMLOGInfo)CBO.FillObject(DataProvider.Instance().HT_SYSTEM_LOG_GetById(ID), typeof(HTSYSTEMLOGInfo));
}

public List<HTSYSTEMLOGInfo> GetAll()
{
	List<HTSYSTEMLOGInfo> list = new List<HTSYSTEMLOGInfo>();
	ArrayList arr = CBO.FillCollection(DataProvider.Instance().HT_SYSTEM_LOG_GetAll(), typeof(HTSYSTEMLOGInfo));
	foreach (object objItem in arr)
	{
		list.Add((HTSYSTEMLOGInfo)objItem);
	}
	return list;
}

public DataSet GetAll_DS()
{
	return DataProvider.Instance().HT_SYSTEM_LOG_GetAll_DS();
}

#endregion

}

}