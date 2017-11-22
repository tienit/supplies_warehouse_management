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

public partial class DTDRUGINPUTController
    {

#region "Instances"
private static DTDRUGINPUTController _instance;

protected DTDRUGINPUTController()
{
}

protected void Dispose()
{
	_instance = null;
}

private static object _syncLock = new object();

public static DTDRUGINPUTController Instance()
{
	if (_instance == null) {
		lock (_syncLock) {
			if (_instance == null) {
				_instance = new DTDRUGINPUTController();
			}
		}
	}
	return _instance;
}

#endregion

#region "Public Methods"

public DTDRUGINPUTInfo Insert(DTDRUGINPUTInfo objInfo)
{
	objInfo.ID = Convert.ToInt32(DataProvider.Instance().DM_DRUG_INPUT_Insert(objInfo));
	return objInfo;
}

public int Update(DTDRUGINPUTInfo objInfo)
{
	return DataProvider.Instance().DM_DRUG_INPUT_Update(objInfo);
}

public int Delete(int ID)
{
	return DataProvider.Instance().DM_DRUG_INPUT_Delete(ID);
}

public DTDRUGINPUTInfo GetById(int ID)
{
	return (DTDRUGINPUTInfo)CBO.FillObject(DataProvider.Instance().DM_DRUG_INPUT_GetById(ID), typeof(DTDRUGINPUTInfo));
}

public List<DTDRUGINPUTInfo> GetAll()
{
	List<DTDRUGINPUTInfo> list = new List<DTDRUGINPUTInfo>();
	ArrayList arr = CBO.FillCollection(DataProvider.Instance().DM_DRUG_INPUT_GetAll(), typeof(DTDRUGINPUTInfo));
	foreach (object objItem in arr)
	{
		list.Add((DTDRUGINPUTInfo)objItem);
	}
	return list;
}

public DataSet GetAll_DS()
{
	return DataProvider.Instance().DM_DRUG_INPUT_GetAll_DS();
}

#endregion

}

}