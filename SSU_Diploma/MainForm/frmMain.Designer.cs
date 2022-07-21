
namespace SSU_Diploma.MainForm
{
    partial class frmMain
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.მთავარიToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsExit = new System.Windows.Forms.ToolStripMenuItem();
            this.მოდულებიToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsStudents = new System.Windows.Forms.ToolStripMenuItem();
            this.ფაკულტეტიToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.დახმარებაToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddUser = new System.Windows.Forms.ToolStripMenuItem();
            this.XtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.XtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tsUser});
            this.statusStrip1.Location = new System.Drawing.Point(0, 601);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(933, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(110, 17);
            this.toolStripStatusLabel1.Text = "მომხმარებელი:";
            // 
            // tsUser
            // 
            this.tsUser.Name = "tsUser";
            this.tsUser.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.მთავარიToolStripMenuItem,
            this.მოდულებიToolStripMenuItem,
            this.დახმარებაToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(933, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // მთავარიToolStripMenuItem
            // 
            this.მთავარიToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsExit});
            this.მთავარიToolStripMenuItem.Name = "მთავარიToolStripMenuItem";
            this.მთავარიToolStripMenuItem.Size = new System.Drawing.Size(73, 22);
            this.მთავარიToolStripMenuItem.Text = "მთავარი";
            // 
            // tsExit
            // 
            this.tsExit.Name = "tsExit";
            this.tsExit.Size = new System.Drawing.Size(121, 22);
            this.tsExit.Text = "გასვლა";
            this.tsExit.Click += new System.EventHandler(this.tsExit_Click);
            // 
            // მოდულებიToolStripMenuItem
            // 
            this.მოდულებიToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsStudents,
            this.ფაკულტეტიToolStripMenuItem});
            this.მოდულებიToolStripMenuItem.Name = "მოდულებიToolStripMenuItem";
            this.მოდულებიToolStripMenuItem.Size = new System.Drawing.Size(90, 22);
            this.მოდულებიToolStripMenuItem.Text = "მოდულები";
            // 
            // tsStudents
            // 
            this.tsStudents.Name = "tsStudents";
            this.tsStudents.Size = new System.Drawing.Size(159, 22);
            this.tsStudents.Text = "სტუდენტები";
            this.tsStudents.Click += new System.EventHandler(this.tsStudents_Click);
            // 
            // ფაკულტეტიToolStripMenuItem
            // 
            this.ფაკულტეტიToolStripMenuItem.Name = "ფაკულტეტიToolStripMenuItem";
            this.ფაკულტეტიToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.ფაკულტეტიToolStripMenuItem.Text = "ფაკულტეტი";
            this.ფაკულტეტიToolStripMenuItem.Click += new System.EventHandler(this.ფაკულტეტიToolStripMenuItem_Click);
            // 
            // დახმარებაToolStripMenuItem
            // 
            this.დახმარებაToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddUser});
            this.დახმარებაToolStripMenuItem.Name = "დახმარებაToolStripMenuItem";
            this.დახმარებაToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.დახმარებაToolStripMenuItem.Text = "დახმარება";
            // 
            // AddUser
            // 
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(224, 22);
            this.AddUser.Text = "დაამატე მომხმარებელი";
            this.AddUser.Click += new System.EventHandler(this.AddUser_Click);
            // 
            // XtraTabbedMdiManager1
            // 
            this.XtraTabbedMdiManager1.Appearance.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.XtraTabbedMdiManager1.Appearance.Options.UseFont = true;
            this.XtraTabbedMdiManager1.AppearancePage.Header.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.XtraTabbedMdiManager1.AppearancePage.Header.Options.UseFont = true;
            this.XtraTabbedMdiManager1.AppearancePage.HeaderActive.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.XtraTabbedMdiManager1.AppearancePage.HeaderActive.ForeColor = System.Drawing.Color.Blue;
            this.XtraTabbedMdiManager1.AppearancePage.HeaderActive.Options.UseFont = true;
            this.XtraTabbedMdiManager1.AppearancePage.HeaderActive.Options.UseForeColor = true;
            this.XtraTabbedMdiManager1.AppearancePage.HeaderDisabled.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.XtraTabbedMdiManager1.AppearancePage.HeaderDisabled.Options.UseFont = true;
            this.XtraTabbedMdiManager1.AppearancePage.HeaderHotTracked.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.XtraTabbedMdiManager1.AppearancePage.HeaderHotTracked.Options.UseFont = true;
            this.XtraTabbedMdiManager1.AppearancePage.PageClient.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.XtraTabbedMdiManager1.AppearancePage.PageClient.Options.UseFont = true;
            this.XtraTabbedMdiManager1.MdiParent = this;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 623);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "სსუ-ს სტუდენტთა მონაცემების დამუშავება და სინქრონიზაცია";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.XtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsUser;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem მთავარიToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem მოდულებიToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem დახმარებაToolStripMenuItem;
        internal DevExpress.XtraTabbedMdi.XtraTabbedMdiManager XtraTabbedMdiManager1;
        private System.Windows.Forms.ToolStripMenuItem tsExit;
        private System.Windows.Forms.ToolStripMenuItem tsStudents;
        private System.Windows.Forms.ToolStripMenuItem AddUser;
        private System.Windows.Forms.ToolStripMenuItem ფაკულტეტიToolStripMenuItem;
    }
}