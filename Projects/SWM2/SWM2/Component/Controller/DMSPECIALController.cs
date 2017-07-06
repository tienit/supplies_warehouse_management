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

public partial class DMSPECIALController
{

#region "Instances"
private static DMSPECIALController _instance;

protected DMSPECIALController()
{
}

protected void Dispose()
{
	_instance = null;
}

private static object _syncLock = new object();

public static DMSPECIALController Instance()
{
	if (_instance == null) {
		lock (_syncLock) {
			if (_instance == null) {
				_instance = new DMSPECIALController();
			}
		}
	}
	return _instance;
}

#endregion

#region "Public Methods"

public DMSPECIALInfo Insert(DMSPECIALInfo objInfo)
{
	objInfo.ID = Convert.ToInt32(DataProvider.Instance().DM_SPECIAL_Insert(objInfo));
	return objInfo;
}

public int Update(DMSPECIALInfo objInfo)
{
	return DataProvider.Instance().DM_SPECIAL_Update(objInfo);
}

public int Delete(int ID)
{
	return DataProvider.Instance().DM_SPECIAL_Delete(ID);
}

public DMSPECIALInfo GetById(int ID)
{
	return (DMSPECIALInfo)CBO.FillObject(DataProvider.Instance().DM_SPECIAL_GetById(ID), typeof(DMSPECIALInfo));
}

public List<DMSPECIALInfo> GetAll()
{
	List<DMSPECIALInfo> list = new List<DMSPECIALInfo>();
	ArrayList arr = CBO.FillCollection(DataProvider.Instance().DM_SPECIAL_GetAll(), typeof(DMSPECIALInfo));
	foreach (object objItem in arr)
	{
		list.Add((DMSPECIALInfo)objItem);
	}
	return list;
}

public DataSet GetAll_DS()
{
	return DataProvider.Instance().DM_SPECIAL_GetAll_DS();
}

#endregion

}

}