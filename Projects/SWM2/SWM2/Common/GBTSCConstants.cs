using VKTIM.Component;
using System.Resources;
using System.Globalization;

namespace VKTIM.Common
{
    public enum ACTION_TYPE
    {
        AddNew = 1,
        Update = 2,
        Delete = 3,
        OnlyView = 4
    }

    public enum GIRD_COLUMN_TYPE
    {
        TextBox = 1,
        ComboBox = 2,
        Image = 3,
        Link = 4,
        CheckBox = 5,
        Button = 6
    }

    public class GBTSCConstants
    {
        //MessageBox Caption
        public static int BUHINSOKO_MSG_BOX_CAPTION_DEFAULT;


        //Check newest version
        public static string BUHINSOKO_LATEST_VERSION;


        //Resources
        public static ResourceManager CURRENT_RESOURCES;
        public static CultureInfo CURRENT_CULTURE; 



        //Current User
        public static HTUSERInfo CURRENT_USER;
        //public static TMFACTORYInfo CURRENT_FACTORY;



        //System Name
        public static string ESWS_SYS_NAME = "VKTIM";
        public static string ESWS_SYS_TITLE = "VKT INVENTORY MANAGEMENT";


        //Text
        public static string TXT_REVISION
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("TXT_REVISION", GBTSCConstants.CURRENT_CULTURE); } }

        public static string TXT_SERVER
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("TXT_SERVER", GBTSCConstants.CURRENT_CULTURE); } }

        //STRING RESOURCES
        //COMMON STRING
        //OK
        public static string MSG_ADD_FAILED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("MSG_ADD_FAILED", GBTSCConstants.CURRENT_CULTURE); } }

        
        //OK
        public static string MSG_EXIT_CONFIRM
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("MSG_EXIT_CONFIRM", GBTSCConstants.CURRENT_CULTURE); } }


        //CAPTION OF MESSAGE BOX
        //OK
        public static string MSG_CAPTION_ERROR
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("MSG_CAPTION_ERROR", GBTSCConstants.CURRENT_CULTURE); } }


        //OK
        public static string MSG_CAPTION_DELETE
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("MSG_CAPTION_DELETE", GBTSCConstants.CURRENT_CULTURE); } }


        //OK
        public static string MSG_SERVER_CONNECT_FAILED_AND_CHECK
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("MSG_SERVER_CONNECT_FAILED_AND_CHECK", GBTSCConstants.CURRENT_CULTURE); } }
        
        //OK
        public static string MSG_SERVER_CONNECT_SUCCESS
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("MSG_SERVER_CONNECT_SUCCESS", GBTSCConstants.CURRENT_CULTURE); } }

        //OK
        public static string MSG_LOGIN_ACCOUNT_NOT_VALID
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("MSG_LOGIN_ACCOUNT_NOT_VALID", GBTSCConstants.CURRENT_CULTURE); } }

        //OK
        public static string MSG_LOGIN_ACCOUNT_LOCKED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("MSG_LOGIN_ACCOUNT_LOCKED", GBTSCConstants.CURRENT_CULTURE); } }

        //OK
        public static string MSG_LOGOUT_CONFIRM
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("MSG_LOGOUT_CONFIRM", GBTSCConstants.CURRENT_CULTURE); } }

        //Change Password
        //OK
        public static string MSG_CHANGE_PASS_CURRENT_INVALID
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("MSG_CHANGE_PASS_CURRENT_INVALID", GBTSCConstants.CURRENT_CULTURE); } }
        //OK
        public static string MSG_CHANGE_PASS_SUCCESS_AND_RESTART
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("MSG_CHANGE_PASS_SUCCESS_AND_RESTART", GBTSCConstants.CURRENT_CULTURE); } }
        //OK
        public static string MSG_CHANGE_PASS_NEW_EQUAL_CURRENT
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("MSG_CHANGE_PASS_NEW_EQUAL_CURRENT", GBTSCConstants.CURRENT_CULTURE); } }

        //OK
        public static string MSG_CHANGE_CONNECTION_SUCCESS_AND_RESTART
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("MSG_CHANGE_CONNECTION_SUCCESS_AND_RESTART", GBTSCConstants.CURRENT_CULTURE); } }


        //OK
        public static string MSG_DELETE_CONFIRM
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("MSG_DELETE_CONFIRM", GBTSCConstants.CURRENT_CULTURE); } }

        //OK
        public static string MSG_UPDATE_NOTIFY
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("MSG_UPDATE_NOTIFY", GBTSCConstants.CURRENT_CULTURE); } }
       
        //OK
        public static string MSG_UPDATE_LATEST_VERSION
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("MSG_UPDATE_LATEST_VERSION", GBTSCConstants.CURRENT_CULTURE); } }

        public static string MSG_REPORT_NO_DATA_TO_EXPORT_EXCEL
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("MSG_REPORT_NO_DATA_TO_EXPORT_EXCEL", GBTSCConstants.CURRENT_CULTURE); } }

        public static string MSG_REPORT_TO_EXCEL_SUCCESS
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("MSG_REPORT_TO_EXCEL_SUCCESS", GBTSCConstants.CURRENT_CULTURE); } }

        public static string MSG_PC_NOT_IN_USED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("MSG_PC_NOT_IN_USED", GBTSCConstants.CURRENT_CULTURE); } }

        public static string MSG_PC_IS_BLOCKED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("MSG_PC_IS_BLOCKED", GBTSCConstants.CURRENT_CULTURE); } }

    }

}
