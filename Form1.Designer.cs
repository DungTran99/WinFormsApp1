﻿namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label1 = new Label();
            label2 = new Label();
            listView2 = new ListView();
            listView1 = new ListView();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(30, 56);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "1 giờ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(111, 56);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 0;
            button2.Text = "10 phút";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(274, 56);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 0;
            button3.Text = "Xác Nhận";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(193, 56);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 0;
            button4.Text = "60 giây";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(355, 56);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 0;
            button5.Text = "Xoá";
            button5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(19, 29);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 2;
            label1.Text = "Nhập thời gian ";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(19, 91);
            label2.Name = "label2";
            label2.Size = new Size(105, 33);
            label2.TabIndex = 2;
            label2.Text = "Thông báo:";
            label2.Click += label2_Click;
            // 
            // listView2
            // 
            listView2.Location = new Point(111, 24);
            listView2.Name = "listView2";
            listView2.Size = new Size(238, 26);
            listView2.TabIndex = 1;
            listView2.UseCompatibleStateImageBehavior = false;
            // 
            // listView1
            // 
            listView1.Location = new Point(120, 91);
            listView1.Name = "listView1";
            listView1.Size = new Size(238, 26);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 144);
            Controls.Add(label1);
            Controls.Add(listView2);
            Controls.Add(listView1);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.cboTime = new System.Windows.Forms.ComboBox();
            this.btnTimer = new System.Windows.Forms.Button();
            this.btnDisTimer = new System.Windows.Forms.Button();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboTime
            // 
            this.cboTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTime.DropDownWidth = 100;
            this.cboTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTime.Location = new System.Drawing.Point(60, 60);
            this.cboTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboTime.Name = "cboTime";
            this.cboTime.Size = new System.Drawing.Size(160, 25);
            this.cboTime.TabIndex = 0;
            // 
            // btnTimer
            // 
            this.btnTimer.BackColor = System.Drawing.Color.LimeGreen;
            this.btnTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTimer.Location = new System.Drawing.Point(250, 58);
            this.btnTimer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(100, 36);
            this.btnTimer.TabIndex = 1;
            this.btnTimer.Text = "Hẹn giờ";
            this.btnTimer.UseVisualStyleBackColor = false;
            this.btnTimer.Click += new System.EventHandler(this.btnTimer_Click);
            // 
            // btnDisTimer
            // 
            this.btnDisTimer.BackColor = System.Drawing.Color.Red;
            this.btnDisTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisTimer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDisTimer.Location = new System.Drawing.Point(250, 111);
            this.btnDisTimer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDisTimer.Name = "btnDisTimer";
            this.btnDisTimer.Size = new System.Drawing.Size(100, 35);
            this.btnDisTimer.TabIndex = 2;
            this.btnDisTimer.Text = "Hủy";
            this.btnDisTimer.UseVisualStyleBackColor = false;
            this.btnDisTimer.Click += new System.EventHandler(this.btnDisTimer_Click);
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.pnlTitle.Controls.Add(this.label1);
            this.pnlTitle.Controls.Add(this.btnExit);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(406, 35);
            this.pnlTitle.TabIndex = 3;
            this.pnlTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseDown);
            this.pnlTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseMove);
            this.pnlTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseUp);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::ShutdownTimer.Properties.Resources.ic_close_black_24dp;
            this.btnExit.Location = new System.Drawing.Point(363, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(43, 35);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hẹn giờ tắt máy";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 178);
            this.Controls.Add(this.pnlTitle);
            this.Controls.Add(this.btnDisTimer);
            this.Controls.Add(this.btnTimer);
            this.Controls.Add(this.cboTime);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shutdown Timer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.ComboBox cboTime;
        private System.Windows.Forms.Button btnTimer;
        private System.Windows.Forms.Button btnDisTimer;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label1;
        private Label label2;
        private ListView listView2;
        private ListView listView1;
    }
}
