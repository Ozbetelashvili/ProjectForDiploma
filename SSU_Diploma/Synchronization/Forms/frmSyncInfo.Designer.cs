
namespace SSU_Diploma.Synchronization.Forms
{
    partial class frmSyncInfo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbStatus = new System.Windows.Forms.CheckBox();
            this.cbLevel = new System.Windows.Forms.CheckBox();
            this.cbSemester = new System.Windows.Forms.CheckBox();
            this.cbProgram = new System.Windows.Forms.CheckBox();
            this.cbFaculty = new System.Windows.Forms.CheckBox();
            this.cbEmail = new System.Windows.Forms.CheckBox();
            this.cbPhone = new System.Windows.Forms.CheckBox();
            this.cbAddress = new System.Windows.Forms.CheckBox();
            this.cbDateOfBirth = new System.Windows.Forms.CheckBox();
            this.cbLastName = new System.Windows.Forms.CheckBox();
            this.cbGender = new System.Windows.Forms.CheckBox();
            this.cbPrivateNo = new System.Windows.Forms.CheckBox();
            this.cbFirstName = new System.Windows.Forms.CheckBox();
            this.txtDateOfBirth = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtSemester = new System.Windows.Forms.TextBox();
            this.txtProgram = new System.Windows.Forms.TextBox();
            this.txtFaculty = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPriveNo = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbStatus);
            this.panel1.Controls.Add(this.cbLevel);
            this.panel1.Controls.Add(this.cbSemester);
            this.panel1.Controls.Add(this.cbProgram);
            this.panel1.Controls.Add(this.cbFaculty);
            this.panel1.Controls.Add(this.cbEmail);
            this.panel1.Controls.Add(this.cbPhone);
            this.panel1.Controls.Add(this.cbAddress);
            this.panel1.Controls.Add(this.cbDateOfBirth);
            this.panel1.Controls.Add(this.cbLastName);
            this.panel1.Controls.Add(this.cbGender);
            this.panel1.Controls.Add(this.cbPrivateNo);
            this.panel1.Controls.Add(this.cbFirstName);
            this.panel1.Controls.Add(this.txtDateOfBirth);
            this.panel1.Controls.Add(this.txtGender);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtLevel);
            this.panel1.Controls.Add(this.txtStatus);
            this.panel1.Controls.Add(this.txtSemester);
            this.panel1.Controls.Add(this.txtProgram);
            this.panel1.Controls.Add(this.txtFaculty);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.txtPriveNo);
            this.panel1.Controls.Add(this.txtLastName);
            this.panel1.Controls.Add(this.txtFirstName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 334);
            this.panel1.TabIndex = 0;
            // 
            // cbStatus
            // 
            this.cbStatus.AutoSize = true;
            this.cbStatus.Location = new System.Drawing.Point(417, 199);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(87, 22);
            this.cbStatus.TabIndex = 27;
            this.cbStatus.Text = "სტატუსი:";
            this.cbStatus.UseVisualStyleBackColor = true;
            this.cbStatus.CheckedChanged += new System.EventHandler(this.cbStatus_CheckedChanged);
            // 
            // cbLevel
            // 
            this.cbLevel.AutoSize = true;
            this.cbLevel.Location = new System.Drawing.Point(180, 199);
            this.cbLevel.Name = "cbLevel";
            this.cbLevel.Size = new System.Drawing.Size(92, 22);
            this.cbLevel.TabIndex = 27;
            this.cbLevel.Text = "საფეხური:";
            this.cbLevel.UseVisualStyleBackColor = true;
            this.cbLevel.CheckedChanged += new System.EventHandler(this.cbLevel_CheckedChanged);
            // 
            // cbSemester
            // 
            this.cbSemester.AutoSize = true;
            this.cbSemester.Location = new System.Drawing.Point(3, 199);
            this.cbSemester.Name = "cbSemester";
            this.cbSemester.Size = new System.Drawing.Size(91, 22);
            this.cbSemester.TabIndex = 27;
            this.cbSemester.Text = "სემესტრი:";
            this.cbSemester.UseVisualStyleBackColor = true;
            this.cbSemester.CheckedChanged += new System.EventHandler(this.cbSemester_CheckedChanged);
            // 
            // cbProgram
            // 
            this.cbProgram.AutoSize = true;
            this.cbProgram.Location = new System.Drawing.Point(3, 171);
            this.cbProgram.Name = "cbProgram";
            this.cbProgram.Size = new System.Drawing.Size(89, 22);
            this.cbProgram.TabIndex = 27;
            this.cbProgram.Text = "პროგრამა:";
            this.cbProgram.UseVisualStyleBackColor = true;
            this.cbProgram.CheckedChanged += new System.EventHandler(this.cbProgram_CheckedChanged);
            // 
            // cbFaculty
            // 
            this.cbFaculty.AutoSize = true;
            this.cbFaculty.Location = new System.Drawing.Point(3, 143);
            this.cbFaculty.Name = "cbFaculty";
            this.cbFaculty.Size = new System.Drawing.Size(106, 22);
            this.cbFaculty.TabIndex = 27;
            this.cbFaculty.Text = "ფაკულტეტი:";
            this.cbFaculty.UseVisualStyleBackColor = true;
            this.cbFaculty.CheckedChanged += new System.EventHandler(this.cbFaculty_CheckedChanged);
            // 
            // cbEmail
            // 
            this.cbEmail.AutoSize = true;
            this.cbEmail.Location = new System.Drawing.Point(328, 91);
            this.cbEmail.Name = "cbEmail";
            this.cbEmail.Size = new System.Drawing.Size(77, 22);
            this.cbEmail.TabIndex = 27;
            this.cbEmail.Text = "იმეილი:";
            this.cbEmail.UseVisualStyleBackColor = true;
            this.cbEmail.CheckedChanged += new System.EventHandler(this.cbEmail_CheckedChanged);
            // 
            // cbPhone
            // 
            this.cbPhone.AutoSize = true;
            this.cbPhone.Location = new System.Drawing.Point(3, 92);
            this.cbPhone.Name = "cbPhone";
            this.cbPhone.Size = new System.Drawing.Size(111, 22);
            this.cbPhone.TabIndex = 27;
            this.cbPhone.Text = "ტელ. ნომერი:";
            this.cbPhone.UseVisualStyleBackColor = true;
            this.cbPhone.CheckedChanged += new System.EventHandler(this.cbPhone_CheckedChanged);
            // 
            // cbAddress
            // 
            this.cbAddress.AutoSize = true;
            this.cbAddress.Location = new System.Drawing.Point(218, 64);
            this.cbAddress.Name = "cbAddress";
            this.cbAddress.Size = new System.Drawing.Size(97, 22);
            this.cbAddress.TabIndex = 27;
            this.cbAddress.Text = "მისამართი:";
            this.cbAddress.UseVisualStyleBackColor = true;
            this.cbAddress.CheckedChanged += new System.EventHandler(this.cbAddress_CheckedChanged);
            // 
            // cbDateOfBirth
            // 
            this.cbDateOfBirth.AutoSize = true;
            this.cbDateOfBirth.Location = new System.Drawing.Point(328, 36);
            this.cbDateOfBirth.Name = "cbDateOfBirth";
            this.cbDateOfBirth.Size = new System.Drawing.Size(151, 22);
            this.cbDateOfBirth.TabIndex = 27;
            this.cbDateOfBirth.Text = "დაბადების თარიღი:";
            this.cbDateOfBirth.UseVisualStyleBackColor = true;
            this.cbDateOfBirth.CheckedChanged += new System.EventHandler(this.cbDateOfBirth_CheckedChanged);
            // 
            // cbLastName
            // 
            this.cbLastName.AutoSize = true;
            this.cbLastName.Location = new System.Drawing.Point(328, 8);
            this.cbLastName.Name = "cbLastName";
            this.cbLastName.Size = new System.Drawing.Size(66, 22);
            this.cbLastName.TabIndex = 27;
            this.cbLastName.Text = "გვარი:";
            this.cbLastName.UseVisualStyleBackColor = true;
            this.cbLastName.CheckedChanged += new System.EventHandler(this.cbLastName_CheckedChanged);
            // 
            // cbGender
            // 
            this.cbGender.AutoSize = true;
            this.cbGender.Location = new System.Drawing.Point(3, 64);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(64, 22);
            this.cbGender.TabIndex = 27;
            this.cbGender.Text = "სქესი:";
            this.cbGender.UseVisualStyleBackColor = true;
            this.cbGender.CheckedChanged += new System.EventHandler(this.cbGender_CheckedChanged);
            // 
            // cbPrivateNo
            // 
            this.cbPrivateNo.AutoSize = true;
            this.cbPrivateNo.Location = new System.Drawing.Point(3, 36);
            this.cbPrivateNo.Name = "cbPrivateNo";
            this.cbPrivateNo.Size = new System.Drawing.Size(89, 22);
            this.cbPrivateNo.TabIndex = 27;
            this.cbPrivateNo.Text = "პირადი N:";
            this.cbPrivateNo.UseVisualStyleBackColor = true;
            this.cbPrivateNo.CheckedChanged += new System.EventHandler(this.ckPrivateNo_CheckedChanged);
            // 
            // cbFirstName
            // 
            this.cbFirstName.AutoSize = true;
            this.cbFirstName.Location = new System.Drawing.Point(3, 8);
            this.cbFirstName.Name = "cbFirstName";
            this.cbFirstName.Size = new System.Drawing.Size(76, 22);
            this.cbFirstName.TabIndex = 27;
            this.cbFirstName.Text = "სახელი:";
            this.cbFirstName.UseVisualStyleBackColor = true;
            this.cbFirstName.CheckedChanged += new System.EventHandler(this.cbFirstName_CheckedChanged);
            // 
            // txtDateOfBirth
            // 
            this.txtDateOfBirth.Enabled = false;
            this.txtDateOfBirth.Location = new System.Drawing.Point(485, 34);
            this.txtDateOfBirth.Name = "txtDateOfBirth";
            this.txtDateOfBirth.Size = new System.Drawing.Size(167, 25);
            this.txtDateOfBirth.TabIndex = 26;
            // 
            // txtGender
            // 
            this.txtGender.Enabled = false;
            this.txtGender.Location = new System.Drawing.Point(73, 62);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(139, 25);
            this.txtGender.TabIndex = 26;
            // 
            // txtPhone
            // 
            this.txtPhone.Enabled = false;
            this.txtPhone.Location = new System.Drawing.Point(120, 90);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(185, 25);
            this.txtPhone.TabIndex = 26;
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(411, 90);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(241, 25);
            this.txtEmail.TabIndex = 26;
            // 
            // txtLevel
            // 
            this.txtLevel.Enabled = false;
            this.txtLevel.Location = new System.Drawing.Point(274, 197);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(137, 25);
            this.txtLevel.TabIndex = 25;
            // 
            // txtStatus
            // 
            this.txtStatus.Enabled = false;
            this.txtStatus.Location = new System.Drawing.Point(510, 197);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(142, 25);
            this.txtStatus.TabIndex = 25;
            // 
            // txtSemester
            // 
            this.txtSemester.Enabled = false;
            this.txtSemester.Location = new System.Drawing.Point(115, 197);
            this.txtSemester.Name = "txtSemester";
            this.txtSemester.Size = new System.Drawing.Size(59, 25);
            this.txtSemester.TabIndex = 25;
            // 
            // txtProgram
            // 
            this.txtProgram.Enabled = false;
            this.txtProgram.Location = new System.Drawing.Point(115, 169);
            this.txtProgram.Name = "txtProgram";
            this.txtProgram.Size = new System.Drawing.Size(537, 25);
            this.txtProgram.TabIndex = 25;
            // 
            // txtFaculty
            // 
            this.txtFaculty.Enabled = false;
            this.txtFaculty.Location = new System.Drawing.Point(115, 141);
            this.txtFaculty.Name = "txtFaculty";
            this.txtFaculty.Size = new System.Drawing.Size(537, 25);
            this.txtFaculty.TabIndex = 25;
            // 
            // txtAddress
            // 
            this.txtAddress.Enabled = false;
            this.txtAddress.Location = new System.Drawing.Point(321, 62);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(331, 25);
            this.txtAddress.TabIndex = 25;
            // 
            // txtPriveNo
            // 
            this.txtPriveNo.Enabled = false;
            this.txtPriveNo.Location = new System.Drawing.Point(97, 34);
            this.txtPriveNo.Name = "txtPriveNo";
            this.txtPriveNo.Size = new System.Drawing.Size(208, 25);
            this.txtPriveNo.TabIndex = 23;
            // 
            // txtLastName
            // 
            this.txtLastName.Enabled = false;
            this.txtLastName.Location = new System.Drawing.Point(400, 6);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(252, 25);
            this.txtLastName.TabIndex = 18;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Enabled = false;
            this.txtFirstName.Location = new System.Drawing.Point(85, 6);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(220, 25);
            this.txtFirstName.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnApply);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 248);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(677, 86);
            this.panel2.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Image = global::SSU_Diploma.Properties.Resources.v4Delete;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(559, 18);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 56);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "გაუქმება";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApply.Image = global::SSU_Diploma.Properties.Resources.v4Apply;
            this.btnApply.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApply.Location = new System.Drawing.Point(434, 18);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(119, 56);
            this.btnApply.TabIndex = 24;
            this.btnApply.Text = "შესრულება";
            this.btnApply.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // frmSyncInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 334);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmSyncInfo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "სინქრონიზაცია";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbAddress;
        private System.Windows.Forms.CheckBox cbDateOfBirth;
        private System.Windows.Forms.CheckBox cbLastName;
        private System.Windows.Forms.CheckBox cbGender;
        private System.Windows.Forms.CheckBox cbPrivateNo;
        private System.Windows.Forms.CheckBox cbFirstName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPriveNo;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.CheckBox cbEmail;
        private System.Windows.Forms.CheckBox cbPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox cbStatus;
        private System.Windows.Forms.CheckBox cbLevel;
        private System.Windows.Forms.CheckBox cbSemester;
        private System.Windows.Forms.CheckBox cbProgram;
        private System.Windows.Forms.CheckBox cbFaculty;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtSemester;
        private System.Windows.Forms.TextBox txtProgram;
        private System.Windows.Forms.TextBox txtFaculty;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.TextBox txtDateOfBirth;
    }
}