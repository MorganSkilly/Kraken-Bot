namespace Kraken_Bot
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Title = new System.Windows.Forms.PictureBox();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.ServerStatusLabel = new System.Windows.Forms.Label();
            this.DomainStatusLabel = new System.Windows.Forms.Label();
            this.ServerStatus = new System.Windows.Forms.Label();
            this.DomainStatus = new System.Windows.Forms.Label();
            this.LicenseKeyLabel = new System.Windows.Forms.Label();
            this.LicenseKey = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.StopAllButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BotsLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EmailBotLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Title)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Title.Image = ((System.Drawing.Image)(resources.GetObject("Title.Image")));
            this.Title.Location = new System.Drawing.Point(490, 20);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(300, 40);
            this.Title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Title.TabIndex = 0;
            this.Title.TabStop = false;
            // 
            // VersionLabel
            // 
            this.VersionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VersionLabel.ForeColor = System.Drawing.Color.Gray;
            this.VersionLabel.Location = new System.Drawing.Point(0, 0);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(70, 20);
            this.VersionLabel.TabIndex = 1;
            this.VersionLabel.Text = "V - 0.1.0";
            // 
            // ServerStatusLabel
            // 
            this.ServerStatusLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ServerStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerStatusLabel.ForeColor = System.Drawing.Color.Gray;
            this.ServerStatusLabel.Location = new System.Drawing.Point(0, 20);
            this.ServerStatusLabel.Name = "ServerStatusLabel";
            this.ServerStatusLabel.Size = new System.Drawing.Size(120, 20);
            this.ServerStatusLabel.TabIndex = 2;
            this.ServerStatusLabel.Text = "Server Status:";
            this.ServerStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DomainStatusLabel
            // 
            this.DomainStatusLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DomainStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DomainStatusLabel.ForeColor = System.Drawing.Color.Gray;
            this.DomainStatusLabel.Location = new System.Drawing.Point(0, 40);
            this.DomainStatusLabel.Name = "DomainStatusLabel";
            this.DomainStatusLabel.Size = new System.Drawing.Size(120, 20);
            this.DomainStatusLabel.TabIndex = 3;
            this.DomainStatusLabel.Text = "Domain Status:";
            this.DomainStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ServerStatus
            // 
            this.ServerStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ServerStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ServerStatus.Location = new System.Drawing.Point(115, 20);
            this.ServerStatus.Name = "ServerStatus";
            this.ServerStatus.Size = new System.Drawing.Size(110, 20);
            this.ServerStatus.TabIndex = 4;
            this.ServerStatus.Text = "Connected";
            this.ServerStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DomainStatus
            // 
            this.DomainStatus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DomainStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DomainStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DomainStatus.Location = new System.Drawing.Point(115, 40);
            this.DomainStatus.Name = "DomainStatus";
            this.DomainStatus.Size = new System.Drawing.Size(110, 20);
            this.DomainStatus.TabIndex = 5;
            this.DomainStatus.Text = "Disconnected";
            this.DomainStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LicenseKeyLabel
            // 
            this.LicenseKeyLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LicenseKeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LicenseKeyLabel.ForeColor = System.Drawing.Color.Gray;
            this.LicenseKeyLabel.Location = new System.Drawing.Point(1000, 0);
            this.LicenseKeyLabel.Name = "LicenseKeyLabel";
            this.LicenseKeyLabel.Size = new System.Drawing.Size(100, 20);
            this.LicenseKeyLabel.TabIndex = 6;
            this.LicenseKeyLabel.Text = "License key:";
            this.LicenseKeyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LicenseKey
            // 
            this.LicenseKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LicenseKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LicenseKey.ForeColor = System.Drawing.Color.Gray;
            this.LicenseKey.Location = new System.Drawing.Point(1090, 0);
            this.LicenseKey.Name = "LicenseKey";
            this.LicenseKey.Size = new System.Drawing.Size(170, 20);
            this.LicenseKey.TabIndex = 7;
            this.LicenseKey.Text = "1234-1234-1234-1234";
            this.LicenseKey.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.ForeColor = System.Drawing.Color.Gray;
            this.UserNameLabel.Location = new System.Drawing.Point(1000, 20);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(50, 20);
            this.UserNameLabel.TabIndex = 8;
            this.UserNameLabel.Text = "User:";
            this.UserNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserName
            // 
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.ForeColor = System.Drawing.Color.Gray;
            this.UserName.Location = new System.Drawing.Point(1050, 20);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(202, 20);
            this.UserName.TabIndex = 9;
            this.UserName.Text = "UserName";
            this.UserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.84906F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.15094F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 312F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 247F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 150);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.2F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.8F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1090, 400);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // StopAllButton
            // 
            this.StopAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.StopAllButton.BackColor = System.Drawing.Color.Red;
            this.StopAllButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StopAllButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.StopAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StopAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopAllButton.Location = new System.Drawing.Point(1100, 620);
            this.StopAllButton.Name = "StopAllButton";
            this.StopAllButton.Size = new System.Drawing.Size(150, 50);
            this.StopAllButton.TabIndex = 11;
            this.StopAllButton.Text = "Stop All";
            this.StopAllButton.UseVisualStyleBackColor = false;
            this.StopAllButton.Click += new System.EventHandler(this.StopAllButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(5, 560);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox1.Size = new System.Drawing.Size(1090, 113);
            this.textBox1.TabIndex = 12;
            // 
            // SettingsButton
            // 
            this.SettingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingsButton.BackColor = System.Drawing.Color.Silver;
            this.SettingsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsButton.Location = new System.Drawing.Point(1100, 560);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(150, 50);
            this.SettingsButton.TabIndex = 13;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(485, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Bot Instances";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BotsLabel
            // 
            this.BotsLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BotsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotsLabel.ForeColor = System.Drawing.Color.White;
            this.BotsLabel.Location = new System.Drawing.Point(1120, 125);
            this.BotsLabel.Name = "BotsLabel";
            this.BotsLabel.Size = new System.Drawing.Size(130, 20);
            this.BotsLabel.TabIndex = 15;
            this.BotsLabel.Text = "Bots";
            this.BotsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.EmailBotLabel);
            this.panel1.Location = new System.Drawing.Point(1101, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 400);
            this.panel1.TabIndex = 16;
            // 
            // EmailBotLabel
            // 
            this.EmailBotLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.EmailBotLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailBotLabel.ForeColor = System.Drawing.Color.White;
            this.EmailBotLabel.Location = new System.Drawing.Point(0, 10);
            this.EmailBotLabel.Name = "EmailBotLabel";
            this.EmailBotLabel.Size = new System.Drawing.Size(150, 20);
            this.EmailBotLabel.TabIndex = 17;
            this.EmailBotLabel.Text = "Email Bot";
            this.EmailBotLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Monitor Bot";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(0, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "JD Bot";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BotsLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SettingsButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.StopAllButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.LicenseKey);
            this.Controls.Add(this.LicenseKeyLabel);
            this.Controls.Add(this.DomainStatus);
            this.Controls.Add(this.ServerStatus);
            this.Controls.Add(this.DomainStatusLabel);
            this.Controls.Add(this.ServerStatusLabel);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kraken Bot - BETA";
            ((System.ComponentModel.ISupportInitialize)(this.Title)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Title;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Label ServerStatusLabel;
        private System.Windows.Forms.Label DomainStatusLabel;
        private System.Windows.Forms.Label ServerStatus;
        private System.Windows.Forms.Label DomainStatus;
        private System.Windows.Forms.Label LicenseKeyLabel;
        private System.Windows.Forms.Label LicenseKey;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button StopAllButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label BotsLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label EmailBotLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

