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

public partial class HTROLEFORMController
{

#region "Instances"
private static HTROLEFORMController _instance;

protected HTROLEFORMController()
{
}

protected void Dispose()
{
	_instance = null;
}

private static object _syncLock = new object();

public static HTROLEFORMController Instance()
{
	if (_instance == null) {
		lock (_syncLock) {
			if (_instance == null) {
				_instance = new HTROLEFORMController();
			}
		}
	}
	return _instance;
}

#endregion

#region "Public Methods"

public HTROLEFORMInfo Insert(HTROLEFORMInfo objInfo)
{
	objInfo.ID = Convert.ToInt32(DataProvider.Instance().HT_ROLE_FORM_Insert(objInfo));
	return objInfo;
}

public int Update(HTROLEFORMInfo objInfo)
{
	return DataProvider.Instance().HT_ROLE_FORM_Update(objInfo);
}

public int Delete(int ID)
{
	return DataProvider.Instance().HT_ROLE_FORM_Delete(ID);
}

public HTROLEFORMInfo GetById(int ID)
{
	return (HTROLEFORMInfo)CBO.FillObject(DataProvider.Instance().HT_ROLE_FORM_GetById(ID), typeof(HTROLEFORMInfo));
}

public List<HTROLEFORMInfo> GetAll()
{
	List<HTROLEFORMInfo> list = new List<HTROLEFORMInfo>();
	ArrayList arr = CBO.FillCollection(DataProvider.Instance().HT_ROLE_FORM_GetAll(), typeof(HTROLEFORMInfo));
	foreach (object objItem in arr)
	{
		list.Add((HTROLEFORMInfo)objItem);
	}
	return list;
}

public DataSet GetAll_DS()
{
	return DataProvider.Instance().HT_ROLE_FORM_GetAll_DS();
}

#endregion

}

}