namespace AppartmentSystem
{
    partial class Frm_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Dashboard));
            this.lbl_header = new System.Windows.Forms.Label();
            this.btn_manageRoom = new System.Windows.Forms.Button();
            this.btn_manageLeases = new System.Windows.Forms.Button();
            this.btn_financialData = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_maintenanceRequestOutput = new System.Windows.Forms.Label();
            this.lbl_InactiveRoomOutput = new System.Windows.Forms.Label();
            this.lbl_ActiveRoomOutput = new System.Windows.Forms.Label();
            this.lbl_MaintenanceRequest = new System.Windows.Forms.Label();
            this.lbl_InactiveRoom = new System.Windows.Forms.Label();
            this.lbl_TotalActiveRoom = new System.Windows.Forms.Label();
            this.panel_actRoom = new System.Windows.Forms.Panel();
            this.panel_inactRoom = new System.Windows.Forms.Panel();
            this.panel_maintenanceRequest = new System.Windows.Forms.Panel();
            this.panel_headDashboard = new System.Windows.Forms.Panel();
            this.panel_dockleft = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel_actRoom.SuspendLayout();
            this.panel_inactRoom.SuspendLayout();
            this.panel_maintenanceRequest.SuspendLayout();
            this.panel_headDashboard.SuspendLayout();
            this.panel_dockleft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_header
            // 
            this.lbl_header.AutoSize = true;
            this.lbl_header.BackColor = System.Drawing.Color.Transparent;
            this.lbl_header.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.ForeColor = System.Drawing.Color.Silver;
            this.lbl_header.Location = new System.Drawing.Point(13, 9);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(187, 45);
            this.lbl_header.TabIndex = 0;
            this.lbl_header.Text = "Dashboard";
            // 
            // btn_manageRoom
            // 
            this.btn_manageRoom.BackColor = System.Drawing.Color.Black;
            this.btn_manageRoom.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manageRoom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_manageRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_manageRoom.Location = new System.Drawing.Point(16, 7);
            this.btn_manageRoom.Name = "btn_manageRoom";
            this.btn_manageRoom.Size = new System.Drawing.Size(160, 55);
            this.btn_manageRoom.TabIndex = 1;
            this.btn_manageRoom.Text = "   Manage Room";
            this.btn_manageRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_manageRoom.UseVisualStyleBackColor = false;
            this.btn_manageRoom.Click += new System.EventHandler(this.btn_manageRoom_Click);
            // 
            // btn_manageLeases
            // 
            this.btn_manageLeases.BackColor = System.Drawing.Color.Black;
            this.btn_manageLeases.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manageLeases.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_manageLeases.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_manageLeases.Location = new System.Drawing.Point(16, 85);
            this.btn_manageLeases.Name = "btn_manageLeases";
            this.btn_manageLeases.Size = new System.Drawing.Size(160, 55);
            this.btn_manageLeases.TabIndex = 2;
            this.btn_manageLeases.Text = "   Manage Leases";
            this.btn_manageLeases.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_manageLeases.UseVisualStyleBackColor = false;
            this.btn_manageLeases.Click += new System.EventHandler(this.btn_manageLeases_Click);
            // 
            // btn_financialData
            // 
            this.btn_financialData.BackColor = System.Drawing.Color.Black;
            this.btn_financialData.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_financialData.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_financialData.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_financialData.Location = new System.Drawing.Point(16, 169);
            this.btn_financialData.Name = "btn_financialData";
            this.btn_financialData.Size = new System.Drawing.Size(160, 55);
            this.btn_financialData.TabIndex = 3;
            this.btn_financialData.Text = "   Financial Data";
            this.btn_financialData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_financialData.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(16, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 55);
            this.button1.TabIndex = 4;
            this.button1.Text = "   Track And Assign    Maintenance";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lbl_maintenanceRequestOutput
            // 
            this.lbl_maintenanceRequestOutput.AutoSize = true;
            this.lbl_maintenanceRequestOutput.Location = new System.Drawing.Point(20, 30);
            this.lbl_maintenanceRequestOutput.Name = "lbl_maintenanceRequestOutput";
            this.lbl_maintenanceRequestOutput.Size = new System.Drawing.Size(73, 13);
            this.lbl_maintenanceRequestOutput.TabIndex = 5;
            this.lbl_maintenanceRequestOutput.Text = "maint_request";
            // 
            // lbl_InactiveRoomOutput
            // 
            this.lbl_InactiveRoomOutput.AutoSize = true;
            this.lbl_InactiveRoomOutput.Location = new System.Drawing.Point(20, 23);
            this.lbl_InactiveRoomOutput.Name = "lbl_InactiveRoomOutput";
            this.lbl_InactiveRoomOutput.Size = new System.Drawing.Size(62, 13);
            this.lbl_InactiveRoomOutput.TabIndex = 4;
            this.lbl_InactiveRoomOutput.Text = "Inact Room";
            // 
            // lbl_ActiveRoomOutput
            // 
            this.lbl_ActiveRoomOutput.AutoSize = true;
            this.lbl_ActiveRoomOutput.Location = new System.Drawing.Point(20, 30);
            this.lbl_ActiveRoomOutput.Name = "lbl_ActiveRoomOutput";
            this.lbl_ActiveRoomOutput.Size = new System.Drawing.Size(50, 13);
            this.lbl_ActiveRoomOutput.TabIndex = 3;
            this.lbl_ActiveRoomOutput.Text = "actRoom";
            this.lbl_ActiveRoomOutput.Click += new System.EventHandler(this.lbl_ActiveRoomOutput_Click);
            // 
            // lbl_MaintenanceRequest
            // 
            this.lbl_MaintenanceRequest.AutoSize = true;
            this.lbl_MaintenanceRequest.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaintenanceRequest.Location = new System.Drawing.Point(-6, 67);
            this.lbl_MaintenanceRequest.Name = "lbl_MaintenanceRequest";
            this.lbl_MaintenanceRequest.Size = new System.Drawing.Size(259, 33);
            this.lbl_MaintenanceRequest.TabIndex = 2;
            this.lbl_MaintenanceRequest.Text = "Maintenance Request";
            // 
            // lbl_InactiveRoom
            // 
            this.lbl_InactiveRoom.AutoSize = true;
            this.lbl_InactiveRoom.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InactiveRoom.Location = new System.Drawing.Point(-6, 67);
            this.lbl_InactiveRoom.Name = "lbl_InactiveRoom";
            this.lbl_InactiveRoom.Size = new System.Drawing.Size(176, 33);
            this.lbl_InactiveRoom.TabIndex = 1;
            this.lbl_InactiveRoom.Text = "Inactive Room";
            // 
            // lbl_TotalActiveRoom
            // 
            this.lbl_TotalActiveRoom.AutoSize = true;
            this.lbl_TotalActiveRoom.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalActiveRoom.Location = new System.Drawing.Point(3, 67);
            this.lbl_TotalActiveRoom.Name = "lbl_TotalActiveRoom";
            this.lbl_TotalActiveRoom.Size = new System.Drawing.Size(181, 37);
            this.lbl_TotalActiveRoom.TabIndex = 0;
            this.lbl_TotalActiveRoom.Text = "Active Room";
            this.lbl_TotalActiveRoom.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel_actRoom
            // 
            this.panel_actRoom.BackColor = System.Drawing.Color.Transparent;
            this.panel_actRoom.Controls.Add(this.lbl_TotalActiveRoom);
            this.panel_actRoom.Controls.Add(this.lbl_ActiveRoomOutput);
            this.panel_actRoom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel_actRoom.Location = new System.Drawing.Point(440, 100);
            this.panel_actRoom.Name = "panel_actRoom";
            this.panel_actRoom.Size = new System.Drawing.Size(261, 100);
            this.panel_actRoom.TabIndex = 6;
            this.panel_actRoom.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel_inactRoom
            // 
            this.panel_inactRoom.BackColor = System.Drawing.Color.Transparent;
            this.panel_inactRoom.Controls.Add(this.lbl_InactiveRoom);
            this.panel_inactRoom.Controls.Add(this.lbl_InactiveRoomOutput);
            this.panel_inactRoom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel_inactRoom.Location = new System.Drawing.Point(440, 355);
            this.panel_inactRoom.Name = "panel_inactRoom";
            this.panel_inactRoom.Size = new System.Drawing.Size(261, 100);
            this.panel_inactRoom.TabIndex = 7;
            // 
            // panel_maintenanceRequest
            // 
            this.panel_maintenanceRequest.BackColor = System.Drawing.Color.Transparent;
            this.panel_maintenanceRequest.Controls.Add(this.lbl_MaintenanceRequest);
            this.panel_maintenanceRequest.Controls.Add(this.lbl_maintenanceRequestOutput);
            this.panel_maintenanceRequest.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel_maintenanceRequest.Location = new System.Drawing.Point(440, 234);
            this.panel_maintenanceRequest.Name = "panel_maintenanceRequest";
            this.panel_maintenanceRequest.Size = new System.Drawing.Size(261, 100);
            this.panel_maintenanceRequest.TabIndex = 8;
            // 
            // panel_headDashboard
            // 
            this.panel_headDashboard.Controls.Add(this.lbl_header);
            this.panel_headDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_headDashboard.Location = new System.Drawing.Point(0, 0);
            this.panel_headDashboard.Name = "panel_headDashboard";
            this.panel_headDashboard.Size = new System.Drawing.Size(1008, 65);
            this.panel_headDashboard.TabIndex = 9;
            this.panel_headDashboard.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_headDashboard_Paint);
            // 
            // panel_dockleft
            // 
            this.panel_dockleft.Controls.Add(this.btn_manageRoom);
            this.panel_dockleft.Controls.Add(this.btn_manageLeases);
            this.panel_dockleft.Controls.Add(this.btn_financialData);
            this.panel_dockleft.Controls.Add(this.button1);
            this.panel_dockleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_dockleft.Location = new System.Drawing.Point(0, 65);
            this.panel_dockleft.Name = "panel_dockleft";
            this.panel_dockleft.Size = new System.Drawing.Size(195, 664);
            this.panel_dockleft.TabIndex = 10;
            this.panel_dockleft.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_dockleft_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(404, 512);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(552, 193);
            this.dataGridView1.TabIndex = 11;
            // 
            // Frm_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel_dockleft);
            this.Controls.Add(this.panel_headDashboard);
            this.Controls.Add(this.panel_maintenanceRequest);
            this.Controls.Add(this.panel_inactRoom);
            this.Controls.Add(this.panel_actRoom);
            this.DoubleBuffered = true;
            this.Name = "Frm_Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Frm_Dashboard_Load);
            this.panel_actRoom.ResumeLayout(false);
            this.panel_actRoom.PerformLayout();
            this.panel_inactRoom.ResumeLayout(false);
            this.panel_inactRoom.PerformLayout();
            this.panel_maintenanceRequest.ResumeLayout(false);
            this.panel_maintenanceRequest.PerformLayout();
            this.panel_headDashboard.ResumeLayout(false);
            this.panel_headDashboard.PerformLayout();
            this.panel_dockleft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.Button btn_manageRoom;
        private System.Windows.Forms.Button btn_manageLeases;
        private System.Windows.Forms.Button btn_financialData;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_TotalActiveRoom;
        private System.Windows.Forms.Label lbl_InactiveRoom;
        private System.Windows.Forms.Label lbl_maintenanceRequestOutput;
        private System.Windows.Forms.Label lbl_InactiveRoomOutput;
        private System.Windows.Forms.Label lbl_ActiveRoomOutput;
        private System.Windows.Forms.Label lbl_MaintenanceRequest;
        private System.Windows.Forms.Panel panel_actRoom;
        private System.Windows.Forms.Panel panel_inactRoom;
        private System.Windows.Forms.Panel panel_maintenanceRequest;
        private System.Windows.Forms.Panel panel_headDashboard;
        private System.Windows.Forms.Panel panel_dockleft;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}