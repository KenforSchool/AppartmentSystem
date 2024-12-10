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
            this.lbl_roomNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_cost = new System.Windows.Forms.Label();
            this.lbl_priority = new System.Windows.Forms.Label();
            this.txt_issue = new System.Windows.Forms.TextBox();
            this.txt_cost = new System.Windows.Forms.TextBox();
            this.txt_priority = new System.Windows.Forms.TextBox();
            this.btn_addMaintenance = new System.Windows.Forms.Button();
            this.btn_editMaintenance = new System.Windows.Forms.Button();
            this.btn_updateMaintenance = new System.Windows.Forms.Button();
            this.btn_deleteMaintenance = new System.Windows.Forms.Button();
            this.lbl_maintenanceRoomOutput = new System.Windows.Forms.Label();
            this.btn_maintenanceBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_maintenance)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_maintenance
            // 
            this.dg_maintenance.AllowUserToOrderColumns = true;
            this.dg_maintenance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_maintenance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_maintenance.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dg_maintenance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_maintenance.Location = new System.Drawing.Point(35, 151);
            this.dg_maintenance.Name = "dg_maintenance";
            this.dg_maintenance.Size = new System.Drawing.Size(935, 459);
            this.dg_maintenance.TabIndex = 0;
            // 
            // lbl_roomNo
            // 
            this.lbl_roomNo.AutoSize = true;
            this.lbl_roomNo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_roomNo.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_roomNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_roomNo.Location = new System.Drawing.Point(144, 31);
            this.lbl_roomNo.Name = "lbl_roomNo";
            this.lbl_roomNo.Size = new System.Drawing.Size(54, 17);
            this.lbl_roomNo.TabIndex = 1;
            this.lbl_roomNo.Text = "Room No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(164, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Issue:";
            // 
            // lbl_cost
            // 
            this.lbl_cost.AutoSize = true;
            this.lbl_cost.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cost.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cost.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_cost.Location = new System.Drawing.Point(346, 30);
            this.lbl_cost.Name = "lbl_cost";
            this.lbl_cost.Size = new System.Drawing.Size(33, 17);
            this.lbl_cost.TabIndex = 3;
            this.lbl_cost.Text = "Cost:";
            // 
            // lbl_priority
            // 
            this.lbl_priority.AutoSize = true;
            this.lbl_priority.BackColor = System.Drawing.Color.Transparent;
            this.lbl_priority.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_priority.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_priority.Location = new System.Drawing.Point(336, 94);
            this.lbl_priority.Name = "lbl_priority";
            this.lbl_priority.Size = new System.Drawing.Size(47, 17);
            this.lbl_priority.TabIndex = 4;
            this.lbl_priority.Text = "Priority:";
            // 
            // txt_issue
            // 
            this.txt_issue.Location = new System.Drawing.Point(205, 92);
            this.txt_issue.Name = "txt_issue";
            this.txt_issue.Size = new System.Drawing.Size(100, 20);
            this.txt_issue.TabIndex = 6;
            // 
            // txt_cost
            // 
            this.txt_cost.Location = new System.Drawing.Point(383, 30);
            this.txt_cost.Name = "txt_cost";
            this.txt_cost.Size = new System.Drawing.Size(100, 20);
            this.txt_cost.TabIndex = 7;
            // 
            // txt_priority
            // 
            this.txt_priority.Location = new System.Drawing.Point(383, 93);
            this.txt_priority.Name = "txt_priority";
            this.txt_priority.Size = new System.Drawing.Size(100, 20);
            this.txt_priority.TabIndex = 8;
            // 
            // btn_addMaintenance
            // 
            this.btn_addMaintenance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addMaintenance.Image = ((System.Drawing.Image)(resources.GetObject("btn_addMaintenance.Image")));
            this.btn_addMaintenance.Location = new System.Drawing.Point(695, 49);
            this.btn_addMaintenance.Name = "btn_addMaintenance";
            this.btn_addMaintenance.Size = new System.Drawing.Size(83, 43);
            this.btn_addMaintenance.TabIndex = 9;
            this.btn_addMaintenance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addMaintenance.UseVisualStyleBackColor = true;
            this.btn_addMaintenance.Click += new System.EventHandler(this.btn_addMaintenance_Click);
            // 
            // btn_editMaintenance
            // 
            this.btn_editMaintenance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_editMaintenance.Image = ((System.Drawing.Image)(resources.GetObject("btn_editMaintenance.Image")));
            this.btn_editMaintenance.Location = new System.Drawing.Point(873, 49);
            this.btn_editMaintenance.Name = "btn_editMaintenance";
            this.btn_editMaintenance.Size = new System.Drawing.Size(83, 43);
            this.btn_editMaintenance.TabIndex = 10;
            this.btn_editMaintenance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_editMaintenance.UseVisualStyleBackColor = true;
            // 
            // btn_updateMaintenance
            // 
            this.btn_updateMaintenance.Image = ((System.Drawing.Image)(resources.GetObject("btn_updateMaintenance.Image")));
            this.btn_updateMaintenance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_updateMaintenance.Location = new System.Drawing.Point(556, 95);
            this.btn_updateMaintenance.Name = "btn_updateMaintenance";
            this.btn_updateMaintenance.Size = new System.Drawing.Size(83, 43);
            this.btn_updateMaintenance.TabIndex = 11;
            this.btn_updateMaintenance.Text = "Update";
            this.btn_updateMaintenance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_updateMaintenance.UseVisualStyleBackColor = true;
            this.btn_updateMaintenance.Visible = false;
            // 
            // btn_deleteMaintenance
            // 
            this.btn_deleteMaintenance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_deleteMaintenance.Image = ((System.Drawing.Image)(resources.GetObject("btn_deleteMaintenance.Image")));
            this.btn_deleteMaintenance.Location = new System.Drawing.Point(784, 49);
            this.btn_deleteMaintenance.Name = "btn_deleteMaintenance";
            this.btn_deleteMaintenance.Size = new System.Drawing.Size(83, 43);
            this.btn_deleteMaintenance.TabIndex = 12;
            this.btn_deleteMaintenance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_deleteMaintenance.UseVisualStyleBackColor = true;
            // 
            // lbl_maintenanceRoomOutput
            // 
            this.lbl_maintenanceRoomOutput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_maintenanceRoomOutput.Location = new System.Drawing.Point(202, 28);
            this.lbl_maintenanceRoomOutput.Name = "lbl_maintenanceRoomOutput";
            this.lbl_maintenanceRoomOutput.Size = new System.Drawing.Size(100, 20);
            this.lbl_maintenanceRoomOutput.TabIndex = 13;
            // 
            // btn_maintenanceBack
            // 
            this.btn_maintenanceBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_maintenanceBack.BackgroundImage")));
            this.btn_maintenanceBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_maintenanceBack.Location = new System.Drawing.Point(12, 11);
            this.btn_maintenanceBack.Name = "btn_maintenanceBack";
            this.btn_maintenanceBack.Size = new System.Drawing.Size(40, 35);
            this.btn_maintenanceBack.TabIndex = 14;
            this.btn_maintenanceBack.UseVisualStyleBackColor = true;
            // 
            // Frm_Maintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btn_maintenanceBack);
            this.Controls.Add(this.lbl_maintenanceRoomOutput);
            this.Controls.Add(this.btn_deleteMaintenance);
            this.Controls.Add(this.btn_updateMaintenance);
            this.Controls.Add(this.btn_editMaintenance);
            this.Controls.Add(this.btn_addMaintenance);
            this.Controls.Add(this.txt_priority);
            this.Controls.Add(this.txt_cost);
            this.Controls.Add(this.txt_issue);
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
        private System.Windows.Forms.Label lbl_roomNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_cost;
        private System.Windows.Forms.Label lbl_priority;
        private System.Windows.Forms.TextBox txt_issue;
        private System.Windows.Forms.TextBox txt_cost;
        private System.Windows.Forms.TextBox txt_priority;
        private System.Windows.Forms.Button btn_addMaintenance;
        private System.Windows.Forms.Button btn_editMaintenance;
        private System.Windows.Forms.Button btn_updateMaintenance;
        private System.Windows.Forms.Button btn_deleteMaintenance;
        private System.Windows.Forms.Label lbl_maintenanceRoomOutput;
        private System.Windows.Forms.Button btn_maintenanceBack;
    }
}