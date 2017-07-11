//*************************************************************
//Author           : Tien NQ
//Created Date     : 7/7/2017
//Comment          : Base class for access to database.
//History          : 
//*************************************************************

namespace VKTIM.Component
{

public static class SqlConnect
{

private static string _ConnectionString;

public static string ConnectionString {
	get {
		if (!string.IsNullOrEmpty(_ConnectionString)) {
			return _ConnectionString;
		} else {
			_ConnectionString = string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3}", Properties.Settings.Default.CS_ServerName, Properties.Settings.Default.CS_DatabaseName, Properties.Settings.Default.CS_UserName, Properties.Settings.Default.CS_PassWord);
                    return _ConnectionString;
		}
	}
	set { _ConnectionString = value; }
}

}

}