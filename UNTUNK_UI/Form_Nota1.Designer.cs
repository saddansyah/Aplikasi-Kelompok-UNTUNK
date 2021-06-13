namespace DashboardUNTUNK
{
    partial class Form_Nota1
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
            this.btnLogout = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btnReportForm = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btnKasirForm = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btnCartForm = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btnCategForm = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.btnInventForm = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.guna2GradientPanel3 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnLoad = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.fromDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.toDate = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2GradientPanel2.SuspendLayout();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.CheckedState.Parent = this.btnLogout;
            this.btnLogout.CustomImages.Parent = this.btnLogout;
            this.btnLogout.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btnLogout.FillColor2 = System.Drawing.Color.SkyBlue;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.HoverState.Parent = this.btnLogout;
            this.btnLogout.Image = global::DashboardUNTUNK.Properties.Resources.logout_rounded_up_58px;
            this.btnLogout.Location = new System.Drawing.Point(-2, 680);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ShadowDecoration.Parent = this.btnLogout;
            this.btnLogout.Size = new System.Drawing.Size(144, 132);
            this.btnLogout.TabIndex = 83;
            this.btnLogout.Text = "Logout";
            // 
            // btnReportForm
            // 
            this.btnReportForm.CheckedState.Parent = this.btnReportForm;
            this.btnReportForm.CustomImages.Parent = this.btnReportForm;
            this.btnReportForm.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btnReportForm.FillColor2 = System.Drawing.Color.SkyBlue;
            this.btnReportForm.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportForm.ForeColor = System.Drawing.Color.White;
            this.btnReportForm.HoverState.Parent = this.btnReportForm;
            this.btnReportForm.Image = global::DashboardUNTUNK.Properties.Resources.report_file_58px;
            this.btnReportForm.Location = new System.Drawing.Point(2, 565);
            this.btnReportForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReportForm.Name = "btnReportForm";
            this.btnReportForm.ShadowDecoration.Parent = this.btnReportForm;
            this.btnReportForm.Size = new System.Drawing.Size(142, 115);
            this.btnReportForm.TabIndex = 82;
            this.btnReportForm.Text = "Sales Report";
            // 
            // btnKasirForm
            // 
            this.btnKasirForm.CheckedState.Parent = this.btnKasirForm;
            this.btnKasirForm.CustomImages.Parent = this.btnKasirForm;
            this.btnKasirForm.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btnKasirForm.FillColor2 = System.Drawing.Color.SkyBlue;
            this.btnKasirForm.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKasirForm.ForeColor = System.Drawing.Color.White;
            this.btnKasirForm.HoverState.Parent = this.btnKasirForm;
            this.btnKasirForm.Image = global::DashboardUNTUNK.Properties.Resources.cash_register_50px;
            this.btnKasirForm.Location = new System.Drawing.Point(0, 108);
            this.btnKasirForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnKasirForm.Name = "btnKasirForm";
            this.btnKasirForm.ShadowDecoration.Parent = this.btnKasirForm;
            this.btnKasirForm.Size = new System.Drawing.Size(142, 109);
            this.btnKasirForm.TabIndex = 78;
            this.btnKasirForm.Text = "Kasir";
            this.btnKasirForm.Click += new System.EventHandler(this.btnKasirForm_Click);
            // 
            // btnCartForm
            // 
            this.btnCartForm.CheckedState.Parent = this.btnCartForm;
            this.btnCartForm.CustomImages.Parent = this.btnCartForm;
            this.btnCartForm.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btnCartForm.FillColor2 = System.Drawing.Color.SkyBlue;
            this.btnCartForm.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCartForm.ForeColor = System.Drawing.Color.White;
            this.btnCartForm.HoverState.Parent = this.btnCartForm;
            this.btnCartForm.Image = global::DashboardUNTUNK.Properties.Resources.shopping_cart_48px1;
            this.btnCartForm.Location = new System.Drawing.Point(0, 218);
            this.btnCartForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCartForm.Name = "btnCartForm";
            this.btnCartForm.ShadowDecoration.Parent = this.btnCartForm;
            this.btnCartForm.Size = new System.Drawing.Size(142, 115);
            this.btnCartForm.TabIndex = 79;
            this.btnCartForm.Text = "Keranjang";
            // 
            // btnCategForm
            // 
            this.btnCategForm.CheckedState.Parent = this.btnCategForm;
            this.btnCategForm.CustomImages.Parent = this.btnCategForm;
            this.btnCategForm.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btnCategForm.FillColor2 = System.Drawing.Color.SkyBlue;
            this.btnCategForm.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategForm.ForeColor = System.Drawing.Color.White;
            this.btnCategForm.HoverState.Parent = this.btnCategForm;
            this.btnCategForm.Image = global::DashboardUNTUNK.Properties.Resources.list_58px;
            this.btnCategForm.Location = new System.Drawing.Point(0, 334);
            this.btnCategForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCategForm.Name = "btnCategForm";
            this.btnCategForm.ShadowDecoration.Parent = this.btnCategForm;
            this.btnCategForm.Size = new System.Drawing.Size(142, 122);
            this.btnCategForm.TabIndex = 81;
            this.btnCategForm.Text = "Category";
            // 
            // btnInventForm
            // 
            this.btnInventForm.CheckedState.Parent = this.btnInventForm;
            this.btnInventForm.CustomImages.Parent = this.btnInventForm;
            this.btnInventForm.FillColor = System.Drawing.Color.LightSkyBlue;
            this.btnInventForm.FillColor2 = System.Drawing.Color.SkyBlue;
            this.btnInventForm.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventForm.ForeColor = System.Drawing.Color.White;
            this.btnInventForm.HoverState.Parent = this.btnInventForm;
            this.btnInventForm.Image = global::DashboardUNTUNK.Properties.Resources.trolley_50px;
            this.btnInventForm.Location = new System.Drawing.Point(0, 449);
            this.btnInventForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnInventForm.Name = "btnInventForm";
            this.btnInventForm.ShadowDecoration.Parent = this.btnInventForm;
            this.btnInventForm.Size = new System.Drawing.Size(142, 117);
            this.btnInventForm.TabIndex = 80;
            this.btnInventForm.Text = "Inventory";
            // 
            // guna2GradientPanel3
            // 
            this.guna2GradientPanel3.FillColor = System.Drawing.Color.SkyBlue;
            this.guna2GradientPanel3.FillColor2 = System.Drawing.Color.SteelBlue;
            this.guna2GradientPanel3.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2GradientPanel3.Location = new System.Drawing.Point(-3, 812);
            this.guna2GradientPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2GradientPanel3.Name = "guna2GradientPanel3";
            this.guna2GradientPanel3.ShadowDecoration.Parent = this.guna2GradientPanel3;
            this.guna2GradientPanel3.Size = new System.Drawing.Size(1006, 38);
            this.guna2GradientPanel3.TabIndex = 84;
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.Controls.Add(this.label4);
            this.guna2GradientPanel2.FillColor = System.Drawing.Color.LightSkyBlue;
            this.guna2GradientPanel2.FillColor2 = System.Drawing.Color.SteelBlue;
            this.guna2GradientPanel2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2GradientPanel2.Location = new System.Drawing.Point(141, 108);
            this.guna2GradientPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.ShadowDecoration.Parent = this.guna2GradientPanel2;
            this.guna2GradientPanel2.Size = new System.Drawing.Size(862, 38);
            this.guna2GradientPanel2.TabIndex = 77;
            // 
            // btnLoad
            // 
            this.btnLoad.CheckedState.Parent = this.btnLoad;
            this.btnLoad.CustomImages.Parent = this.btnLoad;
            this.btnLoad.FillColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLoad.FillColor2 = System.Drawing.Color.DodgerBlue;
            this.btnLoad.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.HoverState.Parent = this.btnLoad;
            this.btnLoad.Location = new System.Drawing.Point(800, 183);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.ShadowDecoration.Parent = this.btnLoad;
            this.btnLoad.Size = new System.Drawing.Size(168, 35);
            this.btnLoad.TabIndex = 85;
            this.btnLoad.Text = "Load";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // fromDate
            // 
            this.fromDate.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fromDate.Location = new System.Drawing.Point(250, 189);
            this.fromDate.Name = "fromDate";
            this.fromDate.Size = new System.Drawing.Size(134, 28);
            this.fromDate.TabIndex = 86;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(502, 189);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(116, 26);
            this.dateTimePicker2.TabIndex = 87;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 88;
            this.label1.Text = "From date:";
            // 
            // toDate
            // 
            this.toDate.AutoSize = true;
            this.toDate.Location = new System.Drawing.Point(430, 195);
            this.toDate.Name = "toDate";
            this.toDate.Size = new System.Drawing.Size(67, 20);
            this.toDate.TabIndex = 89;
            this.toDate.Text = "To date:";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(170, 245);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(797, 533);
            this.reportViewer1.TabIndex = 92;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.label6);
            this.guna2ShadowPanel1.Controls.Add(this.label5);
            this.guna2ShadowPanel1.Controls.Add(this.pictureBox1);
            this.guna2ShadowPanel1.Controls.Add(this.guna2TextBox1);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(141, 12);
            this.guna2ShadowPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.DodgerBlue;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(804, 86);
            this.guna2ShadowPanel1.TabIndex = 95;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic);
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(551, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 21);
            this.label6.TabIndex = 71;
            this.label6.Text = "Search for menu...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(15, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(262, 21);
            this.label5.TabIndex = 71;
            this.label5.Text = "Your Own Digitalized Warunk!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DashboardUNTUNK.Properties.Resources.search_grey;
            this.pictureBox1.Location = new System.Drawing.Point(482, 22);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Location = new System.Drawing.Point(538, 22);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(244, 51);
            this.guna2TextBox1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Akira Expanded", 20F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(0, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 42);
            this.label2.TabIndex = 75;
            this.label2.Text = "unK";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Akira Expanded", 20F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.label3.Location = new System.Drawing.Point(0, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 42);
            this.label3.TabIndex = 74;
            this.label3.Text = "unt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 22);
            this.label4.TabIndex = 96;
            this.label4.Text = "Sales Report";
            // 
            // Form_Nota1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 848);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.toDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.fromDate);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnReportForm);
            this.Controls.Add(this.btnKasirForm);
            this.Controls.Add(this.btnCartForm);
            this.Controls.Add(this.btnCategForm);
            this.Controls.Add(this.btnInventForm);
            this.Controls.Add(this.guna2GradientPanel3);
            this.Controls.Add(this.guna2GradientPanel2);
            this.Name = "Form_Nota1";
            this.Text = "Form_Nota1";
            this.Load += new System.EventHandler(this.Form_Nota1_Load);
            this.guna2GradientPanel2.ResumeLayout(false);
            this.guna2GradientPanel2.PerformLayout();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientTileButton btnLogout;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnReportForm;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnKasirForm;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnCartForm;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnCategForm;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnInventForm;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel3;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private Guna.UI2.WinForms.Guna2GradientTileButton btnLoad;
        private System.Windows.Forms.DateTimePicker fromDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label toDate;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}