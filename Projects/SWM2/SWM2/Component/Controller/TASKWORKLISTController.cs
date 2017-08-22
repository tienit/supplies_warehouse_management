//*************************************************************
//Author           : Tien NQ
//Created Date     : 8/22/2017
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

public partial class TASKWORKLISTController
{

#region "Instances"
private static TASKWORKLISTController _instance;

protected TASKWORKLISTController()
{
}

protected void Dispose()
{
	_instance = null;
}

private static object _syncLock = new object();

public static TASKWORKLISTController Instance()
{
	if (_instance == null) {
		lock (_syncLock) {
			if (_instance == null) {
				_instance = new TASKWORKLISTController();
			}
		}
	}
	return _instance;
}

#endregion

#region "Public Methods"

public int Insert(TASKWORKLISTInfo objInfo)
{
	return DataProvider.Instance().TASK_WORKLIST_Insert(objInfo);
}

public int Update(TASKWORKLISTInfo objInfo)
{
	return DataProvider.Instance().TASK_WORKLIST_Update(objInfo);
}

public int Delete(int ID)
{
	return DataProvider.Instance().TASK_WORKLIST_Delete(ID);
}

public TASKWORKLISTInfo GetById(int ID)
{
	return (TASKWORKLISTInfo)CBO.FillObject(DataProvider.Instance().TASK_WORKLIST_GetById(ID), typeof(TASKWORKLISTInfo));
}

public List<TASKWORKLISTInfo> GetAll()
{
	List<TASKWORKLISTInfo> list = new List<TASKWORKLISTInfo>();
	ArrayList arr = CBO.FillCollection(DataProvider.Instance().TASK_WORKLIST_GetAll(), typeof(TASKWORKLISTInfo));
	foreach (object objItem in arr)
	{
		list.Add((TASKWORKLISTInfo)objItem);
	}
	return list;
}

public DataSet GetAll_DS()
{
	return DataProvider.Instance().TASK_WORKLIST_GetAll_DS();
}

#endregion

}

}