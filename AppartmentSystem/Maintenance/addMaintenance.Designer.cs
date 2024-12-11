namespace AppartmentSystem.Maintenance
{
    partial class frm_addMaintenance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_addMaintenance));
            this.lbl_room = new System.Windows.Forms.Label();
            this.cb_roomaddMaintenance = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_addMaintenanceInfo = new System.Windows.Forms.Button();
            this.btn_addmaintenanceSave = new System.Windows.Forms.Button();
            this.btn_addmaintenanceback = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_room
            // 
            this.lbl_room.AutoSize = true;
            this.lbl_room.BackColor = System.Drawing.Color.Transparent;
            this.lbl_room.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_room.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_room.Location = new System.Drawing.Point(51, 107);
            this.lbl_room.Name = "lbl_room";
            this.lbl_room.Size = new System.Drawing.Size(44, 17);
            this.lbl_room.TabIndex = 0;
            this.lbl_room.Text = "Room";
            // 
            // cb_roomaddMaintenance
            // 
            this.cb_roomaddMaintenance.FormattingEnabled = true;
            this.cb_roomaddMaintenance.Location = new System.Drawing.Point(101, 107);
            this.cb_roomaddMaintenance.Name = "cb_roomaddMaintenance";
            this.cb_roomaddMaintenance.Size = new System.Drawing.Size(121, 21);
            this.cb_roomaddMaintenance.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(51, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(908, 479);
            this.dataGridView1.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // btn_addMaintenanceInfo
            // 
            this.btn_addMaintenanceInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addMaintenanceInfo.BackColor = System.Drawing.Color.LightCyan;
            this.btn_addMaintenanceInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addMaintenanceInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addMaintenanceInfo.Image = ((System.Drawing.Image)(resources.GetObject("btn_addMaintenanceInfo.Image")));
            this.btn_addMaintenanceInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addMaintenanceInfo.Location = new System.Drawing.Point(854, 82);
            this.btn_addMaintenanceInfo.Name = "btn_addMaintenanceInfo";
            this.btn_addMaintenanceInfo.Size = new System.Drawing.Size(105, 46);
            this.btn_addMaintenanceInfo.TabIndex = 3;
            this.btn_addMaintenanceInfo.Text = "   Info";
            this.btn_addMaintenanceInfo.UseVisualStyleBackColor = false;
            this.btn_addMaintenanceInfo.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_addmaintenanceSave
            // 
            this.btn_addmaintenanceSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addmaintenanceSave.BackColor = System.Drawing.Color.LightCyan;
            this.btn_addmaintenanceSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addmaintenanceSave.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addmaintenanceSave.Image = ((System.Drawing.Image)(resources.GetObject("btn_addmaintenanceSave.Image")));
            this.btn_addmaintenanceSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addmaintenanceSave.Location = new System.Drawing.Point(743, 82);
            this.btn_addmaintenanceSave.Name = "btn_addmaintenanceSave";
            this.btn_addmaintenanceSave.Size = new System.Drawing.Size(105, 46);
            this.btn_addmaintenanceSave.TabIndex = 4;
            this.btn_addmaintenanceSave.Text = "      Save";
            this.btn_addmaintenanceSave.UseVisualStyleBackColor = false;
            // 
            // btn_addmaintenanceback
            // 
            this.btn_addmaintenanceback.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addmaintenanceback.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_addmaintenanceback.BackgroundImage")));
            this.btn_addmaintenanceback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_addmaintenanceback.Location = new System.Drawing.Point(922, 12);
            this.btn_addmaintenanceback.Name = "btn_addmaintenanceback";
            this.btn_addmaintenanceback.Size = new System.Drawing.Size(37, 35);
            this.btn_addmaintenanceback.TabIndex = 5;
            this.btn_addmaintenanceback.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 45);
            this.label1.TabIndex = 6;
            this.label1.Text = "Add Maintenance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Can add and show Information about Maintenance";
            // 
            // frm_addMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_addmaintenanceback);
            this.Controls.Add(this.btn_addmaintenanceSave);
            this.Controls.Add(this.btn_addMaintenanceInfo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cb_roomaddMaintenance);
            this.Controls.Add(this.lbl_room);
            this.Name = "frm_addMaintenance";
            this.Text = "addMaintenance";
            this.Load += new System.EventHandler(this.frm_addMaintenance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_room;
        private System.Windows.Forms.ComboBox cb_roomaddMaintenance;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Button btn_addMaintenanceInfo;
        private System.Windows.Forms.Button btn_addmaintenanceSave;
        private System.Windows.Forms.Button btn_addmaintenanceback;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}