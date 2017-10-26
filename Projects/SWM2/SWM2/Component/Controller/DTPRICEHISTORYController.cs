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

public partial class DTPRICEHISTORYController
{

#region "Instances"
private static DTPRICEHISTORYController _instance;

protected DTPRICEHISTORYController()
{
}

protected void Dispose()
{
	_instance = null;
}

private static object _syncLock = new object();

public static DTPRICEHISTORYController Instance()
{
	if (_instance == null) {
		lock (_syncLock) {
			if (_instance == null) {
				_instance = new DTPRICEHISTORYController();
			}
		}
	}
	return _instance;
}

#endregion

#region "Public Methods"

public DTPRICEHISTORYInfo Insert(DTPRICEHISTORYInfo objInfo)
{
	objInfo.ID = Convert.ToInt32(DataProvider.Instance().DT_PRICEHISTORY_Insert(objInfo));
	return objInfo;
}

public int Update(DTPRICEHISTORYInfo objInfo)
{
	return DataProvider.Instance().DT_PRICEHISTORY_Update(objInfo);
}

public int Delete(int ID)
{
	return DataProvider.Instance().DT_PRICEHISTORY_Delete(ID);
}

public DTPRICEHISTORYInfo GetById(int ID)
{
	return (DTPRICEHISTORYInfo)CBO.FillObject(DataProvider.Instance().DT_PRICEHISTORY_GetById(ID), typeof(DTPRICEHISTORYInfo));
}

public List<DTPRICEHISTORYInfo> GetAll()
{
	List<DTPRICEHISTORYInfo> list = new List<DTPRICEHISTORYInfo>();
	ArrayList arr = CBO.FillCollection(DataProvider.Instance().DT_PRICEHISTORY_GetAll(), typeof(DTPRICEHISTORYInfo));
	foreach (object objItem in arr)
	{
		list.Add((DTPRICEHISTORYInfo)objItem);
	}
	return list;
}

public DataSet GetAll_DS()
{
	return DataProvider.Instance().DT_PRICEHISTORY_GetAll_DS();
}

#endregion

}

}