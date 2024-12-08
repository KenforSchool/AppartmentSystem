namespace AppartmentSystem
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
            this.dg_Room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_Tenant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_movedIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_movedOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_addRoom = new System.Windows.Forms.Button();
            this.lbl_roomNo = new System.Windows.Forms.Label();
            this.txt_RoomNo = new System.Windows.Forms.TextBox();
            this.lbl_tenant = new System.Windows.Forms.Label();
            this.txt_tenant = new System.Windows.Forms.TextBox();
            this.lbl_movedIn = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.btn_UpdateRoom = new System.Windows.Forms.Button();
            this.btn_editRoom = new System.Windows.Forms.Button();
            this.btn_deleteRoom = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_price = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dg_ManageRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_ManageRoom
            // 
            this.dg_ManageRoom.AllowUserToAddRows = false;
            this.dg_ManageRoom.AllowUserToDeleteRows = false;
            this.dg_ManageRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dg_ManageRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_ManageRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dg_Room,
            this.dg_Tenant,
            this.dg_movedIn,
            this.dg_movedOut});
            this.dg_ManageRoom.Location = new System.Drawing.Point(75, 170);
            this.dg_ManageRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dg_ManageRoom.Name = "dg_ManageRoom";
            this.dg_ManageRoom.ReadOnly = true;
            this.dg_ManageRoom.RowHeadersWidth = 51;
            this.dg_ManageRoom.Size = new System.Drawing.Size(1196, 586);
            this.dg_ManageRoom.TabIndex = 0;
            // 
            // dg_Room
            // 
            this.dg_Room.HeaderText = "Room";
            this.dg_Room.MinimumWidth = 6;
            this.dg_Room.Name = "dg_Room";
            this.dg_Room.ReadOnly = true;
            // 
            // dg_Tenant
            // 
            this.dg_Tenant.HeaderText = "Tenant";
            this.dg_Tenant.MinimumWidth = 6;
            this.dg_Tenant.Name = "dg_Tenant";
            this.dg_Tenant.ReadOnly = true;
            // 
            // dg_movedIn
            // 
            this.dg_movedIn.HeaderText = "Moved In";
            this.dg_movedIn.MinimumWidth = 6;
            this.dg_movedIn.Name = "dg_movedIn";
            this.dg_movedIn.ReadOnly = true;
            // 
            // dg_movedOut
            // 
            this.dg_movedOut.HeaderText = "Moved Out";
            this.dg_movedOut.MinimumWidth = 6;
            this.dg_movedOut.Name = "dg_movedOut";
            this.dg_movedOut.ReadOnly = true;
            // 
            // btn_addRoom
            // 
            this.btn_addRoom.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addRoom.Image = ((System.Drawing.Image)(resources.GetObject("btn_addRoom.Image")));
            this.btn_addRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_addRoom.Location = new System.Drawing.Point(1171, 90);
            this.btn_addRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_addRoom.Name = "btn_addRoom";
            this.btn_addRoom.Size = new System.Drawing.Size(111, 50);
            this.btn_addRoom.TabIndex = 1;
            this.btn_addRoom.Text = "    Add";
            this.btn_addRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addRoom.UseVisualStyleBackColor = true;
            this.btn_addRoom.Click += new System.EventHandler(this.btn_addRoom_Click);
            // 
            // lbl_roomNo
            // 
            this.lbl_roomNo.AutoSize = true;
            this.lbl_roomNo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_roomNo.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_roomNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_roomNo.Location = new System.Drawing.Point(132, 31);
            this.lbl_roomNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_roomNo.Name = "lbl_roomNo";
            this.lbl_roomNo.Size = new System.Drawing.Size(52, 17);
            this.lbl_roomNo.TabIndex = 2;
            this.lbl_roomNo.Text = "Room:";
            // 
            // txt_RoomNo
            // 
            this.txt_RoomNo.Location = new System.Drawing.Point(191, 27);
            this.txt_RoomNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_RoomNo.Name = "txt_RoomNo";
            this.txt_RoomNo.Size = new System.Drawing.Size(132, 22);
            this.txt_RoomNo.TabIndex = 3;
            // 
            // lbl_tenant
            // 
            this.lbl_tenant.AutoSize = true;
            this.lbl_tenant.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tenant.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tenant.Location = new System.Drawing.Point(124, 106);
            this.lbl_tenant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_tenant.Name = "lbl_tenant";
            this.lbl_tenant.Size = new System.Drawing.Size(57, 17);
            this.lbl_tenant.TabIndex = 4;
            this.lbl_tenant.Text = "Tenant:";
            // 
            // txt_tenant
            // 
            this.txt_tenant.Location = new System.Drawing.Point(191, 101);
            this.txt_tenant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_tenant.Name = "txt_tenant";
            this.txt_tenant.Size = new System.Drawing.Size(132, 22);
            this.txt_tenant.TabIndex = 5;
            // 
            // lbl_movedIn
            // 
            this.lbl_movedIn.AutoSize = true;
            this.lbl_movedIn.BackColor = System.Drawing.Color.Transparent;
            this.lbl_movedIn.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_movedIn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_movedIn.Location = new System.Drawing.Point(353, 31);
            this.lbl_movedIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_movedIn.Name = "lbl_movedIn";
            this.lbl_movedIn.Size = new System.Drawing.Size(75, 17);
            this.lbl_movedIn.TabIndex = 6;
            this.lbl_movedIn.Text = "Moved In:";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.BackColor = System.Drawing.Color.Transparent;
            this.lbl_price.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_price.Location = new System.Drawing.Point(353, 106);
            this.lbl_price.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(44, 17);
            this.lbl_price.TabIndex = 7;
            this.lbl_price.Text = "Price:";
            this.lbl_price.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_UpdateRoom
            // 
            this.btn_UpdateRoom.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdateRoom.Image = ((System.Drawing.Image)(resources.GetObject("btn_UpdateRoom.Image")));
            this.btn_UpdateRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_UpdateRoom.Location = new System.Drawing.Point(1052, 90);
            this.btn_UpdateRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_UpdateRoom.Name = "btn_UpdateRoom";
            this.btn_UpdateRoom.Size = new System.Drawing.Size(111, 50);
            this.btn_UpdateRoom.TabIndex = 10;
            this.btn_UpdateRoom.Text = "Update";
            this.btn_UpdateRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_UpdateRoom.UseVisualStyleBackColor = true;
            this.btn_UpdateRoom.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_editRoom
            // 
            this.btn_editRoom.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editRoom.Image = ((System.Drawing.Image)(resources.GetObject("btn_editRoom.Image")));
            this.btn_editRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_editRoom.Location = new System.Drawing.Point(1171, 27);
            this.btn_editRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_editRoom.Name = "btn_editRoom";
            this.btn_editRoom.Size = new System.Drawing.Size(111, 53);
            this.btn_editRoom.TabIndex = 11;
            this.btn_editRoom.Text = "    Edit";
            this.btn_editRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_editRoom.UseVisualStyleBackColor = true;
            this.btn_editRoom.Click += new System.EventHandler(this.btn_editRoom_Click);
            // 
            // btn_deleteRoom
            // 
            this.btn_deleteRoom.BackColor = System.Drawing.Color.Transparent;
            this.btn_deleteRoom.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteRoom.Image = ((System.Drawing.Image)(resources.GetObject("btn_deleteRoom.Image")));
            this.btn_deleteRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_deleteRoom.Location = new System.Drawing.Point(1052, 27);
            this.btn_deleteRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_deleteRoom.Name = "btn_deleteRoom";
            this.btn_deleteRoom.Size = new System.Drawing.Size(111, 53);
            this.btn_deleteRoom.TabIndex = 12;
            this.btn_deleteRoom.Text = "Delete";
            this.btn_deleteRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_deleteRoom.UseVisualStyleBackColor = false;
            this.btn_deleteRoom.Click += new System.EventHandler(this.btn_deleteRoom_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(435, 31);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(918, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 51);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(435, 104);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(200, 22);
            this.txt_price.TabIndex = 15;
            // 
            // frm_room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1344, 897);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_deleteRoom);
            this.Controls.Add(this.btn_editRoom);
            this.Controls.Add(this.btn_UpdateRoom);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_movedIn);
            this.Controls.Add(this.txt_tenant);
            this.Controls.Add(this.lbl_tenant);
            this.Controls.Add(this.txt_RoomNo);
            this.Controls.Add(this.lbl_roomNo);
            this.Controls.Add(this.btn_addRoom);
            this.Controls.Add(this.dg_ManageRoom);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_room";
            this.Text = "Room";
            this.Load += new System.EventHandler(this.frm_room_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_ManageRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_ManageRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_Room;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_Tenant;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_movedIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_movedOut;
        private System.Windows.Forms.Button btn_addRoom;
        private System.Windows.Forms.Label lbl_roomNo;
        private System.Windows.Forms.TextBox txt_RoomNo;
        private System.Windows.Forms.Label lbl_tenant;
        private System.Windows.Forms.TextBox txt_tenant;
        private System.Windows.Forms.Label lbl_movedIn;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Button btn_UpdateRoom;
        private System.Windows.Forms.Button btn_editRoom;
        private System.Windows.Forms.Button btn_deleteRoom;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_price;
    }
}