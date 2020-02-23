namespace Kraken_Bot
{
    partial class EmailTest
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bodytexttext = new System.Windows.Forms.RichTextBox();
            this.phpscripttext = new System.Windows.Forms.TextBox();
            this.delaytext = new System.Windows.Forms.TextBox();
            this.counttext = new System.Windows.Forms.TextBox();
            this.sendtotext = new System.Windows.Forms.TextBox();
            this.profilestext = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(503, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "start email tasks";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 41);
            this.button2.TabIndex = 1;
            this.button2.Text = "send test webhook";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bodytexttext
            // 
            this.bodytexttext.Location = new System.Drawing.Point(503, 163);
            this.bodytexttext.Name = "bodytexttext";
            this.bodytexttext.Size = new System.Drawing.Size(223, 85);
            this.bodytexttext.TabIndex = 2;
            this.bodytexttext.Text = "";
            // 
            // phpscripttext
            // 
            this.phpscripttext.Location = new System.Drawing.Point(503, 59);
            this.phpscripttext.Name = "phpscripttext";
            this.phpscripttext.Size = new System.Drawing.Size(223, 20);
            this.phpscripttext.TabIndex = 3;
            this.phpscripttext.TextChanged += new System.EventHandler(this.phpscript_TextChanged);
            // 
            // delaytext
            // 
            this.delaytext.Location = new System.Drawing.Point(503, 85);
            this.delaytext.Name = "delaytext";
            this.delaytext.Size = new System.Drawing.Size(223, 20);
            this.delaytext.TabIndex = 4;
            // 
            // counttext
            // 
            this.counttext.Location = new System.Drawing.Point(503, 111);
            this.counttext.Name = "counttext";
            this.counttext.Size = new System.Drawing.Size(223, 20);
            this.counttext.TabIndex = 5;
            // 
            // sendtotext
            // 
            this.sendtotext.Location = new System.Drawing.Point(503, 137);
            this.sendtotext.Name = "sendtotext";
            this.sendtotext.Size = new System.Drawing.Size(223, 20);
            this.sendtotext.TabIndex = 6;
            // 
            // profilestext
            // 
            this.profilestext.Location = new System.Drawing.Point(503, 254);
            this.profilestext.Name = "profilestext";
            this.profilestext.Size = new System.Drawing.Size(223, 85);
            this.profilestext.TabIndex = 7;
            this.profilestext.Text = "";
            // 
            // EmailTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.profilestext);
            this.Controls.Add(this.sendtotext);
            this.Controls.Add(this.counttext);
            this.Controls.Add(this.delaytext);
            this.Controls.Add(this.phpscripttext);
            this.Controls.Add(this.bodytexttext);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "EmailTest";
            this.Text = "EmailTest";
            this.Load += new System.EventHandler(this.EmailTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox bodytexttext;
        private System.Windows.Forms.TextBox phpscripttext;
        private System.Windows.Forms.TextBox delaytext;
        private System.Windows.Forms.TextBox counttext;
        private System.Windows.Forms.TextBox sendtotext;
        private System.Windows.Forms.RichTextBox profilestext;
    }
}