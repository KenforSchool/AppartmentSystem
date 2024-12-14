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
            this.txt_fdtenantName = new System.Windows.Forms.TextBox();
            this.lbl_fdrentCost = new System.Windows.Forms.Label();
            this.lbl_fdmaintenanceCost = new System.Windows.Forms.Label();
            this.txt_fdrentCost = new System.Windows.Forms.TextBox();
            this.txt_fdmaintenanceCost = new System.Windows.Forms.TextBox();
            this.btn_fdAdd = new System.Windows.Forms.Button();
            this.btn_fdUpdate = new System.Windows.Forms.Button();
            this.btn_fdDelete = new System.Windows.Forms.Button();
            this.btn_fdBack = new System.Windows.Forms.Button();
            this.lbl_fdroomNumberOutput = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_fdPaid = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dg_fdroomNumber,
            this.dg_fdtenantName,
            this.dg_fdrentCost,
            this.dg_fdmaintenanceCost,
            this.dg_fdtotalCost});
            this.dataGridView1.Location = new System.Drawing.Point(55, 230);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1235, 523);
            this.dataGridView1.TabIndex = 0;
            // 
            // dg_fdroomNumber
            // 
            this.dg_fdroomNumber.HeaderText = "Room Number";
            this.dg_fdroomNumber.MinimumWidth = 6;
            this.dg_fdroomNumber.Name = "dg_fdroomNumber";
            // 
            // dg_fdtenantName
            // 
            this.dg_fdtenantName.HeaderText = "Tenant Name";
            this.dg_fdtenantName.MinimumWidth = 6;
            this.dg_fdtenantName.Name = "dg_fdtenantName";
            // 
            // dg_fdrentCost
            // 
            this.dg_fdrentCost.HeaderText = "Rent Cost";
            this.dg_fdrentCost.MinimumWidth = 6;
            this.dg_fdrentCost.Name = "dg_fdrentCost";
            // 
            // dg_fdmaintenanceCost
            // 
            this.dg_fdmaintenanceCost.HeaderText = "Maintenance Cost";
            this.dg_fdmaintenanceCost.MinimumWidth = 6;
            this.dg_fdmaintenanceCost.Name = "dg_fdmaintenanceCost";
            // 
            // dg_fdtotalCost
            // 
            this.dg_fdtotalCost.HeaderText = "Total Cost ";
            this.dg_fdtotalCost.MinimumWidth = 6;
            this.dg_fdtotalCost.Name = "dg_fdtotalCost";
            // 
            // lbl_fdroomNumber
            // 
            this.lbl_fdroomNumber.AutoSize = true;
            this.lbl_fdroomNumber.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fdroomNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fdroomNumber.Location = new System.Drawing.Point(55, 191);
            this.lbl_fdroomNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_fdroomNumber.Name = "lbl_fdroomNumber";
            this.lbl_fdroomNumber.Size = new System.Drawing.Size(129, 23);
            this.lbl_fdroomNumber.TabIndex = 1;
            this.lbl_fdroomNumber.Text = "Room Number:";
            // 
            // lbl_fdtenantName
            // 
            this.lbl_fdtenantName.AutoSize = true;
            this.lbl_fdtenantName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fdtenantName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fdtenantName.Location = new System.Drawing.Point(341, 191);
            this.lbl_fdtenantName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_fdtenantName.Name = "lbl_fdtenantName";
            this.lbl_fdtenantName.Size = new System.Drawing.Size(116, 23);
            this.lbl_fdtenantName.TabIndex = 2;
            this.lbl_fdtenantName.Text = "Tenant Name:";
            // 
            // txt_fdtenantName
            // 
            this.txt_fdtenantName.Location = new System.Drawing.Point(472, 191);
            this.txt_fdtenantName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_fdtenantName.Name = "txt_fdtenantName";
            this.txt_fdtenantName.Size = new System.Drawing.Size(132, 22);
            this.txt_fdtenantName.TabIndex = 4;
            // 
            // lbl_fdrentCost
            // 
            this.lbl_fdrentCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_fdrentCost.AutoSize = true;
            this.lbl_fdrentCost.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fdrentCost.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fdrentCost.Location = new System.Drawing.Point(695, 191);
            this.lbl_fdrentCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_fdrentCost.Name = "lbl_fdrentCost";
            this.lbl_fdrentCost.Size = new System.Drawing.Size(89, 23);
            this.lbl_fdrentCost.TabIndex = 5;
            this.lbl_fdrentCost.Text = "Rent Cost:";
            // 
            // lbl_fdmaintenanceCost
            // 
            this.lbl_fdmaintenanceCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_fdmaintenanceCost.AutoSize = true;
            this.lbl_fdmaintenanceCost.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fdmaintenanceCost.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fdmaintenanceCost.Location = new System.Drawing.Point(1003, 191);
            this.lbl_fdmaintenanceCost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_fdmaintenanceCost.Name = "lbl_fdmaintenanceCost";
            this.lbl_fdmaintenanceCost.Size = new System.Drawing.Size(153, 23);
            this.lbl_fdmaintenanceCost.TabIndex = 6;
            this.lbl_fdmaintenanceCost.Text = "Maintenance Cost:";
            // 
            // txt_fdrentCost
            // 
            this.txt_fdrentCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_fdrentCost.Location = new System.Drawing.Point(796, 190);
            this.txt_fdrentCost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_fdrentCost.Name = "txt_fdrentCost";
            this.txt_fdrentCost.Size = new System.Drawing.Size(132, 22);
            this.txt_fdrentCost.TabIndex = 7;
            // 
            // txt_fdmaintenanceCost
            // 
            this.txt_fdmaintenanceCost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_fdmaintenanceCost.Location = new System.Drawing.Point(1156, 191);
            this.txt_fdmaintenanceCost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_fdmaintenanceCost.Name = "txt_fdmaintenanceCost";
            this.txt_fdmaintenanceCost.Size = new System.Drawing.Size(132, 22);
            this.txt_fdmaintenanceCost.TabIndex = 8;
            // 
            // btn_fdAdd
            // 
            this.btn_fdAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_fdAdd.BackColor = System.Drawing.Color.LightCyan;
            this.btn_fdAdd.FlatAppearance.BorderSize = 0;
            this.btn_fdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fdAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fdAdd.Image = ((System.Drawing.Image)(resources.GetObject("btn_fdAdd.Image")));
            this.btn_fdAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_fdAdd.Location = new System.Drawing.Point(859, 92);
            this.btn_fdAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_fdAdd.Name = "btn_fdAdd";
            this.btn_fdAdd.Size = new System.Drawing.Size(140, 57);
            this.btn_fdAdd.TabIndex = 9;
            this.btn_fdAdd.Text = "     Add";
            this.btn_fdAdd.UseVisualStyleBackColor = false;
            this.btn_fdAdd.Click += new System.EventHandler(this.btn_fdAdd_Click);
            // 
            // btn_fdUpdate
            // 
            this.btn_fdUpdate.Location = new System.Drawing.Point(1297, 356);
            this.btn_fdUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_fdUpdate.Name = "btn_fdUpdate";
            this.btn_fdUpdate.Size = new System.Drawing.Size(44, 41);
            this.btn_fdUpdate.TabIndex = 11;
            this.btn_fdUpdate.Text = "Update";
            this.btn_fdUpdate.UseVisualStyleBackColor = true;
            this.btn_fdUpdate.Visible = false;
            this.btn_fdUpdate.Click += new System.EventHandler(this.btn_fdUpdate_Click);
            // 
            // btn_fdDelete
            // 
            this.btn_fdDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_fdDelete.BackColor = System.Drawing.Color.LightCyan;
            this.btn_fdDelete.FlatAppearance.BorderSize = 0;
            this.btn_fdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fdDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fdDelete.Image = ((System.Drawing.Image)(resources.GetObject("btn_fdDelete.Image")));
            this.btn_fdDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_fdDelete.Location = new System.Drawing.Point(1007, 92);
            this.btn_fdDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_fdDelete.Name = "btn_fdDelete";
            this.btn_fdDelete.Size = new System.Drawing.Size(140, 57);
            this.btn_fdDelete.TabIndex = 12;
            this.btn_fdDelete.Text = "      Delete";
            this.btn_fdDelete.UseVisualStyleBackColor = false;
            // 
            // btn_fdBack
            // 
            this.btn_fdBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_fdBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_fdBack.BackgroundImage")));
            this.btn_fdBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_fdBack.Location = new System.Drawing.Point(1236, 15);
            this.btn_fdBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_fdBack.Name = "btn_fdBack";
            this.btn_fdBack.Size = new System.Drawing.Size(53, 43);
            this.btn_fdBack.TabIndex = 13;
            this.btn_fdBack.UseVisualStyleBackColor = true;
            // 
            // lbl_fdroomNumberOutput
            // 
            this.lbl_fdroomNumberOutput.Location = new System.Drawing.Point(199, 191);
            this.lbl_fdroomNumberOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_fdroomNumberOutput.Name = "lbl_fdroomNumberOutput";
            this.lbl_fdroomNumberOutput.Size = new System.Drawing.Size(133, 25);
            this.lbl_fdroomNumberOutput.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 54);
            this.label1.TabIndex = 15;
            this.label1.Text = "Financial Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Can track and edit finances";
            // 
            // btn_fdPaid
            // 
            this.btn_fdPaid.BackColor = System.Drawing.Color.LightCyan;
            this.btn_fdPaid.FlatAppearance.BorderSize = 0;
            this.btn_fdPaid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fdPaid.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fdPaid.Image = ((System.Drawing.Image)(resources.GetObject("btn_fdPaid.Image")));
            this.btn_fdPaid.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_fdPaid.Location = new System.Drawing.Point(1155, 92);
            this.btn_fdPaid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_fdPaid.Name = "btn_fdPaid";
            this.btn_fdPaid.Size = new System.Drawing.Size(140, 57);
            this.btn_fdPaid.TabIndex = 17;
            this.btn_fdPaid.Text = "    Paid";
            this.btn_fdPaid.UseVisualStyleBackColor = false;
            // 
            // frm_financialData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1344, 897);
            this.Controls.Add(this.btn_fdPaid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_fdroomNumberOutput);
            this.Controls.Add(this.btn_fdBack);
            this.Controls.Add(this.btn_fdDelete);
            this.Controls.Add(this.btn_fdUpdate);
            this.Controls.Add(this.btn_fdAdd);
            this.Controls.Add(this.txt_fdmaintenanceCost);
            this.Controls.Add(this.txt_fdrentCost);
            this.Controls.Add(this.lbl_fdmaintenanceCost);
            this.Controls.Add(this.lbl_fdrentCost);
            this.Controls.Add(this.txt_fdtenantName);
            this.Controls.Add(this.lbl_fdtenantName);
            this.Controls.Add(this.lbl_fdroomNumber);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_financialData";
            this.Text = "FinancialData";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_financialData_Load);
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
        private System.Windows.Forms.TextBox txt_fdtenantName;
        private System.Windows.Forms.Label lbl_fdrentCost;
        private System.Windows.Forms.Label lbl_fdmaintenanceCost;
        private System.Windows.Forms.TextBox txt_fdrentCost;
        private System.Windows.Forms.TextBox txt_fdmaintenanceCost;
        private System.Windows.Forms.Button btn_fdAdd;
        private System.Windows.Forms.Button btn_fdUpdate;
        private System.Windows.Forms.Button btn_fdDelete;
        private System.Windows.Forms.Button btn_fdBack;
        private System.Windows.Forms.Label lbl_fdroomNumberOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_fdPaid;
    }
}