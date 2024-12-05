namespace AppartmentSystem
{
    partial class Frm_Maintenance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Maintenance));
            this.dg_maintenance = new System.Windows.Forms.DataGridView();
            this.dg_roomNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_issue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_roomNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_cost = new System.Windows.Forms.Label();
            this.lbl_priority = new System.Windows.Forms.Label();
            this.txt_roomNo = new System.Windows.Forms.TextBox();
            this.txt_issue = new System.Windows.Forms.TextBox();
            this.txt_cost = new System.Windows.Forms.TextBox();
            this.txt_priority = new System.Windows.Forms.TextBox();
            this.btn_addMaintenance = new System.Windows.Forms.Button();
            this.btn_editMaintenance = new System.Windows.Forms.Button();
            this.btn_updateMaintenance = new System.Windows.Forms.Button();
            this.btn_deleteMaintenance = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_maintenance)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_maintenance
            // 
            this.dg_maintenance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_maintenance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_maintenance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dg_roomNo,
            this.dg_issue,
            this.dg_cost,
            this.dg_priority});
            this.dg_maintenance.Location = new System.Drawing.Point(35, 151);
            this.dg_maintenance.Name = "dg_maintenance";
            this.dg_maintenance.Size = new System.Drawing.Size(935, 459);
            this.dg_maintenance.TabIndex = 0;
            // 
            // dg_roomNo
            // 
            this.dg_roomNo.HeaderText = "Room No.";
            this.dg_roomNo.Name = "dg_roomNo";
            // 
            // dg_issue
            // 
            this.dg_issue.HeaderText = "Issue";
            this.dg_issue.Name = "dg_issue";
            // 
            // dg_cost
            // 
            this.dg_cost.HeaderText = "Cost ";
            this.dg_cost.Name = "dg_cost";
            // 
            // dg_priority
            // 
            this.dg_priority.HeaderText = "Priority";
            this.dg_priority.Name = "dg_priority";
            // 
            // lbl_roomNo
            // 
            this.lbl_roomNo.AutoSize = true;
            this.lbl_roomNo.Location = new System.Drawing.Point(79, 31);
            this.lbl_roomNo.Name = "lbl_roomNo";
            this.lbl_roomNo.Size = new System.Drawing.Size(55, 13);
            this.lbl_roomNo.TabIndex = 1;
            this.lbl_roomNo.Text = "Room No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Issue:";
            // 
            // lbl_cost
            // 
            this.lbl_cost.AutoSize = true;
            this.lbl_cost.Location = new System.Drawing.Point(526, 31);
            this.lbl_cost.Name = "lbl_cost";
            this.lbl_cost.Size = new System.Drawing.Size(31, 13);
            this.lbl_cost.TabIndex = 3;
            this.lbl_cost.Text = "Cost:";
            // 
            // lbl_priority
            // 
            this.lbl_priority.AutoSize = true;
            this.lbl_priority.Location = new System.Drawing.Point(516, 95);
            this.lbl_priority.Name = "lbl_priority";
            this.lbl_priority.Size = new System.Drawing.Size(41, 13);
            this.lbl_priority.TabIndex = 4;
            this.lbl_priority.Text = "Priority:";
            // 
            // txt_roomNo
            // 
            this.txt_roomNo.Location = new System.Drawing.Point(140, 24);
            this.txt_roomNo.Name = "txt_roomNo";
            this.txt_roomNo.Size = new System.Drawing.Size(100, 20);
            this.txt_roomNo.TabIndex = 5;
            // 
            // txt_issue
            // 
            this.txt_issue.Location = new System.Drawing.Point(140, 88);
            this.txt_issue.Name = "txt_issue";
            this.txt_issue.Size = new System.Drawing.Size(100, 20);
            this.txt_issue.TabIndex = 6;
            // 
            // txt_cost
            // 
            this.txt_cost.Location = new System.Drawing.Point(563, 24);
            this.txt_cost.Name = "txt_cost";
            this.txt_cost.Size = new System.Drawing.Size(100, 20);
            this.txt_cost.TabIndex = 7;
            // 
            // txt_priority
            // 
            this.txt_priority.Location = new System.Drawing.Point(563, 88);
            this.txt_priority.Name = "txt_priority";
            this.txt_priority.Size = new System.Drawing.Size(100, 20);
            this.txt_priority.TabIndex = 8;
            // 
            // btn_addMaintenance
            // 
            this.btn_addMaintenance.Image = ((System.Drawing.Image)(resources.GetObject("btn_addMaintenance.Image")));
            this.btn_addMaintenance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_addMaintenance.Location = new System.Drawing.Point(781, 90);
            this.btn_addMaintenance.Name = "btn_addMaintenance";
            this.btn_addMaintenance.Size = new System.Drawing.Size(83, 43);
            this.btn_addMaintenance.TabIndex = 9;
            this.btn_addMaintenance.Text = "    Add";
            this.btn_addMaintenance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addMaintenance.UseVisualStyleBackColor = true;
            // 
            // btn_editMaintenance
            // 
            this.btn_editMaintenance.Image = ((System.Drawing.Image)(resources.GetObject("btn_editMaintenance.Image")));
            this.btn_editMaintenance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_editMaintenance.Location = new System.Drawing.Point(870, 92);
            this.btn_editMaintenance.Name = "btn_editMaintenance";
            this.btn_editMaintenance.Size = new System.Drawing.Size(83, 43);
            this.btn_editMaintenance.TabIndex = 10;
            this.btn_editMaintenance.Text = "   Edit";
            this.btn_editMaintenance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_editMaintenance.UseVisualStyleBackColor = true;
            // 
            // btn_updateMaintenance
            // 
            this.btn_updateMaintenance.Image = ((System.Drawing.Image)(resources.GetObject("btn_updateMaintenance.Image")));
            this.btn_updateMaintenance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_updateMaintenance.Location = new System.Drawing.Point(781, 41);
            this.btn_updateMaintenance.Name = "btn_updateMaintenance";
            this.btn_updateMaintenance.Size = new System.Drawing.Size(83, 43);
            this.btn_updateMaintenance.TabIndex = 11;
            this.btn_updateMaintenance.Text = "Update";
            this.btn_updateMaintenance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_updateMaintenance.UseVisualStyleBackColor = true;
            // 
            // btn_deleteMaintenance
            // 
            this.btn_deleteMaintenance.Image = ((System.Drawing.Image)(resources.GetObject("btn_deleteMaintenance.Image")));
            this.btn_deleteMaintenance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_deleteMaintenance.Location = new System.Drawing.Point(870, 41);
            this.btn_deleteMaintenance.Name = "btn_deleteMaintenance";
            this.btn_deleteMaintenance.Size = new System.Drawing.Size(83, 43);
            this.btn_deleteMaintenance.TabIndex = 12;
            this.btn_deleteMaintenance.Text = "  Delete";
            this.btn_deleteMaintenance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_deleteMaintenance.UseVisualStyleBackColor = true;
            // 
            // Frm_Maintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btn_deleteMaintenance);
            this.Controls.Add(this.btn_updateMaintenance);
            this.Controls.Add(this.btn_editMaintenance);
            this.Controls.Add(this.btn_addMaintenance);
            this.Controls.Add(this.txt_priority);
            this.Controls.Add(this.txt_cost);
            this.Controls.Add(this.txt_issue);
            this.Controls.Add(this.txt_roomNo);
            this.Controls.Add(this.lbl_priority);
            this.Controls.Add(this.lbl_cost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_roomNo);
            this.Controls.Add(this.dg_maintenance);
            this.Name = "Frm_Maintenance";
            this.Text = "Maintenance";
            this.Load += new System.EventHandler(this.Maintenance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_maintenance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_maintenance;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_roomNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_issue;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_priority;
        private System.Windows.Forms.Label lbl_roomNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_cost;
        private System.Windows.Forms.Label lbl_priority;
        private System.Windows.Forms.TextBox txt_roomNo;
        private System.Windows.Forms.TextBox txt_issue;
        private System.Windows.Forms.TextBox txt_cost;
        private System.Windows.Forms.TextBox txt_priority;
        private System.Windows.Forms.Button btn_addMaintenance;
        private System.Windows.Forms.Button btn_editMaintenance;
        private System.Windows.Forms.Button btn_updateMaintenance;
        private System.Windows.Forms.Button btn_deleteMaintenance;
    }
}