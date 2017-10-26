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

public partial class HTMASTERORGANIZATIONController
{

#region "Instances"
private static HTMASTERORGANIZATIONController _instance;

protected HTMASTERORGANIZATIONController()
{
}

protected void Dispose()
{
	_instance = null;
}

private static object _syncLock = new object();

public static HTMASTERORGANIZATIONController Instance()
{
	if (_instance == null) {
		lock (_syncLock) {
			if (_instance == null) {
				_instance = new HTMASTERORGANIZATIONController();
			}
		}
	}
	return _instance;
}

#endregion

#region "Public Methods"

public HTMASTERORGANIZATIONInfo Insert(HTMASTERORGANIZATIONInfo objInfo)
{
	objInfo.ID = Convert.ToInt32(DataProvider.Instance().HT_MASTER_ORGANIZATION_Insert(objInfo));
	return objInfo;
}

public int Update(HTMASTERORGANIZATIONInfo objInfo)
{
	return DataProvider.Instance().HT_MASTER_ORGANIZATION_Update(objInfo);
}

public int Delete(int ID)
{
	return DataProvider.Instance().HT_MASTER_ORGANIZATION_Delete(ID);
}

public HTMASTERORGANIZATIONInfo GetById(int ID)
{
	return (HTMASTERORGANIZATIONInfo)CBO.FillObject(DataProvider.Instance().HT_MASTER_ORGANIZATION_GetById(ID), typeof(HTMASTERORGANIZATIONInfo));
}

public List<HTMASTERORGANIZATIONInfo> GetAll()
{
	List<HTMASTERORGANIZATIONInfo> list = new List<HTMASTERORGANIZATIONInfo>();
	ArrayList arr = CBO.FillCollection(DataProvider.Instance().HT_MASTER_ORGANIZATION_GetAll(), typeof(HTMASTERORGANIZATIONInfo));
	foreach (object objItem in arr)
	{
		list.Add((HTMASTERORGANIZATIONInfo)objItem);
	}
	return list;
}

public DataSet GetAll_DS()
{
	return DataProvider.Instance().HT_MASTER_ORGANIZATION_GetAll_DS();
}

#endregion

}

}