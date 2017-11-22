using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VKTIM.Component;
using tienit.core;
using System.IO;
using VKTIM.Common;

namespace VKTIM
{
    public partial class frmDmDrugPopup : Form
    {
        //
        private DMDRUGInfo DRUG_MAIN = new DMDRUGInfo();

        public frmDmDrugPopup()
        {
            InitializeComponent();
        }

        public frmDmDrugPopup(int DrugID)
        {
            InitializeComponent();
            DRUG_MAIN = DMDRUGController.Instance().GetById(DrugID);
        }

        private void frmDmDrugPopup_Load(object sender, EventArgs e)
        {
            if (DRUG_MAIN.ID > 0)
            {
                txt_CATEGORY_NAME.Text = DRUG_MAIN.CATEGORY_NAME;
                txt_COMPANY.Text = DRUG_MAIN.COMPANY;
                txt_COUNTRY.Text = DRUG_MAIN.COUNTRY;
                txt_DRUG_CODE.Text = DRUG_MAIN.DRUG_CODE;
                txt_DRUG_COMPONENT.Text = DRUG_MAIN.DRUG_COMPONENT;
                txt_DRUG_DESCRIPTION.Text = DRUG_MAIN.DRUG_DESCRIPTION;
                txt_DRUG_DOSE.Text = DRUG_MAIN.DRUG_DOSE;
                txt_DRUG_NAME.Text = DRUG_MAIN.DRUG_NAME;
                txt_EXPERIED_DATE.Text = DRUG_MAIN.EXPERIED_DATE.ToShortDateString();
                txt_PRODUCT_DATE.Text = DRUG_MAIN.PRODUCT_DATE.ToShortDateString();
                txt_QUANTITY.Text = DRUG_MAIN.QUANTITY.ToString();
                txt_STATUS.Text = DRUG_MAIN.STATUS;
                txt_UNIT_NAME.Text = DRUG_MAIN.UNIT_NAME;
                txt_UNIT_PRICE.Text = DRUG_MAIN.UNIT_PRICE.ToString();
                if (File.Exists(DRUG_MAIN.IMAGE))
                {
                    pic_IMAGE.Image = Image.FromFile(DRUG_MAIN.IMAGE);
                }
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            DMDRUGInfo saveDrug = new DMDRUGInfo();

            saveDrug.ID = DRUG_MAIN.ID;
            saveDrug.CATEGORY_NAME = txt_CATEGORY_NAME.Text;
            saveDrug.COMPANY = txt_COMPANY.Text;
            saveDrug.COUNTRY = txt_COUNTRY.Text;
            saveDrug.CREATED_DATE = DateTime.Now;
            saveDrug.DRUG_CODE = txt_DRUG_CODE.Text;
            saveDrug.DRUG_COMPONENT = txt_DRUG_COMPONENT.Text;
            saveDrug.DRUG_DESCRIPTION = txt_DRUG_DESCRIPTION.Text;
            saveDrug.DRUG_DOSE = txt_DRUG_DOSE.Text;
            saveDrug.DRUG_NAME = txt_DRUG_NAME.Text;
            saveDrug.EXPERIED_DATE = GBTSCCommon.ObjectToDate(txt_EXPERIED_DATE.Text);
            saveDrug.IMAGE = txt_IMAGE.Text;
            saveDrug.IS_USED = chk_IS_USED.Checked;
            saveDrug.PRODUCT_DATE = GBTSCCommon.ObjectToDate(txt_PRODUCT_DATE.Text);
            saveDrug.QUANTITY = GBTSCCommon.OjectToDouble(txt_QUANTITY.Text);
            saveDrug.STATUS = txt_STATUS.Text;
            saveDrug.UNIT_NAME = txt_UNIT_NAME.Text;
            saveDrug.UNIT_PRICE = GBTSCCommon.OjectToDouble(txt_UNIT_PRICE.Text);
            //saveDrug.USER_NAME = GBTSCConstants.CURRENT_USER.USER_NAME;

            if (saveDrug.ID > 0)
            {
                int updateID = DMDRUGController.Instance().Update(saveDrug);
            }
            else
            {
                saveDrug.DRUG_CODE = new Random(8).Next().ToString();
                DMDRUGController.Instance().Insert(saveDrug);
            }

            this.Close();
        }
    }
}
