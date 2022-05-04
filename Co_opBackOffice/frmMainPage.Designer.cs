
namespace Co_opBackOffice
{
    partial class frmMainPage
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
            this.btnFunds = new System.Windows.Forms.Button();
            this.btnClaimManagement = new System.Windows.Forms.Button();
            this.btnPersonalInjury = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFunds
            // 
            this.btnFunds.Location = new System.Drawing.Point(650, 213);
            this.btnFunds.Name = "btnFunds";
            this.btnFunds.Size = new System.Drawing.Size(108, 52);
            this.btnFunds.TabIndex = 1;
            this.btnFunds.Text = "Funds";
            this.btnFunds.UseVisualStyleBackColor = true;
            // 
            // btnClaimManagement
            // 
            this.btnClaimManagement.Location = new System.Drawing.Point(39, 213);
            this.btnClaimManagement.Name = "btnClaimManagement";
            this.btnClaimManagement.Size = new System.Drawing.Size(99, 52);
            this.btnClaimManagement.TabIndex = 2;
            this.btnClaimManagement.Text = "Claim Management";
            this.btnClaimManagement.UseVisualStyleBackColor = true;
            this.btnClaimManagement.Click += new System.EventHandler(this.btnClaimManagement_Click);
            // 
            // btnPersonalInjury
            // 
            this.btnPersonalInjury.Location = new System.Drawing.Point(144, 213);
            this.btnPersonalInjury.Name = "btnPersonalInjury";
            this.btnPersonalInjury.Size = new System.Drawing.Size(97, 52);
            this.btnPersonalInjury.TabIndex = 3;
            this.btnPersonalInjury.Text = "Personal Injury Management";
            this.btnPersonalInjury.UseVisualStyleBackColor = true;
            this.btnPersonalInjury.Click += new System.EventHandler(this.btnPersonalInjury_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(248, 213);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(118, 52);
            this.btnCustomer.TabIndex = 4;
            this.btnCustomer.Text = "Customer Management";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // frmMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.btnPersonalInjury);
            this.Controls.Add(this.btnClaimManagement);
            this.Controls.Add(this.btnFunds);
            this.Name = "frmMainPage";
            this.Text = "frmMainPage";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnFunds;
        private System.Windows.Forms.Button btnClaimManagement;
        private System.Windows.Forms.Button btnPersonalInjury;
        private System.Windows.Forms.Button btnCustomer;
    }
}