using eSWS.Component;
using System.Resources;
using System.Globalization;

namespace VKTIM.Common
{
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
        public static TMUSERSInfo CURRENT_USER;
        public static TMFACTORYInfo CURRENT_FACTORY;



        //System Name
        public static string ESWS_SYS_NAME = "eSWS";
        public static string ESWS_SYS_TITLE = "eSMART WAREHOUSE SYSTEM";


        //STRING RESOURCES
        //COMMON STRING
        public static string ESWS_MSG_VERSION
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_VERSION", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_CMB_INDEX_ZERO
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_CMB_INDEX_ZERO", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_CONTEXT_MENU_UNDO
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_CONTEXT_MENU_UNDO", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_ADD_FAILED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_ADD_FAILED", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_ADD_SUCCESS
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_ADD_SUCCESS", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_UPDATE_FAILED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_UPDATE_FAILED", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_DELETE_CONFIRM
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_DELETE_CONFIRM", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_DELETE_SUCCESS
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_DELETE_SUCCESS", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_DELETE_FAILED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_DELETE_FAILED", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_UPDATE_SUCCESS
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_UPDATE_SUCCESS", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_UPDATE_DELETE_NOT_SELECTED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_UPDATE_DELETE_NOT_SELECTED", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_NOT_LOGGED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_NOT_LOGGED", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_USED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_USED", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_NOT_USED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_NOT_USED", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_SURE
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_SURE", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_PALLET_EXPORTED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_PALLET_EXPORTED", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_PALLET_DELETED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_PALLET_DELETED", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_NEED_TO_CHECK
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_NEED_TO_CHECK", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_NO_NEED_TO_CHECK
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_NO_NEED_TO_CHECK", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_PAGE
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_PAGE", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_LAYOUT_WAREHOUSE
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_LAYOUT_WAREHOUSE", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_LAYOUT_AREA
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_LAYOUT_AREA", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_LAYOUT_LINE
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_LAYOUT_LINE", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_LAYOUT_FLOOR
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_LAYOUT_FLOOR", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_LAYOUT_CELL
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_LAYOUT_CELL", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_DELETE_EMPTY
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_DELETE_EMPTY", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_FUNCTION_BLOCKED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_FUNCTION_BLOCKED", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_WAREHOUSE_MAINTENENCE
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_FUNCTION_BLOCKED", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_LOGOUT_CONFIRM
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_LOGOUT_CONFIRM", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_CHANGE_CONNECTION_SUCCESS_AND_RESTART
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_CHANGE_CONNECTION_SUCCESS_AND_RESTART", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_EXIT_CONFIRM
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_EXIT_CONFIRM", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_UPDATE_LATEST_VERSION
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_UPDATE_LATEST_VERSION", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_SETTNG_CONFIRM
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_SETTNG_CONFIRM", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_SETTNG__SAVED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_SETTNG__SAVED", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_YES
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_YES", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_NO
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_NO", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_DOUBLE_CLICK_TO_CLOSE
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_DOUBLE_CLICK_TO_CLOSE", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_WH_SETTING_NOT_YET
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_WH_SETTING_NOT_YET", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_WH_SETTING_CREATED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_WH_SETTING_CREATED", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_WH_SETTING_SAVED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_WH_SETTING_SAVED", GBTSCConstants.CURRENT_CULTURE); } }



        //CAPTION OF MESSAGE BOX
        public static string ESWS_MSG_CAPTION_ERROR
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_CAPTION_ERROR", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_CAPTION_CHG_STATUS
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_CAPTION_CHG_STATUS", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_CAPTION_DELETE
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_CAPTION_DELETE", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_CAPTION_UPDATE
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_CAPTION_UPDATE", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_CAPTION_INSERT
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_CAPTION_INSERT", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_CAPTION_MOVING
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_CAPTION_MOVING", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_CAPTION_LAYOUT
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_CAPTION_LAYOUT", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_CAPTION_DELETION_REQUEST
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_CAPTION_DELETION_REQUEST", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_CAPTION_EXPORT_REPRINT
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_CAPTION_EXPORT_REPRINT", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_CAPTION_PERMISSION
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_CAPTION_PERMISSION", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_CAPTION_FEEDBACK
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_CAPTION_FEEDBACK", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_CAPTION_CONFIRM
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_CAPTION_CONFIRM", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_CAPTION_LOGOUT
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_CAPTION_LOGOUT", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_CAPTION_EXIT
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_CAPTION_EXIT", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_CAPTION_VERSION
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_CAPTION_VERSION", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_CAPTION_REINPUT
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_CAPTION_REINPUT", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_CAPTION_EXPORT_EXCEL
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_CAPTION_EXPORT_EXCEL", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_CAPTION_BLOCKED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_CAPTION_BLOCKED", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_CAPTION_SETTING
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_CAPTION_SETTING", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_CAPTION_IMPORT
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_CAPTION_IMPORT", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_CAPTION_EXPORT
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_CAPTION_EXPORT", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_CAPTION_WH_SETTING
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_CAPTION_WH_SETTING", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_CAPTION_CANCEL_EXPORT
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_CAPTION_CANCEL_EXPORT", GBTSCConstants.CURRENT_CULTURE); } }



