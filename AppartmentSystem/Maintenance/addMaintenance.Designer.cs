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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_room
            // 
            this.lbl_room.AutoSize = true;
            this.lbl_room.BackColor = System.Drawing.Color.Transparent;
            this.lbl_room.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_room.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_room.Location = new System.Drawing.Point(73, 43);
            this.lbl_room.Name = "lbl_room";
            this.lbl_room.Size = new System.Drawing.Size(36, 17);
            this.lbl_room.TabIndex = 0;
            this.lbl_room.Text = "Room";
            // 
            // cb_roomaddMaintenance
            // 
            this.cb_roomaddMaintenance.FormattingEnabled = true;
            this.cb_roomaddMaintenance.Location = new System.Drawing.Point(110, 40);
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
            this.dataGridView1.Location = new System.Drawing.Point(74, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(867, 535);
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
            this.btn_addMaintenanceInfo.Image = ((System.Drawing.Image)(resources.GetObject("btn_addMaintenanceInfo.Image")));
            this.btn_addMaintenanceInfo.Location = new System.Drawing.Point(950, 135);
            this.btn_addMaintenanceInfo.Name = "btn_addMaintenanceInfo";
            this.btn_addMaintenanceInfo.Size = new System.Drawing.Size(41, 32);
            this.btn_addMaintenanceInfo.TabIndex = 3;
            this.btn_addMaintenanceInfo.Text = "\r\n";
            this.btn_addMaintenanceInfo.UseVisualStyleBackColor = true;
            this.btn_addMaintenanceInfo.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_addMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 729);
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
    }
}