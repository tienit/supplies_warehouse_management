//*************************************************************
//Author           : Tien NQ
//Created Date     : 9/6/2016
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

public partial class TMLOGLOGINController
{

#region "Instances"
private static TMLOGLOGINController _instance;

protected TMLOGLOGINController()
{
}

protected void Dispose()
{
	_instance = null;
}

private static object _syncLock = new object();

public static TMLOGLOGINController Instance()
{
	if (_instance == null) {
		lock (_syncLock) {
			if (_instance == null) {
				_instance = new TMLOGLOGINController();
			}
		}
	}
	return _instance;
}

#endregion

#region "Public Methods"

public TMLOGLOGINInfo Insert(TMLOGLOGINInfo objInfo)
{
	objInfo.ID = Convert.ToInt32(DataProvider.Instance().TM_LOG_LOGIN_Insert(objInfo));
	return objInfo;
}

public int Update(TMLOGLOGINInfo objInfo)
{
	return DataProvider.Instance().TM_LOG_LOGIN_Update(objInfo);
}

public int Delete(int ID)
{
	return DataProvider.Instance().TM_LOG_LOGIN_Delete(ID);
}

public TMLOGLOGINInfo GetById(int ID)
{
	return (TMLOGLOGINInfo)CBO.FillObject(DataProvider.Instance().TM_LOG_LOGIN_GetById(ID), typeof(TMLOGLOGINInfo));
}

public List<TMLOGLOGINInfo> GetAll()
{
	List<TMLOGLOGINInfo> list = new List<TMLOGLOGINInfo>();
	ArrayList arr = CBO.FillCollection(DataProvider.Instance().TM_LOG_LOGIN_GetAll(), typeof(TMLOGLOGINInfo));
	foreach (object objItem in arr)
	{
		list.Add((TMLOGLOGINInfo)objItem);
	}
	return list;
}

public DataSet GetAll_DS()
{
	return DataProvider.Instance().TM_LOG_LOGIN_GetAll_DS();
}

#endregion

}

}