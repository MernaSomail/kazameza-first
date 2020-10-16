namespace kazameza
{
    partial class excelDownload
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
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.download = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007VistaGlass;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // download
            // 
            this.download.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.download.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.download.Location = new System.Drawing.Point(332, 128);
            this.download.Name = "download";
            this.download.Size = new System.Drawing.Size(158, 23);
            this.download.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.download.TabIndex = 0;
            this.download.Text = "download";
            this.download.Click += new System.EventHandler(this.download_Click);
            // 
            // excelDownload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.download);
            this.Name = "excelDownload";
            this.Text = "excelDownload";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.ButtonX download;
    }
}