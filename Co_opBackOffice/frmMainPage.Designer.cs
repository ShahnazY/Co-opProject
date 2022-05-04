
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
            this.txtPersonalInjury = new System.Windows.Forms.Button();
            this.btnFunds = new System.Windows.Forms.Button();
            this.btnDogInsurance = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPersonalInjury
            // 
            this.txtPersonalInjury.Location = new System.Drawing.Point(660, 263);
            this.txtPersonalInjury.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPersonalInjury.Name = "txtPersonalInjury";
            this.txtPersonalInjury.Size = new System.Drawing.Size(230, 90);
            this.txtPersonalInjury.TabIndex = 0;
            this.txtPersonalInjury.Text = "Personal Injury";
            this.txtPersonalInjury.UseVisualStyleBackColor = true;
            this.txtPersonalInjury.Click += new System.EventHandler(this.txtPersonalInjury_Click);
            // 
            // btnFunds
            // 
            this.btnFunds.Location = new System.Drawing.Point(660, 423);
            this.btnFunds.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnFunds.Name = "btnFunds";
            this.btnFunds.Size = new System.Drawing.Size(230, 75);
            this.btnFunds.TabIndex = 1;
            this.btnFunds.Text = "Funds";
            this.btnFunds.UseVisualStyleBackColor = true;
            // 
            // btnDogInsurance
            // 
            this.btnDogInsurance.Location = new System.Drawing.Point(660, 122);
            this.btnDogInsurance.Name = "btnDogInsurance";
            this.btnDogInsurance.Size = new System.Drawing.Size(230, 82);
            this.btnDogInsurance.TabIndex = 2;
            this.btnDogInsurance.Text = "Dog Insurance";
            this.btnDogInsurance.UseVisualStyleBackColor = true;
            this.btnDogInsurance.Click += new System.EventHandler(this.btnDogInsurance_Click);
            // 
            // frmMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.btnDogInsurance);
            this.Controls.Add(this.btnFunds);
            this.Controls.Add(this.txtPersonalInjury);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmMainPage";
            this.Text = "frmMainPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button txtPersonalInjury;
        private System.Windows.Forms.Button btnFunds;
        private System.Windows.Forms.Button btnDogInsurance;
    }
}