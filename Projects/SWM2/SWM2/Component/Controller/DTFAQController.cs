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

public partial class DTFAQController
{

#region "Instances"
private static DTFAQController _instance;

protected DTFAQController()
{
}

protected void Dispose()
{
	_instance = null;
}

private static object _syncLock = new object();

public static DTFAQController Instance()
{
	if (_instance == null) {
		lock (_syncLock) {
			if (_instance == null) {
				_instance = new DTFAQController();
			}
		}
	}
	return _instance;
}

#endregion

#region "Public Methods"

public DTFAQInfo Insert(DTFAQInfo objInfo)
{
	objInfo.ID = Convert.ToInt32(DataProvider.Instance().DT_FAQ_Insert(objInfo));
	return objInfo;
}

public int Update(DTFAQInfo objInfo)
{
	return DataProvider.Instance().DT_FAQ_Update(objInfo);
}

public int Delete(int ID)
{
	return DataProvider.Instance().DT_FAQ_Delete(ID);
}

public DTFAQInfo GetById(int ID)
{
	return (DTFAQInfo)CBO.FillObject(DataProvider.Instance().DT_FAQ_GetById(ID), typeof(DTFAQInfo));
}

public List<DTFAQInfo> GetAll()
{
	List<DTFAQInfo> list = new List<DTFAQInfo>();
	ArrayList arr = CBO.FillCollection(DataProvider.Instance().DT_FAQ_GetAll(), typeof(DTFAQInfo));
	foreach (object objItem in arr)
	{
		list.Add((DTFAQInfo)objItem);
	}
	return list;
}

public DataSet GetAll_DS()
{
	return DataProvider.Instance().DT_FAQ_GetAll_DS();
}

#endregion

}

}