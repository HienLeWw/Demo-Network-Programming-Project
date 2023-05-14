namespace Demo_Project
{
    partial class Menu_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Form));
            this.title = new System.Windows.Forms.Label();
            this.player_name = new System.Windows.Forms.Label();
            this.choice_panel = new Demo_Project.RPanel();
            this.choice_label = new System.Windows.Forms.Label();
            this.create_btn = new Demo_Project.RJButton();
            this.join_rand_btn = new Demo_Project.RJButton();
            this.join_code_btn = new Demo_Project.RJButton();
            this.back_btn = new Demo_Project.RJButton();
            this.choice_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.Image = ((System.Drawing.Image)(resources.GetObject("title.Image")));
            this.title.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.title.Location = new System.Drawing.Point(462, 33);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(339, 121);
            this.title.TabIndex = 2;
            this.title.Text = "FilLmao";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // player_name
            // 
            this.player_name.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.player_name.Image = ((System.Drawing.Image)(resources.GetObject("player_name.Image")));
            this.player_name.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.player_name.Location = new System.Drawing.Point(560, 179);
            this.player_name.Name = "player_name";
            this.player_name.Size = new System.Drawing.Size(193, 68);
            this.player_name.TabIndex = 7;
            this.player_name.Text = "Player";
            this.player_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.player_name.Click += new System.EventHandler(this.player_name_Click);
            // 
            // choice_panel
            // 
            this.choice_panel.BackColor = System.Drawing.Color.Black;
            this.choice_panel.BorderRadius = 20;
            this.choice_panel.Controls.Add(this.choice_label);
            this.choice_panel.Location = new System.Drawing.Point(61, 285);
            this.choice_panel.Name = "choice_panel";
            this.choice_panel.Size = new System.Drawing.Size(236, 310);
            this.choice_panel.TabIndex = 15;
            // 
            // choice_label
            // 
            this.choice_label.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.choice_label.ForeColor = System.Drawing.Color.White;
            this.choice_label.Location = new System.Drawing.Point(0, 0);
            this.choice_label.Name = "choice_label";
            this.choice_label.Size = new System.Drawing.Size(236, 310);
            this.choice_label.TabIndex = 16;
            this.choice_label.Text = "I want to _______________________";
            // 
            // create_btn
            // 
            this.create_btn.BackColor = System.Drawing.SystemColors.Window;
            this.create_btn.BackgroundColor = System.Drawing.SystemColors.Window;
            this.create_btn.BorderColor = System.Drawing.Color.Black;
            this.create_btn.BorderRadius = 45;
            this.create_btn.BorderSize = 2;
            this.create_btn.FlatAppearance.BorderSize = 0;
            this.create_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create_btn.Font = new System.Drawing.Font("Segoe UI Emoji", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.create_btn.ForeColor = System.Drawing.Color.Black;
            this.create_btn.Location = new System.Drawing.Point(348, 285);
            this.create_btn.Name = "create_btn";
            this.create_btn.Size = new System.Drawing.Size(236, 310);
            this.create_btn.TabIndex = 16;
            this.create_btn.Text = "Create a new room";
            this.create_btn.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.create_btn.TextColor = System.Drawing.Color.Black;
            this.create_btn.UseVisualStyleBackColor = false;
            // 
            // join_rand_btn
            // 
            this.join_rand_btn.BackColor = System.Drawing.SystemColors.Window;
            this.join_rand_btn.BackgroundColor = System.Drawing.SystemColors.Window;
            this.join_rand_btn.BorderColor = System.Drawing.Color.Black;
            this.join_rand_btn.BorderRadius = 45;
            this.join_rand_btn.BorderSize = 2;
            this.join_rand_btn.FlatAppearance.BorderSize = 0;
            this.join_rand_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.join_rand_btn.Font = new System.Drawing.Font("Segoe UI Emoji", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.join_rand_btn.ForeColor = System.Drawing.Color.Black;
            this.join_rand_btn.Location = new System.Drawing.Point(634, 280);
            this.join_rand_btn.Name = "join_rand_btn";
            this.join_rand_btn.Size = new System.Drawing.Size(236, 310);
            this.join_rand_btn.TabIndex = 17;
            this.join_rand_btn.Text = "Join a random room";
            this.join_rand_btn.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.join_rand_btn.TextColor = System.Drawing.Color.Black;
            this.join_rand_btn.UseVisualStyleBackColor = false;
            // 
            // join_code_btn
            // 
            this.join_code_btn.BackColor = System.Drawing.SystemColors.Window;
            this.join_code_btn.BackgroundColor = System.Drawing.SystemColors.Window;
            this.join_code_btn.BorderColor = System.Drawing.Color.Black;
            this.join_code_btn.BorderRadius = 45;
            this.join_code_btn.BorderSize = 2;
            this.join_code_btn.FlatAppearance.BorderSize = 0;
            this.join_code_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.join_code_btn.Font = new System.Drawing.Font("Segoe UI Emoji", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.join_code_btn.ForeColor = System.Drawing.Color.Black;
            this.join_code_btn.Location = new System.Drawing.Point(927, 285);
            this.join_code_btn.Name = "join_code_btn";
            this.join_code_btn.Size = new System.Drawing.Size(236, 310);
            this.join_code_btn.TabIndex = 18;
            this.join_code_btn.Text = "Join room by code";
            this.join_code_btn.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.join_code_btn.TextColor = System.Drawing.Color.Black;
            this.join_code_btn.UseVisualStyleBackColor = false;
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.Transparent;
            this.back_btn.BackgroundColor = System.Drawing.Color.Transparent;
            this.back_btn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.back_btn.BorderRadius = 40;
            this.back_btn.BorderSize = 0;
            this.back_btn.FlatAppearance.BorderSize = 0;
            this.back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_btn.Font = new System.Drawing.Font("Segoe UI Emoji", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.back_btn.ForeColor = System.Drawing.Color.Black;
            this.back_btn.Image = ((System.Drawing.Image)(resources.GetObject("back_btn.Image")));
            this.back_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.back_btn.Location = new System.Drawing.Point(12, 12);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(145, 50);
            this.back_btn.TabIndex = 24;
            this.back_btn.Text = "Back";
            this.back_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.back_btn.TextColor = System.Drawing.Color.Black;
            this.back_btn.UseVisualStyleBackColor = false;
            // 
            // Menu_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.join_code_btn);
            this.Controls.Add(this.join_rand_btn);
            this.Controls.Add(this.create_btn);
            this.Controls.Add(this.choice_panel);
            this.Controls.Add(this.player_name);
            this.Controls.Add(this.title);
            this.Name = "Menu_Form";
            this.Text = "Menu";
            this.choice_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label title;
        private Label player_name;
        private RPanel choice_panel;
        private Label choice_label;
        private RJButton create_btn;
        private RJButton join_rand_btn;
        private RJButton join_code_btn;
        private RJButton back_btn;
    }
}