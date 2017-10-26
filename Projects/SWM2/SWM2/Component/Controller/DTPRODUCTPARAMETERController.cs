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

public partial class DTPRODUCTPARAMETERController
{

#region "Instances"
private static DTPRODUCTPARAMETERController _instance;

protected DTPRODUCTPARAMETERController()
{
}

protected void Dispose()
{
	_instance = null;
}

private static object _syncLock = new object();

public static DTPRODUCTPARAMETERController Instance()
{
	if (_instance == null) {
		lock (_syncLock) {
			if (_instance == null) {
				_instance = new DTPRODUCTPARAMETERController();
			}
		}
	}
	return _instance;
}

#endregion

#region "Public Methods"

public DTPRODUCTPARAMETERInfo Insert(DTPRODUCTPARAMETERInfo objInfo)
{
	objInfo.ID = Convert.ToInt32(DataProvider.Instance().DT_PRODUCT_PARAMETER_Insert(objInfo));
	return objInfo;
}

public int Update(DTPRODUCTPARAMETERInfo objInfo)
{
	return DataProvider.Instance().DT_PRODUCT_PARAMETER_Update(objInfo);
}

public int Delete(int ID)
{
	return DataProvider.Instance().DT_PRODUCT_PARAMETER_Delete(ID);
}

public DTPRODUCTPARAMETERInfo GetById(int ID)
{
	return (DTPRODUCTPARAMETERInfo)CBO.FillObject(DataProvider.Instance().DT_PRODUCT_PARAMETER_GetById(ID), typeof(DTPRODUCTPARAMETERInfo));
}

public List<DTPRODUCTPARAMETERInfo> GetAll()
{
	List<DTPRODUCTPARAMETERInfo> list = new List<DTPRODUCTPARAMETERInfo>();
	ArrayList arr = CBO.FillCollection(DataProvider.Instance().DT_PRODUCT_PARAMETER_GetAll(), typeof(DTPRODUCTPARAMETERInfo));
	foreach (object objItem in arr)
	{
		list.Add((DTPRODUCTPARAMETERInfo)objItem);
	}
	return list;
}

public DataSet GetAll_DS()
{
	return DataProvider.Instance().DT_PRODUCT_PARAMETER_GetAll_DS();
}

#endregion

}

}