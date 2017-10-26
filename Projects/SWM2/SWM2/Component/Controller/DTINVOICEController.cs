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

public partial class DTINVOICEController
{

#region "Instances"
private static DTINVOICEController _instance;

protected DTINVOICEController()
{
}

protected void Dispose()
{
	_instance = null;
}

private static object _syncLock = new object();

public static DTINVOICEController Instance()
{
	if (_instance == null) {
		lock (_syncLock) {
			if (_instance == null) {
				_instance = new DTINVOICEController();
			}
		}
	}
	return _instance;
}

#endregion

#region "Public Methods"

public DTINVOICEInfo Insert(DTINVOICEInfo objInfo)
{
	objInfo.ID = Convert.ToInt32(DataProvider.Instance().DT_INVOICE_Insert(objInfo));
	return objInfo;
}

public int Update(DTINVOICEInfo objInfo)
{
	return DataProvider.Instance().DT_INVOICE_Update(objInfo);
}

public int Delete(int ID)
{
	return DataProvider.Instance().DT_INVOICE_Delete(ID);
}

public DTINVOICEInfo GetById(int ID)
{
	return (DTINVOICEInfo)CBO.FillObject(DataProvider.Instance().DT_INVOICE_GetById(ID), typeof(DTINVOICEInfo));
}

public List<DTINVOICEInfo> GetAll()
{
	List<DTINVOICEInfo> list = new List<DTINVOICEInfo>();
	ArrayList arr = CBO.FillCollection(DataProvider.Instance().DT_INVOICE_GetAll(), typeof(DTINVOICEInfo));
	foreach (object objItem in arr)
	{
		list.Add((DTINVOICEInfo)objItem);
	}
	return list;
}

public DataSet GetAll_DS()
{
	return DataProvider.Instance().DT_INVOICE_GetAll_DS();
}

#endregion

}

}