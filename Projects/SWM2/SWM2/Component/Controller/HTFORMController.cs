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

public partial class HTFORMController
{

#region "Instances"
private static HTFORMController _instance;

protected HTFORMController()
{
}

protected void Dispose()
{
	_instance = null;
}

private static object _syncLock = new object();

public static HTFORMController Instance()
{
	if (_instance == null) {
		lock (_syncLock) {
			if (_instance == null) {
				_instance = new HTFORMController();
			}
		}
	}
	return _instance;
}

#endregion

#region "Public Methods"

public HTFORMInfo Insert(HTFORMInfo objInfo)
{
	objInfo.ID = Convert.ToInt32(DataProvider.Instance().HT_FORM_Insert(objInfo));
	return objInfo;
}

public int Update(HTFORMInfo objInfo)
{
	return DataProvider.Instance().HT_FORM_Update(objInfo);
}

public int Delete(int ID)
{
	return DataProvider.Instance().HT_FORM_Delete(ID);
}

public HTFORMInfo GetById(int ID)
{
	return (HTFORMInfo)CBO.FillObject(DataProvider.Instance().HT_FORM_GetById(ID), typeof(HTFORMInfo));
}

public List<HTFORMInfo> GetAll()
{
	List<HTFORMInfo> list = new List<HTFORMInfo>();
	ArrayList arr = CBO.FillCollection(DataProvider.Instance().HT_FORM_GetAll(), typeof(HTFORMInfo));
	foreach (object objItem in arr)
	{
		list.Add((HTFORMInfo)objItem);
	}
	return list;
}

public DataSet GetAll_DS()
{
	return DataProvider.Instance().HT_FORM_GetAll_DS();
}

#endregion

}

}