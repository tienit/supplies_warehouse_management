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

public partial class DMSUPPLIERController
{

#region "Instances"
private static DMSUPPLIERController _instance;

protected DMSUPPLIERController()
{
}

protected void Dispose()
{
	_instance = null;
}

private static object _syncLock = new object();

public static DMSUPPLIERController Instance()
{
	if (_instance == null) {
		lock (_syncLock) {
			if (_instance == null) {
				_instance = new DMSUPPLIERController();
			}
		}
	}
	return _instance;
}

#endregion

#region "Public Methods"

public DMSUPPLIERInfo Insert(DMSUPPLIERInfo objInfo)
{
	objInfo.ID = Convert.ToInt32(DataProvider.Instance().DM_SUPPLIER_Insert(objInfo));
	return objInfo;
}

public int Update(DMSUPPLIERInfo objInfo)
{
	return DataProvider.Instance().DM_SUPPLIER_Update(objInfo);
}

public int Delete(int ID)
{
	return DataProvider.Instance().DM_SUPPLIER_Delete(ID);
}

public DMSUPPLIERInfo GetById(int ID)
{
	return (DMSUPPLIERInfo)CBO.FillObject(DataProvider.Instance().DM_SUPPLIER_GetById(ID), typeof(DMSUPPLIERInfo));
}

public List<DMSUPPLIERInfo> GetAll()
{
	List<DMSUPPLIERInfo> list = new List<DMSUPPLIERInfo>();
	ArrayList arr = CBO.FillCollection(DataProvider.Instance().DM_SUPPLIER_GetAll(), typeof(DMSUPPLIERInfo));
	foreach (object objItem in arr)
	{
		list.Add((DMSUPPLIERInfo)objItem);
	}
	return list;
}

public DataSet GetAll_DS()
{
	return DataProvider.Instance().DM_SUPPLIER_GetAll_DS();
}

#endregion

}

}