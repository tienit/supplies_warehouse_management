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

public partial class DMPARAMETERController
{

#region "Instances"
private static DMPARAMETERController _instance;

protected DMPARAMETERController()
{
}

protected void Dispose()
{
	_instance = null;
}

private static object _syncLock = new object();

public static DMPARAMETERController Instance()
{
	if (_instance == null) {
		lock (_syncLock) {
			if (_instance == null) {
				_instance = new DMPARAMETERController();
			}
		}
	}
	return _instance;
}

#endregion

#region "Public Methods"

public DMPARAMETERInfo Insert(DMPARAMETERInfo objInfo)
{
	objInfo.ID = Convert.ToInt32(DataProvider.Instance().DM_PARAMETER_Insert(objInfo));
	return objInfo;
}

public int Update(DMPARAMETERInfo objInfo)
{
	return DataProvider.Instance().DM_PARAMETER_Update(objInfo);
}

public int Delete(int ID)
{
	return DataProvider.Instance().DM_PARAMETER_Delete(ID);
}

public DMPARAMETERInfo GetById(int ID)
{
	return (DMPARAMETERInfo)CBO.FillObject(DataProvider.Instance().DM_PARAMETER_GetById(ID), typeof(DMPARAMETERInfo));
}

public List<DMPARAMETERInfo> GetAll()
{
	List<DMPARAMETERInfo> list = new List<DMPARAMETERInfo>();
	ArrayList arr = CBO.FillCollection(DataProvider.Instance().DM_PARAMETER_GetAll(), typeof(DMPARAMETERInfo));
	foreach (object objItem in arr)
	{
		list.Add((DMPARAMETERInfo)objItem);
	}
	return list;
}

public DataSet GetAll_DS()
{
	return DataProvider.Instance().DM_PARAMETER_GetAll_DS();
}

#endregion

}

}