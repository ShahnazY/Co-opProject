
namespace Co_opBackOffice
{
    partial class frmFunds
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
            this.lblSymbol = new System.Windows.Forms.Label();
            this.txtSymbol = new System.Windows.Forms.TextBox();
            this.lblManage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMarketPrice = new System.Windows.Forms.Label();
            this.lblStocks = new System.Windows.Forms.Label();
            this.lblFundName = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.lblObjective = new System.Windows.Forms.Label();
            this.txtRisk = new System.Windows.Forms.TextBox();
            this.txtMarketPrice = new System.Windows.Forms.TextBox();
            this.txtStocks = new System.Windows.Forms.TextBox();
            this.txtFundName = new System.Windows.Forms.TextBox();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.txtObjective = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstFunds = new System.Windows.Forms.ListBox();
            this.btnPopulate = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.lblError1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(124)))), ((int)(((byte)(136)))));
            this.panel1.Controls.Add(this.txtObjective);
            this.panel1.Controls.Add(this.txtChange);
            this.panel1.Controls.Add(this.txtFundName);
            this.panel1.Controls.Add(this.txtStocks);
            this.panel1.Controls.Add(this.txtMarketPrice);
            this.panel1.Controls.Add(this.txtRisk);
            this.panel1.Controls.Add(this.lblObjective);
            this.panel1.Controls.Add(this.lblChange);
            this.panel1.Controls.Add(this.lblFundName);
            this.panel1.Controls.Add(this.lblStocks);
            this.panel1.Controls.Add(this.lblMarketPrice);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblSymbol);
            this.panel1.Controls.Add(this.txtSymbol);
            this.panel1.Location = new System.Drawing.Point(25, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 317);
            this.panel1.TabIndex = 0;
            // 
            // lblSymbol
            // 
            this.lblSymbol.AutoSize = true;
            this.lblSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.6F);
            this.lblSymbol.Location = new System.Drawing.Point(13, 28);
            this.lblSymbol.Name = "lblSymbol";
            this.lblSymbol.Size = new System.Drawing.Size(62, 18);
            this.lblSymbol.TabIndex = 1;
            this.lblSymbol.Text = "Symbol:";
            // 
            // txtSymbol
            // 
            this.txtSymbol.Location = new System.Drawing.Point(201, 28);
            this.txtSymbol.Name = "txtSymbol";
            this.txtSymbol.Size = new System.Drawing.Size(140, 20);
            this.txtSymbol.TabIndex = 0;
            // 
            // lblManage
            // 
            this.lblManage.AutoSize = true;
            this.lblManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.6F);
            this.lblManage.Location = new System.Drawing.Point(19, 41);
            this.lblManage.Name = "lblManage";
            this.lblManage.Size = new System.Drawing.Size(204, 32);
            this.lblManage.TabIndex = 1;
            this.lblManage.Text = "Manage Funds";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.6F);
            this.label1.Location = new System.Drawing.Point(13, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Current Risk Value:";
            // 
            // lblMarketPrice
            // 
            this.lblMarketPrice.AutoSize = true;
            this.lblMarketPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.6F);
            this.lblMarketPrice.Location = new System.Drawing.Point(13, 86);
            this.lblMarketPrice.Name = "lblMarketPrice";
            this.lblMarketPrice.Size = new System.Drawing.Size(149, 18);
            this.lblMarketPrice.TabIndex = 3;
            this.lblMarketPrice.Text = "Current Market Price:";
            // 
            // lblStocks
            // 
            this.lblStocks.AutoSize = true;
            this.lblStocks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.6F);
            this.lblStocks.Location = new System.Drawing.Point(13, 118);
            this.lblStocks.Name = "lblStocks";
            this.lblStocks.Size = new System.Drawing.Size(186, 18);
            this.lblStocks.TabIndex = 4;
            this.lblStocks.Text = "Current Number of Stocks:";
            // 
            // lblFundName
            // 
            this.lblFundName.AutoSize = true;
            this.lblFundName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.6F);
            this.lblFundName.Location = new System.Drawing.Point(13, 147);
            this.lblFundName.Name = "lblFundName";
            this.lblFundName.Size = new System.Drawing.Size(116, 18);
            this.lblFundName.TabIndex = 5;
            this.lblFundName.Text = "Full Fund Name:";
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.6F);
            this.lblChange.Location = new System.Drawing.Point(13, 177);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(63, 18);
            this.lblChange.TabIndex = 6;
            this.lblChange.Text = "Change:";
            // 
            // lblObjective
            // 
            this.lblObjective.AutoSize = true;
            this.lblObjective.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.6F);
            this.lblObjective.Location = new System.Drawing.Point(13, 205);
            this.lblObjective.Name = "lblObjective";
            this.lblObjective.Size = new System.Drawing.Size(73, 18);
            this.lblObjective.TabIndex = 7;
            this.lblObjective.Text = "Objective:";
            // 
            // txtRisk
            // 
            this.txtRisk.Location = new System.Drawing.Point(201, 57);
            this.txtRisk.Name = "txtRisk";
            this.txtRisk.Size = new System.Drawing.Size(140, 20);
            this.txtRisk.TabIndex = 8;
            // 
            // txtMarketPrice
            // 
            this.txtMarketPrice.Location = new System.Drawing.Point(201, 86);
            this.txtMarketPrice.Name = "txtMarketPrice";
            this.txtMarketPrice.Size = new System.Drawing.Size(140, 20);
            this.txtMarketPrice.TabIndex = 9;
            // 
            // txtStocks
            // 
            this.txtStocks.Location = new System.Drawing.Point(201, 118);
            this.txtStocks.Name = "txtStocks";
            this.txtStocks.Size = new System.Drawing.Size(140, 20);
            this.txtStocks.TabIndex = 10;
            // 
            // txtFundName
            // 
            this.txtFundName.Location = new System.Drawing.Point(201, 147);
            this.txtFundName.Name = "txtFundName";
            this.txtFundName.Size = new System.Drawing.Size(140, 20);
            this.txtFundName.TabIndex = 11;
            // 
            // txtChange
            // 
            this.txtChange.Location = new System.Drawing.Point(201, 177);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(140, 20);
            this.txtChange.TabIndex = 12;
            // 
            // txtObjective
            // 
            this.txtObjective.Location = new System.Drawing.Point(16, 237);
            this.txtObjective.Multiline = true;
            this.txtObjective.Name = "txtObjective";
            this.txtObjective.Size = new System.Drawing.Size(325, 65);
            this.txtObjective.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblError);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnPopulate);
            this.panel2.Controls.Add(this.lstFunds);
            this.panel2.Location = new System.Drawing.Point(452, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(440, 317);
            this.panel2.TabIndex = 2;
            // 
            // lstFunds
            // 
            this.lstFunds.FormattingEnabled = true;
            this.lstFunds.Location = new System.Drawing.Point(35, 44);
            this.lstFunds.Name = "lstFunds";
            this.lstFunds.Size = new System.Drawing.Size(369, 121);
            this.lstFunds.TabIndex = 0;
            // 
            // btnPopulate
            // 
            this.btnPopulate.Location = new System.Drawing.Point(35, 194);
            this.btnPopulate.Name = "btnPopulate";
            this.btnPopulate.Size = new System.Drawing.Size(148, 40);
            this.btnPopulate.TabIndex = 1;
            this.btnPopulate.Text = "Populate";
            this.btnPopulate.UseVisualStyleBackColor = true;
            this.btnPopulate.Click += new System.EventHandler(this.btnPopulate_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(228, 194);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(148, 40);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(32, 16);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 15);
            this.lblError.TabIndex = 3;
            // 
            // lblError1
            // 
            this.lblError1.AutoSize = true;
            this.lblError1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.6F);
            this.lblError1.Location = new System.Drawing.Point(25, 400);
            this.lblError1.Name = "lblError1";
            this.lblError1.Size = new System.Drawing.Size(0, 18);
            this.lblError1.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(25, 441);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(148, 40);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(197, 441);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(148, 40);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(367, 441);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(148, 40);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // frmFunds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 524);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblError1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblManage);
            this.Controls.Add(this.panel1);
            this.Name = "frmFunds";
            this.Text = "frmFunds";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSymbol;
        private System.Windows.Forms.TextBox txtSymbol;
        private System.Windows.Forms.Label lblManage;
        private System.Windows.Forms.TextBox txtFundName;
        private System.Windows.Forms.TextBox txtStocks;
        private System.Windows.Forms.TextBox txtMarketPrice;
        private System.Windows.Forms.TextBox txtRisk;
        private System.Windows.Forms.Label lblObjective;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.Label lblFundName;
        private System.Windows.Forms.Label lblStocks;
        private System.Windows.Forms.Label lblMarketPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtChange;
        private System.Windows.Forms.TextBox txtObjective;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnPopulate;
        private System.Windows.Forms.ListBox lstFunds;
        private System.Windows.Forms.Label lblError1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}