        //CONNECTION SETTING
        public static string ESWS_MSG_CAPTION_CONNECTION
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_CAPTION_CONNECTION", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_SERVER_CONNECT_SUCCESS
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_SERVER_CONNECT_SUCCESS", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_SERVER_CONNECT_FAILED_AND_CHECK
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_SERVER_CONNECT_FAILED_AND_CHECK", GBTSCConstants.CURRENT_CULTURE); } }
        



        //CHANGE PASSWORD
        public static string ESWS_MSG_CAPTION_CHG_PASS
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_CAPTION_CHG_PASS", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_CHG_PASS_FAILED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_CHG_PASS_FAILED", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_CHG_PASS_SUCCESS
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_CHG_PASS_SUCCESS", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_CHG_PASS_SUCCESS_AND_RESTART
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_CHG_PASS_SUCCESS_AND_RESTART", GBTSCConstants.CURRENT_CULTURE); } }




        //CHANGE STATUS
        public static string ESWS_MSG_CHG_STATUS_LOT_NO_PALLET_FOR_CHANGE
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_CHG_STATUS_LOT_NO_PALLET_FOR_CHANGE", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_CHG_STATUS_LOT_CHANGE_CONFIRM
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_CHG_STATUS_LOT_CHANGE_CONFIRM", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_CHG_STATUS_LOT_FINISHED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_CHG_STATUS_LOT_FINISHED", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_CHG_STATUS_SUCCESS
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_CHG_STATUS_SUCCESS", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_CHG_STATUS_NO_PALLET_SELECTED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_CHG_STATUS_NO_PALLET_SELECTED", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_CHG_STATUS_AT_LEAST_ONE_PALLET_CHECKED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_CHG_STATUS_AT_LEAST_ONE_PALLET_CHECKED", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_CHG_STATUS_GROUP_CONFIRM
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_CHG_STATUS_GROUP_CONFIRM", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_CHG_STATUS_FROM_TO_INFOR
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_CHG_STATUS_FROM_TO_INFOR", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_CHG_STATUS_GROUP_X_SUCCESS
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_CHG_STATUS_GROUP_X_SUCCESS", GBTSCConstants.CURRENT_CULTURE); } }




        //COMPANY
        public static string ESWS_MSG_COMPANY_UPDATE_RELATIONSHIP
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_COMPANY_UPDATE_RELATIONSHIP", GBTSCConstants.CURRENT_CULTURE); } }



