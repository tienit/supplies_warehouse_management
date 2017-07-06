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

public partial class DTUSERCONFIGController
{

#region "Instances"
private static DTUSERCONFIGController _instance;

protected DTUSERCONFIGController()
{
}

protected void Dispose()
{
	_instance = null;
}

private static object _syncLock = new object();

public static DTUSERCONFIGController Instance()
{
	if (_instance == null) {
		lock (_syncLock) {
			if (_instance == null) {
				_instance = new DTUSERCONFIGController();
			}
		}
	}
	return _instance;
}

#endregion

#region "Public Methods"

public int Insert(DTUSERCONFIGInfo objInfo)
{
	return DataProvider.Instance().DT_USER_CONFIG_Insert(objInfo);
}

public int Update(DTUSERCONFIGInfo objInfo)
{
	return DataProvider.Instance().DT_USER_CONFIG_Update(objInfo);
}

public int Delete(int ID)
{
	return DataProvider.Instance().DT_USER_CONFIG_Delete(ID);
}

public DTUSERCONFIGInfo GetById(int ID)
{
	return (DTUSERCONFIGInfo)CBO.FillObject(DataProvider.Instance().DT_USER_CONFIG_GetById(ID), typeof(DTUSERCONFIGInfo));
}

public List<DTUSERCONFIGInfo> GetAll()
{
	List<DTUSERCONFIGInfo> list = new List<DTUSERCONFIGInfo>();
	ArrayList arr = CBO.FillCollection(DataProvider.Instance().DT_USER_CONFIG_GetAll(), typeof(DTUSERCONFIGInfo));
	foreach (object objItem in arr)
	{
		list.Add((DTUSERCONFIGInfo)objItem);
	}
	return list;
}

public DataSet GetAll_DS()
{
	return DataProvider.Instance().DT_USER_CONFIG_GetAll_DS();
}

#endregion

}

}