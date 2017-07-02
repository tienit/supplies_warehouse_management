//*************************************************************
//Author           : Tien NQ
//Created Date     : 20/03/2014
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

public partial class TMLOGEVENTController
{

#region "Instances"
private static TMLOGEVENTController _instance;

protected TMLOGEVENTController()
{
}

protected void Dispose()
{
	_instance = null;
}

private static object _syncLock = new object();

public static TMLOGEVENTController Instance()
{
	if (_instance == null) {
		lock (_syncLock) {
			if (_instance == null) {
				_instance = new TMLOGEVENTController();
			}
		}
	}
	return _instance;
}

#endregion

#region "Public Methods"

public TMLOGEVENTInfo Insert(TMLOGEVENTInfo objInfo)
{
	objInfo.ID = Convert.ToInt32(DataProvider.Instance().TM_LOG_EVENT_Insert(objInfo));
	return objInfo;
}

public void Update(TMLOGEVENTInfo objInfo)
{
	DataProvider.Instance().TM_LOG_EVENT_Update(objInfo);
}

public void Delete(int ID)
{
	DataProvider.Instance().TM_LOG_EVENT_Delete(ID);
}

public TMLOGEVENTInfo GetById(int ID)
{
	return (TMLOGEVENTInfo)CBO.FillObject(DataProvider.Instance().TM_LOG_EVENT_GetById(ID), typeof(TMLOGEVENTInfo));
}

public List<TMLOGEVENTInfo> GetAll()
{
	List<TMLOGEVENTInfo> list = new List<TMLOGEVENTInfo>();
	ArrayList arr = CBO.FillCollection(DataProvider.Instance().TM_LOG_EVENT_GetAll(), typeof(TMLOGEVENTInfo));
foreach (object objItem in arr)
{
	list.Add((TMLOGEVENTInfo)objItem);
}	return list;
}

public DataSet GetAll_DS()
{
	return DataProvider.Instance().TM_LOG_EVENT_GetAll_DS();
}

#endregion

}

}