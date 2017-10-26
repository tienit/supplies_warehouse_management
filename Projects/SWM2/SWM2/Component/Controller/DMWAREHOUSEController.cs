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

public partial class DMWAREHOUSEController
{

#region "Instances"
private static DMWAREHOUSEController _instance;

protected DMWAREHOUSEController()
{
}

protected void Dispose()
{
	_instance = null;
}

private static object _syncLock = new object();

public static DMWAREHOUSEController Instance()
{
	if (_instance == null) {
		lock (_syncLock) {
			if (_instance == null) {
				_instance = new DMWAREHOUSEController();
			}
		}
	}
	return _instance;
}

#endregion

#region "Public Methods"

public DMWAREHOUSEInfo Insert(DMWAREHOUSEInfo objInfo)
{
	objInfo.ID = Convert.ToInt32(DataProvider.Instance().DM_WAREHOUSE_Insert(objInfo));
	return objInfo;
}

public int Update(DMWAREHOUSEInfo objInfo)
{
	return DataProvider.Instance().DM_WAREHOUSE_Update(objInfo);
}

public int Delete(int ID)
{
	return DataProvider.Instance().DM_WAREHOUSE_Delete(ID);
}

public DMWAREHOUSEInfo GetById(int ID)
{
	return (DMWAREHOUSEInfo)CBO.FillObject(DataProvider.Instance().DM_WAREHOUSE_GetById(ID), typeof(DMWAREHOUSEInfo));
}

public List<DMWAREHOUSEInfo> GetAll()
{
	List<DMWAREHOUSEInfo> list = new List<DMWAREHOUSEInfo>();
	ArrayList arr = CBO.FillCollection(DataProvider.Instance().DM_WAREHOUSE_GetAll(), typeof(DMWAREHOUSEInfo));
	foreach (object objItem in arr)
	{
		list.Add((DMWAREHOUSEInfo)objItem);
	}
	return list;
}

public DataSet GetAll_DS()
{
	return DataProvider.Instance().DM_WAREHOUSE_GetAll_DS();
}

#endregion

}

}