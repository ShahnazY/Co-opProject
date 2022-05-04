
namespace Co_opBackOffice
{
    partial class frmClaims
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.chkYes = new System.Windows.Forms.CheckBox();
            this.lblEvidenceProvided = new System.Windows.Forms.Label();
            this.lblDateOfInjury = new System.Windows.Forms.Label();
            this.lblDateOfClaim = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtDateOfInjury = new System.Windows.Forms.TextBox();
            this.txtDateOfClaim = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblFilterError = new System.Windows.Forms.Label();
            this.btnNO = new System.Windows.Forms.Button();
            this.btnYes = new System.Windows.Forms.Button();
            this.lblConfirmation = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDisplayAll = new System.Windows.Forms.Button();
            this.btnFilterLocation = new System.Windows.Forms.Button();
            this.lblFilterLocation = new System.Windows.Forms.Label();
            this.txtFilterLocation = new System.Windows.Forms.TextBox();
            this.btnFilterStatus = new System.Windows.Forms.Button();
            this.lblFilterStatus = new System.Windows.Forms.Label();
            this.txtFilterStatus = new System.Windows.Forms.TextBox();
            this.lstClaims = new System.Windows.Forms.ListBox();
            this.btnMainPage = new System.Windows.Forms.Button();
            this.lblClaimManagement = new System.Windows.Forms.Label();
            this.lblAddNewClaim = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.chkYes);
            this.panel1.Controls.Add(this.lblEvidenceProvided);
            this.panel1.Controls.Add(this.lblDateOfInjury);
            this.panel1.Controls.Add(this.lblDateOfClaim);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.lblLocation);
            this.panel1.Controls.Add(this.txtDateOfInjury);
            this.panel1.Controls.Add(this.txtDateOfClaim);
            this.panel1.Controls.Add(this.txtStatus);
            this.panel1.Controls.Add(this.txtLocation);
            this.panel1.Location = new System.Drawing.Point(12, 241);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 365);
            this.panel1.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Ivory;
            this.btnUpdate.Location = new System.Drawing.Point(234, 328);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Ivory;
            this.btnAdd.Location = new System.Drawing.Point(119, 328);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // chkYes
            // 
            this.chkYes.AutoSize = true;
            this.chkYes.Location = new System.Drawing.Point(171, 285);
            this.chkYes.Name = "chkYes";
            this.chkYes.Size = new System.Drawing.Size(44, 17);
            this.chkYes.TabIndex = 9;
            this.chkYes.Text = "Yes";
            this.chkYes.UseVisualStyleBackColor = true;
            // 
            // lblEvidenceProvided
            // 
            this.lblEvidenceProvided.AutoSize = true;
            this.lblEvidenceProvided.Location = new System.Drawing.Point(42, 285);
            this.lblEvidenceProvided.Name = "lblEvidenceProvided";
            this.lblEvidenceProvided.Size = new System.Drawing.Size(97, 13);
            this.lblEvidenceProvided.TabIndex = 8;
            this.lblEvidenceProvided.Text = "Evidence Provided";
            // 
            // lblDateOfInjury
            // 
            this.lblDateOfInjury.AutoSize = true;
            this.lblDateOfInjury.Location = new System.Drawing.Point(42, 234);
            this.lblDateOfInjury.Name = "lblDateOfInjury";
            this.lblDateOfInjury.Size = new System.Drawing.Size(70, 13);
            this.lblDateOfInjury.TabIndex = 7;
            this.lblDateOfInjury.Text = "Date of Injury";
            // 
            // lblDateOfClaim
            // 
            this.lblDateOfClaim.AutoSize = true;
            this.lblDateOfClaim.Location = new System.Drawing.Point(42, 168);
            this.lblDateOfClaim.Name = "lblDateOfClaim";
            this.lblDateOfClaim.Size = new System.Drawing.Size(70, 13);
            this.lblDateOfClaim.TabIndex = 6;
            this.lblDateOfClaim.Text = "Date of Claim";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(42, 100);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Status";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(39, 37);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(48, 13);
            this.lblLocation.TabIndex = 4;
            this.lblLocation.Text = "Location";
            // 
            // txtDateOfInjury
            // 
            this.txtDateOfInjury.Location = new System.Drawing.Point(171, 228);
            this.txtDateOfInjury.Name = "txtDateOfInjury";
            this.txtDateOfInjury.Size = new System.Drawing.Size(100, 20);
            this.txtDateOfInjury.TabIndex = 3;
            // 
            // txtDateOfClaim
            // 
            this.txtDateOfClaim.Location = new System.Drawing.Point(171, 162);
            this.txtDateOfClaim.Name = "txtDateOfClaim";
            this.txtDateOfClaim.Size = new System.Drawing.Size(100, 20);
            this.txtDateOfClaim.TabIndex = 2;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(171, 100);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(100, 20);
            this.txtStatus.TabIndex = 1;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(171, 34);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(100, 20);
            this.txtLocation.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Controls.Add(this.lblFilterError);
            this.panel2.Controls.Add(this.btnNO);
            this.panel2.Controls.Add(this.btnYes);
            this.panel2.Controls.Add(this.lblConfirmation);
            this.panel2.Controls.Add(this.lblError);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnDisplayAll);
            this.panel2.Controls.Add(this.btnFilterLocation);
            this.panel2.Controls.Add(this.lblFilterLocation);
            this.panel2.Controls.Add(this.txtFilterLocation);
            this.panel2.Controls.Add(this.btnFilterStatus);
            this.panel2.Controls.Add(this.lblFilterStatus);
            this.panel2.Controls.Add(this.txtFilterStatus);
            this.panel2.Controls.Add(this.lstClaims);
            this.panel2.Location = new System.Drawing.Point(408, 207);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(534, 491);
            this.panel2.TabIndex = 1;
            // 
            // lblFilterError
            // 
            this.lblFilterError.AutoSize = true;
            this.lblFilterError.Location = new System.Drawing.Point(256, 255);
            this.lblFilterError.Name = "lblFilterError";
            this.lblFilterError.Size = new System.Drawing.Size(0, 13);
            this.lblFilterError.TabIndex = 14;
            // 
            // btnNO
            // 
            this.btnNO.Location = new System.Drawing.Point(165, 445);
            this.btnNO.Name = "btnNO";
            this.btnNO.Size = new System.Drawing.Size(75, 23);
            this.btnNO.TabIndex = 13;
            this.btnNO.Text = "NO";
            this.btnNO.UseVisualStyleBackColor = true;
            this.btnNO.Click += new System.EventHandler(this.btnNO_Click);
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(14, 445);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(75, 23);
            this.btnYes.TabIndex = 12;
            this.btnYes.Text = "YES";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // lblConfirmation
            // 
            this.lblConfirmation.AutoSize = true;
            this.lblConfirmation.Location = new System.Drawing.Point(54, 409);
            this.lblConfirmation.Name = "lblConfirmation";
            this.lblConfirmation.Size = new System.Drawing.Size(0, 13);
            this.lblConfirmation.TabIndex = 11;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(147, 337);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 10;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(165, 360);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(14, 360);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDisplayAll
            // 
            this.btnDisplayAll.Location = new System.Drawing.Point(67, 307);
            this.btnDisplayAll.Name = "btnDisplayAll";
            this.btnDisplayAll.Size = new System.Drawing.Size(116, 23);
            this.btnDisplayAll.TabIndex = 7;
            this.btnDisplayAll.Text = "Display All Claims";
            this.btnDisplayAll.UseVisualStyleBackColor = true;
            this.btnDisplayAll.Click += new System.EventHandler(this.btnDisplayAll_Click);
            // 
            // btnFilterLocation
            // 
            this.btnFilterLocation.Location = new System.Drawing.Point(281, 192);
            this.btnFilterLocation.Name = "btnFilterLocation";
            this.btnFilterLocation.Size = new System.Drawing.Size(75, 23);
            this.btnFilterLocation.TabIndex = 6;
            this.btnFilterLocation.Text = "FILTER";
            this.btnFilterLocation.UseVisualStyleBackColor = true;
            // 
            // lblFilterLocation
            // 
            this.lblFilterLocation.AutoSize = true;
            this.lblFilterLocation.Location = new System.Drawing.Point(253, 135);
            this.lblFilterLocation.Name = "lblFilterLocation";
            this.lblFilterLocation.Size = new System.Drawing.Size(90, 13);
            this.lblFilterLocation.TabIndex = 5;
            this.lblFilterLocation.Text = "Filter by Location:";
            // 
            // txtFilterLocation
            // 
            this.txtFilterLocation.Location = new System.Drawing.Point(256, 162);
            this.txtFilterLocation.Name = "txtFilterLocation";
            this.txtFilterLocation.Size = new System.Drawing.Size(100, 20);
            this.txtFilterLocation.TabIndex = 4;
            // 
            // btnFilterStatus
            // 
            this.btnFilterStatus.Location = new System.Drawing.Point(281, 95);
            this.btnFilterStatus.Name = "btnFilterStatus";
            this.btnFilterStatus.Size = new System.Drawing.Size(75, 23);
            this.btnFilterStatus.TabIndex = 3;
            this.btnFilterStatus.Text = "FILTER";
            this.btnFilterStatus.UseVisualStyleBackColor = true;
            this.btnFilterStatus.Click += new System.EventHandler(this.btnFilterStatus_Click);
            // 
            // lblFilterStatus
            // 
            this.lblFilterStatus.AutoSize = true;
            this.lblFilterStatus.Location = new System.Drawing.Point(253, 34);
            this.lblFilterStatus.Name = "lblFilterStatus";
            this.lblFilterStatus.Size = new System.Drawing.Size(79, 13);
            this.lblFilterStatus.TabIndex = 2;
            this.lblFilterStatus.Text = "Filter by Status:";
            // 
            // txtFilterStatus
            // 
            this.txtFilterStatus.Location = new System.Drawing.Point(256, 69);
            this.txtFilterStatus.Name = "txtFilterStatus";
            this.txtFilterStatus.Size = new System.Drawing.Size(100, 20);
            this.txtFilterStatus.TabIndex = 1;
            // 
            // lstClaims
            // 
            this.lstClaims.FormattingEnabled = true;
            this.lstClaims.Location = new System.Drawing.Point(14, 34);
            this.lstClaims.Name = "lstClaims";
            this.lstClaims.Size = new System.Drawing.Size(226, 251);
            this.lstClaims.TabIndex = 0;
            // 
            // btnMainPage
            // 
            this.btnMainPage.Location = new System.Drawing.Point(867, 29);
            this.btnMainPage.Name = "btnMainPage";
            this.btnMainPage.Size = new System.Drawing.Size(75, 23);
            this.btnMainPage.TabIndex = 2;
            this.btnMainPage.Text = "Main Page";
            this.btnMainPage.UseVisualStyleBackColor = true;
            this.btnMainPage.Click += new System.EventHandler(this.btnMainPage_Click);
            // 
            // lblClaimManagement
            // 
            this.lblClaimManagement.AutoSize = true;
            this.lblClaimManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaimManagement.Location = new System.Drawing.Point(309, 46);
            this.lblClaimManagement.Name = "lblClaimManagement";
            this.lblClaimManagement.Size = new System.Drawing.Size(237, 29);
            this.lblClaimManagement.TabIndex = 7;
            this.lblClaimManagement.Text = "Claim Management";
            // 
            // lblAddNewClaim
            // 
            this.lblAddNewClaim.AutoSize = true;
            this.lblAddNewClaim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewClaim.Location = new System.Drawing.Point(12, 179);
            this.lblAddNewClaim.Name = "lblAddNewClaim";
            this.lblAddNewClaim.Size = new System.Drawing.Size(154, 24);
            this.lblAddNewClaim.TabIndex = 8;
            this.lblAddNewClaim.Text = "Add New Claim";
            // 
            // frmClaims
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 820);
            this.Controls.Add(this.lblAddNewClaim);
            this.Controls.Add(this.lblClaimManagement);
            this.Controls.Add(this.btnMainPage);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmClaims";
            this.Text = "frmClaims";
            this.Load += new System.EventHandler(this.frmClaims_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtDateOfInjury;
        private System.Windows.Forms.TextBox txtDateOfClaim;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblDateOfInjury;
        private System.Windows.Forms.Label lblDateOfClaim;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckBox chkYes;
        private System.Windows.Forms.Label lblEvidenceProvided;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDisplayAll;
        private System.Windows.Forms.Button btnFilterLocation;
        private System.Windows.Forms.Label lblFilterLocation;
        private System.Windows.Forms.TextBox txtFilterLocation;
        private System.Windows.Forms.Button btnFilterStatus;
        private System.Windows.Forms.Label lblFilterStatus;
        private System.Windows.Forms.TextBox txtFilterStatus;
        private System.Windows.Forms.ListBox lstClaims;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnNO;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Label lblConfirmation;
        private System.Windows.Forms.Label lblFilterError;
        private System.Windows.Forms.Button btnMainPage;
        private System.Windows.Forms.Label lblClaimManagement;
        private System.Windows.Forms.Label lblAddNewClaim;
    }
}