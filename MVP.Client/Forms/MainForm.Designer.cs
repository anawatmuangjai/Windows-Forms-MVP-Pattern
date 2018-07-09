namespace MVP.Client.Forms
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ProductMenuButton = new System.Windows.Forms.Button();
            this.LoginMenuButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(200, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(569, 501);
            this.MainPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.LoginMenuButton);
            this.panel1.Controls.Add(this.ProductMenuButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 501);
            this.panel1.TabIndex = 1;
            // 
            // ProductMenuButton
            // 
            this.ProductMenuButton.Location = new System.Drawing.Point(28, 76);
            this.ProductMenuButton.Name = "ProductMenuButton";
            this.ProductMenuButton.Size = new System.Drawing.Size(144, 32);
            this.ProductMenuButton.TabIndex = 0;
            this.ProductMenuButton.Text = "Product";
            this.ProductMenuButton.UseVisualStyleBackColor = true;
            this.ProductMenuButton.Click += new System.EventHandler(this.ProductMenuButton_Click);
            // 
            // LoginMenuButton
            // 
            this.LoginMenuButton.Location = new System.Drawing.Point(28, 26);
            this.LoginMenuButton.Name = "LoginMenuButton";
            this.LoginMenuButton.Size = new System.Drawing.Size(144, 32);
            this.LoginMenuButton.TabIndex = 1;
            this.LoginMenuButton.Text = "Login";
            this.LoginMenuButton.UseVisualStyleBackColor = true;
            this.LoginMenuButton.Click += new System.EventHandler(this.LoginMenuButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 501);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ProductMenuButton;
        private System.Windows.Forms.Button LoginMenuButton;
    }
}