        //LAYOUT (WAREHOUSE - AREA - LINE - FLOOR - CELL - FLOOR GROUP)
        public static string ESWS_MSG_LAYOUT_SELECT_WAREHOUSE_FIRST
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_LAYOUT_SELECT_WAREHOUSE_FIRST", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_LAYOUT_AREA_EXISTED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_LAYOUT_AREA_EXISTED", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_LAYOUT_WAREHOUSE_RELATIONSHIP_AREA_UPDATE
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_LAYOUT_WAREHOUSE_RELATIONSHIP_AREA_UPDATE", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_LAYOUT_WAREHOUSE_RELATIONSHIP_USERGROUP_UPDATE
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_LAYOUT_WAREHOUSE_RELATIONSHIP_USERGROUP_UPDATE", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_LAYOUT_WAREHOUSE_RELATIONSHIP_AREA_DEL
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_LAYOUT_WAREHOUSE_RELATIONSHIP_AREA_DEL", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_LAYOUT_WAREHOUSE_RELATIONSHIP_USERGROUP_DEL
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_LAYOUT_WAREHOUSE_RELATIONSHIP_USERGROUP_DEL", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_LAYOUT_NUMBER_OF_CELLS
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_LAYOUT_NUMBER_OF_CELLS", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_LAYOUT_NUMBER_OF_FLOORS
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_LAYOUT_NUMBER_OF_FLOORS", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_LAYOUT_EXCEEDS_MAX_FLOORS
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_LAYOUT_EXCEEDS_MAX_FLOORS", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_LAYOUT_UPDATE_DELETE_FLOOR_NOT_SELECTED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_LAYOUT_UPDATE_DELETE_FLOOR_NOT_SELECTED", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_LAYOUT_FLOOR_HAS_PALLETS_UPDATE
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_LAYOUT_FLOOR_HAS_PALLETS_UPDATE", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_LAYOUT_FLOOR_HAS_PALLETS_DELETE
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_LAYOUT_FLOOR_HAS_PALLETS_DELETE", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_LAYOUT_WANT_AUTO_CREATE_CELL
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_LAYOUT_WANT_AUTO_CREATE_CELL", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_LAYOUT_AUTO_CREATED_X_CELLS
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_LAYOUT_AUTO_CREATED_X_CELLS", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_LAYOUT_ALL_CELLS_DELETED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_LAYOUT_ALL_CELLS_DELETED", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_LAYOUT_EXCEEDS_MAX_CELLS
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_LAYOUT_EXCEEDS_MAX_CELLS", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_LAYOUT_ADD_CELL
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_LAYOUT_ADD_CELL", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_LAYOUT_UPDATE_CELL
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_LAYOUT_UPDATE_CELL", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_LAYOUT_CELL_HAS_PALLET
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_LAYOUT_CELL_HAS_PALLET", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_LAYOUT_EXCEEDS_MAX_LINES
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_LAYOUT_EXCEEDS_MAX_LINES", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_LAYOUT_LINE_NAME_EXISTED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_LAYOUT_LINE_NAME_EXISTED", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_LAYOUT_LINE_WORKING
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_LAYOUT_LINE_WORKING", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_LAYOUT_UPDATE_BATCH_CELLS_SUCCESS
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_LAYOUT_UPDATE_BATCH_CELLS_SUCCESS", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_LAYOUT_FROM_MUST_LESS_THAN_TO
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_LAYOUT_FROM_MUST_LESS_THAN_TO", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_LAYOUT_DELETE_BATCH_CELLS_SUCCESS
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_LAYOUT_DELETE_BATCH_CELLS_SUCCESS", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_LAYOUT_UPDATE_BATCH_CELL_HEIGHT_SUCCESS
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_LAYOUT_UPDATE_BATCH_CELL_HEIGHT_SUCCESS", GBTSCConstants.CURRENT_CULTURE); } }
        




        //STATUS LOT
        public static string ESWS_MSG_LOT_STATUS_DELETE_RELATIONSHIP
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_LOT_STATUS_DELETE_RELATIONSHIP", GBTSCConstants.CURRENT_CULTURE); } }


        //STATUS PALLET
        public static string ESWS_MSG_PALLET_STATUS_DELETE_RELATIONSHIP
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_PALLET_STATUS_DELETE_RELATIONSHIP", GBTSCConstants.CURRENT_CULTURE); } }


