
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
            this.SuspendLayout();
            // 
            // txtPersonalInjury
            // 
            this.txtPersonalInjury.Location = new System.Drawing.Point(330, 137);
            this.txtPersonalInjury.Name = "txtPersonalInjury";
            this.txtPersonalInjury.Size = new System.Drawing.Size(115, 47);
            this.txtPersonalInjury.TabIndex = 0;
            this.txtPersonalInjury.Text = "Personal Injury";
            this.txtPersonalInjury.UseVisualStyleBackColor = true;
            this.txtPersonalInjury.Click += new System.EventHandler(this.txtPersonalInjury_Click);
            // 
            // btnFunds
            // 
            this.btnFunds.Location = new System.Drawing.Point(330, 220);
            this.btnFunds.Name = "btnFunds";
            this.btnFunds.Size = new System.Drawing.Size(115, 39);
            this.btnFunds.TabIndex = 1;
            this.btnFunds.Text = "Funds";
            this.btnFunds.UseVisualStyleBackColor = true;
            // 
            // frmMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFunds);
            this.Controls.Add(this.txtPersonalInjury);
            this.Name = "frmMainPage";
            this.Text = "frmMainPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button txtPersonalInjury;
        private System.Windows.Forms.Button btnFunds;
    }
}