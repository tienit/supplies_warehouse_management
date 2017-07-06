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

public partial class DMOUTPUTTYPEController
{

#region "Instances"
private static DMOUTPUTTYPEController _instance;

protected DMOUTPUTTYPEController()
{
}

protected void Dispose()
{
	_instance = null;
}

private static object _syncLock = new object();

public static DMOUTPUTTYPEController Instance()
{
	if (_instance == null) {
		lock (_syncLock) {
			if (_instance == null) {
				_instance = new DMOUTPUTTYPEController();
			}
		}
	}
	return _instance;
}

#endregion

#region "Public Methods"

public DMOUTPUTTYPEInfo Insert(DMOUTPUTTYPEInfo objInfo)
{
	objInfo.ID = Convert.ToInt32(DataProvider.Instance().DM_OUTPUTTYPE_Insert(objInfo));
	return objInfo;
}

public int Update(DMOUTPUTTYPEInfo objInfo)
{
	return DataProvider.Instance().DM_OUTPUTTYPE_Update(objInfo);
}

public int Delete(int ID)
{
	return DataProvider.Instance().DM_OUTPUTTYPE_Delete(ID);
}

public DMOUTPUTTYPEInfo GetById(int ID)
{
	return (DMOUTPUTTYPEInfo)CBO.FillObject(DataProvider.Instance().DM_OUTPUTTYPE_GetById(ID), typeof(DMOUTPUTTYPEInfo));
}

public List<DMOUTPUTTYPEInfo> GetAll()
{
	List<DMOUTPUTTYPEInfo> list = new List<DMOUTPUTTYPEInfo>();
	ArrayList arr = CBO.FillCollection(DataProvider.Instance().DM_OUTPUTTYPE_GetAll(), typeof(DMOUTPUTTYPEInfo));
	foreach (object objItem in arr)
	{
		list.Add((DMOUTPUTTYPEInfo)objItem);
	}
	return list;
}

public DataSet GetAll_DS()
{
	return DataProvider.Instance().DM_OUTPUTTYPE_GetAll_DS();
}

#endregion

}

}