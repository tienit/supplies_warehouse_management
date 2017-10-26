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

public partial class DMRANKController
{

#region "Instances"
private static DMRANKController _instance;

protected DMRANKController()
{
}

protected void Dispose()
{
	_instance = null;
}

private static object _syncLock = new object();

public static DMRANKController Instance()
{
	if (_instance == null) {
		lock (_syncLock) {
			if (_instance == null) {
				_instance = new DMRANKController();
			}
		}
	}
	return _instance;
}

#endregion

#region "Public Methods"

public DMRANKInfo Insert(DMRANKInfo objInfo)
{
	objInfo.ID = Convert.ToInt32(DataProvider.Instance().DM_RANK_Insert(objInfo));
	return objInfo;
}

public int Update(DMRANKInfo objInfo)
{
	return DataProvider.Instance().DM_RANK_Update(objInfo);
}

public int Delete(int ID)
{
	return DataProvider.Instance().DM_RANK_Delete(ID);
}

public DMRANKInfo GetById(int ID)
{
	return (DMRANKInfo)CBO.FillObject(DataProvider.Instance().DM_RANK_GetById(ID), typeof(DMRANKInfo));
}

public List<DMRANKInfo> GetAll()
{
	List<DMRANKInfo> list = new List<DMRANKInfo>();
	ArrayList arr = CBO.FillCollection(DataProvider.Instance().DM_RANK_GetAll(), typeof(DMRANKInfo));
	foreach (object objItem in arr)
	{
		list.Add((DMRANKInfo)objItem);
	}
	return list;
}

public DataSet GetAll_DS()
{
	return DataProvider.Instance().DM_RANK_GetAll_DS();
}

#endregion

}

}