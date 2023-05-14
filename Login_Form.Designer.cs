using System;
using System.Runtime.InteropServices;

namespace Demo_Project
{
    partial class Login_Form
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
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.login_label = new System.Windows.Forms.Label();
            this.login_info = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.rPanel1 = new Demo_Project.RPanel();
            this.input_panel = new Demo_Project.RPanel();
            this.input_name_box = new System.Windows.Forms.TextBox();
            this.name_btn = new Demo_Project.RJButton();
            this.name_label = new System.Windows.Forms.Label();
            this.exit_btn = new Demo_Project.RJButton();
            this.rPanel1.SuspendLayout();
            this.input_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_label
            // 
            this.login_label.Enabled = false;
            this.login_label.Font = new System.Drawing.Font("Segoe UI Emoji", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.login_label.Image = ((System.Drawing.Image)(resources.GetObject("login_label.Image")));
            this.login_label.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.login_label.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            this.login_label.Location = new System.Drawing.Point(145, 61);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(377, 85);
            this.login_label.TabIndex = 2;
            this.login_label.Text = "Create A Cool Name";
            this.login_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.login_label.Click += new System.EventHandler(this.login_label_Click);
            // 
            // login_info
            // 
            this.login_info.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.login_info.Location = new System.Drawing.Point(145, 170);
            this.login_info.Multiline = true;
            this.login_info.Name = "login_info";
            this.login_info.PlaceholderText = "Put words in me";
            this.login_info.Size = new System.Drawing.Size(349, 65);
            this.login_info.TabIndex = 1;
            this.login_info.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(1)))), ((int)(((byte)(82)))));
            this.login_btn.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.login_btn.ForeColor = System.Drawing.Color.White;
            this.login_btn.Location = new System.Drawing.Point(145, 279);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(349, 78);
            this.login_btn.TabIndex = 0;
            this.login_btn.Text = "Yeah! I\'m in";
            this.login_btn.UseVisualStyleBackColor = false;
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.Image = ((System.Drawing.Image)(resources.GetObject("title.Image")));
            this.title.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.title.Location = new System.Drawing.Point(475, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(331, 117);
            this.title.TabIndex = 1;
            this.title.Text = "FilLmao";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rPanel1
            // 
            this.rPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.rPanel1.BorderRadius = 30;
            this.rPanel1.Controls.Add(this.input_panel);
            this.rPanel1.Controls.Add(this.name_btn);
            this.rPanel1.Controls.Add(this.name_label);
            this.rPanel1.Location = new System.Drawing.Point(314, 151);
            this.rPanel1.Name = "rPanel1";
            this.rPanel1.Size = new System.Drawing.Size(650, 405);
            this.rPanel1.TabIndex = 22;
            // 
            // input_panel
            // 
            this.input_panel.BackColor = System.Drawing.SystemColors.Window;
            this.input_panel.BorderRadius = 20;
            this.input_panel.Controls.Add(this.input_name_box);
            this.input_panel.Location = new System.Drawing.Point(102, 160);
            this.input_panel.Name = "input_panel";
            this.input_panel.Size = new System.Drawing.Size(447, 74);
            this.input_panel.TabIndex = 37;
            // 
            // input_name_box
            // 
            this.input_name_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input_name_box.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.input_name_box.Location = new System.Drawing.Point(29, 20);
            this.input_name_box.Name = "input_name_box";
            this.input_name_box.PlaceholderText = "Put Words Inside Me";
            this.input_name_box.Size = new System.Drawing.Size(400, 31);
            this.input_name_box.TabIndex = 0;
            this.input_name_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // name_btn
            // 
            this.name_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(1)))), ((int)(((byte)(82)))));
            this.name_btn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(1)))), ((int)(((byte)(82)))));
            this.name_btn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.name_btn.BorderRadius = 40;
            this.name_btn.BorderSize = 0;
            this.name_btn.FlatAppearance.BorderSize = 0;
            this.name_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.name_btn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.name_btn.ForeColor = System.Drawing.Color.White;
            this.name_btn.Location = new System.Drawing.Point(102, 271);
            this.name_btn.Name = "name_btn";
            this.name_btn.Size = new System.Drawing.Size(447, 78);
            this.name_btn.TabIndex = 36;
            this.name_btn.Text = "Yeah! I\'m In!";
            this.name_btn.TextColor = System.Drawing.Color.White;
            this.name_btn.UseVisualStyleBackColor = false;
            // 
            // name_label
            // 
            this.name_label.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name_label.Image = ((System.Drawing.Image)(resources.GetObject("name_label.Image")));
            this.name_label.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.name_label.Location = new System.Drawing.Point(131, 55);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(400, 77);
            this.name_label.TabIndex = 34;
            this.name_label.Text = "Create A Cool Name";
            this.name_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.Transparent;
            this.exit_btn.BackgroundColor = System.Drawing.Color.Transparent;
            this.exit_btn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.exit_btn.BorderRadius = 40;
            this.exit_btn.BorderSize = 0;
            this.exit_btn.FlatAppearance.BorderSize = 0;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exit_btn.ForeColor = System.Drawing.Color.Black;
            this.exit_btn.Image = ((System.Drawing.Image)(resources.GetObject("exit_btn.Image")));
            this.exit_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exit_btn.Location = new System.Drawing.Point(1045, 12);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(205, 50);
            this.exit_btn.TabIndex = 23;
            this.exit_btn.Text = "Exit game";
            this.exit_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exit_btn.TextColor = System.Drawing.Color.Black;
            this.exit_btn.UseVisualStyleBackColor = false;
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.rPanel1);
            this.Controls.Add(this.title);
            this.Name = "Login_Form";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.rPanel1.ResumeLayout(false);
            this.input_panel.ResumeLayout(false);
            this.input_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel login_form;
        private Label login_label;
        private TextBox login_info;
        private Button login_btn;
        private Label title;
        private RPanel rPanel1;
        private RJButton name_btn;
        private Label name_label;
        private RPanel input_panel;
        private TextBox input_name_box;
        private RJButton exit_btn;
    }
}