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

public partial class DMORGANIZATIONController
{

#region "Instances"
private static DMORGANIZATIONController _instance;

protected DMORGANIZATIONController()
{
}

protected void Dispose()
{
	_instance = null;
}

private static object _syncLock = new object();

public static DMORGANIZATIONController Instance()
{
	if (_instance == null) {
		lock (_syncLock) {
			if (_instance == null) {
				_instance = new DMORGANIZATIONController();
			}
		}
	}
	return _instance;
}

#endregion

#region "Public Methods"

public DMORGANIZATIONInfo Insert(DMORGANIZATIONInfo objInfo)
{
	objInfo.ID = Convert.ToInt32(DataProvider.Instance().DM_ORGANIZATION_Insert(objInfo));
	return objInfo;
}

public int Update(DMORGANIZATIONInfo objInfo)
{
	return DataProvider.Instance().DM_ORGANIZATION_Update(objInfo);
}

public int Delete(int ID)
{
	return DataProvider.Instance().DM_ORGANIZATION_Delete(ID);
}

public DMORGANIZATIONInfo GetById(int ID)
{
	return (DMORGANIZATIONInfo)CBO.FillObject(DataProvider.Instance().DM_ORGANIZATION_GetById(ID), typeof(DMORGANIZATIONInfo));
}

public List<DMORGANIZATIONInfo> GetAll()
{
	List<DMORGANIZATIONInfo> list = new List<DMORGANIZATIONInfo>();
	ArrayList arr = CBO.FillCollection(DataProvider.Instance().DM_ORGANIZATION_GetAll(), typeof(DMORGANIZATIONInfo));
	foreach (object objItem in arr)
	{
		list.Add((DMORGANIZATIONInfo)objItem);
	}
	return list;
}

public DataSet GetAll_DS()
{
	return DataProvider.Instance().DM_ORGANIZATION_GetAll_DS();
}

#endregion

}

}