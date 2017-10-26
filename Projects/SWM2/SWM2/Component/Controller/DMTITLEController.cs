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

public partial class DMTITLEController
{

#region "Instances"
private static DMTITLEController _instance;

protected DMTITLEController()
{
}

protected void Dispose()
{
	_instance = null;
}

private static object _syncLock = new object();

public static DMTITLEController Instance()
{
	if (_instance == null) {
		lock (_syncLock) {
			if (_instance == null) {
				_instance = new DMTITLEController();
			}
		}
	}
	return _instance;
}

#endregion

#region "Public Methods"

public DMTITLEInfo Insert(DMTITLEInfo objInfo)
{
	objInfo.ID = Convert.ToInt32(DataProvider.Instance().DM_TITLE_Insert(objInfo));
	return objInfo;
}

public int Update(DMTITLEInfo objInfo)
{
	return DataProvider.Instance().DM_TITLE_Update(objInfo);
}

public int Delete(int ID)
{
	return DataProvider.Instance().DM_TITLE_Delete(ID);
}

public DMTITLEInfo GetById(int ID)
{
	return (DMTITLEInfo)CBO.FillObject(DataProvider.Instance().DM_TITLE_GetById(ID), typeof(DMTITLEInfo));
}

public List<DMTITLEInfo> GetAll()
{
	List<DMTITLEInfo> list = new List<DMTITLEInfo>();
	ArrayList arr = CBO.FillCollection(DataProvider.Instance().DM_TITLE_GetAll(), typeof(DMTITLEInfo));
	foreach (object objItem in arr)
	{
		list.Add((DMTITLEInfo)objItem);
	}
	return list;
}

public DataSet GetAll_DS()
{
	return DataProvider.Instance().DM_TITLE_GetAll_DS();
}

#endregion

}

}