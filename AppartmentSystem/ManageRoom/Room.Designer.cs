﻿namespace AppartmentSystem
{
    partial class frm_room
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_room));
            this.dg_ManageRoom = new System.Windows.Forms.DataGridView();
            this.btn_addRoom = new System.Windows.Forms.Button();
            this.lbl_roomNo = new System.Windows.Forms.Label();
            this.lbl_tenant = new System.Windows.Forms.Label();
            this.txt_tenant = new System.Windows.Forms.TextBox();
            this.lbl_movedIn = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.btn_UpdateRoom = new System.Windows.Forms.Button();
            this.btn_editRoom = new System.Windows.Forms.Button();
            this.btn_deleteRoom = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.btn_roomBack = new System.Windows.Forms.Button();
            this.txt_RoomNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_editRoomLog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_ManageRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_ManageRoom
            // 
            this.dg_ManageRoom.AllowUserToAddRows = false;
            this.dg_ManageRoom.AllowUserToDeleteRows = false;
            this.dg_ManageRoom.AllowUserToResizeColumns = false;
            this.dg_ManageRoom.AllowUserToResizeRows = false;
            this.dg_ManageRoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_ManageRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_ManageRoom.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dg_ManageRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_ManageRoom.Location = new System.Drawing.Point(75, 207);
            this.dg_ManageRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dg_ManageRoom.MultiSelect = false;
            this.dg_ManageRoom.Name = "dg_ManageRoom";
            this.dg_ManageRoom.ReadOnly = true;
            this.dg_ManageRoom.RowHeadersWidth = 51;
            this.dg_ManageRoom.Size = new System.Drawing.Size(1196, 549);
            this.dg_ManageRoom.TabIndex = 0;
            this.dg_ManageRoom.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_ManageRoom_CellClick);
            this.dg_ManageRoom.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_ManageRoom_CellContentClick);
            // 
            // btn_addRoom
            // 
            this.btn_addRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addRoom.BackColor = System.Drawing.Color.LightCyan;
            this.btn_addRoom.FlatAppearance.BorderSize = 0;
            this.btn_addRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addRoom.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addRoom.Image = ((System.Drawing.Image)(resources.GetObject("btn_addRoom.Image")));
            this.btn_addRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addRoom.Location = new System.Drawing.Point(833, 74);
            this.btn_addRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_addRoom.Name = "btn_addRoom";
            this.btn_addRoom.Size = new System.Drawing.Size(140, 55);
            this.btn_addRoom.TabIndex = 1;
            this.btn_addRoom.Text = "        Add";
            this.btn_addRoom.UseVisualStyleBackColor = false;
            this.btn_addRoom.Click += new System.EventHandler(this.btn_addRoom_Click);
            // 
            // lbl_roomNo
            // 
            this.lbl_roomNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_roomNo.AutoSize = true;
            this.lbl_roomNo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_roomNo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_roomNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_roomNo.Location = new System.Drawing.Point(72, 160);
            this.lbl_roomNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_roomNo.Name = "lbl_roomNo";
            this.lbl_roomNo.Size = new System.Drawing.Size(60, 23);
            this.lbl_roomNo.TabIndex = 2;
            this.lbl_roomNo.Text = "Room:";
            // 
            // lbl_tenant
            // 
            this.lbl_tenant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_tenant.AutoSize = true;
            this.lbl_tenant.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tenant.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tenant.Location = new System.Drawing.Point(732, 159);
            this.lbl_tenant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tenant.Name = "lbl_tenant";
            this.lbl_tenant.Size = new System.Drawing.Size(65, 23);
            this.lbl_tenant.TabIndex = 4;
            this.lbl_tenant.Text = "Tenant:";
            // 
            // txt_tenant
            // 
            this.txt_tenant.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_tenant.Location = new System.Drawing.Point(792, 156);
            this.txt_tenant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_tenant.Name = "txt_tenant";
            this.txt_tenant.Size = new System.Drawing.Size(132, 22);
            this.txt_tenant.TabIndex = 5;
            this.txt_tenant.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_tenant_MouseClick);
            this.txt_tenant.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tenant_KeyPress);
            // 
            // lbl_movedIn
            // 
            this.lbl_movedIn.AutoSize = true;
            this.lbl_movedIn.BackColor = System.Drawing.Color.Transparent;
            this.lbl_movedIn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_movedIn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_movedIn.Location = new System.Drawing.Point(323, 159);
            this.lbl_movedIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_movedIn.Name = "lbl_movedIn";
            this.lbl_movedIn.Size = new System.Drawing.Size(88, 23);
            this.lbl_movedIn.TabIndex = 6;
            this.lbl_movedIn.Text = "Moved In:";
            // 
            // lbl_price
            // 
            this.lbl_price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_price.AutoSize = true;
            this.lbl_price.BackColor = System.Drawing.Color.Transparent;
            this.lbl_price.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_price.Location = new System.Drawing.Point(1012, 156);
            this.lbl_price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(51, 23);
            this.lbl_price.TabIndex = 7;
            this.lbl_price.Text = "Price:";
            // 
            // btn_UpdateRoom
            // 
            this.btn_UpdateRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_UpdateRoom.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdateRoom.Image = ((System.Drawing.Image)(resources.GetObject("btn_UpdateRoom.Image")));
            this.btn_UpdateRoom.Location = new System.Drawing.Point(1264, 763);
            this.btn_UpdateRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_UpdateRoom.Name = "btn_UpdateRoom";
            this.btn_UpdateRoom.Size = new System.Drawing.Size(64, 50);
            this.btn_UpdateRoom.TabIndex = 10;
            this.btn_UpdateRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_UpdateRoom.UseVisualStyleBackColor = true;
            this.btn_UpdateRoom.Visible = false;
            this.btn_UpdateRoom.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_editRoom
            // 
            this.btn_editRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_editRoom.BackColor = System.Drawing.Color.LightCyan;
            this.btn_editRoom.FlatAppearance.BorderSize = 0;
            this.btn_editRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editRoom.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editRoom.Image = ((System.Drawing.Image)(resources.GetObject("btn_editRoom.Image")));
            this.btn_editRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_editRoom.Location = new System.Drawing.Point(1129, 74);
            this.btn_editRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_editRoom.Name = "btn_editRoom";
            this.btn_editRoom.Size = new System.Drawing.Size(140, 55);
            this.btn_editRoom.TabIndex = 11;
            this.btn_editRoom.Text = "       Edit";
            this.btn_editRoom.UseVisualStyleBackColor = false;
            this.btn_editRoom.Click += new System.EventHandler(this.btn_editRoom_Click_1);
            // 
            // btn_deleteRoom
            // 
            this.btn_deleteRoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_deleteRoom.BackColor = System.Drawing.Color.LightCyan;
            this.btn_deleteRoom.FlatAppearance.BorderSize = 0;
            this.btn_deleteRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteRoom.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteRoom.Image = ((System.Drawing.Image)(resources.GetObject("btn_deleteRoom.Image")));
            this.btn_deleteRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_deleteRoom.Location = new System.Drawing.Point(981, 74);
            this.btn_deleteRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_deleteRoom.Name = "btn_deleteRoom";
            this.btn_deleteRoom.Size = new System.Drawing.Size(140, 55);
            this.btn_deleteRoom.TabIndex = 12;
            this.btn_deleteRoom.Text = "        Delete";
            this.btn_deleteRoom.UseVisualStyleBackColor = false;
            this.btn_deleteRoom.Click += new System.EventHandler(this.btn_deleteRoom_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(420, 156);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 13;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txt_price
            // 
            this.txt_price.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_price.Location = new System.Drawing.Point(1068, 156);
            this.txt_price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(200, 22);
            this.txt_price.TabIndex = 15;
            this.txt_price.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_price_MouseClick);
            this.txt_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_price_KeyPress);
            // 
            // btn_roomBack
            // 
            this.btn_roomBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_roomBack.BackColor = System.Drawing.Color.Transparent;
            this.btn_roomBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_roomBack.BackgroundImage")));
            this.btn_roomBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_roomBack.Location = new System.Drawing.Point(1217, 15);
            this.btn_roomBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_roomBack.Name = "btn_roomBack";
            this.btn_roomBack.Size = new System.Drawing.Size(53, 43);
            this.btn_roomBack.TabIndex = 16;
            this.btn_roomBack.UseVisualStyleBackColor = false;
            this.btn_roomBack.Click += new System.EventHandler(this.btn_roomBack_Click);
            // 
            // txt_RoomNo
            // 
            this.txt_RoomNo.Location = new System.Drawing.Point(131, 156);
            this.txt_RoomNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_RoomNo.Name = "txt_RoomNo";
            this.txt_RoomNo.Size = new System.Drawing.Size(132, 22);
            this.txt_RoomNo.TabIndex = 17;
            this.txt_RoomNo.Click += new System.EventHandler(this.txt_RoomNo_Click);
            this.txt_RoomNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_RoomNo_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 54);
            this.label1.TabIndex = 18;
            this.label1.Text = "Manage Room";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Can add, delete, and edit room information";
            // 
            // btn_editRoomLog
            // 
            this.btn_editRoomLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_editRoomLog.BackColor = System.Drawing.Color.LightCyan;
            this.btn_editRoomLog.FlatAppearance.BorderSize = 0;
            this.btn_editRoomLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editRoomLog.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editRoomLog.Image = ((System.Drawing.Image)(resources.GetObject("btn_editRoomLog.Image")));
            this.btn_editRoomLog.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_editRoomLog.Location = new System.Drawing.Point(685, 73);
            this.btn_editRoomLog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_editRoomLog.Name = "btn_editRoomLog";
            this.btn_editRoomLog.Size = new System.Drawing.Size(140, 57);
            this.btn_editRoomLog.TabIndex = 20;
            this.btn_editRoomLog.Text = "Edit Log";
            this.btn_editRoomLog.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_editRoomLog.UseVisualStyleBackColor = false;
            this.btn_editRoomLog.Click += new System.EventHandler(this.btn_editRoomLog_Click);
            // 
            // frm_room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1344, 897);
            this.Controls.Add(this.btn_editRoomLog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_RoomNo);
            this.Controls.Add(this.btn_roomBack);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_deleteRoom);
            this.Controls.Add(this.btn_editRoom);
            this.Controls.Add(this.btn_UpdateRoom);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_movedIn);
            this.Controls.Add(this.txt_tenant);
            this.Controls.Add(this.lbl_tenant);
            this.Controls.Add(this.lbl_roomNo);
            this.Controls.Add(this.btn_addRoom);
            this.Controls.Add(this.dg_ManageRoom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_room";
            this.Text = "Room";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_room_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_ManageRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_ManageRoom;
        private System.Windows.Forms.Button btn_addRoom;
        private System.Windows.Forms.Label lbl_roomNo;
        private System.Windows.Forms.Label lbl_tenant;
        private System.Windows.Forms.TextBox txt_tenant;
        private System.Windows.Forms.Label lbl_movedIn;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Button btn_UpdateRoom;
        private System.Windows.Forms.Button btn_editRoom;
        private System.Windows.Forms.Button btn_deleteRoom;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Button btn_roomBack;
        private System.Windows.Forms.TextBox txt_RoomNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_editRoomLog;
    }
}