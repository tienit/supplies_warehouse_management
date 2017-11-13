using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VKTIM.Component;
using VKTIM.Common;
using tienit.core;

namespace VKTIM
{
    public partial class frmTaskWork : Form
    {
        public frmTaskWork()
        {
            InitializeComponent();
        }

        private void frmTaskWork_Load(object sender, EventArgs e)
        {
            //
            grc_MainTask.DataSource = TASKWORKLISTController.Instance().GetAll_DS().Tables[0];

            //
            grc_TaskWork.DataSource = TASKWORKLISTController.Instance().GetAll_DS().Tables[0];

            //
            repositoryItemPictureEdit2.InitialImage = global::VKTIM.Properties.Resources.plus;
        }

        private void grv_MainTask_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "ENDDATE" && e.IsForGroupRow) {
                try//NULL FEILD 'ENDDATE' IN DB
                {
                    DateTime dateEnd = Convert.ToDateTime(grv_MainTask.GetGroupRowValue(e.GroupRowHandle, grv_MainTask.Columns["ENDDATE"]));
                    e.DisplayText = convertDateToNgayThangNam(dateEnd);
                }
                catch// (Exception)
                {

                  //  throw;
                }

            }
        }

        private int getTimeSpanTwoDate(DateTime startDate, DateTime endDate)
        {
            //
            startDate = Convert.ToDateTime( startDate.ToShortDateString());
            endDate = Convert.ToDateTime(endDate.ToShortDateString());

            TimeSpan diff = endDate - startDate;
            int daySpan = diff.Days;

            return daySpan;
        }

        private string convertDateToNgayThangNam(DateTime date)
        {
            if (getTimeSpanTwoDate(DateTime.Now, date) == 0)
            {
                return "hôm nay";
            }
            else if (getTimeSpanTwoDate(DateTime.Now, date) == 1)
            {
                return "mai";
            }
            else
            {
                return string.Format("{0} tháng {1} năm {2}", date.Day, date.Month, date.Year);
            }
        }

        private void grv_TaskWork_CustomColumnGroup(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnSortEventArgs e)
        {
            //Group row by day
            //Group 1: last date to today
            //Group 2...n: tomorow to next date
            if (e.Column.FieldName == "ENDDATE")
            {
                e.Handled = true;
                DateTime val1 = Convert.ToDateTime(e.Value1);
                DateTime val2 = Convert.ToDateTime(e.Value2);
                DateTime today = Convert.ToDateTime(DateTime.Now.ToShortDateString());

                TimeSpan diff_1 = today - val1;
                TimeSpan diff_2 = today - val2;

                if (diff_1.Days >= 0 && diff_2.Days >= 0)
                {
                    e.Result = 0;
                }
                else
                {
                    e.Result = System.Collections.Comparer.Default.Compare(diff_1.Days, diff_2.Days);
                }

            }
        }

        private void grv_TaskWork_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName == "ENDDATE" && e.IsForGroupRow)
            {
                try//NULL FEILD 'ENDDATE' IN DB
                {
                    DateTime valRow = Convert.ToDateTime(grv_TaskWork.GetGroupRowValue(e.GroupRowHandle, grv_MainTask.Columns["ENDDATE"]));
                    DateTime today = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                    TimeSpan diff = today - valRow;
                    if (diff.Days >= 0)
                    {
                        e.DisplayText = "Cần làm hôm nay";
                    }
                    else
                    {
                        e.DisplayText = "ngày " + convertDateToNgayThangNam(valRow);
                    }
                }
                catch// (Exception)
                {

                    //  throw;
                }
            }


        }

        private void grv_TaskWork_EndGrouping(object sender, EventArgs e)
        {
            grv_TaskWork.ExpandGroupRow(-1);
        }

        //Timer remind
        List<TASKWORKLISTInfo> workList = TASKWORKLISTController.Instance().getListRemind();
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            workList = TASKWORKLISTController.Instance().getListRemind();
            Timer remindTimer = new Timer();
            remindTimer.Interval = 1000;
            remindTimer.Enabled = true;
            remindTimer.Tick += new System.EventHandler(remindTimer_Tick);
            remindTimer.Start();
        }

        //
        private void remindTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < workList.Count; i++)
            {
                if (DateTime.Now.TimeOfDay >= workList[i].TIME_REMIND)
                {
                    Form f = new Form();
                    Label l = new Label();
                    l.Size = new System.Drawing.Size(216, 22);
                    l.Text = workList[i].CONTENTS;
                    f.Controls.Add(l);
                    f.Show();
                    workList.RemoveAt(i);
                    return;
                }
            }
        }

        private void grv_TaskWork_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            udpateTaskWorkAdapter(grv_TaskWork.GetDataRow(e.RowHandle));
        }

        private TASKWORKLISTInfo udpateTaskWorkAdapter(DataRow row)
        {
            TASKWORKLISTInfo objectInfo = null;
            try
            {
                objectInfo = new TASKWORKLISTInfo();
                objectInfo.ID = Convert.ToInt32(row["ID"]);
                objectInfo.CODE = row["CODE"].ToString();
                objectInfo.CONTENTS = row["CONTENTS"].ToString();
                objectInfo.CONTROL = row["CONTROL"].ToString();
                objectInfo.REMARKS = row["REMARKS"].ToString();
                
                objectInfo.STARTDATE = GBTSCCommon.ObjectToDate(row["STARTDATE"]);
                objectInfo.ENDDATE = GBTSCCommon.ObjectToDate(row["ENDDATE"]);

                objectInfo.REPEAT_DAY = GBTSCCommon.OjectToInteger32(row["REPEAT_DAY"]);
                objectInfo.REPEAT_HOUR = GBTSCCommon.OjectToInteger32(row["REPEAT_HOUR"]);
                objectInfo.REPEAT_MONTH = GBTSCCommon.OjectToInteger32(row["REPEAT_MONTH"]);
                objectInfo.REPEAT_WEEK = GBTSCCommon.OjectToInteger32(row["REPEAT_WEEK"]);
                objectInfo.REPEAT_YEAR = GBTSCCommon.OjectToInteger32(row["REPEAT_YEAR"]);
                objectInfo.TIME_REMIND = GBTSCCommon.ObjectToTime(row["TIME_REMIND"]);      
                objectInfo.STATUS = GBTSCCommon.StringToBoolearn(row["STATUS"]);
                objectInfo.FINISHED = GBTSCCommon.StringToBoolearn(row["FINISHED"]);
                objectInfo.REPEAT = GBTSCCommon.StringToBoolearn(row["REPEAT"]);
                objectInfo.REMIND = GBTSCCommon.StringToBoolearn(row["REMIND"]);
                objectInfo.TIME_SPAN_REMIND = GBTSCCommon.DateAndTimeToTimeSpan(objectInfo.ENDDATE, objectInfo.TIME_REMIND);

                int id = TASKWORKLISTController.Instance().Update(objectInfo);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }

            return objectInfo;
        }

        private void grv_TaskWork_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {

        }
    }
}
