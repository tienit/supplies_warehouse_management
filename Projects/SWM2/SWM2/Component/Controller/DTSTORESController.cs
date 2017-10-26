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

public partial class DTSTORESController
{

#region "Instances"
private static DTSTORESController _instance;

protected DTSTORESController()
{
}

protected void Dispose()
{
	_instance = null;
}

private static object _syncLock = new object();

public static DTSTORESController Instance()
{
	if (_instance == null) {
		lock (_syncLock) {
			if (_instance == null) {
				_instance = new DTSTORESController();
			}
		}
	}
	return _instance;
}

#endregion

#region "Public Methods"

public DTSTORESInfo Insert(DTSTORESInfo objInfo)
{
	objInfo.ID = Convert.ToInt32(DataProvider.Instance().DT_STORES_Insert(objInfo));
	return objInfo;
}

public int Update(DTSTORESInfo objInfo)
{
	return DataProvider.Instance().DT_STORES_Update(objInfo);
}

public int Delete(int ID)
{
	return DataProvider.Instance().DT_STORES_Delete(ID);
}

public DTSTORESInfo GetById(int ID)
{
	return (DTSTORESInfo)CBO.FillObject(DataProvider.Instance().DT_STORES_GetById(ID), typeof(DTSTORESInfo));
}

public List<DTSTORESInfo> GetAll()
{
	List<DTSTORESInfo> list = new List<DTSTORESInfo>();
	ArrayList arr = CBO.FillCollection(DataProvider.Instance().DT_STORES_GetAll(), typeof(DTSTORESInfo));
	foreach (object objItem in arr)
	{
		list.Add((DTSTORESInfo)objItem);
	}
	return list;
}

public DataSet GetAll_DS()
{
	return DataProvider.Instance().DT_STORES_GetAll_DS();
}

#endregion

}

}