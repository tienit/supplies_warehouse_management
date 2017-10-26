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

public partial class DTOUTPUTDETAILController
{

#region "Instances"
private static DTOUTPUTDETAILController _instance;

protected DTOUTPUTDETAILController()
{
}

protected void Dispose()
{
	_instance = null;
}

private static object _syncLock = new object();

public static DTOUTPUTDETAILController Instance()
{
	if (_instance == null) {
		lock (_syncLock) {
			if (_instance == null) {
				_instance = new DTOUTPUTDETAILController();
			}
		}
	}
	return _instance;
}

#endregion

#region "Public Methods"

public DTOUTPUTDETAILInfo Insert(DTOUTPUTDETAILInfo objInfo)
{
	objInfo.ID = Convert.ToInt32(DataProvider.Instance().DT_OUTPUTDETAIL_Insert(objInfo));
	return objInfo;
}

public int Update(DTOUTPUTDETAILInfo objInfo)
{
	return DataProvider.Instance().DT_OUTPUTDETAIL_Update(objInfo);
}

public int Delete(int ID)
{
	return DataProvider.Instance().DT_OUTPUTDETAIL_Delete(ID);
}

public DTOUTPUTDETAILInfo GetById(int ID)
{
	return (DTOUTPUTDETAILInfo)CBO.FillObject(DataProvider.Instance().DT_OUTPUTDETAIL_GetById(ID), typeof(DTOUTPUTDETAILInfo));
}

public List<DTOUTPUTDETAILInfo> GetAll()
{
	List<DTOUTPUTDETAILInfo> list = new List<DTOUTPUTDETAILInfo>();
	ArrayList arr = CBO.FillCollection(DataProvider.Instance().DT_OUTPUTDETAIL_GetAll(), typeof(DTOUTPUTDETAILInfo));
	foreach (object objItem in arr)
	{
		list.Add((DTOUTPUTDETAILInfo)objItem);
	}
	return list;
}

public DataSet GetAll_DS()
{
	return DataProvider.Instance().DT_OUTPUTDETAIL_GetAll_DS();
}

#endregion

}

}