using System.Windows.Forms;

namespace minigames._SLIL
{
    partial class SLIL
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SLIL));
            this.top_panel = new System.Windows.Forms.Panel();
            this.game_over_text = new System.Windows.Forms.Label();
            this.shop_panel = new System.Windows.Forms.Panel();
            this.ShopInterface_panel = new System.Windows.Forms.Panel();
            this.shop_title_panel = new System.Windows.Forms.Panel();
            this.shop_title = new System.Windows.Forms.Label();
            this.shop_money = new System.Windows.Forms.Label();
            this.stamina_panel = new System.Windows.Forms.Panel();
            this.start_btn = new System.Windows.Forms.Button();
            this.raycast = new System.Windows.Forms.Timer(this.components);
            this.time_remein = new System.Windows.Forms.Timer(this.components);
            this.step_sound_timer = new System.Windows.Forms.Timer(this.components);
            this.map_timer = new System.Windows.Forms.Timer(this.components);
            this.question = new System.Windows.Forms.Button();
            this.by = new System.Windows.Forms.Label();
            this.developer_name = new System.Windows.Forms.Label();
            this.stamina_timer = new System.Windows.Forms.Timer(this.components);
            this.mouse_timer = new System.Windows.Forms.Timer(this.components);
            this.shot_timer = new System.Windows.Forms.Timer(this.components);
            this.reload_timer = new System.Windows.Forms.Timer(this.components);
            this.enemy_timer = new System.Windows.Forms.Timer(this.components);
            this.status_refresh = new System.Windows.Forms.Timer(this.components);
            this.show_settings = new System.Windows.Forms.PictureBox();
            this.chill_timer = new System.Windows.Forms.Timer(this.components);
            this.top_panel.SuspendLayout();
            this.shop_panel.SuspendLayout();
            this.shop_title_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.show_settings)).BeginInit();
            this.SuspendLayout();
            // 
            // top_panel
            // 
            this.top_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.top_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(50)))));
            this.top_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.top_panel.Controls.Add(this.game_over_text);
            this.top_panel.Controls.Add(this.shop_panel);
            this.top_panel.Controls.Add(this.stamina_panel);
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(679, 392);
            this.top_panel.TabIndex = 0;
            // 
            // game_over_text
            // 
            this.game_over_text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(50)))));
            this.game_over_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.game_over_text.Dock = System.Windows.Forms.DockStyle.Fill;
            this.game_over_text.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.game_over_text.ForeColor = System.Drawing.Color.White;
            this.game_over_text.Location = new System.Drawing.Point(0, 0);
            this.game_over_text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.game_over_text.Name = "game_over_text";
            this.game_over_text.Size = new System.Drawing.Size(675, 388);
            this.game_over_text.TabIndex = 2;
            this.game_over_text.Text = "GAME OVER";
            this.game_over_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.game_over_text.Visible = false;
            // 
            // shop_panel
            // 
            this.shop_panel.Controls.Add(this.ShopInterface_panel);
            this.shop_panel.Controls.Add(this.shop_title_panel);
            this.shop_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shop_panel.Location = new System.Drawing.Point(0, 0);
            this.shop_panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.shop_panel.Name = "shop_panel";
            this.shop_panel.Size = new System.Drawing.Size(675, 388);
            this.shop_panel.TabIndex = 4;
            this.shop_panel.Visible = false;
            this.shop_panel.VisibleChanged += new System.EventHandler(this.Shop_panel_VisibleChanged);
            // 
            // ShopInterface_panel
            // 
            this.ShopInterface_panel.AutoScroll = true;
            this.ShopInterface_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ShopInterface_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShopInterface_panel.Location = new System.Drawing.Point(0, 37);
            this.ShopInterface_panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ShopInterface_panel.Name = "ShopInterface_panel";
            this.ShopInterface_panel.Size = new System.Drawing.Size(675, 351);
            this.ShopInterface_panel.TabIndex = 1;
            // 
            // shop_title_panel
            // 
            this.shop_title_panel.Controls.Add(this.shop_title);
            this.shop_title_panel.Controls.Add(this.shop_money);
            this.shop_title_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.shop_title_panel.Location = new System.Drawing.Point(0, 0);
            this.shop_title_panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.shop_title_panel.Name = "shop_title_panel";
            this.shop_title_panel.Size = new System.Drawing.Size(675, 37);
            this.shop_title_panel.TabIndex = 2;
            // 
            // shop_title
            // 
            this.shop_title.AutoSize = true;
            this.shop_title.Dock = System.Windows.Forms.DockStyle.Left;
            this.shop_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.shop_title.ForeColor = System.Drawing.Color.White;
            this.shop_title.Location = new System.Drawing.Point(0, 0);
            this.shop_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.shop_title.Name = "shop_title";
            this.shop_title.Size = new System.Drawing.Size(153, 33);
            this.shop_title.TabIndex = 1;
            this.shop_title.Text = "МАГАЗИН";
            this.shop_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shop_money
            // 
            this.shop_money.AutoSize = true;
            this.shop_money.Dock = System.Windows.Forms.DockStyle.Right;
            this.shop_money.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.shop_money.ForeColor = System.Drawing.Color.White;
            this.shop_money.Location = new System.Drawing.Point(612, 0);
            this.shop_money.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.shop_money.Name = "shop_money";
            this.shop_money.Size = new System.Drawing.Size(63, 33);
            this.shop_money.TabIndex = 0;
            this.shop_money.Text = "$: 0";
            this.shop_money.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stamina_panel
            // 
            this.stamina_panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stamina_panel.BackColor = System.Drawing.Color.Lime;
            this.stamina_panel.Location = new System.Drawing.Point(0, 378);
            this.stamina_panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stamina_panel.Name = "stamina_panel";
            this.stamina_panel.Size = new System.Drawing.Size(554, 9);
            this.stamina_panel.TabIndex = 3;
            this.stamina_panel.Visible = false;
            // 
            // start_btn
            // 
            this.start_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.start_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.start_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.start_btn.Location = new System.Drawing.Point(120, 403);
            this.start_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(158, 62);
            this.start_btn.TabIndex = 36;
            this.start_btn.TabStop = false;
            this.start_btn.Text = "СТАРТ";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.Start_btn_Click);
            // 
            // raycast
            // 
            this.raycast.Interval = 1;
            this.raycast.Tick += new System.EventHandler(this.Raycast_Tick);
            // 
            // time_remein
            // 
            this.time_remein.Interval = 1000;
            this.time_remein.Tick += new System.EventHandler(this.Time_remein_Tick);
            // 
            // step_sound_timer
            // 
            this.step_sound_timer.Interval = 1;
            this.step_sound_timer.Tick += new System.EventHandler(this.Step_sound_timer_Tick);
            // 
            // map_timer
            // 
            this.map_timer.Interval = 1;
            this.map_timer.Tick += new System.EventHandler(this.Map_timer_Tick);
            // 
            // question
            // 
            this.question.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.question.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.question.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.question.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.question.Location = new System.Drawing.Point(60, 403);
            this.question.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(60, 62);
            this.question.TabIndex = 39;
            this.question.TabStop = false;
            this.question.Text = "?";
            this.question.UseVisualStyleBackColor = true;
            this.question.Click += new System.EventHandler(this.Question_Click);
            // 
            // by
            // 
            this.by.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.by.Cursor = System.Windows.Forms.Cursors.Default;
            this.by.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.by.Location = new System.Drawing.Point(514, 400);
            this.by.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.by.Name = "by";
            this.by.Size = new System.Drawing.Size(166, 32);
            this.by.TabIndex = 41;
            this.by.Text = "By.";
            this.by.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // developer_name
            // 
            this.developer_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.developer_name.AutoSize = true;
            this.developer_name.Cursor = System.Windows.Forms.Cursors.Help;
            this.developer_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.developer_name.Location = new System.Drawing.Point(477, 432);
            this.developer_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.developer_name.Name = "developer_name";
            this.developer_name.Size = new System.Drawing.Size(161, 29);
            this.developer_name.TabIndex = 40;
            this.developer_name.Text = "Lonewolf239";
            this.developer_name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.developer_name.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Developer_name_MouseClick);
            // 
            // stamina_timer
            // 
            this.stamina_timer.Interval = 10;
            this.stamina_timer.Tick += new System.EventHandler(this.Stamina_timer_Tick);
            // 
            // mouse_timer
            // 
            this.mouse_timer.Interval = 1;
            this.mouse_timer.Tick += new System.EventHandler(this.Mouse_timer_Tick);
            // 
            // shot_timer
            // 
            this.shot_timer.Interval = 200;
            this.shot_timer.Tick += new System.EventHandler(this.Shot_timer_Tick);
            // 
            // reload_timer
            // 
            this.reload_timer.Interval = 750;
            this.reload_timer.Tick += new System.EventHandler(this.Reload_gun_Tick);
            // 
            // enemy_timer
            // 
            this.enemy_timer.Interval = 500;
            this.enemy_timer.Tick += new System.EventHandler(this.Enemy_timer_Tick);
            // 
            // status_refresh
            // 
            this.status_refresh.Enabled = true;
            this.status_refresh.Interval = 1;
            this.status_refresh.Tick += new System.EventHandler(this.Status_refresh_Tick);
            // 
            // show_settings
            // 
            this.show_settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.show_settings.Image = global::minigames.Properties.Resources.setting_btn;
            this.show_settings.Location = new System.Drawing.Point(0, 403);
            this.show_settings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.show_settings.Name = "show_settings";
            this.show_settings.Size = new System.Drawing.Size(60, 62);
            this.show_settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.show_settings.TabIndex = 38;
            this.show_settings.TabStop = false;
            this.show_settings.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Show_settings_MouseClick);
            this.show_settings.MouseEnter += new System.EventHandler(this.Show_settings_MouseEnter);
            this.show_settings.MouseLeave += new System.EventHandler(this.Show_settings_MouseLeave);
            // 
            // chill_timer
            // 
            this.chill_timer.Interval = 150;
            this.chill_timer.Tick += new System.EventHandler(this.Chill_timer_Tick);
            // 
            // SLIL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 465);
            this.Controls.Add(this.by);
            this.Controls.Add(this.developer_name);
            this.Controls.Add(this.question);
            this.Controls.Add(this.show_settings);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.top_panel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SLIL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабезумие";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.SLIL_Activated);
            this.Deactivate += new System.EventHandler(this.SLIL_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SLIL_FormClosing);
            this.Load += new System.EventHandler(this.SLIL_Load);
            this.LocationChanged += new System.EventHandler(this.SLIL_LocationChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SLIL_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SLIL_KeyUp);
            this.top_panel.ResumeLayout(false);
            this.shop_panel.ResumeLayout(false);
            this.shop_title_panel.ResumeLayout(false);
            this.shop_title_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.show_settings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Timer raycast;
        private System.Windows.Forms.Timer time_remein;
        private System.Windows.Forms.Timer step_sound_timer;
        private System.Windows.Forms.Timer map_timer;
        private System.Windows.Forms.PictureBox show_settings;
        private System.Windows.Forms.Button question;
        private System.Windows.Forms.Label by;
        private System.Windows.Forms.Label developer_name;
        private System.Windows.Forms.Label game_over_text;
        private System.Windows.Forms.Timer stamina_timer;
        private System.Windows.Forms.Panel stamina_panel;
        private System.Windows.Forms.Timer mouse_timer;
        private System.Windows.Forms.Timer shot_timer;
        private System.Windows.Forms.Timer reload_timer;
        private System.Windows.Forms.Timer enemy_timer;
        private System.Windows.Forms.Timer status_refresh;
        private Panel shop_panel;
        private Label shop_money;
        private Panel ShopInterface_panel;
        private Panel shop_title_panel;
        private Label shop_title;
        private Timer chill_timer;
    }
}