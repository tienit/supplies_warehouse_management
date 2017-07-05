//*************************************************************
//Author           : Tien NQ
//Created Date     : 9/10/2016
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

public HTUSERnfo Insert(HTUSERnfo objInfo)
{
	objInfo.ID = Convert.ToInt32(DataProvider.Instance().TM_USERS_Insert(objInfo));
	return objInfo;
}

public int Update(HTUSERnfo objInfo)
{
	return DataProvider.Instance().TM_USERS_Update(objInfo);
}

public int Delete(int ID)
{
	return DataProvider.Instance().TM_USERS_Delete(ID);
}

public HTUSERnfo GetById(int ID)
{
	return (HTUSERnfo)CBO.FillObject(DataProvider.Instance().TM_USERS_GetById(ID), typeof(HTUSERnfo));
}

public List<HTUSERnfo> GetAll()
{
	List<HTUSERnfo> list = new List<HTUSERnfo>();
	ArrayList arr = CBO.FillCollection(DataProvider.Instance().TM_USERS_GetAll(), typeof(HTUSERnfo));
	foreach (object objItem in arr)
	{
		list.Add((HTUSERnfo)objItem);
	}
	return list;
}

public DataSet GetAll_DS()
{
	return DataProvider.Instance().TM_USERS_GetAll_DS();
}

#endregion

}

}