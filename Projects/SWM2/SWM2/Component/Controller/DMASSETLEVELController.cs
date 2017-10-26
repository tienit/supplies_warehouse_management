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

public partial class DMASSETLEVELController
{

#region "Instances"
private static DMASSETLEVELController _instance;

protected DMASSETLEVELController()
{
}

protected void Dispose()
{
	_instance = null;
}

private static object _syncLock = new object();

public static DMASSETLEVELController Instance()
{
	if (_instance == null) {
		lock (_syncLock) {
			if (_instance == null) {
				_instance = new DMASSETLEVELController();
			}
		}
	}
	return _instance;
}

#endregion

#region "Public Methods"

public DMASSETLEVELInfo Insert(DMASSETLEVELInfo objInfo)
{
	objInfo.ID = Convert.ToInt32(DataProvider.Instance().DM_ASSETLEVEL_Insert(objInfo));
	return objInfo;
}

public int Update(DMASSETLEVELInfo objInfo)
{
	return DataProvider.Instance().DM_ASSETLEVEL_Update(objInfo);
}

public int Delete(int ID)
{
	return DataProvider.Instance().DM_ASSETLEVEL_Delete(ID);
}

public DMASSETLEVELInfo GetById(int ID)
{
	return (DMASSETLEVELInfo)CBO.FillObject(DataProvider.Instance().DM_ASSETLEVEL_GetById(ID), typeof(DMASSETLEVELInfo));
}

public List<DMASSETLEVELInfo> GetAll()
{
	List<DMASSETLEVELInfo> list = new List<DMASSETLEVELInfo>();
	ArrayList arr = CBO.FillCollection(DataProvider.Instance().DM_ASSETLEVEL_GetAll(), typeof(DMASSETLEVELInfo));
	foreach (object objItem in arr)
	{
		list.Add((DMASSETLEVELInfo)objItem);
	}
	return list;
}

public DataSet GetAll_DS()
{
	return DataProvider.Instance().DM_ASSETLEVEL_GetAll_DS();
}

#endregion

}

}