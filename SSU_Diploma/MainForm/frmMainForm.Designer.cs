
namespace SSU_Diploma.MainForm
{
    partial class frmMainForm
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsAdd = new System.Windows.Forms.ToolStripButton();
            this.tsEdit = new System.Windows.Forms.ToolStripButton();
            this.tsPrint = new System.Windows.Forms.ToolStripButton();
            this.tsSync = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSemester = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCardNo = new System.Windows.Forms.TextBox();
            this.cmbEducationLevel = new System.Windows.Forms.ComboBox();
            this.cmbDiretion = new System.Windows.Forms.ComboBox();
            this.cmbFaculty = new System.Windows.Forms.ComboBox();
            this.txtPrivateNo = new System.Windows.Forms.TextBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gc = new DevExpress.XtraGrid.GridControl();
            this.gw = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFullNameGeo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateOfBirth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrivateNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMobile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSemester = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gw)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAdd,
            this.tsEdit,
            this.tsPrint,
            this.tsSync});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1143, 41);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsAdd
            // 
            this.tsAdd.AutoSize = false;
            this.tsAdd.Image = global::SSU_Diploma.Properties.Resources.plus__1_;
            this.tsAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAdd.Name = "tsAdd";
            this.tsAdd.Size = new System.Drawing.Size(88, 29);
            this.tsAdd.Text = "დამატება";
            this.tsAdd.Click += new System.EventHandler(this.tsAdd_Click);
            // 
            // tsEdit
            // 
            this.tsEdit.AutoSize = false;
            this.tsEdit.Image = global::SSU_Diploma.Properties.Resources.pencil;
            this.tsEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEdit.Name = "tsEdit";
            this.tsEdit.Size = new System.Drawing.Size(105, 32);
            this.tsEdit.Text = "რედაქტირება";
            this.tsEdit.Click += new System.EventHandler(this.tsEdit_Click);
            // 
            // tsPrint
            // 
            this.tsPrint.AutoSize = false;
            this.tsPrint.Image = global::SSU_Diploma.Properties.Resources.print;
            this.tsPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsPrint.Name = "tsPrint";
            this.tsPrint.Size = new System.Drawing.Size(138, 38);
            this.tsPrint.Text = "სასწავლო ბარათი";
            this.tsPrint.Click += new System.EventHandler(this.tsPrint_Click);
            // 
            // tsSync
            // 
            this.tsSync.Image = global::SSU_Diploma.Properties.Resources.v4Flow;
            this.tsSync.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSync.Name = "tsSync";
            this.tsSync.Size = new System.Drawing.Size(123, 29);
            this.tsSync.Text = "სინქრონიზაცია";
            this.tsSync.Click += new System.EventHandler(this.tsSync_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtSemester);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtCardNo);
            this.panel1.Controls.Add(this.cmbEducationLevel);
            this.panel1.Controls.Add(this.cmbDiretion);
            this.panel1.Controls.Add(this.cmbFaculty);
            this.panel1.Controls.Add(this.txtPrivateNo);
            this.panel1.Controls.Add(this.txtFullName);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1143, 169);
            this.panel1.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.MediumPurple;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(939, 30);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(125, 76);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "ძიება";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(278, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "სემესტრი:";
            // 
            // txtSemester
            // 
            this.txtSemester.Location = new System.Drawing.Point(281, 128);
            this.txtSemester.Name = "txtSemester";
            this.txtSemester.Size = new System.Drawing.Size(84, 25);
            this.txtSemester.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(713, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "ბარათის N:";
            // 
            // txtCardNo
            // 
            this.txtCardNo.Location = new System.Drawing.Point(716, 81);
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.Size = new System.Drawing.Size(190, 25);
            this.txtCardNo.TabIndex = 2;
            // 
            // cmbEducationLevel
            // 
            this.cmbEducationLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEducationLevel.FormattingEnabled = true;
            this.cmbEducationLevel.Items.AddRange(new object[] {
            "კომპიუტერული ტექნოლოგიები",
            "მათემატიკა",
            "ბიოლოგია",
            "გეოგრაფია",
            "ფიზიკა",
            "ქიმია"});
            this.cmbEducationLevel.Location = new System.Drawing.Point(15, 128);
            this.cmbEducationLevel.Name = "cmbEducationLevel";
            this.cmbEducationLevel.Size = new System.Drawing.Size(260, 26);
            this.cmbEducationLevel.TabIndex = 3;
            // 
            // cmbDiretion
            // 
            this.cmbDiretion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbDiretion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDiretion.FormattingEnabled = true;
            this.cmbDiretion.Location = new System.Drawing.Point(281, 80);
            this.cmbDiretion.Name = "cmbDiretion";
            this.cmbDiretion.Size = new System.Drawing.Size(429, 26);
            this.cmbDiretion.TabIndex = 3;
            // 
            // cmbFaculty
            // 
            this.cmbFaculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFaculty.FormattingEnabled = true;
            this.cmbFaculty.Location = new System.Drawing.Point(281, 30);
            this.cmbFaculty.Name = "cmbFaculty";
            this.cmbFaculty.Size = new System.Drawing.Size(625, 26);
            this.cmbFaculty.TabIndex = 3;
            this.cmbFaculty.SelectedIndexChanged += new System.EventHandler(this.cmbFaculty_SelectedIndexChanged);
            // 
            // txtPrivateNo
            // 
            this.txtPrivateNo.Location = new System.Drawing.Point(15, 79);
            this.txtPrivateNo.Name = "txtPrivateNo";
            this.txtPrivateNo.Size = new System.Drawing.Size(260, 25);
            this.txtPrivateNo.TabIndex = 2;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(15, 30);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(260, 25);
            this.txtFullName.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "სწავლის საფეხური:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(278, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "სპეციალობა:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "ფაკულტეტი:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "პირადი N:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "გვარი, სახელი:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gc);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 210);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1143, 424);
            this.panel2.TabIndex = 2;
            // 
            // gc
            // 
            this.gc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc.Location = new System.Drawing.Point(0, 0);
            this.gc.MainView = this.gw;
            this.gc.Name = "gc";
            this.gc.Size = new System.Drawing.Size(1143, 424);
            this.gc.TabIndex = 0;
            this.gc.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gw});
            // 
            // gw
            // 
            this.gw.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.gw.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gw.Appearance.ColumnFilterButtonActive.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.gw.Appearance.ColumnFilterButtonActive.Options.UseFont = true;
            this.gw.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.gw.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.gw.Appearance.DetailTip.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.gw.Appearance.DetailTip.Options.UseFont = true;
            this.gw.Appearance.Empty.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.gw.Appearance.Empty.Options.UseFont = true;
            this.gw.Appearance.EvenRow.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.gw.Appearance.EvenRow.Options.UseFont = true;
            this.gw.Appearance.FilterCloseButton.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.gw.Appearance.FilterCloseButton.Options.UseFont = true;
            this.gw.Appearance.FilterPanel.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.gw.Appearance.FilterPanel.Options.UseFont = true;
            this.gw.Appearance.FixedLine.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.gw.Appearance.FixedLine.Options.UseFont = true;
            this.gw.Appearance.FocusedCell.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.gw.Appearance.FocusedCell.Options.UseFont = true;
            this.gw.Appearance.FocusedRow.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.gw.Appearance.FocusedRow.Options.UseFont = true;
            this.gw.Appearance.FooterPanel.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.gw.Appearance.FooterPanel.Options.UseFont = true;
            this.gw.Appearance.GroupButton.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.gw.Appearance.GroupButton.Options.UseFont = true;
            this.gw.Appearance.GroupFooter.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.gw.Appearance.GroupFooter.Options.UseFont = true;
            this.gw.Appearance.GroupPanel.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.gw.Appearance.GroupPanel.Options.UseFont = true;
            this.gw.Appearance.GroupRow.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.gw.Appearance.GroupRow.Options.UseFont = true;
            this.gw.Appearance.HeaderPanel.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.gw.Appearance.HeaderPanel.Options.UseFont = true;
            this.gw.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.gw.Appearance.HideSelectionRow.Options.UseFont = true;
            this.gw.Appearance.HorzLine.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.gw.Appearance.HorzLine.Options.UseFont = true;
            this.gw.Appearance.OddRow.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.gw.Appearance.OddRow.Options.UseFont = true;
            this.gw.Appearance.Preview.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.gw.Appearance.Preview.Options.UseFont = true;
            this.gw.Appearance.Row.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.gw.Appearance.Row.Options.UseFont = true;
            this.gw.Appearance.RowSeparator.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.gw.Appearance.RowSeparator.Options.UseFont = true;
            this.gw.Appearance.SelectedRow.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.gw.Appearance.SelectedRow.Options.UseFont = true;
            this.gw.Appearance.TopNewRow.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.gw.Appearance.TopNewRow.Options.UseFont = true;
            this.gw.Appearance.VertLine.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.gw.Appearance.VertLine.Options.UseFont = true;
            this.gw.Appearance.ViewCaption.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.gw.Appearance.ViewCaption.Options.UseFont = true;
            this.gw.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colFullNameGeo,
            this.colDateOfBirth,
            this.colPrivateNo,
            this.colMobile,
            this.colEmail,
            this.colAddress,
            this.colSemester});
            this.gw.GridControl = this.gc;
            this.gw.Name = "gw";
            this.gw.OptionsView.ShowGroupPanel = false;
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowEdit = false;
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colFullNameGeo
            // 
            this.colFullNameGeo.Caption = "გვარი, სახელი";
            this.colFullNameGeo.FieldName = "FullNameGeo";
            this.colFullNameGeo.Name = "colFullNameGeo";
            this.colFullNameGeo.OptionsColumn.AllowEdit = false;
            this.colFullNameGeo.Visible = true;
            this.colFullNameGeo.VisibleIndex = 1;
            // 
            // colDateOfBirth
            // 
            this.colDateOfBirth.Caption = "პირადი N";
            this.colDateOfBirth.FieldName = "PrivateNo";
            this.colDateOfBirth.Name = "colDateOfBirth";
            this.colDateOfBirth.OptionsColumn.AllowEdit = false;
            this.colDateOfBirth.Visible = true;
            this.colDateOfBirth.VisibleIndex = 2;
            // 
            // colPrivateNo
            // 
            this.colPrivateNo.Caption = "დაბადების თარიღი";
            this.colPrivateNo.FieldName = "DateOfBirth";
            this.colPrivateNo.Name = "colPrivateNo";
            this.colPrivateNo.OptionsColumn.AllowEdit = false;
            this.colPrivateNo.Visible = true;
            this.colPrivateNo.VisibleIndex = 3;
            // 
            // colMobile
            // 
            this.colMobile.Caption = "ტელეფონი";
            this.colMobile.FieldName = "Mobile";
            this.colMobile.Name = "colMobile";
            this.colMobile.OptionsColumn.AllowEdit = false;
            this.colMobile.Visible = true;
            this.colMobile.VisibleIndex = 4;
            // 
            // colEmail
            // 
            this.colEmail.Caption = "ელ-ფოსტა";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.OptionsColumn.AllowEdit = false;
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 5;
            // 
            // colAddress
            // 
            this.colAddress.Caption = "მისამართი";
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.OptionsColumn.AllowEdit = false;
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 6;
            // 
            // colSemester
            // 
            this.colSemester.Caption = "სემესტრი";
            this.colSemester.FieldName = "Semester";
            this.colSemester.Name = "colSemester";
            this.colSemester.OptionsColumn.AllowEdit = false;
            this.colSemester.Visible = true;
            this.colSemester.VisibleIndex = 7;
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 634);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "სტუდენტები";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsAdd;
        private System.Windows.Forms.ToolStripButton tsEdit;
        private System.Windows.Forms.ToolStripButton tsPrint;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCardNo;
        private System.Windows.Forms.ComboBox cmbDiretion;
        private System.Windows.Forms.ComboBox cmbFaculty;
        private System.Windows.Forms.TextBox txtPrivateNo;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gc;
        private DevExpress.XtraGrid.Views.Grid.GridView gw;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSemester;
        private System.Windows.Forms.ComboBox cmbEducationLevel;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colFullNameGeo;
        private DevExpress.XtraGrid.Columns.GridColumn colDateOfBirth;
        private DevExpress.XtraGrid.Columns.GridColumn colPrivateNo;
        private DevExpress.XtraGrid.Columns.GridColumn colMobile;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colSemester;
        private System.Windows.Forms.ToolStripButton tsSync;
    }
}