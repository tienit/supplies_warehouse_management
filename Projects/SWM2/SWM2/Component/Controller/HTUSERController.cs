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

public partial class HTUSERController
{

#region "Instances"
private static HTUSERController _instance;

protected HTUSERController()
{
}

protected void Dispose()
{
	_instance = null;
}

private static object _syncLock = new object();

public static HTUSERController Instance()
{
	if (_instance == null) {
		lock (_syncLock) {
			if (_instance == null) {
				_instance = new HTUSERController();
			}
		}
	}
	return _instance;
}

#endregion

#region "Public Methods"

public HTUSERInfo Insert(HTUSERInfo objInfo)
{
	objInfo.ID = Convert.ToInt32(DataProvider.Instance().HT_USER_Insert(objInfo));
	return objInfo;
}

public int Update(HTUSERInfo objInfo)
{
	return DataProvider.Instance().HT_USER_Update(objInfo);
}

public int Delete(int ID)
{
	return DataProvider.Instance().HT_USER_Delete(ID);
}

public HTUSERInfo GetById(int ID)
{
	return (HTUSERInfo)CBO.FillObject(DataProvider.Instance().HT_USER_GetById(ID), typeof(HTUSERInfo));
}

public List<HTUSERInfo> GetAll()
{
	List<HTUSERInfo> list = new List<HTUSERInfo>();
	ArrayList arr = CBO.FillCollection(DataProvider.Instance().HT_USER_GetAll(), typeof(HTUSERInfo));
	foreach (object objItem in arr)
	{
		list.Add((HTUSERInfo)objItem);
	}
	return list;
}

public DataSet GetAll_DS()
{
	return DataProvider.Instance().HT_USER_GetAll_DS();
}

#endregion

}

}