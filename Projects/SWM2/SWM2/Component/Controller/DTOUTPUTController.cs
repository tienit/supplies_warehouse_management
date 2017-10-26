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

public partial class DTOUTPUTController
{

#region "Instances"
private static DTOUTPUTController _instance;

protected DTOUTPUTController()
{
}

protected void Dispose()
{
	_instance = null;
}

private static object _syncLock = new object();

public static DTOUTPUTController Instance()
{
	if (_instance == null) {
		lock (_syncLock) {
			if (_instance == null) {
				_instance = new DTOUTPUTController();
			}
		}
	}
	return _instance;
}

#endregion

#region "Public Methods"

public DTOUTPUTInfo Insert(DTOUTPUTInfo objInfo)
{
	objInfo.ID = Convert.ToInt32(DataProvider.Instance().DT_OUTPUT_Insert(objInfo));
	return objInfo;
}

public int Update(DTOUTPUTInfo objInfo)
{
	return DataProvider.Instance().DT_OUTPUT_Update(objInfo);
}

public int Delete(int ID)
{
	return DataProvider.Instance().DT_OUTPUT_Delete(ID);
}

public DTOUTPUTInfo GetById(int ID)
{
	return (DTOUTPUTInfo)CBO.FillObject(DataProvider.Instance().DT_OUTPUT_GetById(ID), typeof(DTOUTPUTInfo));
}

public List<DTOUTPUTInfo> GetAll()
{
	List<DTOUTPUTInfo> list = new List<DTOUTPUTInfo>();
	ArrayList arr = CBO.FillCollection(DataProvider.Instance().DT_OUTPUT_GetAll(), typeof(DTOUTPUTInfo));
	foreach (object objItem in arr)
	{
		list.Add((DTOUTPUTInfo)objItem);
	}
	return list;
}

public DataSet GetAll_DS()
{
	return DataProvider.Instance().DT_OUTPUT_GetAll_DS();
}

#endregion

}

}