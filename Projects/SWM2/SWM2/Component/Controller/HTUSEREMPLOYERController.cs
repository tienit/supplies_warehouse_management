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

public partial class HTUSEREMPLOYERController
{

#region "Instances"
private static HTUSEREMPLOYERController _instance;

protected HTUSEREMPLOYERController()
{
}

protected void Dispose()
{
	_instance = null;
}

private static object _syncLock = new object();

public static HTUSEREMPLOYERController Instance()
{
	if (_instance == null) {
		lock (_syncLock) {
			if (_instance == null) {
				_instance = new HTUSEREMPLOYERController();
			}
		}
	}
	return _instance;
}

#endregion

#region "Public Methods"

public HTUSEREMPLOYERInfo Insert(HTUSEREMPLOYERInfo objInfo)
{
	objInfo.ID = Convert.ToInt32(DataProvider.Instance().HT_USER_EMPLOYER_Insert(objInfo));
	return objInfo;
}

public int Update(HTUSEREMPLOYERInfo objInfo)
{
	return DataProvider.Instance().HT_USER_EMPLOYER_Update(objInfo);
}

public int Delete(int ID)
{
	return DataProvider.Instance().HT_USER_EMPLOYER_Delete(ID);
}

public HTUSEREMPLOYERInfo GetById(int ID)
{
	return (HTUSEREMPLOYERInfo)CBO.FillObject(DataProvider.Instance().HT_USER_EMPLOYER_GetById(ID), typeof(HTUSEREMPLOYERInfo));
}

public List<HTUSEREMPLOYERInfo> GetAll()
{
	List<HTUSEREMPLOYERInfo> list = new List<HTUSEREMPLOYERInfo>();
	ArrayList arr = CBO.FillCollection(DataProvider.Instance().HT_USER_EMPLOYER_GetAll(), typeof(HTUSEREMPLOYERInfo));
	foreach (object objItem in arr)
	{
		list.Add((HTUSEREMPLOYERInfo)objItem);
	}
	return list;
}

public DataSet GetAll_DS()
{
	return DataProvider.Instance().HT_USER_EMPLOYER_GetAll_DS();
}

#endregion

}

}