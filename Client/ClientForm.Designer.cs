
namespace Client
{
    partial class clientForm
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Portenter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IPenter = new System.Windows.Forms.TextBox();
            this.connectServer = new System.Windows.Forms.Button();
            this.disconnectServer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.NamePlaceSearch = new System.Windows.Forms.TextBox();
            this.displayAll = new System.Windows.Forms.Button();
            this.searchData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(620, 39);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(121, 29);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.TabStop = false;
            this.checkBox1.Text = "Automatic";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(329, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Port";
            // 
            // Portenter
            // 
            this.Portenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Portenter.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Portenter.Location = new System.Drawing.Point(335, 39);
            this.Portenter.Margin = new System.Windows.Forms.Padding(4);
            this.Portenter.Name = "Portenter";
            this.Portenter.Size = new System.Drawing.Size(263, 29);
            this.Portenter.TabIndex = 9;
            this.Portenter.TabStop = false;
            this.Portenter.Text = "Enter port";
            this.Portenter.Click += new System.EventHandler(this.Portenter_Click);
            this.Portenter.Leave += new System.EventHandler(this.Portenter_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "IP";
            // 
            // IPenter
            // 
            this.IPenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPenter.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.IPenter.Location = new System.Drawing.Point(16, 39);
            this.IPenter.Margin = new System.Windows.Forms.Padding(4);
            this.IPenter.Name = "IPenter";
            this.IPenter.Size = new System.Drawing.Size(263, 29);
            this.IPenter.TabIndex = 7;
            this.IPenter.TabStop = false;
            this.IPenter.Text = "Enter IP";
            this.IPenter.Click += new System.EventHandler(this.IPenter_Click);
            this.IPenter.Leave += new System.EventHandler(this.IPenter_Leave);
            // 
            // connectServer
            // 
            this.connectServer.BackColor = System.Drawing.SystemColors.Highlight;
            this.connectServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectServer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.connectServer.Location = new System.Drawing.Point(13, 91);
            this.connectServer.Margin = new System.Windows.Forms.Padding(4);
            this.connectServer.Name = "connectServer";
            this.connectServer.Size = new System.Drawing.Size(157, 38);
            this.connectServer.TabIndex = 12;
            this.connectServer.TabStop = false;
            this.connectServer.Text = "Connect";
            this.connectServer.UseVisualStyleBackColor = false;
            this.connectServer.Click += new System.EventHandler(this.connectServer_Click);
            // 
            // disconnectServer
            // 
            this.disconnectServer.BackColor = System.Drawing.SystemColors.Highlight;
            this.disconnectServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disconnectServer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.disconnectServer.Location = new System.Drawing.Point(192, 91);
            this.disconnectServer.Margin = new System.Windows.Forms.Padding(4);
            this.disconnectServer.Name = "disconnectServer";
            this.disconnectServer.Size = new System.Drawing.Size(161, 38);
            this.disconnectServer.TabIndex = 13;
            this.disconnectServer.TabStop = false;
            this.disconnectServer.Text = "Pause";
            this.disconnectServer.UseVisualStyleBackColor = false;
            this.disconnectServer.Click += new System.EventHandler(this.disconnectServer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Request";
            // 
            // NamePlaceSearch
            // 
            this.NamePlaceSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamePlaceSearch.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.NamePlaceSearch.Location = new System.Drawing.Point(20, 162);
            this.NamePlaceSearch.Margin = new System.Windows.Forms.Padding(4);
            this.NamePlaceSearch.Name = "NamePlaceSearch";
            this.NamePlaceSearch.Size = new System.Drawing.Size(497, 29);
            this.NamePlaceSearch.TabIndex = 15;
            this.NamePlaceSearch.TabStop = false;
            this.NamePlaceSearch.Text = "Enter name of place";
            this.NamePlaceSearch.Click += new System.EventHandler(this.NamePlaceSearch_Click);
            this.NamePlaceSearch.Leave += new System.EventHandler(this.NamePlaceSearch_Leave);
            // 
            // displayAll
            // 
            this.displayAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayAll.Location = new System.Drawing.Point(20, 209);
            this.displayAll.Margin = new System.Windows.Forms.Padding(4);
            this.displayAll.Name = "displayAll";
            this.displayAll.Size = new System.Drawing.Size(244, 36);
            this.displayAll.TabIndex = 16;
            this.displayAll.TabStop = false;
            this.displayAll.Text = "Show All Inform";
            this.displayAll.UseVisualStyleBackColor = true;
            this.displayAll.Click += new System.EventHandler(this.displayAll_Click);
            // 
            // searchData
            // 
            this.searchData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchData.Location = new System.Drawing.Point(525, 159);
            this.searchData.Margin = new System.Windows.Forms.Padding(4);
            this.searchData.Name = "searchData";
            this.searchData.Size = new System.Drawing.Size(248, 39);
            this.searchData.TabIndex = 17;
            this.searchData.TabStop = false;
            this.searchData.Text = "Search";
            this.searchData.UseVisualStyleBackColor = true;
            this.searchData.Click += new System.EventHandler(this.search_Click);
            // 
            // clientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(991, 272);
            this.Controls.Add(this.searchData);
            this.Controls.Add(this.displayAll);
            this.Controls.Add(this.NamePlaceSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.disconnectServer);
            this.Controls.Add(this.connectServer);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Portenter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IPenter);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "clientForm";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Portenter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IPenter;
        private System.Windows.Forms.Button connectServer;
        private System.Windows.Forms.Button disconnectServer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NamePlaceSearch;
        private System.Windows.Forms.Button displayAll;
        private System.Windows.Forms.Button searchData;
    }
}

