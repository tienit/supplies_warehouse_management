using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using VKTIM.Component;
using System.Globalization;
using System.Resources;
using System.Reflection;

namespace VKTIM.Common
{
    public class GBTSCCommon
    {
        public enum MessageType
        {
            Message_OK,
            Message_NG
        }

        public static List<Control> _LST_CTRL;

        public static void SetCommon(Form frm)
        {
            frm.Icon = Properties.Resources.eAppLogo;
            frm.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
            frm.BackColor = Properties.Settings.Default.COLOR_APP_BACK;
            Init_Resources();
            SetFormLanguageIncludeGrid(frm);
        }

        public static void SetCommonForMap(Form frm)
        {
            frm.Icon = Properties.Resources.eAppLogo;
            Init_Resources();
            SetFormLanguageIncludeGridForMap(frm);
        }

        public static void Message_Info(string msgText, string caption, MessageType msgType)
        {
            frmMessage m_Frm = new frmMessage();
            //System.Globalization.CultureInfo oldCulture = System.Threading.Thread.CurrentThread.CurrentCulture;
            //System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            m_Frm.txtMsg.Text = msgText;
            //m_Frm.txtMsg.Text = System.Web.HttpUtility.HtmlEncode(msgText);
            //System.Threading.Thread.CurrentThread.CurrentCulture = oldCulture;
            if (msgType == MessageType.Message_OK)
            {
                if (GBTSCConstants.BUHINSOKO_MSG_BOX_CAPTION_DEFAULT == 0)
                {
                    m_Frm.lblType.Text = caption.ToUpper();
                }
                else
                {
                    m_Frm.lblType.Text = "OK";
                }
                m_Frm.lblType.ForeColor = Color.Green;
                if (GBTSCConstants.CURRENT_USER != null)
                {
                    DTLOGEVENTController.Instance().Insert(new DTLOGEVENTInfo(0, "COMMON", "OK", msgText, GBTSCCommon.SERVER_NOW(), GBTSCConstants.CURRENT_USER.ID, GBTSCConstants.CURRENT_USER.USER_NAME, Environment.UserName, Environment.MachineName, Environment.UserDomainName, Environment.CurrentDirectory, ""));
                }
            }
            else if (msgType == MessageType.Message_NG)
            {
                if (GBTSCConstants.BUHINSOKO_MSG_BOX_CAPTION_DEFAULT == 0)
                {
                    m_Frm.lblType.Text = caption.ToUpper();
                }
                else
                {
                    m_Frm.lblType.Text = "NG";
                }
                m_Frm.lblType.ForeColor = Color.Red;
                if (GBTSCConstants.CURRENT_USER != null)
                {
                    DTLOGEVENTController.Instance().Insert(new DTLOGEVENTInfo(0, "COMMON", "NG", msgText, GBTSCCommon.SERVER_NOW(), GBTSCConstants.CURRENT_USER.ID, GBTSCConstants.CURRENT_USER.USER_NAME, Environment.UserName, Environment.MachineName, Environment.UserDomainName, Environment.CurrentDirectory, ""));
                }
            }
            m_Frm.ShowDialog();
        }

        public static DialogResult Message_Confirm(string msgText, string caption)
        {
            frmMessage m_Frm = new frmMessage();
            if (GBTSCConstants.BUHINSOKO_MSG_BOX_CAPTION_DEFAULT == 0)
            {
                m_Frm.lblType.Text = caption.ToUpper();
            }
            else
            {
                m_Frm.lblType.Text = "OK";
            }
            m_Frm.lblType.ForeColor = Color.Blue;
            m_Frm.txtMsg.Text = msgText;
            m_Frm.btnConfirm.Visible = false;
            m_Frm.btnOK.Visible = true;
            m_Frm.btnCancel.Visible = true;
            m_Frm.AcceptButton = m_Frm.btnOK;
            return m_Frm.ShowDialog();
        }

        public static void ShowForm_ClassName(string className, string title)
        {
            try
            {
                string fullFormName = string.Format("{0}.{1}", GBTSCConstants.ESWS_SYS_NAME, className);
                Form frm = (Form)Activator.CreateInstance(GBTSCConstants.ESWS_SYS_NAME, fullFormName).Unwrap();
                frm.Text = title;
                frm.ShowDialog();
            }
            catch (System.Exception ex)
            {
                GBTSCCommon.Message_Info(ex.Message, "ERROR", MessageType.Message_NG);
            }
        }

