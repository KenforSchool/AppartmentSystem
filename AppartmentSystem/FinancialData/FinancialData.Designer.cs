namespace AppartmentSystem
{
    partial class frm_financialData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_financialData));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dg_fdroomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_fdtenantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_fdrentCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_fdmaintenanceCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_fdtotalCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_fdroomNumber = new System.Windows.Forms.Label();
            this.lbl_fdtenantName = new System.Windows.Forms.Label();
            this.txt_fdroomNumber = new System.Windows.Forms.TextBox();
            this.txt_fdtenantName = new System.Windows.Forms.TextBox();
            this.lbl_fdrentCost = new System.Windows.Forms.Label();
            this.lbl_fdmaintenanceCost = new System.Windows.Forms.Label();
            this.txt_fdrentCost = new System.Windows.Forms.TextBox();
            this.txt_fdmaintenanceCost = new System.Windows.Forms.TextBox();
            this.btn_fdAdd = new System.Windows.Forms.Button();
            this.btn_fdEdit = new System.Windows.Forms.Button();
            this.btn_fdUpdate = new System.Windows.Forms.Button();
            this.btn_fdDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dg_fdroomNumber,
            this.dg_fdtenantName,
            this.dg_fdrentCost,
            this.dg_fdmaintenanceCost,
            this.dg_fdtotalCost});
            this.dataGridView1.Location = new System.Drawing.Point(41, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(906, 470);
            this.dataGridView1.TabIndex = 0;
            // 
            // dg_fdroomNumber
            // 
            this.dg_fdroomNumber.HeaderText = "Room Number";
            this.dg_fdroomNumber.Name = "dg_fdroomNumber";
            // 
            // dg_fdtenantName
            // 
            this.dg_fdtenantName.HeaderText = "Tenant Name";
            this.dg_fdtenantName.Name = "dg_fdtenantName";
            // 
            // dg_fdrentCost
            // 
            this.dg_fdrentCost.HeaderText = "Rent Cost";
            this.dg_fdrentCost.Name = "dg_fdrentCost";
            // 
            // dg_fdmaintenanceCost
            // 
            this.dg_fdmaintenanceCost.HeaderText = "Maintenance Cost";
            this.dg_fdmaintenanceCost.Name = "dg_fdmaintenanceCost";
            // 
            // dg_fdtotalCost
            // 
            this.dg_fdtotalCost.HeaderText = "Total Cost ";
            this.dg_fdtotalCost.Name = "dg_fdtotalCost";
            // 
            // lbl_fdroomNumber
            // 
            this.lbl_fdroomNumber.AutoSize = true;
            this.lbl_fdroomNumber.Location = new System.Drawing.Point(87, 30);
            this.lbl_fdroomNumber.Name = "lbl_fdroomNumber";
            this.lbl_fdroomNumber.Size = new System.Drawing.Size(78, 13);
            this.lbl_fdroomNumber.TabIndex = 1;
            this.lbl_fdroomNumber.Text = "Room Number:";
            // 
            // lbl_fdtenantName
            // 
            this.lbl_fdtenantName.AutoSize = true;
            this.lbl_fdtenantName.Location = new System.Drawing.Point(90, 79);
            this.lbl_fdtenantName.Name = "lbl_fdtenantName";
            this.lbl_fdtenantName.Size = new System.Drawing.Size(75, 13);
            this.lbl_fdtenantName.TabIndex = 2;
            this.lbl_fdtenantName.Text = "Tenant Name:";
            // 
            // txt_fdroomNumber
            // 
            this.txt_fdroomNumber.Location = new System.Drawing.Point(171, 27);
            this.txt_fdroomNumber.Name = "txt_fdroomNumber";
            this.txt_fdroomNumber.Size = new System.Drawing.Size(100, 20);
            this.txt_fdroomNumber.TabIndex = 3;
            // 
            // txt_fdtenantName
            // 
            this.txt_fdtenantName.Location = new System.Drawing.Point(171, 72);
            this.txt_fdtenantName.Name = "txt_fdtenantName";
            this.txt_fdtenantName.Size = new System.Drawing.Size(100, 20);
            this.txt_fdtenantName.TabIndex = 4;
            // 
            // lbl_fdrentCost
            // 
            this.lbl_fdrentCost.AutoSize = true;
            this.lbl_fdrentCost.Location = new System.Drawing.Point(335, 30);
            this.lbl_fdrentCost.Name = "lbl_fdrentCost";
            this.lbl_fdrentCost.Size = new System.Drawing.Size(57, 13);
            this.lbl_fdrentCost.TabIndex = 5;
            this.lbl_fdrentCost.Text = "Rent Cost:";
            // 
            // lbl_fdmaintenanceCost
            // 
            this.lbl_fdmaintenanceCost.AutoSize = true;
            this.lbl_fdmaintenanceCost.Location = new System.Drawing.Point(335, 76);
            this.lbl_fdmaintenanceCost.Name = "lbl_fdmaintenanceCost";
            this.lbl_fdmaintenanceCost.Size = new System.Drawing.Size(96, 13);
            this.lbl_fdmaintenanceCost.TabIndex = 6;
            this.lbl_fdmaintenanceCost.Text = "Maintenance Cost:";
            // 
            // txt_fdrentCost
            // 
            this.txt_fdrentCost.Location = new System.Drawing.Point(399, 27);
            this.txt_fdrentCost.Name = "txt_fdrentCost";
            this.txt_fdrentCost.Size = new System.Drawing.Size(100, 20);
            this.txt_fdrentCost.TabIndex = 7;
            // 
            // txt_fdmaintenanceCost
            // 
            this.txt_fdmaintenanceCost.Location = new System.Drawing.Point(437, 69);
            this.txt_fdmaintenanceCost.Name = "txt_fdmaintenanceCost";
            this.txt_fdmaintenanceCost.Size = new System.Drawing.Size(100, 20);
            this.txt_fdmaintenanceCost.TabIndex = 8;
            // 
            // btn_fdAdd
            // 
            this.btn_fdAdd.Location = new System.Drawing.Point(762, 12);
            this.btn_fdAdd.Name = "btn_fdAdd";
            this.btn_fdAdd.Size = new System.Drawing.Size(85, 46);
            this.btn_fdAdd.TabIndex = 9;
            this.btn_fdAdd.Text = "Add";
            this.btn_fdAdd.UseVisualStyleBackColor = true;
            // 
            // btn_fdEdit
            // 
            this.btn_fdEdit.Location = new System.Drawing.Point(762, 72);
            this.btn_fdEdit.Name = "btn_fdEdit";
            this.btn_fdEdit.Size = new System.Drawing.Size(85, 46);
            this.btn_fdEdit.TabIndex = 10;
            this.btn_fdEdit.Text = "Edit";
            this.btn_fdEdit.UseVisualStyleBackColor = true;
            // 
            // btn_fdUpdate
            // 
            this.btn_fdUpdate.Location = new System.Drawing.Point(862, 12);
            this.btn_fdUpdate.Name = "btn_fdUpdate";
            this.btn_fdUpdate.Size = new System.Drawing.Size(85, 46);
            this.btn_fdUpdate.TabIndex = 11;
            this.btn_fdUpdate.Text = "Update";
            this.btn_fdUpdate.UseVisualStyleBackColor = true;
            // 
            // btn_fdDelete
            // 
            this.btn_fdDelete.Location = new System.Drawing.Point(863, 72);
            this.btn_fdDelete.Name = "btn_fdDelete";
            this.btn_fdDelete.Size = new System.Drawing.Size(85, 46);
            this.btn_fdDelete.TabIndex = 12;
            this.btn_fdDelete.Text = "Delete";
            this.btn_fdDelete.UseVisualStyleBackColor = true;
            // 
            // frm_financialData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btn_fdDelete);
            this.Controls.Add(this.btn_fdUpdate);
            this.Controls.Add(this.btn_fdEdit);
            this.Controls.Add(this.btn_fdAdd);
            this.Controls.Add(this.txt_fdmaintenanceCost);
            this.Controls.Add(this.txt_fdrentCost);
            this.Controls.Add(this.lbl_fdmaintenanceCost);
            this.Controls.Add(this.lbl_fdrentCost);
            this.Controls.Add(this.txt_fdtenantName);
            this.Controls.Add(this.txt_fdroomNumber);
            this.Controls.Add(this.lbl_fdtenantName);
            this.Controls.Add(this.lbl_fdroomNumber);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frm_financialData";
            this.Text = "FinancialData";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_fdroomNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_fdtenantName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_fdrentCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_fdmaintenanceCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_fdtotalCost;
        private System.Windows.Forms.Label lbl_fdroomNumber;
        private System.Windows.Forms.Label lbl_fdtenantName;
        private System.Windows.Forms.TextBox txt_fdroomNumber;
        private System.Windows.Forms.TextBox txt_fdtenantName;
        private System.Windows.Forms.Label lbl_fdrentCost;
        private System.Windows.Forms.Label lbl_fdmaintenanceCost;
        private System.Windows.Forms.TextBox txt_fdrentCost;
        private System.Windows.Forms.TextBox txt_fdmaintenanceCost;
        private System.Windows.Forms.Button btn_fdAdd;
        private System.Windows.Forms.Button btn_fdEdit;
        private System.Windows.Forms.Button btn_fdUpdate;
        private System.Windows.Forms.Button btn_fdDelete;
    }
}