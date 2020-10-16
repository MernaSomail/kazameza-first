namespace kazameza
{
    partial class Mainform
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.sideNav1 = new DevComponents.DotNetBar.Controls.SideNav();
            this.sideNavItem1 = new DevComponents.DotNetBar.Controls.SideNavItem();
            this.separator1 = new DevComponents.DotNetBar.Separator();
            this.sideNavItem2 = new DevComponents.DotNetBar.Controls.SideNavItem();
            this.sideNavPanel1 = new DevComponents.DotNetBar.Controls.SideNavPanel();
            this.Button_products = new DevComponents.DotNetBar.Controls.SideNavItem();
            this.Button_setting = new DevComponents.DotNetBar.Controls.SideNavItem();
            this.button_automation = new DevComponents.DotNetBar.Controls.SideNavItem();
            this.Button_Reports = new DevComponents.DotNetBar.Controls.SideNavItem();
            this.button_Getproducts = new DevComponents.DotNetBar.Controls.SideNavItem();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Ean = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.products = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lasttry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sideNav1.SuspendLayout();
            this.sideNavPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007VistaGlass;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // sideNav1
            // 
            this.sideNav1.Controls.Add(this.sideNavPanel1);
            this.sideNav1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideNav1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.sideNavItem1,
            this.separator1,
            this.sideNavItem2,
            this.Button_products,
            this.Button_setting,
            this.button_automation,
            this.Button_Reports,
            this.button_Getproducts});
            this.sideNav1.Location = new System.Drawing.Point(0, 0);
            this.sideNav1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sideNav1.Name = "sideNav1";
            this.sideNav1.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.sideNav1.Size = new System.Drawing.Size(955, 634);
            this.sideNav1.TabIndex = 0;
            this.sideNav1.Text = "Souq Automation Software";
            // 
            // sideNavItem1
            // 
            this.sideNavItem1.IsSystemMenu = true;
            this.sideNavItem1.Name = "sideNavItem1";
            this.sideNavItem1.Symbol = "";
            this.sideNavItem1.Text = "Menu";
            // 
            // separator1
            // 
            this.separator1.FixedSize = new System.Drawing.Size(3, 1);
            this.separator1.Name = "separator1";
            this.separator1.Padding.Bottom = 2;
            this.separator1.Padding.Left = 6;
            this.separator1.Padding.Right = 6;
            this.separator1.Padding.Top = 2;
            this.separator1.SeparatorOrientation = DevComponents.DotNetBar.eDesignMarkerOrientation.Vertical;
            // 
            // sideNavItem2
            // 
            this.sideNavItem2.Checked = true;
            this.sideNavItem2.Name = "sideNavItem2";
            this.sideNavItem2.Panel = this.sideNavPanel1;
            this.sideNavItem2.Symbol = "";
            this.sideNavItem2.Text = "Home";
            // 
            // sideNavPanel1
            // 
            this.sideNavPanel1.Controls.Add(this.dataGridViewX1);
            this.sideNavPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideNavPanel1.Location = new System.Drawing.Point(174, 37);
            this.sideNavPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sideNavPanel1.Name = "sideNavPanel1";
            this.sideNavPanel1.Size = new System.Drawing.Size(775, 596);
            this.sideNavPanel1.TabIndex = 2;
            // 
            // Button_products
            // 
            this.Button_products.Name = "Button_products";
            this.Button_products.Symbol = "";
            this.Button_products.Text = "Products";
            // 
            // Button_setting
            // 
            this.Button_setting.Name = "Button_setting";
            this.Button_setting.Symbol = "";
            this.Button_setting.Text = "Setting";
            // 
            // button_automation
            // 
            this.button_automation.Name = "button_automation";
            this.button_automation.Symbol = "";
            this.button_automation.Text = "Update automation";
            // 
            // Button_Reports
            // 
            this.Button_Reports.Name = "Button_Reports";
            this.Button_Reports.Symbol = "";
            this.Button_Reports.Text = "Reports";
            // 
            // button_Getproducts
            // 
            this.button_Getproducts.Name = "button_Getproducts";
            this.button_Getproducts.Symbol = "";
            this.button_Getproducts.Text = "Get Products";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(827, 5);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(75, 26);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.buttonX1.TabIndex = 1;
            this.buttonX1.Text = "close";
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ean,
            this.products,
            this.price,
            this.lasttry});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.Size = new System.Drawing.Size(775, 596);
            this.dataGridViewX1.TabIndex = 0;
            // 
            // Ean
            // 
            this.Ean.HeaderText = "Ean";
            this.Ean.Name = "Ean";
            // 
            // products
            // 
            this.products.HeaderText = "Products";
            this.products.Name = "products";
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            // 
            // lasttry
            // 
            this.lasttry.HeaderText = "Last Try";
            this.lasttry.Name = "lasttry";
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 634);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.sideNav1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mainform";
            this.sideNav1.ResumeLayout(false);
            this.sideNav1.PerformLayout();
            this.sideNavPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.Controls.SideNav sideNav1;
        private DevComponents.DotNetBar.Controls.SideNavPanel sideNavPanel1;
        private DevComponents.DotNetBar.Controls.SideNavItem sideNavItem1;
        private DevComponents.DotNetBar.Separator separator1;
        private DevComponents.DotNetBar.Controls.SideNavItem sideNavItem2;
        private DevComponents.DotNetBar.Controls.SideNavItem Button_products;
        private DevComponents.DotNetBar.Controls.SideNavItem Button_setting;
        private DevComponents.DotNetBar.Controls.SideNavItem button_automation;
        private DevComponents.DotNetBar.Controls.SideNavItem Button_Reports;
        private DevComponents.DotNetBar.Controls.SideNavItem button_Getproducts;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ean;
        private System.Windows.Forms.DataGridViewTextBoxColumn products;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn lasttry;
    }
}