        public static void ShowForm_ClassName_2(string className, string title)
        {
            try
            {
                string fullFormName = string.Format("{0}.{1}", GBTSCConstants.ESWS_SYS_NAME, className);
                Form frm = (Form)Activator.CreateInstance(GBTSCConstants.ESWS_SYS_NAME, fullFormName).Unwrap();
                frm.Text = title;
                frm.Show();
            }
            catch (System.Exception ex)
            {
                GBTSCCommon.Message_Info(ex.Message, "ERROR", MessageType.Message_NG);
            }
        }

        public static bool Connection_Testing_Inner()
        {
            bool bCheck = false;
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(SqlConnect.ConnectionString);
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    bCheck = true;
                }
            }
            catch
            {
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            return bCheck;
        }

        public static bool Connection_Testing(string server, string user, string pass, string database)
        {
            string strConnection = string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3}", server, database, user, pass);
            bool bCheck = false;
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(strConnection);
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    bCheck = true;
                }
            }
            catch
            {
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            return bCheck;
        }

        public static Keys ConvertToKeys(string strKeys)
        {
            return (Keys)Enum.Parse(typeof(Keys), strKeys);
        }

        public static void SetKeysForItem(ToolStripMenuItem item, string lstKeys)
        {
            if (!(lstKeys == null || lstKeys.Equals("")))
            {
                string[] arrKeys = lstKeys.Split(Convert.ToChar("+"));
                if (arrKeys.Length == 1)
                {
                    item.ShortcutKeys = ConvertToKeys(arrKeys[0]);
                }
                else if (arrKeys.Length == 2)
                {
                    item.ShortcutKeys = ConvertToKeys(arrKeys[0]) | ConvertToKeys(arrKeys[1]);
                }
                else if (arrKeys.Length == 3)
                {
                    item.ShortcutKeys = ConvertToKeys(arrKeys[0]) | ConvertToKeys(arrKeys[1]) | ConvertToKeys(arrKeys[2]);
                }
                else if (arrKeys.Length == 4)
                {
                    item.ShortcutKeys = ConvertToKeys(arrKeys[0]) | ConvertToKeys(arrKeys[1]) | ConvertToKeys(arrKeys[2]) | ConvertToKeys(arrKeys[3]);
                }
            }
        }

        public static void CMB_BindData(ComboBox cmb, object source, string dataTextField, string dataValueField)
        {
            cmb.DataSource = source;
            cmb.DisplayMember = dataTextField;
            cmb.ValueMember = dataValueField;
        }

        public static DateTime SERVER_NOW()
        {
            return HTUSERController.Instance().SERVER_NOW();
        }

        public static string DateTimeToString(DateTime dt)
        {
            return dt.ToString("dd/MM/yyyy HH:mm tt");
        }

        public static string DateTimeToStringNotAM(DateTime dt)
        {
            return dt.ToString("dd/MM/yyyy HH:mm");
        }

        public static string Reverse(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        public static Color GetColorFromRGB(string rgb)
        {
            if (rgb.ToLower().Trim().Equals("transparent"))
            {
                return Color.Transparent;
            }
            else
            {
                string[] arr = rgb.Split(Convert.ToChar(","));
                return Color.FromArgb(Convert.ToInt32(arr[0]), Convert.ToInt32(arr[1]), Convert.ToInt32(arr[2]));
            }
        }

        public static Color GetColorFromARGB(string argb)
        {
            try
            {
                string[] arr = argb.Split(Convert.ToChar(","));
                return Color.FromArgb(Convert.ToInt32(arr[0]), Convert.ToInt32(arr[1]), Convert.ToInt32(arr[2]), Convert.ToInt32(arr[3]));
            }
            catch
            {
                return Color.Transparent;
            }
        }

        private static void Init_Resources()
        {
            GBTSCConstants.CURRENT_CULTURE = CultureInfo.CreateSpecificCulture(Properties.Settings.Default.CURRENT_CULTURE);
            GBTSCConstants.CURRENT_RESOURCES = new ResourceManager("VKTIM.Lang.MyResources", typeof(frmMain).Assembly);
        }

        public static void SetFormLanguageIncludeGrid(Form frm)
        {
            //SetCurrentCulture();
            frm.Text = GBTSCConstants.CURRENT_RESOURCES.GetString(frm.Name, GBTSCConstants.CURRENT_CULTURE);
            SetControlTextIncludeGrid(frm, frm.Name);
        }

        public static void SetFormLanguageIncludeGridForMap(Form frm)
        {
            //SetCurrentCulture();
            frm.Text = GBTSCConstants.CURRENT_RESOURCES.GetString(frm.Name, GBTSCConstants.CURRENT_CULTURE);
            SetControlTextIncludeGridForMap(frm, frm.Name);
        }

        private static void SetControlTextIncludeGrid(Control ctrl, string formName)
        {
            try
            {
                foreach (Control c in ctrl.Controls)
                {
                    if (c.GetType() == typeof(Label) ||
                        c.GetType() == typeof(Button) ||
                        c.GetType() == typeof(CheckBox) ||
                        c.GetType() == typeof(RadioButton) ||
                        c.GetType() == typeof(GroupBox) ||
                        c.GetType() == typeof(LinkLabel) ||
                        c.GetType() == typeof(TabPage) ||
                        c.GetType() == typeof(ToolStripMenuItem) ||
                        c.GetType() == typeof(ToolStripStatusLabel))
                    {
                        c.Text = GBTSCConstants.CURRENT_RESOURCES.GetString(formName + "." + c.Name, GBTSCConstants.CURRENT_CULTURE);
                        if (c.GetType() == typeof(Button))
                        {
                            c.Cursor = Cursors.Hand;
                        }
                    }
                    else if (c.GetType() == typeof(MenuStrip))
                    {
                        MenuStrip mStrip = (MenuStrip)c;
                        foreach (ToolStripMenuItem item in mStrip.Items)
                        {
                            item.Text = GBTSCConstants.CURRENT_RESOURCES.GetString(formName + "." + item.Name, GBTSCConstants.CURRENT_CULTURE);
                        }
                    }
                    else if (c.GetType() == typeof(DataGridView))
                    {
                        c.Cursor = Cursors.Hand;
                        DataGridView dgv = (DataGridView)c;
                        dgv.EnableHeadersVisualStyles = false;
                        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
                        dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
                        dgv.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 10, FontStyle.Bold);
                        dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                        dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(222, 222, 222);
                        dgv.ColumnHeadersHeight = 26;
                        dgv.BackgroundColor = Color.White;
                        dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 128, 0); //255, 255, 225
                        dgv.DefaultCellStyle.SelectionForeColor = Color.White;
                        foreach (DataGridViewColumn col in dgv.Columns)
                        {
                            col.HeaderText = GBTSCConstants.CURRENT_RESOURCES.GetString(formName + "." + col.Name, GBTSCConstants.CURRENT_CULTURE);
                            if (col.GetType() == typeof(DataGridViewCheckBoxColumn))
                            {
                                ((DataGridViewCheckBoxColumn)col).FlatStyle = FlatStyle.Flat;
                            }
                            else if (col.GetType() == typeof(DataGridViewComboBoxColumn))
                            {
                                ((DataGridViewComboBoxColumn)col).FlatStyle = FlatStyle.Flat;
                            }
                        }
                    }
                    SetControlTextIncludeGrid(c, formName);
                }
            }
            catch //(Exception ex)
            {
                //MessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace);
            }
        }

        private static void SetControlTextIncludeGridForMap(Control ctrl, string formName)
        {
            try
            {
                foreach (Control c in ctrl.Controls)
                {
                    if (c.GetType() == typeof(Label) ||
                        c.GetType() == typeof(Button) ||
                        c.GetType() == typeof(CheckBox) ||
                        c.GetType() == typeof(RadioButton) ||
                        c.GetType() == typeof(GroupBox) ||
                        c.GetType() == typeof(LinkLabel) ||
                        c.GetType() == typeof(TabPage) ||
                        c.GetType() == typeof(ToolStripMenuItem) ||
                        c.GetType() == typeof(ToolStripStatusLabel))
                    {
                        c.Text = GBTSCConstants.CURRENT_RESOURCES.GetString(formName + "." + c.Name, GBTSCConstants.CURRENT_CULTURE);
                        if (c.GetType() == typeof(Button))
                        {
                            c.Cursor = Cursors.Hand;
                        }
                    }
                    SetControlTextIncludeGridForMap(c, formName);
                }
            }
            catch
            {
            }
        }

        //private static void SetCurrentCulture()
        //{
        //    GBTSCConstants.CURRENT_CULTURE = CultureInfo.CreateSpecificCulture(Properties.Settings.Default.CURRENT_CULTURE);
        //}

        //private static void SetCurrentResources()
        //{
        //    GBTSCConstants.CURRENT_RESOURCES = new ResourceManager("eSWS.Lang.MyResources", typeof(frmMain).Assembly);
        //}

        public static bool CheckBeforeLogin()
        {
            bool bCheck = true;

            //Check PC valid
            DTDEVICESInfo myPC = DTDEVICESController.Instance().GetByName(Environment.MachineName);
            if (myPC == null)
            {
                GBTSCCommon.Message_Info(string.Format(GBTSCConstants.BUHINSOKO_MSG_PC_NOT_IN_USED, Environment.MachineName), "DEVICE NOT VALID", GBTSCCommon.MessageType.Message_NG);
                bCheck = false;
                goto unornally_break;
            }
            else
            {
                if (myPC.LOCKED)
                {
                    GBTSCCommon.Message_Info(string.Format(GBTSCConstants.BUHINSOKO_MSG_PC_NOT_IN_USED, Environment.MachineName), "DEVICE LOCKED", GBTSCCommon.MessageType.Message_NG);
                    bCheck = false;
                    goto unornally_break;
                }
            }

            //Check Version
            HTCONFIGInfo tempInfo = HTCONFIGController.Instance().GetByCode("UPDATE_NOTIFY");
            if (tempInfo != null)
            {
                string app_revision = Application.ProductVersion.Substring(Application.ProductVersion.LastIndexOf(".") + 1);
                if (!tempInfo.CONFIG_VALUE.Equals(app_revision))
                {
                    string msg_notify = string.Format(GBTSCConstants.BUHINSOKO_MSG_UPDATE_NOTIFY, app_revision, tempInfo.CONFIG_VALUE);
                    GBTSCCommon.Message_Info(msg_notify, "UPDATE", GBTSCCommon.MessageType.Message_NG);
                    bCheck = false;
                }
            }

        unornally_break: //Label
            return bCheck;
        }

        public static bool CheckValidApps()
        {
            bool bCheck = true;

            //Check PC valid
            DTDEVICESInfo myPC = DTDEVICESController.Instance().GetByName(Environment.MachineName);
            if (myPC == null)
            {
                GBTSCCommon.Message_Info(string.Format(GBTSCConstants.BUHINSOKO_MSG_PC_NOT_IN_USED, Environment.MachineName), "DEVICE NOT VALID", GBTSCCommon.MessageType.Message_NG);
                bCheck = false;
                goto unornally_break;
            }
            else
            {
                if (myPC.LOCKED)
                {
                    GBTSCCommon.Message_Info(string.Format(GBTSCConstants.BUHINSOKO_MSG_PC_NOT_IN_USED, Environment.MachineName), "DEVICE LOCKED", GBTSCCommon.MessageType.Message_NG);
                    bCheck = false;
                    goto unornally_break;
                }
            }

            //Check Version
            HTCONFIGInfo tempInfo = HTCONFIGController.Instance().GetByCode("UPDATE_NOTIFY");
            if (tempInfo != null)
            {
                string app_revision = Application.ProductVersion.Substring(Application.ProductVersion.LastIndexOf(".") + 1);
                if (!tempInfo.CONFIG_VALUE.Equals(app_revision))
                {
                    string msg_notify = string.Format(GBTSCConstants.BUHINSOKO_MSG_UPDATE_NOTIFY, app_revision, tempInfo.CONFIG_VALUE);
                    GBTSCCommon.Message_Info(msg_notify, "UPDATE", GBTSCCommon.MessageType.Message_NG);
                    bCheck = false;
                    goto unornally_break;
                }
            }

            //Check User Locked
            HTUSERInfo userInfo = HTUSERController.Instance().GetById(GBTSCConstants.CURRENT_USER.ID);
            if (userInfo != null)
            {
                if (userInfo.IS_BLOCKED == true)
                {
                    GBTSCCommon.Message_Info(GBTSCConstants.BUHINSOKO_MSG_LOGIN_ACCOUNT_LOCKED, "ACCOUNT LOCKED", GBTSCCommon.MessageType.Message_NG);
                    bCheck = false;
                    goto unornally_break;
                }
            }

            //Check All Factory is in Maintenance status?
            //if (GBTSCConstants.CURRENT_FACTORY.BIT_IS_LOCKED)
            //{
            //    GBTSCCommon.Message_Info(GBTSCConstants.CURRENT_FACTORY.CHR_CODE + " is being maintained. Please check back later.", GBTSCConstants.CURRENT_FACTORY.CHR_CODE, GBTSCCommon.MessageType.Message_NG);
            //    bCheck = false;
            //    goto unornally_break;
            //}

        unornally_break: //Label
            return bCheck;
        }

        private static string GetPropertyValue(string pName, Control control)
        {

            Type type = control.GetType();

            string propertyName = pName;

            BindingFlags flags = BindingFlags.GetProperty;

            Binder binder = null;

            object[] args = null;

            object value = type.InvokeMember(

            propertyName,

            flags,

            binder,

            control,

            args

            );

            return value.ToString();

        }

        private static void SetPropertyValue(string pName, Control control, object newValue)
        {

            Type type = control.GetType();

            string propertyName = pName;

            BindingFlags flags = BindingFlags.GetProperty;

            Binder binder = null;

            object[] args = null;

            object value = type.InvokeMember(

            propertyName,

            flags,

            binder,

            control,

            args

            );

            value = newValue;

        }

        public static bool CheckValidForm(Control containerCtrl)
        {
            bool bCheck = true;
            bool bTemp = true;
            _LST_CTRL = new List<Control>();
            GetListControlForValidation(containerCtrl);
            foreach (Control c in _LST_CTRL)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    ErrorProvider ep = (ErrorProvider)c.Tag;
                    bTemp = CheckValid_TextBox_Data(ep, (TextBox)c, true, "", "");
                    if (bTemp == false)
                    {
                        bCheck = false;
                    }
                }
                if (c.GetType() == typeof(RichTextBox))
                {
                    ErrorProvider ep = (ErrorProvider)c.Tag;
                    bTemp = CheckValid_RichTextBox_Data(ep, (RichTextBox)c, true, "", "");
                    if (bTemp == false)
                    {
                        bCheck = false;
                    }
                }
                else if (c.GetType() == typeof(ComboBox))
                {
                    ErrorProvider ep = (ErrorProvider)c.Tag;
                    bCheck = CheckValid_ComboBox_Data(ep, (ComboBox)c, true, "", "", true);
                    if (bTemp == false)
                    {
                        bCheck = false;
                    }
                }
            }
            return bCheck;
        }

        public static bool CheckValidFormWithNumber(Control containerCtrl, int num)
        {
            bool bCheck = true;
            bool bTemp = true;
            _LST_CTRL = new List<Control>();
            GetListControlForValidationWithNumber(containerCtrl, num);
            foreach (Control c in _LST_CTRL)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    ErrorProvider ep = (ErrorProvider)c.Tag;
                    bTemp = CheckValid_TextBox_Data(ep, (TextBox)c, true, "", "");
                    if (bTemp == false)
                    {
                        bCheck = false;
                    }
                }
                else if (c.GetType() == typeof(ComboBox))
                {
                    ErrorProvider ep = (ErrorProvider)c.Tag;
                    bCheck = CheckValid_ComboBox_Data(ep, (ComboBox)c, true, "", "", true);
                    if (bTemp == false)
                    {
                        bCheck = false;
                    }
                }
            }
            return bCheck;
        }

        public static void InitErrorProvider(Control containerCtrl)
        {
            _LST_CTRL = new List<Control>();
            GetListControlForValidation(containerCtrl);
            foreach (Control c in _LST_CTRL)
            {
                ErrorProvider ep = new ErrorProvider();
                ep.ContainerControl = (ContainerControl)containerCtrl;
                c.Tag = ep;
                c.Leave += C_Leave;
            }
        }

        public static void RemoveErrorProvider(Control containerCtrl)
        {
            _LST_CTRL = new List<Control>();
            GetListControlForValidation(containerCtrl);
            foreach (Control c in _LST_CTRL)
            {
                try
                {
                    ErrorProvider ep = (ErrorProvider)c.Tag;
                    ep.Clear();
                    c.Leave -= C_Leave;
                }
                catch
                {
                }
            }
        }

        private static bool CheckValid_TextBox_Data(ErrorProvider ep, TextBox txtControl, bool useDefault, string notValidText, string validText)
        {
            try
            {
                if (string.IsNullOrEmpty(txtControl.Text))
                {
                    if (useDefault)
                    {
                        notValidText = "Data can not empty";
                    }
                    ep.Clear();
                    ep.Icon = Properties.Resources.e_provider_ng_16;
                    ep.SetError(txtControl, notValidText);
                    return false;
                }
                else
                {
                    if (useDefault)
                    {
                        validText = "Valid";
                    }
                    ep.Clear();
                    ep.Icon = Properties.Resources.e_provider_ok_16;
                    ep.SetError(txtControl, validText);
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        private static bool CheckValid_RichTextBox_Data(ErrorProvider ep, RichTextBox txtControl, bool useDefault, string notValidText, string validText)
        {
            try
            {
                if (txtControl.Text.Trim().Equals(""))
                {
                    if (useDefault)
                    {
                        notValidText = "Data can not empty";
                    }
                    ep.Clear();
                    ep.Icon = Properties.Resources.e_provider_ng_16;
                    ep.SetError(txtControl, notValidText);
                    return false;
                }
                else
                {
                    if (useDefault)
                    {
                        validText = "Valid";
                    }
                    ep.Clear();
                    ep.Icon = Properties.Resources.e_provider_ok_16;
                    ep.SetError(txtControl, validText);
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        private static bool CheckValid_ComboBox_Data(ErrorProvider ep, ComboBox cmbControl, bool useDefault, string notValidText, string validText, bool haveHeader)
        {
            try
            {
                if (cmbControl.Items.Count == 0)
                {
                    if (useDefault)
                    {
                        notValidText = "At least one item must be selected";
                    }
                    ep.Clear();
                    ep.Icon = Properties.Resources.e_provider_ng_16;
                    ep.SetError(cmbControl, notValidText);
                    return false;
                }
                else if (haveHeader)
                {
                    if (cmbControl.SelectedIndex == 0)
                    {
                        if (useDefault)
                        {
                            notValidText = "At least one item must be selected";
                        }
                        ep.Clear();
                        ep.Icon = Properties.Resources.e_provider_ng_16;
                        ep.SetError(cmbControl, notValidText);
                        return false;
                    }
                    else
                    {
                        if (useDefault)
                        {
                            validText = "Valid";
                        }
                        ep.Clear();
                        ep.Icon = Properties.Resources.e_provider_ok_16;
                        ep.SetError(cmbControl, validText);
                        return true;
                    }
                }
                else
                {
                    if (useDefault)
                    {
                        validText = "Valid";
                    }
                    ep.Clear();
                    ep.Icon = Properties.Resources.e_provider_ok_16;
                    ep.SetError(cmbControl, validText);
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        private static void C_Leave(object sender, EventArgs e)
        {
            Control c = (Control)sender;
            ErrorProvider ep = (ErrorProvider)c.Tag;
            if (c.GetType() == typeof(TextBox))
            {
                CheckValid_TextBox_Data(ep, (TextBox)c, true, "", "");
            }
            else if (c.GetType() == typeof(ComboBox))
            {
                CheckValid_ComboBox_Data(ep, (ComboBox)c, true, "", "", true);
            }
        }

        private static void GetListControlForValidation(Control containerCtrl)
        {
            try
            {
                foreach (Control c in containerCtrl.Controls)
                {
                    if (c.GetType() == typeof(TextBox) || c.GetType() == typeof(RichTextBox) || c.GetType() == typeof(ComboBox))
                    {
                        //Some control not have AccessibleDescription property
                        try
                        {
                            if (c.AccessibleDescription.Equals("1"))
                            {
                                _LST_CTRL.Add(c);
                            }
                        }
                        catch
                        {
                        }
                    }
                    GetListControlForValidation(c);
                }
            }
            catch
            {
            }
        }

        private static void GetListControlForValidationWithNumber(Control containerCtrl, int num)
        {
            try
            {
                foreach (Control c in containerCtrl.Controls)
                {
                    if (c.GetType() == typeof(TextBox) || c.GetType() == typeof(ComboBox))
                    {
                        //Some control not have AccessibleDescription property
                        try
                        {
                            if (c.AccessibleDescription.Equals(num.ToString()))
                            {
                                _LST_CTRL.Add(c);
                            }
                        }
                        catch
                        {
                        }
                    }
                    GetListControlForValidationWithNumber(c, num);
                }
            }
            catch
            {
            }
        }
    }
}
