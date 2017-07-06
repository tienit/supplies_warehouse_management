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

public partial class DMLOCATIONController
{

#region "Instances"
private static DMLOCATIONController _instance;

protected DMLOCATIONController()
{
}

protected void Dispose()
{
	_instance = null;
}

private static object _syncLock = new object();

public static DMLOCATIONController Instance()
{
	if (_instance == null) {
		lock (_syncLock) {
			if (_instance == null) {
				_instance = new DMLOCATIONController();
			}
		}
	}
	return _instance;
}

#endregion

#region "Public Methods"

public DMLOCATIONInfo Insert(DMLOCATIONInfo objInfo)
{
	objInfo.ID = Convert.ToInt32(DataProvider.Instance().DM_LOCATION_Insert(objInfo));
	return objInfo;
}

public int Update(DMLOCATIONInfo objInfo)
{
	return DataProvider.Instance().DM_LOCATION_Update(objInfo);
}

public int Delete(int ID)
{
	return DataProvider.Instance().DM_LOCATION_Delete(ID);
}

public DMLOCATIONInfo GetById(int ID)
{
	return (DMLOCATIONInfo)CBO.FillObject(DataProvider.Instance().DM_LOCATION_GetById(ID), typeof(DMLOCATIONInfo));
}

public List<DMLOCATIONInfo> GetAll()
{
	List<DMLOCATIONInfo> list = new List<DMLOCATIONInfo>();
	ArrayList arr = CBO.FillCollection(DataProvider.Instance().DM_LOCATION_GetAll(), typeof(DMLOCATIONInfo));
	foreach (object objItem in arr)
	{
		list.Add((DMLOCATIONInfo)objItem);
	}
	return list;
}

public DataSet GetAll_DS()
{
	return DataProvider.Instance().DM_LOCATION_GetAll_DS();
}

#endregion

}

}