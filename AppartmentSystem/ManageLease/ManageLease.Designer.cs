namespace AppartmentSystem
{
    partial class ManageLease
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageLease));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_roomNo = new System.Windows.Forms.Label();
            this.txtTenantName = new System.Windows.Forms.TextBox();
            this.lbl_tenantName = new System.Windows.Forms.Label();
            this.lbl_maintenanceCost = new System.Windows.Forms.Label();
            this.txtRoomBill = new System.Windows.Forms.TextBox();
            this.btn_renewalLease = new System.Windows.Forms.Button();
            this.btn_deleteLease = new System.Windows.Forms.Button();
            this.btn_updateLease = new System.Windows.Forms.Button();
            this.btn_editLease = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_roomNumberleaseOutput = new System.Windows.Forms.Label();
            this.btn_archiveLease = new System.Windows.Forms.Button();
            this.lbl_leaseStart = new System.Windows.Forms.Label();
            this.btn_mlBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(951, 538);
            this.dataGridView1.TabIndex = 0;
            // 
            // lbl_roomNo
            // 
            this.lbl_roomNo.AutoSize = true;
            this.lbl_roomNo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_roomNo.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_roomNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_roomNo.Location = new System.Drawing.Point(100, 34);
            this.lbl_roomNo.Name = "lbl_roomNo";
            this.lbl_roomNo.Size = new System.Drawing.Size(79, 17);
            this.lbl_roomNo.TabIndex = 1;
            this.lbl_roomNo.Text = "Room Number:";
            this.lbl_roomNo.Click += new System.EventHandler(this.lbl_roomNo_Click);
            // 
            // txtTenantName
            // 
            this.txtTenantName.Location = new System.Drawing.Point(177, 79);
            this.txtTenantName.Name = "txtTenantName";
            this.txtTenantName.Size = new System.Drawing.Size(100, 20);
            this.txtTenantName.TabIndex = 3;
            // 
            // lbl_tenantName
            // 
            this.lbl_tenantName.AutoSize = true;
            this.lbl_tenantName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tenantName.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tenantName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_tenantName.Location = new System.Drawing.Point(106, 79);
            this.lbl_tenantName.Name = "lbl_tenantName";
            this.lbl_tenantName.Size = new System.Drawing.Size(74, 17);
            this.lbl_tenantName.TabIndex = 4;
            this.lbl_tenantName.Text = "Tenant Name:";
            // 
            // lbl_maintenanceCost
            // 
            this.lbl_maintenanceCost.AutoSize = true;
            this.lbl_maintenanceCost.BackColor = System.Drawing.Color.Transparent;
            this.lbl_maintenanceCost.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maintenanceCost.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_maintenanceCost.Location = new System.Drawing.Point(300, 76);
            this.lbl_maintenanceCost.Name = "lbl_maintenanceCost";
            this.lbl_maintenanceCost.Size = new System.Drawing.Size(100, 17);
            this.lbl_maintenanceCost.TabIndex = 10;
            this.lbl_maintenanceCost.Text = "Maintenance Cost:\r\n";
            // 
            // txtRoomBill
            // 
            this.txtRoomBill.Location = new System.Drawing.Point(400, 75);
            this.txtRoomBill.Name = "txtRoomBill";
            this.txtRoomBill.Size = new System.Drawing.Size(126, 20);
            this.txtRoomBill.TabIndex = 12;
            // 
            // btn_renewalLease
            // 
            this.btn_renewalLease.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_renewalLease.BackColor = System.Drawing.Color.White;
            this.btn_renewalLease.Image = ((System.Drawing.Image)(resources.GetObject("btn_renewalLease.Image")));
            this.btn_renewalLease.Location = new System.Drawing.Point(772, 12);
            this.btn_renewalLease.Name = "btn_renewalLease";
            this.btn_renewalLease.Size = new System.Drawing.Size(85, 46);
            this.btn_renewalLease.TabIndex = 13;
            this.btn_renewalLease.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_renewalLease.UseVisualStyleBackColor = false;
            this.btn_renewalLease.Click += new System.EventHandler(this.btn_addLease_Click);
            // 
            // btn_deleteLease
            // 
            this.btn_deleteLease.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_deleteLease.Image = ((System.Drawing.Image)(resources.GetObject("btn_deleteLease.Image")));
            this.btn_deleteLease.Location = new System.Drawing.Point(772, 64);
            this.btn_deleteLease.Name = "btn_deleteLease";
            this.btn_deleteLease.Size = new System.Drawing.Size(85, 43);
            this.btn_deleteLease.TabIndex = 14;
            this.btn_deleteLease.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_deleteLease.UseVisualStyleBackColor = true;
            this.btn_deleteLease.Click += new System.EventHandler(this.btn_deleteLease_Click);
            // 
            // btn_updateLease
            // 
            this.btn_updateLease.Image = ((System.Drawing.Image)(resources.GetObject("btn_updateLease.Image")));
            this.btn_updateLease.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_updateLease.Location = new System.Drawing.Point(681, 103);
            this.btn_updateLease.Name = "btn_updateLease";
            this.btn_updateLease.Size = new System.Drawing.Size(85, 46);
            this.btn_updateLease.TabIndex = 15;
            this.btn_updateLease.Text = "Update";
            this.btn_updateLease.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_updateLease.UseVisualStyleBackColor = true;
            this.btn_updateLease.Visible = false;
            this.btn_updateLease.Click += new System.EventHandler(this.btn_updateLease_Click);
            // 
            // btn_editLease
            // 
            this.btn_editLease.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_editLease.Image = ((System.Drawing.Image)(resources.GetObject("btn_editLease.Image")));
            this.btn_editLease.Location = new System.Drawing.Point(866, 64);
            this.btn_editLease.Name = "btn_editLease";
            this.btn_editLease.Size = new System.Drawing.Size(85, 43);
            this.btn_editLease.TabIndex = 16;
            this.btn_editLease.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_editLease.UseVisualStyleBackColor = true;
            this.btn_editLease.Click += new System.EventHandler(this.btn_editLease_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(370, 29);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // lbl_roomNumberleaseOutput
            // 
            this.lbl_roomNumberleaseOutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_roomNumberleaseOutput.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_roomNumberleaseOutput.Location = new System.Drawing.Point(177, 32);
            this.lbl_roomNumberleaseOutput.Name = "lbl_roomNumberleaseOutput";
            this.lbl_roomNumberleaseOutput.Size = new System.Drawing.Size(100, 23);
            this.lbl_roomNumberleaseOutput.TabIndex = 18;
            // 
            // btn_archiveLease
            // 
            this.btn_archiveLease.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_archiveLease.Image = ((System.Drawing.Image)(resources.GetObject("btn_archiveLease.Image")));
            this.btn_archiveLease.Location = new System.Drawing.Point(866, 12);
            this.btn_archiveLease.Name = "btn_archiveLease";
            this.btn_archiveLease.Size = new System.Drawing.Size(85, 46);
            this.btn_archiveLease.TabIndex = 19;
            this.btn_archiveLease.UseVisualStyleBackColor = true;
            this.btn_archiveLease.Click += new System.EventHandler(this.btn_archiveLease_Click);
            // 
            // lbl_leaseStart
            // 
            this.lbl_leaseStart.AutoSize = true;
            this.lbl_leaseStart.BackColor = System.Drawing.Color.Transparent;
            this.lbl_leaseStart.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_leaseStart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_leaseStart.Location = new System.Drawing.Point(302, 32);
            this.lbl_leaseStart.Name = "lbl_leaseStart";
            this.lbl_leaseStart.Size = new System.Drawing.Size(67, 17);
            this.lbl_leaseStart.TabIndex = 20;
            this.lbl_leaseStart.Text = "Lease Start:";
            // 
            // btn_mlBack
            // 
            this.btn_mlBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_mlBack.BackgroundImage")));
            this.btn_mlBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_mlBack.Location = new System.Drawing.Point(13, 12);
            this.btn_mlBack.Name = "btn_mlBack";
            this.btn_mlBack.Size = new System.Drawing.Size(40, 35);
            this.btn_mlBack.TabIndex = 22;
            this.btn_mlBack.UseVisualStyleBackColor = true;
            // 
            // ManageLease
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btn_mlBack);
            this.Controls.Add(this.lbl_leaseStart);
            this.Controls.Add(this.btn_archiveLease);
            this.Controls.Add(this.lbl_roomNumberleaseOutput);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_editLease);
            this.Controls.Add(this.btn_updateLease);
            this.Controls.Add(this.btn_deleteLease);
            this.Controls.Add(this.btn_renewalLease);
            this.Controls.Add(this.txtRoomBill);
            this.Controls.Add(this.lbl_maintenanceCost);
            this.Controls.Add(this.lbl_tenantName);
            this.Controls.Add(this.txtTenantName);
            this.Controls.Add(this.lbl_roomNo);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ManageLease";
            this.Text = "ManageLease";
            this.Load += new System.EventHandler(this.ManageLease_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_roomNo;
        private System.Windows.Forms.TextBox txtTenantName;
        private System.Windows.Forms.Label lbl_tenantName;
        private System.Windows.Forms.Label lbl_maintenanceCost;
        private System.Windows.Forms.TextBox txtRoomBill;
        private System.Windows.Forms.Button btn_renewalLease;
        private System.Windows.Forms.Button btn_deleteLease;
        private System.Windows.Forms.Button btn_updateLease;
        private System.Windows.Forms.Button btn_editLease;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbl_roomNumberleaseOutput;
        private System.Windows.Forms.Button btn_archiveLease;
        private System.Windows.Forms.Label lbl_leaseStart;
        private System.Windows.Forms.Button btn_mlBack;
    }
}