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

public partial class DMORIGINController
{

#region "Instances"
private static DMORIGINController _instance;

protected DMORIGINController()
{
}

protected void Dispose()
{
	_instance = null;
}

private static object _syncLock = new object();

public static DMORIGINController Instance()
{
	if (_instance == null) {
		lock (_syncLock) {
			if (_instance == null) {
				_instance = new DMORIGINController();
			}
		}
	}
	return _instance;
}

#endregion

#region "Public Methods"

public DMORIGINInfo Insert(DMORIGINInfo objInfo)
{
	objInfo.ID = Convert.ToInt32(DataProvider.Instance().DM_ORIGIN_Insert(objInfo));
	return objInfo;
}

public int Update(DMORIGINInfo objInfo)
{
	return DataProvider.Instance().DM_ORIGIN_Update(objInfo);
}

public int Delete(int ID)
{
	return DataProvider.Instance().DM_ORIGIN_Delete(ID);
}

public DMORIGINInfo GetById(int ID)
{
	return (DMORIGINInfo)CBO.FillObject(DataProvider.Instance().DM_ORIGIN_GetById(ID), typeof(DMORIGINInfo));
}

public List<DMORIGINInfo> GetAll()
{
	List<DMORIGINInfo> list = new List<DMORIGINInfo>();
	ArrayList arr = CBO.FillCollection(DataProvider.Instance().DM_ORIGIN_GetAll(), typeof(DMORIGINInfo));
	foreach (object objItem in arr)
	{
		list.Add((DMORIGINInfo)objItem);
	}
	return list;
}

public DataSet GetAll_DS()
{
	return DataProvider.Instance().DM_ORIGIN_GetAll_DS();
}

#endregion

}

}