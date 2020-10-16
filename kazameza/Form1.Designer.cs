namespace kazameza
{
    partial class Form1
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
            this.msgerror = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.username_txt = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.password_txt = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.login_btn = new DevComponents.DotNetBar.ButtonX();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // msgerror
            // 
            // 
            // 
            // 
            this.msgerror.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.msgerror.Location = new System.Drawing.Point(668, 68);
            this.msgerror.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.msgerror.Name = "msgerror";
            this.msgerror.Size = new System.Drawing.Size(277, 28);
            this.msgerror.TabIndex = 5;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(19, 49);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(100, 28);
            this.labelX1.TabIndex = 6;
            this.labelX1.Text = "UserName";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(19, 119);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(100, 28);
            this.labelX2.TabIndex = 7;
            this.labelX2.Text = "Password";
            // 
            // username_txt
            // 
            this.username_txt.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.username_txt.Border.Class = "TextBoxBorder";
            this.username_txt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.username_txt.DisabledBackColor = System.Drawing.Color.White;
            this.username_txt.ForeColor = System.Drawing.Color.Black;
            this.username_txt.Location = new System.Drawing.Point(153, 53);
            this.username_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.username_txt.Name = "username_txt";
            this.username_txt.PreventEnterBeep = true;
            this.username_txt.Size = new System.Drawing.Size(275, 23);
            this.username_txt.TabIndex = 8;
            // 
            // password_txt
            // 
            this.password_txt.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.password_txt.Border.Class = "TextBoxBorder";
            this.password_txt.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.password_txt.DisabledBackColor = System.Drawing.Color.White;
            this.password_txt.ForeColor = System.Drawing.Color.Black;
            this.password_txt.Location = new System.Drawing.Point(153, 108);
            this.password_txt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.password_txt.Name = "password_txt";
            this.password_txt.PreventEnterBeep = true;
            this.password_txt.Size = new System.Drawing.Size(275, 23);
            this.password_txt.TabIndex = 9;
            this.password_txt.UseSystemPasswordChar = true;
            // 
            // login_btn
            // 
            this.login_btn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.login_btn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.login_btn.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.login_btn.Location = new System.Drawing.Point(19, 176);
            this.login_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(193, 41);
            this.login_btn.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.login_btn.TabIndex = 10;
            this.login_btn.Text = "login";
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX1.Location = new System.Drawing.Point(235, 176);
            this.buttonX1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(193, 41);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 11;
            this.buttonX1.Text = "close";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 236);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.username_txt);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.msgerror);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Souq Automation";
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.LabelX msgerror;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX username_txt;
        private DevComponents.DotNetBar.Controls.TextBoxX password_txt;
        private DevComponents.DotNetBar.ButtonX login_btn;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.ButtonX buttonX1;
    }
}

