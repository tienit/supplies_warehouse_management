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

public partial class DTDRUGINPUTLISTController
    {

#region "Instances"
private static DTDRUGINPUTLISTController _instance;

protected DTDRUGINPUTLISTController()
{
}

protected void Dispose()
{
	_instance = null;
}

private static object _syncLock = new object();

public static DTDRUGINPUTLISTController Instance()
{
	if (_instance == null) {
		lock (_syncLock) {
			if (_instance == null) {
				_instance = new DTDRUGINPUTLISTController();
			}
		}
	}
	return _instance;
}

#endregion

#region "Public Methods"

public DTDRUGINPUTLISTInfo Insert(DTDRUGINPUTLISTInfo objInfo)
{
	objInfo.ID = Convert.ToInt32(DataProvider.Instance().DM_DRUG_INPUTLIST_Insert(objInfo));
	return objInfo;
}

public int Update(DTDRUGINPUTLISTInfo objInfo)
{
	return DataProvider.Instance().DM_DRUG_INPUTLIST_Update(objInfo);
}

public int Delete(int ID)
{
	return DataProvider.Instance().DM_DRUG_INPUTLIST_Delete(ID);
}

public DTDRUGINPUTLISTInfo GetById(int ID)
{
	return (DTDRUGINPUTLISTInfo)CBO.FillObject(DataProvider.Instance().DM_DRUG_INPUTLIST_GetById(ID), typeof(DTDRUGINPUTLISTInfo));
}

public List<DTDRUGINPUTLISTInfo> GetAll()
{
	List<DTDRUGINPUTLISTInfo> list = new List<DTDRUGINPUTLISTInfo>();
	ArrayList arr = CBO.FillCollection(DataProvider.Instance().DM_DRUG_INPUTLIST_GetAll(), typeof(DTDRUGINPUTLISTInfo));
	foreach (object objItem in arr)
	{
		list.Add((DTDRUGINPUTLISTInfo)objItem);
	}
	return list;
}

public DataSet GetAll_DS()
{
	return DataProvider.Instance().DM_DRUG_INPUTLIST_GetAll_DS();
}

#endregion

}

}