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
            ((System.ComponentModel.ISupportInitialize)(this.Title)).BeginInit();
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
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.35883F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.64117F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(119, 235);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(719, 100);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
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
            this.ResumeLayout(false);

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
    }
}

