﻿namespace minigames
{
    partial class Downloading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Downloading));
            this.title = new System.Windows.Forms.Label();
            this.progress = new System.Windows.Forms.Label();
            this.download_progress_panel = new System.Windows.Forms.Panel();
            this.download_progress = new System.Windows.Forms.Panel();
            this.cancel = new System.Windows.Forms.Button();
            this.download_progress_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.Location = new System.Drawing.Point(8, 5);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(219, 24);
            this.title.TabIndex = 1;
            this.title.Text = "Загрузка обновления...";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progress
            // 
            this.progress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.progress.Location = new System.Drawing.Point(330, 5);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(92, 24);
            this.progress.TabIndex = 2;
            this.progress.Text = "0%";
            this.progress.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // download_progress_panel
            // 
            this.download_progress_panel.BackColor = System.Drawing.Color.Silver;
            this.download_progress_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.download_progress_panel.Controls.Add(this.download_progress);
            this.download_progress_panel.Location = new System.Drawing.Point(12, 32);
            this.download_progress_panel.Name = "download_progress_panel";
            this.download_progress_panel.Size = new System.Drawing.Size(403, 23);
            this.download_progress_panel.TabIndex = 3;
            // 
            // download_progress
            // 
            this.download_progress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.download_progress.Dock = System.Windows.Forms.DockStyle.Left;
            this.download_progress.Location = new System.Drawing.Point(0, 0);
            this.download_progress.Name = "download_progress";
            this.download_progress.Size = new System.Drawing.Size(0, 19);
            this.download_progress.TabIndex = 0;
            // 
            // cancel
            // 
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancel.Location = new System.Drawing.Point(325, 61);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(90, 35);
            this.cancel.TabIndex = 4;
            this.cancel.TabStop = false;
            this.cancel.Text = "Отмена";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Downloading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancel;
            this.ClientSize = new System.Drawing.Size(427, 101);
            this.ControlBox = false;
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.download_progress_panel);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.title);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Downloading";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Загрузка...";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Downloading_FormClosing);
            this.Load += new System.EventHandler(this.Downloading_Load);
            this.download_progress_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label progress;
        private System.Windows.Forms.Panel download_progress_panel;
        private System.Windows.Forms.Panel download_progress;
        private System.Windows.Forms.Button cancel;
    }
}