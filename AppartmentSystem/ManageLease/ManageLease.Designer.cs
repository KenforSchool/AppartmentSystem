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
            this.lbl_electricBill = new System.Windows.Forms.Label();
            this.lbl_waterBill = new System.Windows.Forms.Label();
            this.txtElectricBill = new System.Windows.Forms.TextBox();
            this.txtWaterBill = new System.Windows.Forms.TextBox();
            this.lbl_wifiBill = new System.Windows.Forms.Label();
            this.lbl_maintenanceCost = new System.Windows.Forms.Label();
            this.txt_wifiBill = new System.Windows.Forms.TextBox();
            this.txtRoomBill = new System.Windows.Forms.TextBox();
            this.btn_addLease = new System.Windows.Forms.Button();
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
            this.dataGridView1.Size = new System.Drawing.Size(951, 423);
            this.dataGridView1.TabIndex = 0;
            // 
            // lbl_roomNo
            // 
            this.lbl_roomNo.AutoSize = true;
            this.lbl_roomNo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_roomNo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_roomNo.Location = new System.Drawing.Point(100, 34);
            this.lbl_roomNo.Name = "lbl_roomNo";
            this.lbl_roomNo.Size = new System.Drawing.Size(78, 13);
            this.lbl_roomNo.TabIndex = 1;
            this.lbl_roomNo.Text = "Room Number:";
            this.lbl_roomNo.Click += new System.EventHandler(this.lbl_roomNo_Click);
            // 
            // txtTenantName
            // 
            this.txtTenantName.Location = new System.Drawing.Point(187, 72);
            this.txtTenantName.Name = "txtTenantName";
            this.txtTenantName.Size = new System.Drawing.Size(100, 20);
            this.txtTenantName.TabIndex = 3;
            // 
            // lbl_tenantName
            // 
            this.lbl_tenantName.AutoSize = true;
            this.lbl_tenantName.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tenantName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_tenantName.Location = new System.Drawing.Point(106, 79);
            this.lbl_tenantName.Name = "lbl_tenantName";
            this.lbl_tenantName.Size = new System.Drawing.Size(75, 13);
            this.lbl_tenantName.TabIndex = 4;
            this.lbl_tenantName.Text = "Tenant Name:";
            // 
            // lbl_electricBill
            // 
            this.lbl_electricBill.AutoSize = true;
            this.lbl_electricBill.BackColor = System.Drawing.Color.Transparent;
            this.lbl_electricBill.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_electricBill.Location = new System.Drawing.Point(304, 32);
            this.lbl_electricBill.Name = "lbl_electricBill";
            this.lbl_electricBill.Size = new System.Drawing.Size(58, 13);
            this.lbl_electricBill.TabIndex = 5;
            this.lbl_electricBill.Text = "Electric Bill";
            // 
            // lbl_waterBill
            // 
            this.lbl_waterBill.AutoSize = true;
            this.lbl_waterBill.BackColor = System.Drawing.Color.Transparent;
            this.lbl_waterBill.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_waterBill.Location = new System.Drawing.Point(307, 79);
            this.lbl_waterBill.Name = "lbl_waterBill";
            this.lbl_waterBill.Size = new System.Drawing.Size(51, 13);
            this.lbl_waterBill.TabIndex = 6;
            this.lbl_waterBill.Text = "Water bill";
            // 
            // txtElectricBill
            // 
            this.txtElectricBill.Location = new System.Drawing.Point(368, 29);
            this.txtElectricBill.Name = "txtElectricBill";
            this.txtElectricBill.Size = new System.Drawing.Size(100, 20);
            this.txtElectricBill.TabIndex = 7;
            // 
            // txtWaterBill
            // 
            this.txtWaterBill.Location = new System.Drawing.Point(369, 72);
            this.txtWaterBill.Name = "txtWaterBill";
            this.txtWaterBill.Size = new System.Drawing.Size(100, 20);
            this.txtWaterBill.TabIndex = 8;
            // 
            // lbl_wifiBill
            // 
            this.lbl_wifiBill.AutoSize = true;
            this.lbl_wifiBill.BackColor = System.Drawing.Color.Transparent;
            this.lbl_wifiBill.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_wifiBill.Location = new System.Drawing.Point(515, 31);
            this.lbl_wifiBill.Name = "lbl_wifiBill";
            this.lbl_wifiBill.Size = new System.Drawing.Size(41, 13);
            this.lbl_wifiBill.TabIndex = 9;
            this.lbl_wifiBill.Text = "Wifi Bill";
            // 
            // lbl_maintenanceCost
            // 
            this.lbl_maintenanceCost.AutoSize = true;
            this.lbl_maintenanceCost.BackColor = System.Drawing.Color.Transparent;
            this.lbl_maintenanceCost.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_maintenanceCost.Location = new System.Drawing.Point(518, 79);
            this.lbl_maintenanceCost.Name = "lbl_maintenanceCost";
            this.lbl_maintenanceCost.Size = new System.Drawing.Size(93, 13);
            this.lbl_maintenanceCost.TabIndex = 10;
            this.lbl_maintenanceCost.Text = "Maintenance Cost";
            // 
            // txt_wifiBill
            // 
            this.txt_wifiBill.Location = new System.Drawing.Point(563, 32);
            this.txt_wifiBill.Name = "txt_wifiBill";
            this.txt_wifiBill.Size = new System.Drawing.Size(170, 20);
            this.txt_wifiBill.TabIndex = 11;
            // 
            // txtRoomBill
            // 
            this.txtRoomBill.Location = new System.Drawing.Point(618, 79);
            this.txtRoomBill.Name = "txtRoomBill";
            this.txtRoomBill.Size = new System.Drawing.Size(115, 20);
            this.txtRoomBill.TabIndex = 12;
            // 
            // btn_addLease
            // 
            this.btn_addLease.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addLease.BackColor = System.Drawing.Color.White;
            this.btn_addLease.Image = ((System.Drawing.Image)(resources.GetObject("btn_addLease.Image")));
            this.btn_addLease.Location = new System.Drawing.Point(772, 12);
            this.btn_addLease.Name = "btn_addLease";
            this.btn_addLease.Size = new System.Drawing.Size(85, 46);
            this.btn_addLease.TabIndex = 13;
            this.btn_addLease.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addLease.UseVisualStyleBackColor = false;
            this.btn_addLease.Click += new System.EventHandler(this.btn_addLease_Click);
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
            this.dateTimePicker1.Location = new System.Drawing.Point(187, 114);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // lbl_roomNumberleaseOutput
            // 
            this.lbl_roomNumberleaseOutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_roomNumberleaseOutput.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_roomNumberleaseOutput.Location = new System.Drawing.Point(187, 29);
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
            this.lbl_leaseStart.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_leaseStart.Location = new System.Drawing.Point(114, 119);
            this.lbl_leaseStart.Name = "lbl_leaseStart";
            this.lbl_leaseStart.Size = new System.Drawing.Size(64, 13);
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
            this.Controls.Add(this.btn_addLease);
            this.Controls.Add(this.txtRoomBill);
            this.Controls.Add(this.txt_wifiBill);
            this.Controls.Add(this.lbl_maintenanceCost);
            this.Controls.Add(this.lbl_wifiBill);
            this.Controls.Add(this.txtWaterBill);
            this.Controls.Add(this.txtElectricBill);
            this.Controls.Add(this.lbl_waterBill);
            this.Controls.Add(this.lbl_electricBill);
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
        private System.Windows.Forms.Label lbl_electricBill;
        private System.Windows.Forms.Label lbl_waterBill;
        private System.Windows.Forms.TextBox txtElectricBill;
        private System.Windows.Forms.TextBox txtWaterBill;
        private System.Windows.Forms.Label lbl_wifiBill;
        private System.Windows.Forms.Label lbl_maintenanceCost;
        private System.Windows.Forms.TextBox txt_wifiBill;
        private System.Windows.Forms.TextBox txtRoomBill;
        private System.Windows.Forms.Button btn_addLease;
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