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

public partial class DMPRICEController
{

#region "Instances"
private static DMPRICEController _instance;

protected DMPRICEController()
{
}

protected void Dispose()
{
	_instance = null;
}

private static object _syncLock = new object();

public static DMPRICEController Instance()
{
	if (_instance == null) {
		lock (_syncLock) {
			if (_instance == null) {
				_instance = new DMPRICEController();
			}
		}
	}
	return _instance;
}

#endregion

#region "Public Methods"

public DMPRICEInfo Insert(DMPRICEInfo objInfo)
{
	objInfo.ID = Convert.ToInt32(DataProvider.Instance().DM_PRICE_Insert(objInfo));
	return objInfo;
}

public int Update(DMPRICEInfo objInfo)
{
	return DataProvider.Instance().DM_PRICE_Update(objInfo);
}

public int Delete(int ID)
{
	return DataProvider.Instance().DM_PRICE_Delete(ID);
}

public DMPRICEInfo GetById(int ID)
{
	return (DMPRICEInfo)CBO.FillObject(DataProvider.Instance().DM_PRICE_GetById(ID), typeof(DMPRICEInfo));
}

public List<DMPRICEInfo> GetAll()
{
	List<DMPRICEInfo> list = new List<DMPRICEInfo>();
	ArrayList arr = CBO.FillCollection(DataProvider.Instance().DM_PRICE_GetAll(), typeof(DMPRICEInfo));
	foreach (object objItem in arr)
	{
		list.Add((DMPRICEInfo)objItem);
	}
	return list;
}

public DataSet GetAll_DS()
{
	return DataProvider.Instance().DM_PRICE_GetAll_DS();
}

#endregion

}

}