namespace Demo_Project
{
    partial class Wild_Gameplay_Screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wild_Gameplay_Screen));
            this.question_panel = new Demo_Project.RPanel();
            this.question_label = new System.Windows.Forms.Label();
            this.game_name = new System.Windows.Forms.Label();
            this.time_label = new System.Windows.Forms.Label();
            this.rPanel1 = new Demo_Project.RPanel();
            this.ready_btn = new Demo_Project.RJButton();
            this.title = new System.Windows.Forms.Label();
            this.ans_box = new Demo_Project.RJTextBox();
            this.scoreboard_panel = new Demo_Project.RPanel();
            this.top_score_panel = new Demo_Project.RPanel();
            this.top1_score = new System.Windows.Forms.Label();
            this.top3_score = new System.Windows.Forms.Label();
            this.top2_score = new System.Windows.Forms.Label();
            this.top_player_panel = new Demo_Project.RPanel();
            this.top1 = new System.Windows.Forms.Label();
            this.top3 = new System.Windows.Forms.Label();
            this.top2 = new System.Windows.Forms.Label();
            this.scoreboard_label = new System.Windows.Forms.Label();
            this.salt_img = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.question_panel.SuspendLayout();
            this.rPanel1.SuspendLayout();
            this.scoreboard_panel.SuspendLayout();
            this.top_score_panel.SuspendLayout();
            this.top_player_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // question_panel
            // 
            this.question_panel.BackColor = System.Drawing.Color.Black;
            this.question_panel.BorderRadius = 20;
            this.question_panel.Controls.Add(this.question_label);
            this.question_panel.Location = new System.Drawing.Point(455, 125);
            this.question_panel.Name = "question_panel";
            this.question_panel.Size = new System.Drawing.Size(186, 234);
            this.question_panel.TabIndex = 41;
            // 
            // question_label
            // 
            this.question_label.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.question_label.ForeColor = System.Drawing.Color.White;
            this.question_label.Location = new System.Drawing.Point(0, 0);
            this.question_label.Name = "question_label";
            this.question_label.Size = new System.Drawing.Size(186, 234);
            this.question_label.TabIndex = 16;
            this.question_label.Text = "fill me with _______________________";
            // 
            // game_name
            // 
            this.game_name.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.game_name.Image = ((System.Drawing.Image)(resources.GetObject("game_name.Image")));
            this.game_name.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.game_name.Location = new System.Drawing.Point(12, 9);
            this.game_name.Name = "game_name";
            this.game_name.Size = new System.Drawing.Size(264, 112);
            this.game_name.TabIndex = 42;
            this.game_name.Text = "FilLmao";
            this.game_name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // time_label
            // 
            this.time_label.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.time_label.Image = ((System.Drawing.Image)(resources.GetObject("time_label.Image")));
            this.time_label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.time_label.Location = new System.Drawing.Point(420, 9);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(301, 65);
            this.time_label.TabIndex = 43;
            this.time_label.Text = "5:00";
            this.time_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rPanel1
            // 
            this.rPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.rPanel1.BorderRadius = 30;
            this.rPanel1.Controls.Add(this.label1);
            this.rPanel1.Controls.Add(this.salt_img);
            this.rPanel1.Controls.Add(this.ans_box);
            this.rPanel1.Controls.Add(this.ready_btn);
            this.rPanel1.Controls.Add(this.title);
            this.rPanel1.Location = new System.Drawing.Point(115, 396);
            this.rPanel1.Name = "rPanel1";
            this.rPanel1.Size = new System.Drawing.Size(1004, 265);
            this.rPanel1.TabIndex = 44;
            // 
            // ready_btn
            // 
            this.ready_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(1)))), ((int)(((byte)(82)))));
            this.ready_btn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(1)))), ((int)(((byte)(82)))));
            this.ready_btn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ready_btn.BorderRadius = 40;
            this.ready_btn.BorderSize = 0;
            this.ready_btn.FlatAppearance.BorderSize = 0;
            this.ready_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ready_btn.Font = new System.Drawing.Font("Segoe UI Emoji", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ready_btn.ForeColor = System.Drawing.Color.White;
            this.ready_btn.Location = new System.Drawing.Point(776, 186);
            this.ready_btn.Name = "ready_btn";
            this.ready_btn.Size = new System.Drawing.Size(192, 66);
            this.ready_btn.TabIndex = 45;
            this.ready_btn.Text = "Submit";
            this.ready_btn.TextColor = System.Drawing.Color.White;
            this.ready_btn.UseVisualStyleBackColor = false;
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.title.Location = new System.Drawing.Point(0, -10);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(526, 94);
            this.title.TabIndex = 46;
            this.title.Text = "Write some lmao idea           :";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ans_box
            // 
            this.ans_box.BackColor = System.Drawing.SystemColors.Window;
            this.ans_box.BorderColor = System.Drawing.SystemColors.Highlight;
            this.ans_box.BorderFocusColor = System.Drawing.Color.HotPink;
            this.ans_box.BorderRadius = 0;
            this.ans_box.BorderSize = 2;
            this.ans_box.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ans_box.Location = new System.Drawing.Point(97, 107);
            this.ans_box.Margin = new System.Windows.Forms.Padding(4);
            this.ans_box.Multiline = false;
            this.ans_box.Name = "ans_box";
            this.ans_box.Padding = new System.Windows.Forms.Padding(7);
            this.ans_box.PasswordChar = false;
            this.ans_box.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.ans_box.PlaceholderText = "";
            this.ans_box.Size = new System.Drawing.Size(859, 61);
            this.ans_box.TabIndex = 47;
            this.ans_box.Texts = "";
            this.ans_box.UnderlinedStyle = true;
            // 
            // scoreboard_panel
            // 
            this.scoreboard_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.scoreboard_panel.BorderRadius = 20;
            this.scoreboard_panel.Controls.Add(this.top_score_panel);
            this.scoreboard_panel.Controls.Add(this.top_player_panel);
            this.scoreboard_panel.Controls.Add(this.scoreboard_label);
            this.scoreboard_panel.Location = new System.Drawing.Point(782, 78);
            this.scoreboard_panel.Name = "scoreboard_panel";
            this.scoreboard_panel.Size = new System.Drawing.Size(468, 296);
            this.scoreboard_panel.TabIndex = 45;
            // 
            // top_score_panel
            // 
            this.top_score_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(1)))), ((int)(((byte)(82)))));
            this.top_score_panel.BorderRadius = 10;
            this.top_score_panel.Controls.Add(this.top1_score);
            this.top_score_panel.Controls.Add(this.top3_score);
            this.top_score_panel.Controls.Add(this.top2_score);
            this.top_score_panel.Location = new System.Drawing.Point(327, 77);
            this.top_score_panel.Name = "top_score_panel";
            this.top_score_panel.Size = new System.Drawing.Size(123, 200);
            this.top_score_panel.TabIndex = 47;
            // 
            // top1_score
            // 
            this.top1_score.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.top1_score.ForeColor = System.Drawing.SystemColors.Window;
            this.top1_score.Location = new System.Drawing.Point(28, 24);
            this.top1_score.Name = "top1_score";
            this.top1_score.Size = new System.Drawing.Size(60, 38);
            this.top1_score.TabIndex = 43;
            this.top1_score.Text = "1st";
            this.top1_score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // top3_score
            // 
            this.top3_score.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.top3_score.ForeColor = System.Drawing.SystemColors.Window;
            this.top3_score.Location = new System.Drawing.Point(28, 137);
            this.top3_score.Name = "top3_score";
            this.top3_score.Size = new System.Drawing.Size(60, 51);
            this.top3_score.TabIndex = 45;
            this.top3_score.Text = "3rd. Player3";
            this.top3_score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // top2_score
            // 
            this.top2_score.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.top2_score.ForeColor = System.Drawing.SystemColors.Window;
            this.top2_score.Location = new System.Drawing.Point(28, 80);
            this.top2_score.Name = "top2_score";
            this.top2_score.Size = new System.Drawing.Size(67, 43);
            this.top2_score.TabIndex = 44;
            this.top2_score.Text = "2nd";
            this.top2_score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // top_player_panel
            // 
            this.top_player_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(1)))), ((int)(((byte)(82)))));
            this.top_player_panel.BorderRadius = 10;
            this.top_player_panel.Controls.Add(this.top1);
            this.top_player_panel.Controls.Add(this.top3);
            this.top_player_panel.Controls.Add(this.top2);
            this.top_player_panel.Location = new System.Drawing.Point(39, 77);
            this.top_player_panel.Name = "top_player_panel";
            this.top_player_panel.Size = new System.Drawing.Size(250, 200);
            this.top_player_panel.TabIndex = 46;
            // 
            // top1
            // 
            this.top1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.top1.ForeColor = System.Drawing.SystemColors.Window;
            this.top1.Location = new System.Drawing.Point(35, 24);
            this.top1.Name = "top1";
            this.top1.Size = new System.Drawing.Size(164, 38);
            this.top1.TabIndex = 43;
            this.top1.Text = "1st. Player1";
            this.top1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // top3
            // 
            this.top3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.top3.ForeColor = System.Drawing.SystemColors.Window;
            this.top3.Location = new System.Drawing.Point(35, 137);
            this.top3.Name = "top3";
            this.top3.Size = new System.Drawing.Size(164, 51);
            this.top3.TabIndex = 45;
            this.top3.Text = "3rd. Player3";
            this.top3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // top2
            // 
            this.top2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.top2.ForeColor = System.Drawing.SystemColors.Window;
            this.top2.Location = new System.Drawing.Point(35, 80);
            this.top2.Name = "top2";
            this.top2.Size = new System.Drawing.Size(171, 43);
            this.top2.TabIndex = 44;
            this.top2.Text = "2nd. Player2";
            this.top2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scoreboard_label
            // 
            this.scoreboard_label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreboard_label.Image = ((System.Drawing.Image)(resources.GetObject("scoreboard_label.Image")));
            this.scoreboard_label.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.scoreboard_label.Location = new System.Drawing.Point(39, 10);
            this.scoreboard_label.Name = "scoreboard_label";
            this.scoreboard_label.Size = new System.Drawing.Size(394, 64);
            this.scoreboard_label.TabIndex = 42;
            this.scoreboard_label.Text = "Leader Scoreboard ";
            this.scoreboard_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // salt_img
            // 
            this.salt_img.Image = ((System.Drawing.Image)(resources.GetObject("salt_img.Image")));
            this.salt_img.Location = new System.Drawing.Point(340, -10);
            this.salt_img.Name = "salt_img";
            this.salt_img.Size = new System.Drawing.Size(79, 94);
            this.salt_img.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(0, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 94);
            this.label1.TabIndex = 47;
            // 
            // Wild_Gameplay_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.scoreboard_panel);
            this.Controls.Add(this.time_label);
            this.Controls.Add(this.game_name);
            this.Controls.Add(this.question_panel);
            this.Controls.Add(this.rPanel1);
            this.Name = "Wild_Gameplay_Screen";
            this.Text = "Wild_Gameplay_Screen";
            this.Load += new System.EventHandler(this.Wild_Gameplay_Screen_Load);
            this.question_panel.ResumeLayout(false);
            this.rPanel1.ResumeLayout(false);
            this.scoreboard_panel.ResumeLayout(false);
            this.top_score_panel.ResumeLayout(false);
            this.top_player_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RPanel question_panel;
        private Label question_label;
        private Label game_name;
        private Label time_label;
        private RPanel rPanel1;
        private RJButton ready_btn;
        private Label title;
        private RJTextBox ans_box;
        private RPanel scoreboard_panel;
        private RPanel top_score_panel;
        private Label top1_score;
        private Label top3_score;
        private Label top2_score;
        private RPanel top_player_panel;
        private Label top1;
        private Label top3;
        private Label top2;
        private Label scoreboard_label;
        private Label label1;
        private Label salt_img;
    }
}