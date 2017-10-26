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

public partial class HTTITLEEMPLOYERController
{

#region "Instances"
private static HTTITLEEMPLOYERController _instance;

protected HTTITLEEMPLOYERController()
{
}

protected void Dispose()
{
	_instance = null;
}

private static object _syncLock = new object();

public static HTTITLEEMPLOYERController Instance()
{
	if (_instance == null) {
		lock (_syncLock) {
			if (_instance == null) {
				_instance = new HTTITLEEMPLOYERController();
			}
		}
	}
	return _instance;
}

#endregion

#region "Public Methods"

public HTTITLEEMPLOYERInfo Insert(HTTITLEEMPLOYERInfo objInfo)
{
	objInfo.ID = Convert.ToInt32(DataProvider.Instance().HT_TITLE_EMPLOYER_Insert(objInfo));
	return objInfo;
}

public int Update(HTTITLEEMPLOYERInfo objInfo)
{
	return DataProvider.Instance().HT_TITLE_EMPLOYER_Update(objInfo);
}

public int Delete(int ID)
{
	return DataProvider.Instance().HT_TITLE_EMPLOYER_Delete(ID);
}

public HTTITLEEMPLOYERInfo GetById(int ID)
{
	return (HTTITLEEMPLOYERInfo)CBO.FillObject(DataProvider.Instance().HT_TITLE_EMPLOYER_GetById(ID), typeof(HTTITLEEMPLOYERInfo));
}

public List<HTTITLEEMPLOYERInfo> GetAll()
{
	List<HTTITLEEMPLOYERInfo> list = new List<HTTITLEEMPLOYERInfo>();
	ArrayList arr = CBO.FillCollection(DataProvider.Instance().HT_TITLE_EMPLOYER_GetAll(), typeof(HTTITLEEMPLOYERInfo));
	foreach (object objItem in arr)
	{
		list.Add((HTTITLEEMPLOYERInfo)objItem);
	}
	return list;
}

public DataSet GetAll_DS()
{
	return DataProvider.Instance().HT_TITLE_EMPLOYER_GetAll_DS();
}

#endregion

}

}