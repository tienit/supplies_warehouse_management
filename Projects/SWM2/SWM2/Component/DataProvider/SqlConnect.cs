//*************************************************************
//Author           : Tien NQ
//Created Date     : 9/6/2016
//Comment          : Base class for access to database.
//History          : 
//*************************************************************

using VKTIM.Common;

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
			_ConnectionString = string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3}", Crytopo.Decrypt_Rfc2898(Properties.Settings.Default.CS_ServerName), Crytopo.Decrypt_Rfc2898(Properties.Settings.Default.CS_DatabaseName), Crytopo.Decrypt_Rfc2898(Properties.Settings.Default.CS_UserName), Crytopo.Decrypt_Rfc2898(Properties.Settings.Default.CS_PassWord));
			return _ConnectionString;
		}
	}
	set { _ConnectionString = value; }
}

}

}