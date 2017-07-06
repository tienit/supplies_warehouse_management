//*************************************************************
//Author           : Tien NQ
//Created Date     : 7/7/2017
//Comment          : Base class for access to database.
//History          : 
//*************************************************************

using System;

namespace VKTIM.Component
{

public abstract class CommonDataProvider
{

#region "Constructor"
private static DataProvider _instance;

protected CommonDataProvider()
{
}

protected void Dispose()
{
	_instance = null;
}

private static object _syncLock = new object();

public static DataProvider Instance()
{
	if (_instance == null) {
		lock (_syncLock) {
			if (_instance == null) {
				_instance = new DataProvider();
			}
		}
	}
	return _instance;
}

public object DB_GetNull(object Field)
{
return tienit.core.Null.GetNull(Field, DBNull.Value);
}

#endregion

}

}