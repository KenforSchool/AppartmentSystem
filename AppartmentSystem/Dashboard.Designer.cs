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
            this.panel_status = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_InactiveRoomOutput = new System.Windows.Forms.Label();
            this.lbl_ActiveRoomOutput = new System.Windows.Forms.Label();
            this.lbl_MaintenanceRequest = new System.Windows.Forms.Label();
            this.lbl_InactiveRoom = new System.Windows.Forms.Label();
            this.lbl_TotalActiveRoom = new System.Windows.Forms.Label();
            this.panel_status.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_header
            // 
            this.lbl_header.AutoSize = true;
            this.lbl_header.BackColor = System.Drawing.Color.Transparent;
            this.lbl_header.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.ForeColor = System.Drawing.Color.Silver;
            this.lbl_header.Location = new System.Drawing.Point(12, 9);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(187, 45);
            this.lbl_header.TabIndex = 0;
            this.lbl_header.Text = "Dashboard";
            // 
            // btn_manageRoom
            // 
            this.btn_manageRoom.BackColor = System.Drawing.Color.Silver;
            this.btn_manageRoom.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manageRoom.Image = ((System.Drawing.Image)(resources.GetObject("btn_manageRoom.Image")));
            this.btn_manageRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_manageRoom.Location = new System.Drawing.Point(40, 100);
            this.btn_manageRoom.Name = "btn_manageRoom";
            this.btn_manageRoom.Size = new System.Drawing.Size(160, 55);
            this.btn_manageRoom.TabIndex = 1;
            this.btn_manageRoom.Text = "Manage Room";
            this.btn_manageRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_manageRoom.UseVisualStyleBackColor = false;
            // 
            // btn_manageLeases
            // 
            this.btn_manageLeases.BackColor = System.Drawing.Color.Silver;
            this.btn_manageLeases.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manageLeases.Image = ((System.Drawing.Image)(resources.GetObject("btn_manageLeases.Image")));
            this.btn_manageLeases.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_manageLeases.Location = new System.Drawing.Point(39, 200);
            this.btn_manageLeases.Name = "btn_manageLeases";
            this.btn_manageLeases.Size = new System.Drawing.Size(160, 55);
            this.btn_manageLeases.TabIndex = 2;
            this.btn_manageLeases.Text = "Manage Leases";
            this.btn_manageLeases.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_manageLeases.UseVisualStyleBackColor = false;
            // 
            // btn_financialData
            // 
            this.btn_financialData.BackColor = System.Drawing.Color.Silver;
            this.btn_financialData.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_financialData.Image = ((System.Drawing.Image)(resources.GetObject("btn_financialData.Image")));
            this.btn_financialData.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_financialData.Location = new System.Drawing.Point(40, 300);
            this.btn_financialData.Name = "btn_financialData";
            this.btn_financialData.Size = new System.Drawing.Size(160, 55);
            this.btn_financialData.TabIndex = 3;
            this.btn_financialData.Text = "Financial Data";
            this.btn_financialData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_financialData.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(40, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 55);
            this.button1.TabIndex = 4;
            this.button1.Text = "Track And Assign Maintenance";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel_status
            // 
            this.panel_status.BackColor = System.Drawing.Color.Silver;
            this.panel_status.Controls.Add(this.label1);
            this.panel_status.Controls.Add(this.lbl_InactiveRoomOutput);
            this.panel_status.Controls.Add(this.lbl_ActiveRoomOutput);
            this.panel_status.Controls.Add(this.lbl_MaintenanceRequest);
            this.panel_status.Controls.Add(this.lbl_InactiveRoom);
            this.panel_status.Controls.Add(this.lbl_TotalActiveRoom);
            this.panel_status.Location = new System.Drawing.Point(406, 100);
            this.panel_status.Name = "panel_status";
            this.panel_status.Size = new System.Drawing.Size(514, 330);
            this.panel_status.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(417, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "maint_request";
            // 
            // lbl_InactiveRoomOutput
            // 
            this.lbl_InactiveRoomOutput.AutoSize = true;
            this.lbl_InactiveRoomOutput.Location = new System.Drawing.Point(428, 142);
            this.lbl_InactiveRoomOutput.Name = "lbl_InactiveRoomOutput";
            this.lbl_InactiveRoomOutput.Size = new System.Drawing.Size(62, 13);
            this.lbl_InactiveRoomOutput.TabIndex = 4;
            this.lbl_InactiveRoomOutput.Text = "Inact Room";
            // 
            // lbl_ActiveRoomOutput
            // 
            this.lbl_ActiveRoomOutput.AutoSize = true;
            this.lbl_ActiveRoomOutput.Location = new System.Drawing.Point(440, 37);
            this.lbl_ActiveRoomOutput.Name = "lbl_ActiveRoomOutput";
            this.lbl_ActiveRoomOutput.Size = new System.Drawing.Size(50, 13);
            this.lbl_ActiveRoomOutput.TabIndex = 3;
            this.lbl_ActiveRoomOutput.Text = "actRoom";
            // 
            // lbl_MaintenanceRequest
            // 
            this.lbl_MaintenanceRequest.AutoSize = true;
            this.lbl_MaintenanceRequest.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaintenanceRequest.Location = new System.Drawing.Point(24, 232);
            this.lbl_MaintenanceRequest.Name = "lbl_MaintenanceRequest";
            this.lbl_MaintenanceRequest.Size = new System.Drawing.Size(259, 33);
            this.lbl_MaintenanceRequest.TabIndex = 2;
            this.lbl_MaintenanceRequest.Text = "Maintenance Request";
            // 
            // lbl_InactiveRoom
            // 
            this.lbl_InactiveRoom.AutoSize = true;
            this.lbl_InactiveRoom.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InactiveRoom.Location = new System.Drawing.Point(24, 132);
            this.lbl_InactiveRoom.Name = "lbl_InactiveRoom";
            this.lbl_InactiveRoom.Size = new System.Drawing.Size(237, 33);
            this.lbl_InactiveRoom.TabIndex = 1;
            this.lbl_InactiveRoom.Text = "Total Inactive Room";
            // 
            // lbl_TotalActiveRoom
            // 
            this.lbl_TotalActiveRoom.AutoSize = true;
            this.lbl_TotalActiveRoom.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalActiveRoom.Location = new System.Drawing.Point(24, 37);
            this.lbl_TotalActiveRoom.Name = "lbl_TotalActiveRoom";
            this.lbl_TotalActiveRoom.Size = new System.Drawing.Size(219, 33);
            this.lbl_TotalActiveRoom.TabIndex = 0;
            this.lbl_TotalActiveRoom.Text = "Total Active Room";
            this.lbl_TotalActiveRoom.Click += new System.EventHandler(this.label1_Click);
            // 
            // Frm_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.panel_status);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_financialData);
            this.Controls.Add(this.btn_manageLeases);
            this.Controls.Add(this.btn_manageRoom);
            this.Controls.Add(this.lbl_header);
            this.DoubleBuffered = true;
            this.Name = "Frm_Dashboard";
            this.Text = "Dashboard";
            this.panel_status.ResumeLayout(false);
            this.panel_status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.Button btn_manageRoom;
        private System.Windows.Forms.Button btn_manageLeases;
        private System.Windows.Forms.Button btn_financialData;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel_status;
        private System.Windows.Forms.Label lbl_TotalActiveRoom;
        private System.Windows.Forms.Label lbl_InactiveRoom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_InactiveRoomOutput;
        private System.Windows.Forms.Label lbl_ActiveRoomOutput;
        private System.Windows.Forms.Label lbl_MaintenanceRequest;
    }
}