﻿namespace HolidayMailerCSCD350
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ordertb = new System.Windows.Forms.TextBox();
            this.reltb = new System.Windows.Forms.TextBox();
            this.addbtn = new System.Windows.Forms.Button();
            this.dobtb = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.outputtb = new System.Windows.Forms.TextBox();
            this.emailtb = new System.Windows.Forms.TextBox();
            this.lnametb = new System.Windows.Forms.TextBox();
            this.fnametb = new System.Windows.Forms.TextBox();
            this.prevcb = new System.Windows.Forms.CheckBox();
            this.showbtn = new System.Windows.Forms.Button();
            this.sortRelbtn = new System.Windows.Forms.Button();
            this.mailbtn = new System.Windows.Forms.Button();
            this.searchtb = new System.Windows.Forms.TextBox();
            this.searchbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ordertb
            // 
            this.ordertb.Location = new System.Drawing.Point(0, 579);
            this.ordertb.Name = "ordertb";
            this.ordertb.Size = new System.Drawing.Size(333, 20);
            this.ordertb.TabIndex = 0;
            // 
            // reltb
            // 
            this.reltb.Location = new System.Drawing.Point(0, 357);
            this.reltb.Name = "reltb";
            this.reltb.Size = new System.Drawing.Size(333, 20);
            this.reltb.TabIndex = 1;
            // 
            // addbtn
            // 
            this.addbtn.Location = new System.Drawing.Point(0, 409);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(75, 23);
            this.addbtn.TabIndex = 2;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = true;
            this.addbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // dobtb
            // 
            this.dobtb.Location = new System.Drawing.Point(0, 383);
            this.dobtb.Name = "dobtb";
            this.dobtb.Size = new System.Drawing.Size(333, 20);
            this.dobtb.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(591, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // outputtb
            // 
            this.outputtb.Location = new System.Drawing.Point(48, 27);
            this.outputtb.Multiline = true;
            this.outputtb.Name = "outputtb";
            this.outputtb.ReadOnly = true;
            this.outputtb.Size = new System.Drawing.Size(285, 206);
            this.outputtb.TabIndex = 5;
            // 
            // emailtb
            // 
            this.emailtb.Location = new System.Drawing.Point(0, 305);
            this.emailtb.Name = "emailtb";
            this.emailtb.Size = new System.Drawing.Size(333, 20);
            this.emailtb.TabIndex = 6;
            // 
            // lnametb
            // 
            this.lnametb.Location = new System.Drawing.Point(0, 279);
            this.lnametb.Name = "lnametb";
            this.lnametb.Size = new System.Drawing.Size(333, 20);
            this.lnametb.TabIndex = 7;
            // 
            // fnametb
            // 
            this.fnametb.Location = new System.Drawing.Point(0, 253);
            this.fnametb.Name = "fnametb";
            this.fnametb.Size = new System.Drawing.Size(333, 20);
            this.fnametb.TabIndex = 8;
            // 
            // prevcb
            // 
            this.prevcb.AutoSize = true;
            this.prevcb.Location = new System.Drawing.Point(348, 282);
            this.prevcb.Name = "prevcb";
            this.prevcb.Size = new System.Drawing.Size(153, 17);
            this.prevcb.TabIndex = 9;
            this.prevcb.Text = "Previous holiday email sent";
            this.prevcb.UseVisualStyleBackColor = true;
            // 
            // showbtn
            // 
            this.showbtn.Location = new System.Drawing.Point(130, 409);
            this.showbtn.Name = "showbtn";
            this.showbtn.Size = new System.Drawing.Size(75, 23);
            this.showbtn.TabIndex = 10;
            this.showbtn.Text = "Show db";
            this.showbtn.UseVisualStyleBackColor = true;
            this.showbtn.Click += new System.EventHandler(this.showbtn_Click);
            // 
            // sortRelbtn
            // 
            this.sortRelbtn.Location = new System.Drawing.Point(12, 475);
            this.sortRelbtn.Name = "sortRelbtn";
            this.sortRelbtn.Size = new System.Drawing.Size(156, 23);
            this.sortRelbtn.TabIndex = 11;
            this.sortRelbtn.Text = "sort by email";
            this.sortRelbtn.UseVisualStyleBackColor = true;
            this.sortRelbtn.Click += new System.EventHandler(this.sortRelbtn_Click);
            // 
            // mailbtn
            // 
            this.mailbtn.Location = new System.Drawing.Point(258, 409);
            this.mailbtn.Name = "mailbtn";
            this.mailbtn.Size = new System.Drawing.Size(75, 23);
            this.mailbtn.TabIndex = 12;
            this.mailbtn.Text = "Send mail";
            this.mailbtn.UseVisualStyleBackColor = true;
            this.mailbtn.Click += new System.EventHandler(this.mailbtn_Click);
            // 
            // searchtb
            // 
            this.searchtb.Location = new System.Drawing.Point(339, 174);
            this.searchtb.Name = "searchtb";
            this.searchtb.Size = new System.Drawing.Size(222, 20);
            this.searchtb.TabIndex = 13;
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(486, 200);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(75, 23);
            this.searchbtn.TabIndex = 14;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 684);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.searchtb);
            this.Controls.Add(this.mailbtn);
            this.Controls.Add(this.sortRelbtn);
            this.Controls.Add(this.showbtn);
            this.Controls.Add(this.prevcb);
            this.Controls.Add(this.fnametb);
            this.Controls.Add(this.lnametb);
            this.Controls.Add(this.emailtb);
            this.Controls.Add(this.dobtb);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.reltb);
            this.Controls.Add(this.ordertb);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.outputtb);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ordertb;
        private System.Windows.Forms.TextBox reltb;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.TextBox dobtb;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox outputtb;
        private System.Windows.Forms.TextBox emailtb;
        private System.Windows.Forms.TextBox lnametb;
        private System.Windows.Forms.TextBox fnametb;
        private System.Windows.Forms.CheckBox prevcb;
        private System.Windows.Forms.Button showbtn;
        private System.Windows.Forms.Button sortRelbtn;
        private System.Windows.Forms.Button mailbtn;
        private System.Windows.Forms.TextBox searchtb;
        private System.Windows.Forms.Button searchbtn;
    }
}

