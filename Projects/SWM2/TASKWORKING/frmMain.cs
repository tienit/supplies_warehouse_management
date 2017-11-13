using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VKTIM;

namespace TASKWORKING
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        List<TaskItem> lst_task = new List<TaskItem>();
        List<TaskItem> lst_task_finished = new List<TaskItem>();

        private void frmMain_Load(object sender, EventArgs e)
        {            

            for (int i = 0; i < 20; i++)
            {
                TaskItem taskItem2 = new TASKWORKING.TaskItem("Property là một giải pháp để giải quyết vấn đề số " + i); ;
                taskItem2.Location = new System.Drawing.Point(39, i*40);
                taskItem2.Name = "taskItem" + i;
                taskItem2.Sort = i;

                lst_task.Add(taskItem2);
            }


        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int y_coor = 1;
            for (int i = 0; i < lst_task.Count; i++)
            {
                lst_task[i].Location = new System.Drawing.Point(39, y_coor * 40);
                xtraScrollableControl1.Controls.Add(lst_task[i]);
                y_coor++;
            }

            for (int j = 0; j < lst_task_finished.Count; j++)
            {
                lst_task_finished[j].Location = new System.Drawing.Point(39, y_coor * 40);
                xtraScrollableControl1.Controls.Add(lst_task_finished[j]);
                y_coor++;
            }
        }
    }
}
