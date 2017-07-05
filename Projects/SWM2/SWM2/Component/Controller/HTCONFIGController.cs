//*************************************************************
//Author           : Tien NQ
//Created Date     : 20/03/2014
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

public partial class HTCONFIGController
    {

#region "Instances"
private static HTCONFIGController _instance;

protected HTCONFIGController()
{
}

protected void Dispose()
{
	_instance = null;
}

private static object _syncLock = new object();

public static HTCONFIGController Instance()
{
	if (_instance == null) {
		lock (_syncLock) {
			if (_instance == null) {
				_instance = new HTCONFIGController();
			}
		}
	}
	return _instance;
}

#endregion

#region "Public Methods"

public HTCONFIGInfo Insert(HTCONFIGInfo objInfo)
{
	objInfo.ID = Convert.ToInt32(DataProvider.Instance().HT_CONFIG_Insert(objInfo));
	return objInfo;
}

public void Update(HTCONFIGInfo objInfo)
{
	DataProvider.Instance().HT_CONFIG_Update(objInfo);
}

public void Delete(int ID)
{
	DataProvider.Instance().HT_CONFIG_Delete(ID);
}

public HTCONFIGInfo GetById(int ID)
{
	return (HTCONFIGInfo)CBO.FillObject(DataProvider.Instance().HT_CONFIG_GetById(ID), typeof(HTCONFIGInfo));
}

public List<HTCONFIGInfo> GetAll()
{
	List<HTCONFIGInfo> list = new List<HTCONFIGInfo>();
	ArrayList arr = CBO.FillCollection(DataProvider.Instance().HT_CONFIG_GetAll(), typeof(HTCONFIGInfo));
foreach (object objItem in arr)
{
	list.Add((HTCONFIGInfo)objItem);
}	return list;
}

public DataSet GetAll_DS()
{
	return DataProvider.Instance().HT_CONFIG_GetAll_DS();
}

#endregion

}

}