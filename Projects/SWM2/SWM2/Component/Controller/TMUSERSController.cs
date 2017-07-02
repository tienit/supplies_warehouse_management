//*************************************************************
//Author           : Tien NQ
//Created Date     : 9/10/2016
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

public partial class TMUSERSController
{

#region "Instances"
private static TMUSERSController _instance;

protected TMUSERSController()
{
}

protected void Dispose()
{
	_instance = null;
}

private static object _syncLock = new object();

public static TMUSERSController Instance()
{
	if (_instance == null) {
		lock (_syncLock) {
			if (_instance == null) {
				_instance = new TMUSERSController();
			}
		}
	}
	return _instance;
}

#endregion

#region "Public Methods"

public TMUSERSInfo Insert(TMUSERSInfo objInfo)
{
	objInfo.ID = Convert.ToInt32(DataProvider.Instance().TM_USERS_Insert(objInfo));
	return objInfo;
}

public int Update(TMUSERSInfo objInfo)
{
	return DataProvider.Instance().TM_USERS_Update(objInfo);
}

public int Delete(int ID)
{
	return DataProvider.Instance().TM_USERS_Delete(ID);
}

public TMUSERSInfo GetById(int ID)
{
	return (TMUSERSInfo)CBO.FillObject(DataProvider.Instance().TM_USERS_GetById(ID), typeof(TMUSERSInfo));
}

public List<TMUSERSInfo> GetAll()
{
	List<TMUSERSInfo> list = new List<TMUSERSInfo>();
	ArrayList arr = CBO.FillCollection(DataProvider.Instance().TM_USERS_GetAll(), typeof(TMUSERSInfo));
	foreach (object objItem in arr)
	{
		list.Add((TMUSERSInfo)objItem);
	}
	return list;
}

public DataSet GetAll_DS()
{
	return DataProvider.Instance().TM_USERS_GetAll_DS();
}

#endregion

}

}