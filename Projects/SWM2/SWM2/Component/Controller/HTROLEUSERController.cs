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

public partial class HTROLEUSERController
{

#region "Instances"
private static HTROLEUSERController _instance;

protected HTROLEUSERController()
{
}

protected void Dispose()
{
	_instance = null;
}

private static object _syncLock = new object();

public static HTROLEUSERController Instance()
{
	if (_instance == null) {
		lock (_syncLock) {
			if (_instance == null) {
				_instance = new HTROLEUSERController();
			}
		}
	}
	return _instance;
}

#endregion

#region "Public Methods"

public HTROLEUSERInfo Insert(HTROLEUSERInfo objInfo)
{
	objInfo.ID = Convert.ToInt32(DataProvider.Instance().HT_ROLE_USER_Insert(objInfo));
	return objInfo;
}

public int Update(HTROLEUSERInfo objInfo)
{
	return DataProvider.Instance().HT_ROLE_USER_Update(objInfo);
}

public int Delete(int ID)
{
	return DataProvider.Instance().HT_ROLE_USER_Delete(ID);
}

public HTROLEUSERInfo GetById(int ID)
{
	return (HTROLEUSERInfo)CBO.FillObject(DataProvider.Instance().HT_ROLE_USER_GetById(ID), typeof(HTROLEUSERInfo));
}

public List<HTROLEUSERInfo> GetAll()
{
	List<HTROLEUSERInfo> list = new List<HTROLEUSERInfo>();
	ArrayList arr = CBO.FillCollection(DataProvider.Instance().HT_ROLE_USER_GetAll(), typeof(HTROLEUSERInfo));
	foreach (object objItem in arr)
	{
		list.Add((HTROLEUSERInfo)objItem);
	}
	return list;
}

public DataSet GetAll_DS()
{
	return DataProvider.Instance().HT_ROLE_USER_GetAll_DS();
}

#endregion

}

}