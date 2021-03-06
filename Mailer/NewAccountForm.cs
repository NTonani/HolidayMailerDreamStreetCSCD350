﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace HolidayMailerCSCD350
{
    public partial class NewAccountForm : Form
    {

        bool fnselected = false;
        bool lnselected = false;

        public NewAccountForm()
        {
            InitializeComponent();

            p1Label1.Text = "Dream Street accounts are currently stored only with the client that creates them, and will not be accessible on other Holiday Mailer clients.\n\nPlease ensure that any and all email addresses you attach to your account have been approved to send thrid party emails. Otherwise, you will not be able to send messages and your email account may be suspended.\n\nThe images used in the release of this software are property of Line Corporation and Naver Corporation.";

            p2Label1.Text = "Enter an Account Name and Password.\nPassword is CASE-SENSITIVE.\nPassword must contain at least 6 characters.";
            p2pwBox1.PasswordChar = '●';
            p2pwBox2.PasswordChar = '●';


            p3Label1.Text = "Enter a default Email Address, more can be added later.";
            p3pwBox.PasswordChar = '●';

            p4Label.Text = "Your Account has been created successfully!\n\n";

        }

        private void p1agreeButton_Click(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Show();
        }

        private void p2backButton_Click(object sender, EventArgs e)
        {
            panel1.Show();
            panel2.Hide();
        }
        
        private void p2nextButton_Click(object sender, EventArgs e)
        {
            
            if (ValidatePage2())
            {
                panel2.Hide();
                panel3.Show();
            }
            else
            {
                p2Label3.Text = "An account with that name already exists";
            }
        }

        private bool ValidatePage2()
        {
            if (Data.db.CheckUsername(p2accountBox.Text))
            {
                return true;
            }

            return false;
        }

        private void p3backButton_Click(object sender, EventArgs e)
        {
            panel2.Show();
            panel3.Hide();
        }

        private void p3createButton_Click(object sender, EventArgs e)
        {
            if (CreateAccount())
            {
                panel3.Hide();
                panel4.Show();
            }
            else
            {
                new MessageForm("There was an error creating your account, please review your information", false, new Point(this.Location.X+83, this.Location.Y+100)).ShowDialog();
            }
        }


        private bool CreateAccount()
        {
            string lname = "";
            string fname = "";

            if (lnselected)
            {
                lname = fnBox.Text;
            }

            if (fnselected)
            {
                fname = lnBox.Text;
            }

            List<UserMail> defaultemail = new List<UserMail>();
            defaultemail.Add(new UserMail(p3emailBox1.Text, p3pwBox.Text));

            User toadd = new User(p2accountBox.Text, fname, lname, "", p2pwBox1.Text, defaultemail);

            return Data.db.AddUser(toadd);

        }


        private void p4finishButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void fnBox_Enter(object sender, EventArgs e)
        {
            if (!fnselected)
            {
                fnBox.Clear();
                fnBox.ForeColor = Color.Black;
                fnselected = true;
            }

        }

        private void fnBox_Leave(object sender, EventArgs e)
        {
            if (fnBox.Text.Equals(""))
            {
                fnBox.Text = "First";
                fnBox.ForeColor = Color.DarkGray;
                fnselected = false;
            }
        }

        private void lnBox_Enter(object sender, EventArgs e)
        {
            if (!lnselected)
            {
                lnBox.Clear();
                lnBox.ForeColor = Color.Black;
                lnselected = true;
            }

        }

        private void lnBox_Leave(object sender, EventArgs e)
        {
            if (lnBox.Text.Equals(""))
            {
                lnBox.Text = "Last";
                lnBox.ForeColor = Color.DarkGray;
                lnselected = false;
            }
        }
        
        private void p2accountBox_TextChanged(object sender, EventArgs e)
        {
            if (CheckUN())
            {
                if (CheckPW())
                {
                    PwMatch();
                }
            }
        }

        private bool CheckUN()
        {
            if (!Data.CheckAlphanumeric(p2accountBox.Text))
            {
                p2Label3.Text = "Account Name must contain only alphanumeric characters";
                nameast.Text = "*";
                p2nextButton.Enabled = false;
                return false;
            }
            else if (p2accountBox.Text.Length < 3)
            {
                p2Label3.Text = "Account Name must be at least 3 characters";
                nameast.Text = "*";
                p2nextButton.Enabled = false;
                return false;
            }

            p2Label3.Text = "";

            nameast.Text = "";
            return true;
        }

        private void p2pwBox1_TextChanged(object sender, EventArgs e)
        {
            if (CheckPW())
            {
                PwMatch();
            }
        }

        private void p2pwBox2_TextChanged(object sender, EventArgs e)
        {
            if (CheckPW())
            {
                PwMatch();
            }
        }

        private bool CheckPW()
        {
            if (!Data.CheckAlphanumeric(p2pwBox1.Text))
            {
                p2Label2.Text = "Password must contain only alphanumeric characters";
                pwast1.Text = "*";
                p2nextButton.Enabled = false;
                return false;
            }
            else if (p2pwBox1.Text.Length < 6)
            {
                p2Label2.Text = "Password must be at least 6 characters";
                pwast1.Text = "*";
                p2nextButton.Enabled = false;
                return false;
            }

            pwast1.Text = "";
            return true;
        }


        private bool PwMatch()
        {
            if (p2pwBox1.Text.Equals(p2pwBox2.Text))
            {
                p2Label2.Text = "";
                pwast2.Text = "";
                if (CheckUN())
                {
                    p2nextButton.Enabled = true;
                    return true;
                }

            }

            pwast2.Text = "*";
            p2Label2.Text = "Passwords must match";
            p2nextButton.Enabled = false;
            return false;
        }

        private void p3emailBox1_TextChanged(object sender, EventArgs e)
        {
            if (Data.ValidateUserEmail(p3emailBox1.Text))
            {
                EmailMatch();
            }
            else
            {
                p3Label2.Text = "Email is in invalid form or not supported";
                p3createButton.Enabled = false;
            }
        }

        private void p3emailBox2_TextChanged(object sender, EventArgs e)
        {
            if (Data.ValidateUserEmail(p3emailBox1.Text))
            {
                EmailMatch();
            }
            else
            {
                p3Label2.Text = "Email is in invalid form or not supported";
                p3createButton.Enabled = false;
            }
        }

        private bool EmailMatch()
        {
            if (p3emailBox1.Text.Equals(p3emailBox2.Text))
            {
                p3Label2.Text = "";
                p3createButton.Enabled = true;
                return true;
            }

            p3Label2.Text = "Emails must match";
            p3createButton.Enabled = false;
            return false;
        }


        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panelbar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }




    }
}
