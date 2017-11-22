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

public partial class DMDRUGController
{

#region "Instances"
private static DMDRUGController _instance;

protected DMDRUGController()
{
}

protected void Dispose()
{
	_instance = null;
}

private static object _syncLock = new object();

public static DMDRUGController Instance()
{
	if (_instance == null) {
		lock (_syncLock) {
			if (_instance == null) {
				_instance = new DMDRUGController();
			}
		}
	}
	return _instance;
}

#endregion

#region "Public Methods"

public DMDRUGInfo Insert(DMDRUGInfo objInfo)
{
	objInfo.ID = Convert.ToInt32(DataProvider.Instance().DM_DRUG_Insert(objInfo));
	return objInfo;
}

public int Update(DMDRUGInfo objInfo)
{
	return DataProvider.Instance().DM_DRUG_Update(objInfo);
}

public int Delete(int ID)
{
	return DataProvider.Instance().DM_DRUG_Delete(ID);
}

public DMDRUGInfo GetById(int ID)
{
	return (DMDRUGInfo)CBO.FillObject(DataProvider.Instance().DM_DRUG_GetById(ID), typeof(DMDRUGInfo));
}

public List<DMDRUGInfo> GetAll()
{
	List<DMDRUGInfo> list = new List<DMDRUGInfo>();
	ArrayList arr = CBO.FillCollection(DataProvider.Instance().DM_DRUG_GetAll(), typeof(DMDRUGInfo));
	foreach (object objItem in arr)
	{
		list.Add((DMDRUGInfo)objItem);
	}
	return list;
}

public DataSet GetAll_DS()
{
	return DataProvider.Instance().DM_DRUG_GetAll_DS();
}

#endregion

}

}