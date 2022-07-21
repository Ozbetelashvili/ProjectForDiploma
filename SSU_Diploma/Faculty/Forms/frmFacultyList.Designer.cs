
namespace SSU_Diploma.Faculty.Forms
{
    partial class frmFacultyList
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
            this.trFaculty = new DevExpress.XtraTreeList.TreeList();
            this.trIteratorID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tsFaculty = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.trParentID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trFaculty)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Font = new System.Drawing.Font("Sylfaen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAdd,
            this.tsEdit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(933, 36);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsAdd
            // 
            this.tsAdd.AutoSize = false;
            this.tsAdd.Image = global::SSU_Diploma.Properties.Resources.plus__1_;
            this.tsAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAdd.Name = "tsAdd";
            this.tsAdd.Size = new System.Drawing.Size(80, 36);
            this.tsAdd.Text = "დამატება";
            this.tsAdd.Click += new System.EventHandler(this.tsAdd_Click);
            // 
            // tsEdit
            // 
            this.tsEdit.AutoSize = false;
            this.tsEdit.Image = global::SSU_Diploma.Properties.Resources.pencil;
            this.tsEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEdit.Name = "tsEdit";
            this.tsEdit.Size = new System.Drawing.Size(105, 36);
            this.tsEdit.Text = "რედაქტირება";
            this.tsEdit.Click += new System.EventHandler(this.tsEdit_Click);
            // 
            // trFaculty
            // 
            this.trFaculty.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.trIteratorID,
            this.tsFaculty,
            this.trParentID});
            this.trFaculty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trFaculty.Location = new System.Drawing.Point(0, 36);
            this.trFaculty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trFaculty.MinWidth = 23;
            this.trFaculty.Name = "trFaculty";
            this.trFaculty.OptionsView.AutoWidth = false;
            this.trFaculty.Size = new System.Drawing.Size(933, 587);
            this.trFaculty.TabIndex = 1;
            this.trFaculty.TreeLevelWidth = 21;
            // 
            // trIteratorID
            // 
            this.trIteratorID.Caption = "IteratorID";
            this.trIteratorID.FieldName = "ID";
            this.trIteratorID.Name = "trIteratorID";
            this.trIteratorID.OptionsColumn.AllowEdit = false;
            // 
            // tsFaculty
            // 
            this.tsFaculty.Caption = "ფაკულტეტი/სპეციალობა";
            this.tsFaculty.FieldName = "Faculty";
            this.tsFaculty.Name = "tsFaculty";
            this.tsFaculty.OptionsColumn.AllowEdit = false;
            this.tsFaculty.Visible = true;
            this.tsFaculty.VisibleIndex = 0;
            // 
            // trParentID
            // 
            this.trParentID.Caption = "ParentID";
            this.trParentID.FieldName = "ParentID";
            this.trParentID.Name = "trParentID";
            this.trParentID.OptionsColumn.AllowEdit = false;
            // 
            // frmFacultyList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 623);
            this.Controls.Add(this.trFaculty);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmFacultyList";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ფაკულტეტი/სპეციალობა";
            this.Load += new System.EventHandler(this.frmFacultyList_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trFaculty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsAdd;
        private System.Windows.Forms.ToolStripButton tsEdit;
        private DevExpress.XtraTreeList.TreeList trFaculty;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tsFaculty;
        private DevExpress.XtraTreeList.Columns.TreeListColumn trParentID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn trIteratorID;
    }
}