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

public partial class DTLOGLOGINController
{

#region "Instances"
private static DTLOGLOGINController _instance;

protected DTLOGLOGINController()
{
}

protected void Dispose()
{
	_instance = null;
}

private static object _syncLock = new object();

public static DTLOGLOGINController Instance()
{
	if (_instance == null) {
		lock (_syncLock) {
			if (_instance == null) {
				_instance = new DTLOGLOGINController();
			}
		}
	}
	return _instance;
}

#endregion

#region "Public Methods"

public DTLOGLOGINInfo Insert(DTLOGLOGINInfo objInfo)
{
	objInfo.ID = Convert.ToInt32(DataProvider.Instance().DT_LOG_LOGIN_Insert(objInfo));
	return objInfo;
}

public int Update(DTLOGLOGINInfo objInfo)
{
	return DataProvider.Instance().DT_LOG_LOGIN_Update(objInfo);
}

public int Delete(int ID)
{
	return DataProvider.Instance().DT_LOG_LOGIN_Delete(ID);
}

public DTLOGLOGINInfo GetById(int ID)
{
	return (DTLOGLOGINInfo)CBO.FillObject(DataProvider.Instance().DT_LOG_LOGIN_GetById(ID), typeof(DTLOGLOGINInfo));
}

public List<DTLOGLOGINInfo> GetAll()
{
	List<DTLOGLOGINInfo> list = new List<DTLOGLOGINInfo>();
	ArrayList arr = CBO.FillCollection(DataProvider.Instance().DT_LOG_LOGIN_GetAll(), typeof(DTLOGLOGINInfo));
	foreach (object objItem in arr)
	{
		list.Add((DTLOGLOGINInfo)objItem);
	}
	return list;
}

public DataSet GetAll_DS()
{
	return DataProvider.Instance().DT_LOG_LOGIN_GetAll_DS();
}

#endregion

}

}