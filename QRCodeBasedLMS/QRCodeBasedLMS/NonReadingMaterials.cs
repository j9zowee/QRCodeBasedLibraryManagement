﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRCodeBasedLMS
{
    public partial class NonReadingMaterials : Form
    {
        public NonReadingMaterials()
        {
            InitializeComponent();
        }
        dcLMSDataContext db = new dcLMSDataContext();
        private void NonReadingMaterials_Load(object sender, EventArgs e)
        {
            dgv_NonReadingMaterials.DataSource = db.sp_ViewNonReadingMaterial();
        }

        private void btnAddOrUpdate_Click(object sender, EventArgs e)
        {
            if (btnAddOrUpdate.Text == "ADD")
            {
                db.sp_AddNonReadingMaterial(txt_MaterialIDNumber.Text, cmb_MatType.selectedValue, txt_Title.Text, txt_Volume.Text
                , txt_Issue.Text, int.Parse(txt_CopyrightYear.Text), txt_Author.Text, txt_Publisher.Text
                   , int.Parse(txt_Page.Text), int.Parse(txt_NumberOfCopies.Text));
                MessageBox.Show("Good job (y)");
                Clear();
                dgv_NonReadingMaterials.DataSource = db.sp_ViewNonReadingMaterial();
            } else
            {
                db.sp_UpdateNonReadingMaterial(txt_MaterialIDNumber.Text, cmb_MatType.selectedValue, txt_Title.Text, txt_Volume.Text
                , txt_Issue.Text, int.Parse(txt_CopyrightYear.Text), txt_Author.Text, txt_Publisher.Text
                   , int.Parse(txt_Page.Text), int.Parse(txt_NumberOfCopies.Text));
                MessageBox.Show("Good job (y)");
                Clear();
                dgv_NonReadingMaterials.DataSource = db.sp_ViewNonReadingMaterial();
            }
        }

        private void dgv_NonReadingMaterials_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaterialIDNumber.Text = dgv_NonReadingMaterials.CurrentRow.Cells[1].Value.ToString();
            setComboBoxValue(cmb_MatType, dgv_NonReadingMaterials.CurrentRow.Cells[2].Value.ToString());
            txt_Title.Text = dgv_NonReadingMaterials.CurrentRow.Cells[3].Value.ToString();
            txt_Volume.Text = dgv_NonReadingMaterials.CurrentRow.Cells[4].Value.ToString();
            txt_Issue.Text = dgv_NonReadingMaterials.CurrentRow.Cells[5].Value.ToString();
            txt_CopyrightYear.Text = dgv_NonReadingMaterials.CurrentRow.Cells[6].Value.ToString();
            txt_Author.Text = dgv_NonReadingMaterials.CurrentRow.Cells[7].Value.ToString();
            txt_Publisher.Text = dgv_NonReadingMaterials.CurrentRow.Cells[8].Value.ToString();
            txt_Page.Text = dgv_NonReadingMaterials.CurrentRow.Cells[9].Value.ToString();
            txt_NumberOfCopies.Text = dgv_NonReadingMaterials.CurrentRow.Cells[10].Value.ToString();
            btnAddOrUpdate.Text = "UPDATE";
        }

        // mao ni ako pasabot diay oy hahahahah
        public void Clear()
        {
            txt_MaterialIDNumber.Text = "";
            cmb_MatType.selectedIndex = 0;
            txt_Title.Text = "";
            txt_Volume.Text = "";
            txt_Issue.Text = "";
            txt_CopyrightYear.Text = "";
            txt_Author.Text = "";
            txt_Publisher.Text = "";
            txt_Page.Text = "";
            txt_NumberOfCopies.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void setComboBoxValue(Bunifu.Framework.UI.BunifuDropdown cmbDrop, string value)
        {
            foreach (Control ctl in cmbDrop.Controls)
            {
                if (ctl.GetType() == typeof(ComboBox))
                {
                    var cmb = (ComboBox)ctl;
                    cmb.Text = value;

                    // Set other properties & events here...
                }
            }
        }


    }
}
