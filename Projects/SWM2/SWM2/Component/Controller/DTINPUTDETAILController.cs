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

public partial class DTINPUTDETAILController
{

#region "Instances"
private static DTINPUTDETAILController _instance;

protected DTINPUTDETAILController()
{
}

protected void Dispose()
{
	_instance = null;
}

private static object _syncLock = new object();

public static DTINPUTDETAILController Instance()
{
	if (_instance == null) {
		lock (_syncLock) {
			if (_instance == null) {
				_instance = new DTINPUTDETAILController();
			}
		}
	}
	return _instance;
}

#endregion

#region "Public Methods"

public DTINPUTDETAILInfo Insert(DTINPUTDETAILInfo objInfo)
{
	objInfo.ID = Convert.ToInt32(DataProvider.Instance().DT_INPUTDETAIL_Insert(objInfo));
	return objInfo;
}

public int Update(DTINPUTDETAILInfo objInfo)
{
	return DataProvider.Instance().DT_INPUTDETAIL_Update(objInfo);
}

public int Delete(int ID)
{
	return DataProvider.Instance().DT_INPUTDETAIL_Delete(ID);
}

public DTINPUTDETAILInfo GetById(int ID)
{
	return (DTINPUTDETAILInfo)CBO.FillObject(DataProvider.Instance().DT_INPUTDETAIL_GetById(ID), typeof(DTINPUTDETAILInfo));
}

public List<DTINPUTDETAILInfo> GetAll()
{
	List<DTINPUTDETAILInfo> list = new List<DTINPUTDETAILInfo>();
	ArrayList arr = CBO.FillCollection(DataProvider.Instance().DT_INPUTDETAIL_GetAll(), typeof(DTINPUTDETAILInfo));
	foreach (object objItem in arr)
	{
		list.Add((DTINPUTDETAILInfo)objItem);
	}
	return list;
}

public DataSet GetAll_DS()
{
	return DataProvider.Instance().DT_INPUTDETAIL_GetAll_DS();
}

        public DataSet GetTop0Row()
        {
            return DataProvider.Instance().DT_INPUTDETAIL_GetTop0Row();
        }
#endregion

}

}