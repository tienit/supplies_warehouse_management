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

public partial class DMASSETPRODUCTSController
{

#region "Instances"
private static DMASSETPRODUCTSController _instance;

protected DMASSETPRODUCTSController()
{
}

protected void Dispose()
{
	_instance = null;
}

private static object _syncLock = new object();

public static DMASSETPRODUCTSController Instance()
{
	if (_instance == null) {
		lock (_syncLock) {
			if (_instance == null) {
				_instance = new DMASSETPRODUCTSController();
			}
		}
	}
	return _instance;
}

#endregion

#region "Public Methods"

public DMASSETPRODUCTSInfo Insert(DMASSETPRODUCTSInfo objInfo)
{
	objInfo.ID = Convert.ToInt32(DataProvider.Instance().DM_ASSETPRODUCTS_Insert(objInfo));
	return objInfo;
}

public int Update(DMASSETPRODUCTSInfo objInfo)
{
	return DataProvider.Instance().DM_ASSETPRODUCTS_Update(objInfo);
}

public int Delete(int ID)
{
	return DataProvider.Instance().DM_ASSETPRODUCTS_Delete(ID);
}

public DMASSETPRODUCTSInfo GetById(int ID)
{
	return (DMASSETPRODUCTSInfo)CBO.FillObject(DataProvider.Instance().DM_ASSETPRODUCTS_GetById(ID), typeof(DMASSETPRODUCTSInfo));
}

public List<DMASSETPRODUCTSInfo> GetAll()
{
	List<DMASSETPRODUCTSInfo> list = new List<DMASSETPRODUCTSInfo>();
	ArrayList arr = CBO.FillCollection(DataProvider.Instance().DM_ASSETPRODUCTS_GetAll(), typeof(DMASSETPRODUCTSInfo));
	foreach (object objItem in arr)
	{
		list.Add((DMASSETPRODUCTSInfo)objItem);
	}
	return list;
}

public DataSet GetAll_DS()
{
	return DataProvider.Instance().DM_ASSETPRODUCTS_GetAll_DS();
}

#endregion

}

}