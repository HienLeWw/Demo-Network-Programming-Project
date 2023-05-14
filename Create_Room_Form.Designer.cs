namespace Demo_Project
{
    partial class Create_Room_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Create_Room_Form));
            this.title = new System.Windows.Forms.Label();
            this.rPanel1 = new Demo_Project.RPanel();
            this.img2 = new System.Windows.Forms.Label();
            this.img3 = new System.Windows.Forms.Label();
            this.img1 = new System.Windows.Forms.Label();
            this.title_label = new System.Windows.Forms.Label();
            this.num_player_panel = new Demo_Project.RPanel();
            this.decrease_player_btn = new System.Windows.Forms.Button();
            this.increase_player_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.num_player_label = new System.Windows.Forms.Label();
            this.round_time_panel = new Demo_Project.RPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.decrease_time_btn = new System.Windows.Forms.Button();
            this.increase_time_btn = new System.Windows.Forms.Button();
            this.round_time_label = new System.Windows.Forms.Label();
            this.num_round_panel = new Demo_Project.RPanel();
            this.decrease_round_btn = new System.Windows.Forms.Button();
            this.num_round_label = new System.Windows.Forms.Label();
            this.increase_round_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.create_room_btn = new Demo_Project.RJButton();
            this.wild_mode_btn = new Demo_Project.RJButton();
            this.standard_mode_btn = new Demo_Project.RJButton();
            this.back_btn = new Demo_Project.RJButton();
            this.rPanel1.SuspendLayout();
            this.num_player_panel.SuspendLayout();
            this.round_time_panel.SuspendLayout();
            this.num_round_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.Image = ((System.Drawing.Image)(resources.GetObject("title.Image")));
            this.title.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.title.Location = new System.Drawing.Point(467, 24);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(339, 121);
            this.title.TabIndex = 3;
            this.title.Text = "FilLmao";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rPanel1
            // 
            this.rPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.rPanel1.BorderRadius = 30;
            this.rPanel1.Controls.Add(this.img2);
            this.rPanel1.Controls.Add(this.img3);
            this.rPanel1.Controls.Add(this.img1);
            this.rPanel1.Controls.Add(this.title_label);
            this.rPanel1.Location = new System.Drawing.Point(376, 161);
            this.rPanel1.Name = "rPanel1";
            this.rPanel1.Size = new System.Drawing.Size(517, 98);
            this.rPanel1.TabIndex = 21;
            // 
            // img2
            // 
            this.img2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.img2.Image = ((System.Drawing.Image)(resources.GetObject("img2.Image")));
            this.img2.Location = new System.Drawing.Point(398, 17);
            this.img2.Name = "img2";
            this.img2.Size = new System.Drawing.Size(51, 73);
            this.img2.TabIndex = 19;
            // 
            // img3
            // 
            this.img3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.img3.Image = ((System.Drawing.Image)(resources.GetObject("img3.Image")));
            this.img3.Location = new System.Drawing.Point(442, 22);
            this.img3.Name = "img3";
            this.img3.Size = new System.Drawing.Size(53, 68);
            this.img3.TabIndex = 20;
            // 
            // img1
            // 
            this.img1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.img1.Image = ((System.Drawing.Image)(resources.GetObject("img1.Image")));
            this.img1.Location = new System.Drawing.Point(344, 17);
            this.img1.Name = "img1";
            this.img1.Size = new System.Drawing.Size(62, 73);
            this.img1.TabIndex = 18;
            // 
            // title_label
            // 
            this.title_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.title_label.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title_label.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.title_label.Location = new System.Drawing.Point(12, 4);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(492, 91);
            this.title_label.TabIndex = 17;
            this.title_label.Text = "Create A New Room";
            this.title_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // num_player_panel
            // 
            this.num_player_panel.BackColor = System.Drawing.Color.White;
            this.num_player_panel.BorderRadius = 20;
            this.num_player_panel.Controls.Add(this.decrease_player_btn);
            this.num_player_panel.Controls.Add(this.increase_player_btn);
            this.num_player_panel.Controls.Add(this.label4);
            this.num_player_panel.Controls.Add(this.num_player_label);
            this.num_player_panel.Location = new System.Drawing.Point(239, 278);
            this.num_player_panel.Name = "num_player_panel";
            this.num_player_panel.Size = new System.Drawing.Size(379, 65);
            this.num_player_panel.TabIndex = 22;
            // 
            // decrease_player_btn
            // 
            this.decrease_player_btn.BackColor = System.Drawing.Color.White;
            this.decrease_player_btn.FlatAppearance.BorderSize = 0;
            this.decrease_player_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decrease_player_btn.Image = ((System.Drawing.Image)(resources.GetObject("decrease_player_btn.Image")));
            this.decrease_player_btn.Location = new System.Drawing.Point(303, 20);
            this.decrease_player_btn.Name = "decrease_player_btn";
            this.decrease_player_btn.Size = new System.Drawing.Size(36, 35);
            this.decrease_player_btn.TabIndex = 24;
            this.decrease_player_btn.UseVisualStyleBackColor = false;
            // 
            // increase_player_btn
            // 
            this.increase_player_btn.BackColor = System.Drawing.Color.White;
            this.increase_player_btn.FlatAppearance.BorderSize = 0;
            this.increase_player_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.increase_player_btn.Image = ((System.Drawing.Image)(resources.GetObject("increase_player_btn.Image")));
            this.increase_player_btn.Location = new System.Drawing.Point(335, 20);
            this.increase_player_btn.Name = "increase_player_btn";
            this.increase_player_btn.Size = new System.Drawing.Size(36, 35);
            this.increase_player_btn.TabIndex = 22;
            this.increase_player_btn.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(8, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 45);
            this.label4.TabIndex = 23;
            // 
            // num_player_label
            // 
            this.num_player_label.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num_player_label.Location = new System.Drawing.Point(60, 14);
            this.num_player_label.Name = "num_player_label";
            this.num_player_label.Size = new System.Drawing.Size(237, 38);
            this.num_player_label.TabIndex = 25;
            this.num_player_label.Text = "Number of players: ";
            this.num_player_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // round_time_panel
            // 
            this.round_time_panel.BackColor = System.Drawing.Color.White;
            this.round_time_panel.BorderRadius = 20;
            this.round_time_panel.Controls.Add(this.label1);
            this.round_time_panel.Controls.Add(this.decrease_time_btn);
            this.round_time_panel.Controls.Add(this.increase_time_btn);
            this.round_time_panel.Controls.Add(this.round_time_label);
            this.round_time_panel.Location = new System.Drawing.Point(671, 278);
            this.round_time_panel.Name = "round_time_panel";
            this.round_time_panel.Size = new System.Drawing.Size(379, 65);
            this.round_time_panel.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 45);
            this.label1.TabIndex = 23;
            // 
            // decrease_time_btn
            // 
            this.decrease_time_btn.BackColor = System.Drawing.Color.White;
            this.decrease_time_btn.FlatAppearance.BorderSize = 0;
            this.decrease_time_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decrease_time_btn.Image = ((System.Drawing.Image)(resources.GetObject("decrease_time_btn.Image")));
            this.decrease_time_btn.Location = new System.Drawing.Point(296, 20);
            this.decrease_time_btn.Name = "decrease_time_btn";
            this.decrease_time_btn.Size = new System.Drawing.Size(36, 35);
            this.decrease_time_btn.TabIndex = 25;
            this.decrease_time_btn.UseVisualStyleBackColor = false;
            // 
            // increase_time_btn
            // 
            this.increase_time_btn.BackColor = System.Drawing.Color.White;
            this.increase_time_btn.FlatAppearance.BorderSize = 0;
            this.increase_time_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.increase_time_btn.Image = ((System.Drawing.Image)(resources.GetObject("increase_time_btn.Image")));
            this.increase_time_btn.Location = new System.Drawing.Point(328, 20);
            this.increase_time_btn.Name = "increase_time_btn";
            this.increase_time_btn.Size = new System.Drawing.Size(36, 35);
            this.increase_time_btn.TabIndex = 24;
            this.increase_time_btn.UseVisualStyleBackColor = false;
            // 
            // round_time_label
            // 
            this.round_time_label.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.round_time_label.Location = new System.Drawing.Point(66, 14);
            this.round_time_label.Name = "round_time_label";
            this.round_time_label.Size = new System.Drawing.Size(237, 38);
            this.round_time_label.TabIndex = 26;
            this.round_time_label.Text = "Round time: 1.00 m";
            this.round_time_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num_round_panel
            // 
            this.num_round_panel.BackColor = System.Drawing.SystemColors.Window;
            this.num_round_panel.BorderRadius = 20;
            this.num_round_panel.Controls.Add(this.decrease_round_btn);
            this.num_round_panel.Controls.Add(this.num_round_label);
            this.num_round_panel.Controls.Add(this.increase_round_btn);
            this.num_round_panel.Controls.Add(this.label2);
            this.num_round_panel.Location = new System.Drawing.Point(671, 376);
            this.num_round_panel.Name = "num_round_panel";
            this.num_round_panel.Size = new System.Drawing.Size(379, 65);
            this.num_round_panel.TabIndex = 24;
            // 
            // decrease_round_btn
            // 
            this.decrease_round_btn.BackColor = System.Drawing.Color.White;
            this.decrease_round_btn.FlatAppearance.BorderSize = 0;
            this.decrease_round_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decrease_round_btn.Image = ((System.Drawing.Image)(resources.GetObject("decrease_round_btn.Image")));
            this.decrease_round_btn.Location = new System.Drawing.Point(305, 19);
            this.decrease_round_btn.Name = "decrease_round_btn";
            this.decrease_round_btn.Size = new System.Drawing.Size(36, 35);
            this.decrease_round_btn.TabIndex = 27;
            this.decrease_round_btn.UseVisualStyleBackColor = false;
            // 
            // num_round_label
            // 
            this.num_round_label.BackColor = System.Drawing.Color.White;
            this.num_round_label.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.num_round_label.Location = new System.Drawing.Point(62, 10);
            this.num_round_label.Name = "num_round_label";
            this.num_round_label.Size = new System.Drawing.Size(224, 45);
            this.num_round_label.TabIndex = 25;
            this.num_round_label.Text = "Number of rounds:";
            this.num_round_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // increase_round_btn
            // 
            this.increase_round_btn.BackColor = System.Drawing.Color.White;
            this.increase_round_btn.FlatAppearance.BorderSize = 0;
            this.increase_round_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.increase_round_btn.Image = ((System.Drawing.Image)(resources.GetObject("increase_round_btn.Image")));
            this.increase_round_btn.Location = new System.Drawing.Point(337, 19);
            this.increase_round_btn.Name = "increase_round_btn";
            this.increase_round_btn.Size = new System.Drawing.Size(36, 35);
            this.increase_round_btn.TabIndex = 28;
            this.increase_round_btn.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(10, 4);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(65, 60);
            this.label2.TabIndex = 26;
            // 
            // create_room_btn
            // 
            this.create_room_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(1)))), ((int)(((byte)(82)))));
            this.create_room_btn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(1)))), ((int)(((byte)(82)))));
            this.create_room_btn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.create_room_btn.BorderRadius = 40;
            this.create_room_btn.BorderSize = 0;
            this.create_room_btn.FlatAppearance.BorderSize = 0;
            this.create_room_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create_room_btn.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.create_room_btn.ForeColor = System.Drawing.Color.White;
            this.create_room_btn.Location = new System.Drawing.Point(671, 475);
            this.create_room_btn.Name = "create_room_btn";
            this.create_room_btn.Size = new System.Drawing.Size(379, 78);
            this.create_room_btn.TabIndex = 25;
            this.create_room_btn.Text = "Create Room";
            this.create_room_btn.TextColor = System.Drawing.Color.White;
            this.create_room_btn.UseVisualStyleBackColor = false;
            // 
            // wild_mode_btn
            // 
            this.wild_mode_btn.BackColor = System.Drawing.SystemColors.Window;
            this.wild_mode_btn.BackgroundColor = System.Drawing.SystemColors.Window;
            this.wild_mode_btn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.wild_mode_btn.BorderRadius = 40;
            this.wild_mode_btn.BorderSize = 0;
            this.wild_mode_btn.FlatAppearance.BorderSize = 0;
            this.wild_mode_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wild_mode_btn.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.wild_mode_btn.ForeColor = System.Drawing.Color.Black;
            this.wild_mode_btn.Location = new System.Drawing.Point(456, 376);
            this.wild_mode_btn.Name = "wild_mode_btn";
            this.wild_mode_btn.Size = new System.Drawing.Size(162, 177);
            this.wild_mode_btn.TabIndex = 26;
            this.wild_mode_btn.Text = "Wild Mode";
            this.wild_mode_btn.TextColor = System.Drawing.Color.Black;
            this.wild_mode_btn.UseVisualStyleBackColor = false;
            // 
            // standard_mode_btn
            // 
            this.standard_mode_btn.BackColor = System.Drawing.SystemColors.Window;
            this.standard_mode_btn.BackgroundColor = System.Drawing.SystemColors.Window;
            this.standard_mode_btn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.standard_mode_btn.BorderRadius = 40;
            this.standard_mode_btn.BorderSize = 0;
            this.standard_mode_btn.FlatAppearance.BorderSize = 0;
            this.standard_mode_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.standard_mode_btn.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.standard_mode_btn.ForeColor = System.Drawing.Color.Black;
            this.standard_mode_btn.Location = new System.Drawing.Point(239, 376);
            this.standard_mode_btn.Name = "standard_mode_btn";
            this.standard_mode_btn.Size = new System.Drawing.Size(162, 177);
            this.standard_mode_btn.TabIndex = 27;
            this.standard_mode_btn.Text = "Standard Mode";
            this.standard_mode_btn.TextColor = System.Drawing.Color.Black;
            this.standard_mode_btn.UseVisualStyleBackColor = false;
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
            this.back_btn.TabIndex = 28;
            this.back_btn.Text = "Back";
            this.back_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.back_btn.TextColor = System.Drawing.Color.Black;
            this.back_btn.UseVisualStyleBackColor = false;
            // 
            // Create_Room_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.standard_mode_btn);
            this.Controls.Add(this.wild_mode_btn);
            this.Controls.Add(this.create_room_btn);
            this.Controls.Add(this.num_round_panel);
            this.Controls.Add(this.round_time_panel);
            this.Controls.Add(this.num_player_panel);
            this.Controls.Add(this.rPanel1);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Create_Room_Form";
            this.Text = "Create Room";
            this.rPanel1.ResumeLayout(false);
            this.num_player_panel.ResumeLayout(false);
            this.round_time_panel.ResumeLayout(false);
            this.num_round_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label title;
        private RPanel rPanel1;
        private Label img2;
        private Label img3;
        private Label img1;
        private Label title_label;
        private RPanel num_player_panel;
        private Button decrease_player_btn;
        private Button increase_player_btn;
        private Label label4;
        private Label num_player_label;
        private RPanel round_time_panel;
        private Label label1;
        private Button decrease_time_btn;
        private Button increase_time_btn;
        private Label round_time_label;
        private RPanel num_round_panel;
        private Button decrease_round_btn;
        private Label num_round_label;
        private Button increase_round_btn;
        private Label label2;
        private RJButton create_room_btn;
        private RJButton wild_mode_btn;
        private RJButton standard_mode_btn;
        private RJButton back_btn;
    }
}