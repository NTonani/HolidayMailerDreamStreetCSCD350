﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolidayMailerCSCD350
{
    public partial class AccountForm : Form
    {
        int j = -1;
        public AccountForm()
        {
            InitializeComponent();
            ReadOnly(true);
            passwordbx.Hide();
            Fill();
            FillEmails();

            
        }

        private void ReadOnly(bool t)
        {
            accountgb.Show();
            passwordbx.Hide();
            if (t)
            {
                emailbox.Enabled = true;
                submitbtn.Hide();
                cancelbtn.Hide();
                fnametb.ReadOnly = true;
                lnametb.ReadOnly = true;
                unametb.ReadOnly = true;
                bdaytb.ReadOnly = true;

                fnametb.BorderStyle = System.Windows.Forms.BorderStyle.None;
                lnametb.BorderStyle = System.Windows.Forms.BorderStyle.None;
                unametb.BorderStyle = System.Windows.Forms.BorderStyle.None;
                bdaytb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            }
            else
            {
                
                submitbtn.Show();
                cancelbtn.Show();
                emailbox.Enabled = false;
                fnametb.ReadOnly = false;
                lnametb.ReadOnly = false;
                bdaytb.ReadOnly = false;

                fnametb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                lnametb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                bdaytb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            }
        }

        private void Fill()
        {
            fnametb.Text = Data.user.fname;
            lnametb.Text = Data.user.lname;
            unametb.Text = Data.user.username;
            bdaytb.Text = Data.user.DOB;

        }

        private void FillEmails()
        {
            foreach (UserMail element in Data.user.accounts)
            {
                emaillb.Items.Add(element.email);
            }
        }
        private void Submit()
        {
            


            Data.user.fname = fnametb.Text;
            Data.user.lname = lnametb.Text;
            Data.user.DOB = bdaytb.Text;
            Data.user.pwd = newpwtb.Text;
            
            Data.db.UpdateUser(Data.user);
            
            ReadOnly(true);
            Fill();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReadOnly(false);
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            Submit();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            Fill();
            ReadOnly(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            accountgb.Hide();
            emailbox.Enabled = false;
            passwordbx.Show();
        }

        private void submitpwbtn_Click(object sender, EventArgs e)
        {
            
            incurpwtb.Text = "";
            innewpwtb.Text = "";
            innewpw2tb.Text = "";
            if (newpwtb.Text == newpw2tb.Text && curpwtb.Text == Data.user.pwd)
                Submit();
            else
            {
                if (newpwtb.Text != newpw2tb.Text)
                {
                    innewpw2tb.Text = "Password does not match";
                }
                if(curpwtb.Text !=Data.user.pwd)
                {
                    incurpwtb.Text = "Incorrect password";
                }
            }
            curpwtb.Text = "";
            newpwtb.Text = "";
            newpw2tb.Text = "";
        }

        private void cancelpwbtn_Click(object sender, EventArgs e)
        {
            ReadOnly(true);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (emaillb.SelectedIndex != -1)
            {

                for (int i = 0; i < Data.user.accounts.Count(); i++)
                {
                    if (Data.user.accounts[i].email == emaillb.SelectedItem.ToString())
                    {
                        j = i;
                        em1tb.Text = emaillb.SelectedItem.ToString();
                        pw1tb.Text = Data.user.accounts[i].pwd;

                        accountgb.Enabled = false;
                        emailbox.Show();
                        emailaccntbox.Hide();
                    }
                }
            }
        }

        private void cnclemailbtn_Click(object sender, EventArgs e)
        {
            emailbox.Hide();
            emailaccntbox.Show();
            accountgb.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void submitemlbtn_Click(object sender, EventArgs e)
        {
            Data.user.accounts[j].email = em1tb.Text;
            Data.user.accounts[j].email = pw1tb.Text;
        }

        private void addsubbtn_Click(object sender, EventArgs e)
        {
            Data.user.accounts.Add(new UserMail());
        }

        private void addcanbtn_Click(object sender, EventArgs e)
        {

        }

    }
}
