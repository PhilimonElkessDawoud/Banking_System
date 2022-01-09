namespace ElMal_ElHaram_BankingSystem
{
    partial class Teller
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddClient = new System.Windows.Forms.Button();
            this.RemoveClient = new System.Windows.Forms.Button();
            this.CheckClient = new System.Windows.Forms.Button();
            this.Searchtext = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(285, 485);
            this.listBox1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CheckClient);
            this.panel1.Controls.Add(this.RemoveClient);
            this.panel1.Controls.Add(this.AddClient);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(285, 423);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 62);
            this.panel1.TabIndex = 1;
            // 
            // AddClient
            // 
            this.AddClient.Dock = System.Windows.Forms.DockStyle.Left;
            this.AddClient.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddClient.Location = new System.Drawing.Point(0, 0);
            this.AddClient.Name = "AddClient";
            this.AddClient.Size = new System.Drawing.Size(238, 62);
            this.AddClient.TabIndex = 0;
            this.AddClient.Text = "Add Client";
            this.AddClient.UseVisualStyleBackColor = true;
            // 
            // RemoveClient
            // 
            this.RemoveClient.Dock = System.Windows.Forms.DockStyle.Left;
            this.RemoveClient.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveClient.Location = new System.Drawing.Point(238, 0);
            this.RemoveClient.Name = "RemoveClient";
            this.RemoveClient.Size = new System.Drawing.Size(240, 62);
            this.RemoveClient.TabIndex = 1;
            this.RemoveClient.Text = "Remove Client";
            this.RemoveClient.UseVisualStyleBackColor = true;
            // 
            // CheckClient
            // 
            this.CheckClient.Dock = System.Windows.Forms.DockStyle.Right;
            this.CheckClient.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckClient.Location = new System.Drawing.Point(477, 0);
            this.CheckClient.Name = "CheckClient";
            this.CheckClient.Size = new System.Drawing.Size(231, 62);
            this.CheckClient.TabIndex = 2;
            this.CheckClient.Text = "CheckClient";
            this.CheckClient.UseVisualStyleBackColor = true;
            // 
            // Searchtext
            // 
            this.Searchtext.Location = new System.Drawing.Point(431, 16);
            this.Searchtext.Multiline = true;
            this.Searchtext.Name = "Searchtext";
            this.Searchtext.Size = new System.Drawing.Size(550, 31);
            this.Searchtext.TabIndex = 2;
            this.Searchtext.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(301, 16);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(109, 31);
            this.Search.TabIndex = 3;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            // 
            // Teller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 485);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Searchtext);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox1);
            this.Name = "Teller";
            this.Text = "Teller";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CheckClient;
        private System.Windows.Forms.Button RemoveClient;
        private System.Windows.Forms.Button AddClient;
        private System.Windows.Forms.TextBox Searchtext;
        private System.Windows.Forms.Button Search;
    }
}