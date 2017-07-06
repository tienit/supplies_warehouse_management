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

public partial class DTFUNDSController
{

#region "Instances"
private static DTFUNDSController _instance;

protected DTFUNDSController()
{
}

protected void Dispose()
{
	_instance = null;
}

private static object _syncLock = new object();

public static DTFUNDSController Instance()
{
	if (_instance == null) {
		lock (_syncLock) {
			if (_instance == null) {
				_instance = new DTFUNDSController();
			}
		}
	}
	return _instance;
}

#endregion

#region "Public Methods"

public DTFUNDSInfo Insert(DTFUNDSInfo objInfo)
{
	objInfo.ID = Convert.ToInt32(DataProvider.Instance().DT_FUNDS_Insert(objInfo));
	return objInfo;
}

public int Update(DTFUNDSInfo objInfo)
{
	return DataProvider.Instance().DT_FUNDS_Update(objInfo);
}

public int Delete(int ID)
{
	return DataProvider.Instance().DT_FUNDS_Delete(ID);
}

public DTFUNDSInfo GetById(int ID)
{
	return (DTFUNDSInfo)CBO.FillObject(DataProvider.Instance().DT_FUNDS_GetById(ID), typeof(DTFUNDSInfo));
}

public List<DTFUNDSInfo> GetAll()
{
	List<DTFUNDSInfo> list = new List<DTFUNDSInfo>();
	ArrayList arr = CBO.FillCollection(DataProvider.Instance().DT_FUNDS_GetAll(), typeof(DTFUNDSInfo));
	foreach (object objItem in arr)
	{
		list.Add((DTFUNDSInfo)objItem);
	}
	return list;
}

public DataSet GetAll_DS()
{
	return DataProvider.Instance().DT_FUNDS_GetAll_DS();
}

#endregion

}

}