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

public partial class DMEMPLOYERController
{

#region "Instances"
private static DMEMPLOYERController _instance;

protected DMEMPLOYERController()
{
}

protected void Dispose()
{
	_instance = null;
}

private static object _syncLock = new object();

public static DMEMPLOYERController Instance()
{
	if (_instance == null) {
		lock (_syncLock) {
			if (_instance == null) {
				_instance = new DMEMPLOYERController();
			}
		}
	}
	return _instance;
}

#endregion

#region "Public Methods"

public DMEMPLOYERInfo Insert(DMEMPLOYERInfo objInfo)
{
	objInfo.ID = Convert.ToInt32(DataProvider.Instance().DM_EMPLOYER_Insert(objInfo));
	return objInfo;
}

public int Update(DMEMPLOYERInfo objInfo)
{
	return DataProvider.Instance().DM_EMPLOYER_Update(objInfo);
}

public int Delete(int ID)
{
	return DataProvider.Instance().DM_EMPLOYER_Delete(ID);
}

public DMEMPLOYERInfo GetById(int ID)
{
	return (DMEMPLOYERInfo)CBO.FillObject(DataProvider.Instance().DM_EMPLOYER_GetById(ID), typeof(DMEMPLOYERInfo));
}

public List<DMEMPLOYERInfo> GetAll()
{
	List<DMEMPLOYERInfo> list = new List<DMEMPLOYERInfo>();
	ArrayList arr = CBO.FillCollection(DataProvider.Instance().DM_EMPLOYER_GetAll(), typeof(DMEMPLOYERInfo));
	foreach (object objItem in arr)
	{
		list.Add((DMEMPLOYERInfo)objItem);
	}
	return list;
}

public DataSet GetAll_DS()
{
	return DataProvider.Instance().DM_EMPLOYER_GetAll_DS();
}

#endregion

}

}