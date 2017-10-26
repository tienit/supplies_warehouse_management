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

public partial class DTDEVICESController
{

#region "Instances"
private static DTDEVICESController _instance;

protected DTDEVICESController()
{
}

protected void Dispose()
{
	_instance = null;
}

private static object _syncLock = new object();

public static DTDEVICESController Instance()
{
	if (_instance == null) {
		lock (_syncLock) {
			if (_instance == null) {
				_instance = new DTDEVICESController();
			}
		}
	}
	return _instance;
}

#endregion

#region "Public Methods"

public DTDEVICESInfo Insert(DTDEVICESInfo objInfo)
{
	objInfo.ID = Convert.ToInt32(DataProvider.Instance().DT_DEVICES_Insert(objInfo));
	return objInfo;
}

public int Update(DTDEVICESInfo objInfo)
{
	return DataProvider.Instance().DT_DEVICES_Update(objInfo);
}

public int Delete(int ID)
{
	return DataProvider.Instance().DT_DEVICES_Delete(ID);
}

public DTDEVICESInfo GetById(int ID)
{
	return (DTDEVICESInfo)CBO.FillObject(DataProvider.Instance().DT_DEVICES_GetById(ID), typeof(DTDEVICESInfo));
}

public List<DTDEVICESInfo> GetAll()
{
	List<DTDEVICESInfo> list = new List<DTDEVICESInfo>();
	ArrayList arr = CBO.FillCollection(DataProvider.Instance().DT_DEVICES_GetAll(), typeof(DTDEVICESInfo));
	foreach (object objItem in arr)
	{
		list.Add((DTDEVICESInfo)objItem);
	}
	return list;
}

public DataSet GetAll_DS()
{
	return DataProvider.Instance().DT_DEVICES_GetAll_DS();
}

#endregion

}

}