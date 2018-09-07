﻿using MessagingToolkit.QRCode.Codec.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QRCodeBasedLMS
{
    public partial class Book : Form
    {
        private string qrcode;
        public Book(string qr)
        {
            InitializeComponent();
            qrcode = qr;
        }

        //----------------------------------
        //----------------------------------
        // text changed and keypress
        //----------------------------------
        //----------------------------------

        dcLMSDataContext db = new dcLMSDataContext();
        clsBook bk = new clsBook();
        private void Book_Load(object sender, EventArgs e)
        {
            btnUpdate.Visible = false;
            txt_BookIDNum.Text= bk.GenerateBookIDNum();
            cmbBookType.Text = "References";
            dgvBook.DataSource = db.sp_ViewBook();
            cmb_SearchCategory.Text = "QR Code";
            cmb_Status.Text = "Available";
            if (qrcode != "")
            {
                dgvBook.DataSource = db.sp_SearchBook(cmb_SearchCategory.Text, qrcode);
            }
        }

        private void btnAddOrAddBookCopy_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_BookIDNum.Text) || string.IsNullOrWhiteSpace(txt_Title.Text) || string.IsNullOrWhiteSpace(txt_Pages.Text) || string.IsNullOrWhiteSpace(txt_Publisher.Text) || string.IsNullOrWhiteSpace(txt_CopyrightYear.Text))
            {
                MessageBox.Show("Incomplete Information!\nPlease enter values in textboxes that has (*) indicator.");
            }
            else
            {
                if(bk.CheckValidCopyrightYear() == false)
                {
                    MessageBox.Show("Invalid Copyright Year!");
                }
                else
                {
                    
                    if (btnAddOrAddBookCopy.Text == "ADD")
                    {
                        bk.BookIDNumber = txt_BookIDNum.Text;
                        bk.BookType = cmbBookType.Text;
                        bk.ISBN = txt_ISBN.Text;
                        bk.AccessionNumber = int.Parse(txt_AccessionNumber.Text);
                        bk.CallNumber = txt_CallNumber.Text;
                        bk.DateReceived = DateTime.Parse(dtp_DateReceived.Text);
                        bk.Title = txt_Title.Text;
                        bk.Author = txt_Author.Text;
                        bk.Publisher = txt_Publisher.Text;
                        bk.CopyrightYear = int.Parse(txt_CopyrightYear.Text);
                        bk.Edition = txt_Edition.Text;
                        bk.Volume = txt_Volume.Text;
                        bk.Pages = int.Parse(txt_Pages.Text);
                        bk.Status = cmb_Status.Text;
                        bk.Remarks = txt_Remarks.Text;
                        bk.AddRecord();
                        using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true })
                        {
                            if (sfd.ShowDialog() == DialogResult.OK)
                            {
                                pb_QRBook.Image.Save(sfd.FileName, ImageFormat.Jpeg);
                            }
                        }
                        dgvBook.DataSource = db.sp_ViewBook(); ;
                        MessageBox.Show("Sucessfully Added!");
                        ClearText();
                        txt_BookIDNum.Text = bk.GenerateBookIDNum();
                        cmbBookType.Text = "References";
                    }
                    else
                    {
                        BookCopy bc = new BookCopy(txt_BookIDNum.Text);
                        bc.Show();
                        this.Hide();
                    }
                }
                
            }
        }

        public int getBookType(string booktype)
        {
            int bookIndex;
            if (booktype == "References")
            {
                bookIndex = 0;
            } else if (booktype == "Filipiniana")
            {
                bookIndex = 1;
            } else if (booktype == "General Reference")
            {
                bookIndex = 2;
            } else
            {
                bookIndex = 3;
            }
            return bookIndex;
        }

        private void dgvBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAddOrAddBookCopy.Text = "ADD COPY";
            gb_Copy.Visible = false;
            btnUpdate.Visible = true;
            txt_BookIDNum.Text = dgvBook.CurrentRow.Cells[0].Value.ToString();
            cmbBookType.selectedIndex = getBookType(dgvBook.CurrentRow.Cells[1].Value.ToString());
            txt_ISBN.Text = (from s in db.tblBooks where s.book_BookNum == txt_BookIDNum.Text select s.book_ISBN).FirstOrDefault();
            txt_CallNumber.Text = dgvBook.CurrentRow.Cells[2].Value.ToString();
            txt_Title.Text = dgvBook.CurrentRow.Cells[3].Value.ToString();
            txt_Author.Text = dgvBook.CurrentRow.Cells[4].Value.ToString();
            txt_Publisher.Text = (from s in db.tblBooks where s.book_BookNum == txt_BookIDNum.Text select s.book_Publisher).FirstOrDefault();
            txt_CopyrightYear.Text = dgvBook.CurrentRow.Cells[5].Value.ToString();
            txt_Edition.Text = (from s in db.tblBooks where s.book_BookNum == txt_BookIDNum.Text select s.book_Edition).FirstOrDefault();
            txt_Volume.Text = (from s in db.tblBooks where s.book_BookNum == txt_BookIDNum.Text select s.book_Volume).FirstOrDefault();
            txt_Pages.Text = (from s in db.tblBooks where s.book_BookNum == txt_BookIDNum.Text select s.book_Pages).FirstOrDefault().ToString();
            txt_Remarks.Text = (from s in db.tblBooks where s.book_BookNum == txt_BookIDNum.Text select s.book_Remarks).FirstOrDefault();

            lbl_NumCopies.Visible = true;
            lbl_NumCopies.Text = "Total No. of Copies : " +db.sp_TotalBookCopy(txt_BookIDNum.Text).Count().ToString();
        }
        
        private void txt_BookIDNum_OnValueChanged(object sender, EventArgs e)
        {
            
            MessagingToolkit.QRCode.Codec.QRCodeEncoder encode = new MessagingToolkit.QRCode.Codec.QRCodeEncoder();
            encode.QRCodeScale = 6;
            Bitmap bmp = encode.Encode(txt_BookIDNum.Text);
            pb_QRBook.Image = bmp;
        }

        public void ClearText()
        {
            txt_ISBN.Text = "";
            txt_AccessionNumber.Text = "";
            txt_CallNumber.Text = "";
            txt_Title.Text = "";
            txt_Author.Text = "";
            txt_Publisher.Text = "";
            txt_CopyrightYear.Text = "";
            txt_Edition.Text = "";
            txt_Volume.Text = "";
            txt_Pages.Text = "";
            cmb_Status.Text = "";
            txt_Remarks.Text = "";
            btnAddOrAddBookCopy.Text = "ADD";
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearText();
            txt_BookIDNum.Text = bk.GenerateBookIDNum();
            cmbBookType.Text = "References";
            gb_Copy.Visible = true;
            btnUpdate.Visible = false;
            lbl_NumCopies.Visible = false;
            dgvBook.DataSource = db.sp_ViewBook();
        }
        

        private void txt_AccessionNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_CopyrightYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            //txt_CopyrightYear.MaxLength = 4;
            SetMaximumLength(txt_CopyrightYear, 4);

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_Pages_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Link_Scan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            MainForm MF = new MainForm();
            MF.Show();
            this.Hide();
        }




        // function in setting maximum length in copyright year
        // since bunifu dont support direct maxlength control
        private void SetMaximumLength(Bunifu.Framework.UI.BunifuMetroTextbox metroTextbox, int maximumLength)
        {
            foreach (Control ctl in metroTextbox.Controls)
            {
                if (ctl.GetType() == typeof(TextBox))
                {
                    var txt = (TextBox)ctl;
                    txt.MaxLength = maximumLength;

                    // Set other properties & events here...
                }
            }
        }

        private void cmb_SelectedCategory_onItemSelected(object sender, EventArgs e)
        {
            if (cmb_SearchCategory.selectedValue == "QR Code")
            {
                link_Scan.Visible = true;
                txt_Search.Visible = false;
            }
            else
            {
                txt_Search.Visible = true;
                link_Scan.Visible = false;
            }
        }

        private void dgvBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void link_Scan_Click(object sender, EventArgs e)
        {
            ScanQRCode scan = new ScanQRCode("book");
            scan.Show();
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_BookIDNum.Text) || string.IsNullOrWhiteSpace(txt_Title.Text) || string.IsNullOrWhiteSpace(txt_Publisher.Text) || string.IsNullOrWhiteSpace(txt_CopyrightYear.Text))
            {
                MessageBox.Show("Incomplete Information!\nPlease enter values in textboxes that has (*) indicator.");
            }
            else
            {
                if (bk.CheckValidCopyrightYear() == false)
                {
                    MessageBox.Show("Invalid Copyright Year!");
                }
                else
                {
                    bk.BookIDNumber = txt_BookIDNum.Text;
                    bk.BookType = cmbBookType.Text;
                    bk.ISBN = txt_ISBN.Text;
                    bk.CallNumber = txt_CallNumber.Text;
                    bk.Title = txt_Title.Text;
                    bk.Author = txt_Author.Text;
                    bk.Publisher = txt_Publisher.Text;
                    bk.CopyrightYear = int.Parse(txt_CopyrightYear.Text);
                    bk.Edition = txt_Edition.Text;
                    bk.Volume = txt_Volume.Text;
                    bk.Pages = int.Parse(txt_Pages.Text);
                    bk.Remarks = txt_Remarks.Text;


                    bk.UpdateRecord();
                    dgvBook.DataSource = db.sp_ViewBook();
                    MessageBox.Show("Sucessfully Updated!");
                    ClearText();
                    btnUpdate.Visible = false;

                }

            }
        }
    }
}
