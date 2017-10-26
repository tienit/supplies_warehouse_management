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

public partial class DTINPUTController
{

#region "Instances"
private static DTINPUTController _instance;

protected DTINPUTController()
{
}

protected void Dispose()
{
	_instance = null;
}

private static object _syncLock = new object();

public static DTINPUTController Instance()
{
	if (_instance == null) {
		lock (_syncLock) {
			if (_instance == null) {
				_instance = new DTINPUTController();
			}
		}
	}
	return _instance;
}

#endregion

#region "Public Methods"

public DTINPUTInfo Insert(DTINPUTInfo objInfo)
{
	objInfo.ID = Convert.ToInt32(DataProvider.Instance().DT_INPUT_Insert(objInfo));
	return objInfo;
}

public int Update(DTINPUTInfo objInfo)
{
	return DataProvider.Instance().DT_INPUT_Update(objInfo);
}

public int Delete(int ID)
{
	return DataProvider.Instance().DT_INPUT_Delete(ID);
}

public DTINPUTInfo GetById(int ID)
{
	return (DTINPUTInfo)CBO.FillObject(DataProvider.Instance().DT_INPUT_GetById(ID), typeof(DTINPUTInfo));
}

public List<DTINPUTInfo> GetAll()
{
	List<DTINPUTInfo> list = new List<DTINPUTInfo>();
	ArrayList arr = CBO.FillCollection(DataProvider.Instance().DT_INPUT_GetAll(), typeof(DTINPUTInfo));
	foreach (object objItem in arr)
	{
		list.Add((DTINPUTInfo)objItem);
	}
	return list;
}

public DataSet GetAll_DS()
{
	return DataProvider.Instance().DT_INPUT_GetAll_DS();
}

#endregion

}

}