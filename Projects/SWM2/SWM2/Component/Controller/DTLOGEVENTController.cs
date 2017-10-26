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

public partial class DTLOGEVENTController
{

#region "Instances"
private static DTLOGEVENTController _instance;

protected DTLOGEVENTController()
{
}

protected void Dispose()
{
	_instance = null;
}

private static object _syncLock = new object();

public static DTLOGEVENTController Instance()
{
	if (_instance == null) {
		lock (_syncLock) {
			if (_instance == null) {
				_instance = new DTLOGEVENTController();
			}
		}
	}
	return _instance;
}

#endregion

#region "Public Methods"

public DTLOGEVENTInfo Insert(DTLOGEVENTInfo objInfo)
{
	objInfo.ID = Convert.ToInt32(DataProvider.Instance().DT_LOG_EVENT_Insert(objInfo));
	return objInfo;
}

public int Update(DTLOGEVENTInfo objInfo)
{
	return DataProvider.Instance().DT_LOG_EVENT_Update(objInfo);
}

public int Delete(int ID)
{
	return DataProvider.Instance().DT_LOG_EVENT_Delete(ID);
}

public DTLOGEVENTInfo GetById(int ID)
{
	return (DTLOGEVENTInfo)CBO.FillObject(DataProvider.Instance().DT_LOG_EVENT_GetById(ID), typeof(DTLOGEVENTInfo));
}

public List<DTLOGEVENTInfo> GetAll()
{
	List<DTLOGEVENTInfo> list = new List<DTLOGEVENTInfo>();
	ArrayList arr = CBO.FillCollection(DataProvider.Instance().DT_LOG_EVENT_GetAll(), typeof(DTLOGEVENTInfo));
	foreach (object objItem in arr)
	{
		list.Add((DTLOGEVENTInfo)objItem);
	}
	return list;
}

public DataSet GetAll_DS()
{
	return DataProvider.Instance().DT_LOG_EVENT_GetAll_DS();
}

#endregion

}

}