        //DELETE PALLET
        public static string ESWS_MSG_THIS_FUCNTION_BLOCKED_BY_ADMIN
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_THIS_FUCNTION_BLOCKED_BY_ADMIN", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_WH_IMPORT_DELETE_PALLET_SUCCESS
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_WH_IMPORT_DELETE_PALLET_SUCCESS", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_WH_IMPORT_PALLET_NOT_EXISTED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_WH_IMPORT_PALLET_NOT_EXISTED", GBTSCConstants.CURRENT_CULTURE); } }
        


        //WAREHOUSE INVENTORY
        public static string ESWS_MSG_WH_INVENTORY_MOVING_INFOR
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_WH_INVENTORY_MOVING_INFOR", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_WH_IMPORT_REPRINT_PALLET_CODE_NOT_EXISTED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_WH_IMPORT_REPRINT_PALLET_CODE_NOT_EXISTED", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_WH_PALLET_WAIT_EXPORT
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_WH_PALLET_WAIT_EXPORT", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_WH_LINE_NOT_CONFIG
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_WH_LINE_NOT_CONFIG", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_WH_NO_CONFIG_FOR_LINE
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_WH_NO_CONFIG_FOR_LINE", GBTSCConstants.CURRENT_CULTURE); } }

        


        //MASTER DATA
        public static string ESWS_MSG_MASTER_DELETION_REQUEST_CONFIRM
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_MASTER_DELETION_REQUEST_CONFIRM", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_MASTER_DELETION_REQUEST_CONFIRMED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_MASTER_DELETION_REQUEST_CONFIRMED", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_MASTER_DELETION_REQUEST_RESTORE
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_MASTER_DELETION_REQUEST_RESTORE", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_MASTER_DELETION_REQUEST_RESTORED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_MASTER_DELETION_REQUEST_RESTORED", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_DELETION_REQUEST_SUPPLIER_WAITING
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_DELETION_REQUEST_SUPPLIER_WAITING", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_DELETION_REQUEST_SUPPLIER_CANCELED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_DELETION_REQUEST_SUPPLIER_CANCELED", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_DELETION_REQUEST_SUPPLIER_ACCEPTED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_DELETION_REQUEST_SUPPLIER_ACCEPTED", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_DELETION_REQUEST_SENT
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_DELETION_REQUEST_SENT", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_DELETION_REQUEST_SUPPLIER_USING
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_DELETION_REQUEST_SUPPLIER_USING", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_DELETION_REQUEST_GOODS_USING
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_DELETION_REQUEST_GOODS_USING", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_MASTER_EXISTED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_MASTER_EXISTED", GBTSCConstants.CURRENT_CULTURE); } }



        //WAREHOUSING EXPORT
        public static string ESWS_MSG_WH_EXPORT_CODE_NOT_EXISTED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_WH_EXPORT_CODE_NOT_EXISTED", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_WAREHOUSE_GOODS_CODE_NOT_EXISTED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_WAREHOUSE_GOODS_CODE_NOT_EXISTED", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_WH_EXPORT_SUCCESS
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_WH_EXPORT_SUCCESS", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_WH_EXPORT_PALLET_SCANED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_WH_EXPORT_PALLET_SCANED", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_WH_EXPORT_PALLET_ISNOT_BELONGS_SCANED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_WH_EXPORT_PALLET_ISNOT_BELONGS_SCANED", GBTSCConstants.CURRENT_CULTURE); } }
        




        //WAREHOUSING IMPORT
        public static string ESWS_MSG_WH_IMPORT_LOT_NOT_EXISTED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_WH_IMPORT_LOT_NOT_EXISTED", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_WH_IMPORT_PALLET_USING_OR_DELTED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_WH_IMPORT_PALLET_USING_OR_DELTED", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_WH_IMPORT_PALLET_NOT_IN_WAREHOUSE
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_WH_IMPORT_PALLET_NOT_IN_WAREHOUSE", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_WH_IMPORT_REINPUT_SUCCESS
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_WH_IMPORT_REINPUT_SUCCESS", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_WH_IMPORT_NOT_FOUND_LOCATION
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_WH_IMPORT_NOT_FOUND_LOCATION", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_WH_IMPORT_LOCATION_NOT_AVAILABLE
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_WH_IMPORT_LOCATION_NOT_AVAILABLE", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_WH_IMPORT_BARCODE_INVALID
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_WH_IMPORT_BARCODE_INVALID", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_WH_IMPORT_DATE_FORMAT_INVALID
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_WH_IMPORT_DATE_FORMAT_INVALID", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_WH_IMPORT_NO_AVAILABLE_LOCATION
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_WH_IMPORT_NO_AVAILABLE_LOCATION", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_WH_IMPORT_BARCODE_EMPTY
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_WH_IMPORT_BARCODE_EMPTY", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_WH_IMPORT_LOCATION_USING
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_WH_IMPORT_LOCATION_USING", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_WH_IMPORT_RECEIVED_AND_SELECT_LOCATION
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_WH_IMPORT_RECEIVED_AND_SELECT_LOCATION", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_WH_IMPORT_RECEIVED_ERROR
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_WH_IMPORT_RECEIVED_ERROR", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_WH_IMPORT_LOCATION_NOT_IN_LIST
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_WH_IMPORT_LOCATION_NOT_IN_LIST", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_WH_IMPORT_SUCCESS
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_WH_IMPORT_SUCCESS", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_WH_IMPORT_LOT_USED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_WH_IMPORT_LOT_USED", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_WH_IMPORT_NUMBER_LOCATION_NOT_ENOUGH
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_WH_IMPORT_NUMBER_LOCATION_NOT_ENOUGH", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_WH_IMPORT_LOT_NOT_ENOUGH_LOCATIONS
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_WH_IMPORT_LOT_NOT_ENOUGH_LOCATIONS", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_WH_IMPORT_LOT_CHANGED_WHILE_OPEN_THIS
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_WH_IMPORT_LOT_CHANGED_WHILE_OPEN_THIS", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_WH_IMPORT_LOT_HAS_LOCATION_USED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_WH_IMPORT_LOT_HAS_LOCATION_USED", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_WH_IMPORT_ADD_X_PALLET_SUCCESS
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_WH_IMPORT_ADD_X_PALLET_SUCCESS", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_WH_IMPORT_INVOICE_CANCELED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_WH_IMPORT_INVOICE_CANCELED", GBTSCConstants.CURRENT_CULTURE); } }
        





        //WAREHOUSE INVENTORY
        public static string ESWS_MSG_REPORT_NO_DATA_TO_EXPORT_EXCEL
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_REPORT_NO_DATA_TO_EXPORT_EXCEL", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_REPORT_TO_EXCEL_SUCCESS
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_REPORT_TO_EXCEL_SUCCESS", GBTSCConstants.CURRENT_CULTURE); } }
        



        //WAREHOUSE MAP
        public static string ESWS_MSG_WH_MAP_FOUND_X_PALLETS
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_WH_MAP_FOUND_X_PALLETS", GBTSCConstants.CURRENT_CULTURE); } }



        //PERMISSION
        public static string ESWS_MSG_PERMISSION_WAREHOUSE_SUCCESS
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_PERMISSION_WAREHOUSE_SUCCESS", GBTSCConstants.CURRENT_CULTURE); } }



        //FEEDBACK
        public static string ESWS_MSG_FEEDBACK_FUNCTION_NOT_SELECTED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_FEEDBACK_FUNCTION_NOT_SELECTED", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_FEEDBACK_SEND_OK
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_FEEDBACK_SEND_OK", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_FEEDBACK_SEND_FAILED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_FEEDBACK_SEND_FAILED", GBTSCConstants.CURRENT_CULTURE); } }



        //USER MANAGEMENT
        public static string ESWS_MSG_USERS_LOCK
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_USERS_LOCK", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_USERS_UNLOCK
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_USERS_UNLOCK", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_USERGROUP_NAME_EXISTED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_USERGROUP_NAME_EXISTED", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_USERGROUP_NOT_SELECTED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_USERGROUP_NOT_SELECTED", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_PERMISSION_USERGROUP_SUCCESS
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_PERMISSION_USERGROUP_SUCCESS", GBTSCConstants.CURRENT_CULTURE); } }

        



        //LOGIN
        public static string ESWS_MSG_LOGIN_ACCOUNT_NOT_VALID
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_LOGIN_ACCOUNT_NOT_VALID", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_LOGIN_ACCOUNT_LOCKED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_LOGIN_ACCOUNT_NOT_VALID", GBTSCConstants.CURRENT_CULTURE); } }



        //SMART DEVICES
        public static string ESWS_MSG_SMART_AT_LEAST_ONE_WAREHOUSE_SELECTED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_SMART_AT_LEAST_ONE_WAREHOUSE_SELECTED", GBTSCConstants.CURRENT_CULTURE); } }

        public static string ESWS_MSG_SMART_WORKING
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("ESWS_MSG_SMART_WORKING", GBTSCConstants.CURRENT_CULTURE); } }




        //Login
        public static string BUHINSOKO_MSG_SERVER_CONNECT_FAILED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_SERVER_CONNECT_FAILED", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_SERVER_CONNECT_FAILED_AND_CHECK
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_SERVER_CONNECT_FAILED_AND_CHECK", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_SERVER_CONNECT_SUCCESS
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_SERVER_CONNECT_SUCCESS", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_LOGIN_ACCOUNT_NOT_VALID
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_LOGIN_ACCOUNT_NOT_VALID", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_LOGIN_ACCOUNT_LOCKED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_LOGIN_ACCOUNT_LOCKED", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_FACTORY_SELECTED_NOT_AVAILABLE
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_FACTORY_SELECTED_NOT_AVAILABLE", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_FACTORY_SELECTED_INVALID
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_FACTORY_SELECTED_INVALID", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_LOGOUT_CONFIRM
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_LOGOUT_CONFIRM", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_EXIT_CONFIRM
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_EXIT_CONFIRM", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_SAVE_CONFIRM
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_SAVE_CONFIRM", GBTSCConstants.CURRENT_CULTURE); } }



        //Change Password
        public static string BUHINSOKO_MSG_CHANGE_PASS_SUCCESS
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_CHANGE_PASS_SUCCESS", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_CHANGE_PASS_SUCCESS_AND_RESTART
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_CHANGE_PASS_SUCCESS_AND_RESTART", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_CHANGE_PASS_FAILED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_CHANGE_PASS_FAILED", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_CHANGE_CONNECTION_SUCCESS_AND_RESTART
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_CHANGE_CONNECTION_SUCCESS_AND_RESTART", GBTSCConstants.CURRENT_CULTURE); } }



        //Add,Update,Delete Action
        public static string BUHINSOKO_MSG_ADD_SUCCESS
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_ADD_SUCCESS", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_ADD_FAILED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_ADD_FAILED", GBTSCConstants.CURRENT_CULTURE); } }

        public static string BUHINSOKO_MSG_UPDATE_SUCCESS
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_UPDATE_SUCCESS", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_UPDATE_FAILED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_UPDATE_FAILED", GBTSCConstants.CURRENT_CULTURE); } }

        public static string BUHINSOKO_MSG_DELETE_SUCCESS
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_DELETE_SUCCESS", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_DELETE_FAILED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_DELETE_FAILED", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_DELETE_CONFIRM
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_DELETE_CONFIRM", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_DELETE_EMPTY
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_DELETE_EMPTY", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_UPDATE_DELETE_NOT_SELECTED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_UPDATE_DELETE_NOT_SELECTED", GBTSCConstants.CURRENT_CULTURE); } }



        //Part Master
        public static string BUHINSOKO_MSG_PART_HIEGHT_MUST_LESS
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_PART_HIEGHT_MUST_LESS", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_PART_CODE_BLANK
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_PART_CODE_BLANK", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_PART_NAME_BLANK
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_PART_NAME_BLANK", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_PART_CODE_EXISTED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_PART_CODE_EXISTED", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_PART_CANNOT_UPDATED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_PART_CANNOT_UPDATED", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_PART_CANNOT_DELETED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_PART_CANNOT_DELETED", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_PART_DELETE_REQUEST_SENT
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_PART_DELETE_REQUEST_SENT", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_PART_IMPORT_INVALID_FORMAT
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_PART_IMPORT_INVALID_FORMAT", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_PART_IMPORT_NO_DATA
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_PART_IMPORT_NO_DATA", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_PART_IMPORT_NOT_SELECTED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_PART_IMPORT_NOT_SELECTED", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_PART_IMPORT_SUCCESS
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_PART_IMPORT_SUCCESS", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_PART_EXPORT_DATABLE_NULL
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_PART_EXPORT_DATABLE_NULL", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_PART_EXPORT_FAILED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_PART_EXPORT_FAILED", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_PART_EXPORT_SUCCESS
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_PART_EXPORT_SUCCESS", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_PART_IMPORT_EXCEL_RESULT
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_PART_IMPORT_EXCEL_RESULT", GBTSCConstants.CURRENT_CULTURE); } }



        //Permission
        public static string BUHINSOKO_MSG_PERMISSION_GRANT_SUCCESS
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_PERMISSION_GRANT_SUCCESS", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_PERMISSION_GRANT_FAILED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_PERMISSION_GRANT_FAILED", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_PERMISSION_GRANT_FACTORY_SUCCESS
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_PERMISSION_GRANT_FACTORY_SUCCESS", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_PERMISSION_GRANT_FACTORY_FAILED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_PERMISSION_GRANT_FACTORY_FAILED", GBTSCConstants.CURRENT_CULTURE); } }



        //Warehouse Import
        public static string BUHINSOKO_MSG_WH_IMPORT_PART_CODE_EXISTED_BOTH
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_WH_IMPORT_PART_CODE_EXISTED_BOTH", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_WH_IMPORT_PART_CODE_NOT_EXISTED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_WH_IMPORT_PART_CODE_NOT_EXISTED", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_WH_IMPORT_BARCODE_INVALID
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_WH_IMPORT_BARCODE_INVALID", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_WH_IMPORT_BARCODE_EMPTY
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_WH_IMPORT_BARCODE_EMPTY", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_WH_IMPORT_PALLET_IMPORT_SUCCESS
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_WH_IMPORT_PALLET_IMPORT_SUCCESS", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_WH_IMPORT_PALLET_IMPORT_FAILED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_WH_IMPORT_PALLET_IMPORT_FAILED", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_WH_IMPORT_LOCATION_NOT_IN_LIST
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_WH_IMPORT_LOCATION_NOT_IN_LIST", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_WH_IMPORT_LOCATION_NOT_AVAILABLE
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_WH_IMPORT_LOCATION_NOT_AVAILABLE", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_WH_IMPORT_REPRINT_PALLET_CODE_NOT_EXISTED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_WH_IMPORT_REPRINT_PALLET_CODE_NOT_EXISTED", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_WH_IMPORT_DELETE_PALLET_SUCCESS
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_WH_IMPORT_DELETE_PALLET_SUCCESS", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_WH_IMPORT_QUANTITY_ZERO
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_WH_IMPORT_QUANTITY_ZERO", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_WH_IMPORT_NUMBER_LOCATION_NOT_ENOUGH
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_WH_IMPORT_NUMBER_LOCATION_NOT_ENOUGH", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_WH_IMPORT_OVERSEA_EXISTED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_WH_IMPORT_OVERSEA_EXISTED", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_WH_IMPORT_ADD_X_PALLET_TO_STOCK_OK
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_WH_IMPORT_ADD_X_PALLET_TO_STOCK_OK", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_WH_IMPORT_INVOICE_CANCELED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_WH_IMPORT_INVOICE_CANCELED", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_WH_IMPORT_DOMESTIC_EXISTED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_WH_IMPORT_DOMESTIC_EXISTED", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_WH_IMPORT_DATETIME_INVALID
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_WH_IMPORT_DATETIME_INVALID", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_WH_IMPORT_PART_CODE_IN_ACCEPTED_DELETE
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_WH_IMPORT_PART_CODE_IN_ACCEPTED_DELETE", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_WH_IMPORT_DOMESTIC_WAIT_CHANGED_VENDOR
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_WH_IMPORT_DOMESTIC_WAIT_CHANGED_VENDOR", GBTSCConstants.CURRENT_CULTURE); } }



        //Warehouse Export
        public static string BUHINSOKO_MSG_WH_EXPORT_INFOR_NET_ENOUGH
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_WH_EXPORT_INFOR_NET_ENOUGH", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_WH_EXPORT_QUANTITY_NET_ENOUGH
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_WH_EXPORT_QUANTITY_NET_ENOUGH", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_WH_ExPORT_PART_CODE_NOT_EXISTED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_WH_ExPORT_PART_CODE_NOT_EXISTED", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_WH_ExPORT_SUCCESS
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_WH_ExPORT_SUCCESS", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_WH_EXPORT_PALLET_SCANED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_WH_EXPORT_PALLET_SCANED", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_WH_EXPORT_PALLET_ISNOT_BELONGS_SCANED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_WH_EXPORT_PALLET_ISNOT_BELONGS_SCANED", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_WH_EXPORT_REPRINT_CODE_NOT_EXISTED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_WH_EXPORT_REPRINT_CODE_NOT_EXISTED", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_WH_EXPORT_DOMESTIC_NO_PRO_DATE
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_WH_EXPORT_DOMESTIC_NO_PRO_DATE", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_WH_EXPORT_OVERSEA_NO_LOT
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_WH_EXPORT_OVERSEA_NO_LOT", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_WH_EXPORT_OVERSEA_VENDOR_NO_LOT
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_WH_EXPORT_OVERSEA_VENDOR_NO_LOT", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_WH_EXPORT_DOMESTIC_NOT_ENOUGH_PRO_DATE
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_WH_EXPORT_DOMESTIC_NOT_ENOUGH_PRO_DATE", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_WH_EXPORT_OVERSEA_NOT_ENOUGH_LOT
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_WH_EXPORT_OVERSEA_NOT_ENOUGH_LOT", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_WH_EXPORT_DOMESTIC_VENDOR_NO_PRO_DATE
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_WH_EXPORT_DOMESTIC_VENDOR_NO_PRO_DATE", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_WH_EXPORT_BOTH_PART_TYPE_NOT_SELECTED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_WH_EXPORT_BOTH_PART_TYPE_NOT_SELECTED", GBTSCConstants.CURRENT_CULTURE); } }


        //Warehouse Change Pallet Status
        public static string BUHINSOKO_MSG_WH_CHANGE_PALLET_STATUS_TO_OK_CONFIRM
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_WH_CHANGE_PALLET_STATUS_TO_OK_CONFIRM", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_WH_CHANGE_PALLET_STATUS_NOT_INPUT_STAFF_CODE
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_WH_CHANGE_PALLET_STATUS_NOT_INPUT_STAFF_CODE", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_WH_CHANGE_PALLET_STATUS_LOCATION_NOT_VALID
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_WH_CHANGE_PALLET_STATUS_LOCATION_NOT_VALID", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_WH_CHANGE_PALLET_STATUS_STAFF_CODE_CANNOT_EMPTY
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_WH_CHANGE_PALLET_STATUS_STAFF_CODE_CANNOT_EMPTY", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_WH_CHANGE_PALLET_STATUS_STAFF_CODE_NOT_VALID
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_WH_CHANGE_PALLET_STATUS_STAFF_CODE_NOT_VALID", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_WH_CHANGE_PALLET_STATUS_NG_REMARK_EMPTY
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_WH_CHANGE_PALLET_STATUS_NG_REMARK_EMPTY", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_WH_CHANGE_PALLET_STATUS_PALLET_IN_EXPORT
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_WH_CHANGE_PALLET_STATUS_PALLET_IN_EXPORT", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_WH_CHANGE_PALLET_STATUS_GROUP_CONFIRM
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_WH_CHANGE_PALLET_STATUS_GROUP_CONFIRM", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_WH_CHANGE_PALLET_STATUS_GROUP_AT_LEAST
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_WH_CHANGE_PALLET_STATUS_GROUP_AT_LEAST", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_WH_CHANGE_PALLET_STATUS_GROUP_X_SUCCESS
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_WH_CHANGE_PALLET_STATUS_GROUP_X_SUCCESS", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_WH_CHANGE_PALLET_STAFF_CODE_EMPTY
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_WH_CHANGE_PALLET_STAFF_CODE_EMPTY", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_WH_CHANGE_PALLET_STAFF_CODE_INVALID
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_WH_CHANGE_PALLET_STAFF_CODE_INVALID", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_WH_CHANGE_PALLET_INVOICE_CONFIRM
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_WH_CHANGE_PALLET_INVOICE_CONFIRM", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_WH_CHANGE_PALLET_INVOICE_SUCCESS
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_WH_CHANGE_PALLET_INVOICE_SUCCESS", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_WH_CHANGE_PALLET_NG_EXPORT_SUCCESS
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_WH_CHANGE_PALLET_NG_EXPORT_SUCCESS", GBTSCConstants.CURRENT_CULTURE); } }


        //Warehouse Map
        public static string BUHINSOKO_MSG_WH_MAP_CONFIRM_CHANGE_OK
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_WH_MAP_CONFIRM_CHANGE_OK", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_WH_MAP_CONFIRM_CHANGE_NG
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_WH_MAP_CONFIRM_CHANGE_NG", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_WH_MAP_CHANGE_STATUS_NOT_SELECTED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_WH_MAP_CHANGE_STATUS_NOT_SELECTED", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_WH_MAP_CHANGE_STATUS_NOT_ACCEPTED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_WH_MAP_CHANGE_STATUS_NOT_ACCEPTED", GBTSCConstants.CURRENT_CULTURE); } }



        //Floor
        public static string BUHINSOKO_MSG_LINE_OVER_MAX_FLOOR
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_LINE_OVER_MAX_FLOOR", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_FLOOR_OVER_MAX_CELLS
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_FLOOR_OVER_MAX_CELLS", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_FLOOR_CAN_NOT_UPDATE
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_FLOOR_CAN_NOT_UPDATE", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_FLOOR_CAN_NOT_DELETE
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_FLOOR_CAN_NOT_DELETE", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_FLOOR_CELL_CAN_NOT_UPDATE
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_FLOOR_CELL_CAN_NOT_UPDATE", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_FLOOR_CELL_CAN_NOT_DELETE
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_FLOOR_CELL_CAN_NOT_DELETE", GBTSCConstants.CURRENT_CULTURE); } }



        //Layout
        public static string BUHINSOKO_MSG_LAYOUT_OVERLOAD_LINE
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_LAYOUT_OVERLOAD_LINE", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_LAYOUT_NAME_EXISTED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_LAYOUT_NAME_EXISTED", GBTSCConstants.CURRENT_CULTURE); } }



        //Lines
        public static string BUHINSOKO_MSG_LINE_CANNOT_DELETED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_LINE_CANNOT_DELETED", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_LINE_NAME_EXISTED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_LINE_NAME_EXISTED", GBTSCConstants.CURRENT_CULTURE); } }
        


        //User Group
        //Lines
        public static string BUHINSOKO_MSG_USERGROUP_CANNOT_DELETED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_USERGROUP_CANNOT_DELETED", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_USERGROUP_NAME_EXISTED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_USERGROUP_NAME_EXISTED", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_USERGROUP_NOT_SELECTED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_USERGROUP_NOT_SELECTED", GBTSCConstants.CURRENT_CULTURE); } }



        //Setting
        public static string BUHINSOKO_MSG_SETTING_SAVED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_SETTING_SAVED", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_UPDATE_NOTIFY
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_UPDATE_NOTIFY", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_UPDATE_LATEST_VERSION
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_UPDATE_LATEST_VERSION", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_THIS_FUCNTION_BLOCKED_BY_ADMIN
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_THIS_FUCNTION_BLOCKED_BY_ADMIN", GBTSCConstants.CURRENT_CULTURE); } }


        //Feedback
        public static string BUHINSOKO_MSG_FEEDBACK_SEND_OK
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_FEEDBACK_SEND_OK", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_FEEDBACK_SEND_FAILED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_FEEDBACK_SEND_FAILED", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_FEEDBACK_FUNCTION_NULL
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_FEEDBACK_FUNCTION_NULL", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_FEEDBACK_MSG_NULL
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_FEEDBACK_MSG_NULL", GBTSCConstants.CURRENT_CULTURE); } }

        //PC Management
        public static string BUHINSOKO_MSG_PC_NOT_IN_USED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_PC_NOT_IN_USED", GBTSCConstants.CURRENT_CULTURE); } }

        //Inventory Note
        public static string BUHINSOKO_MSG_INVENTORY_NOTE_PRINTED_OK
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_INVENTORY_NOTE_PRINTED_OK", GBTSCConstants.CURRENT_CULTURE); } }
        public static string BUHINSOKO_MSG_INVENTORY_ALL_PRINT_CONFIRMED
        { get { return GBTSCConstants.CURRENT_RESOURCES.GetString("BUHINSOKO_MSG_INVENTORY_ALL_PRINT_CONFIRMED", GBTSCConstants.CURRENT_CULTURE); } }
    }

}
