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
            this.lbl_movedOut = new System.Windows.Forms.Label();
            this.txt_MovedIn = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_UpdateRoom = new System.Windows.Forms.Button();
            this.btn_editRoom = new System.Windows.Forms.Button();
            this.btn_deleteRoom = new System.Windows.Forms.Button();
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
            this.dg_ManageRoom.Location = new System.Drawing.Point(56, 138);
            this.dg_ManageRoom.Name = "dg_ManageRoom";
            this.dg_ManageRoom.ReadOnly = true;
            this.dg_ManageRoom.Size = new System.Drawing.Size(897, 476);
            this.dg_ManageRoom.TabIndex = 0;
            // 
            // dg_Room
            // 
            this.dg_Room.HeaderText = "Room";
            this.dg_Room.Name = "dg_Room";
            this.dg_Room.ReadOnly = true;
            // 
            // dg_Tenant
            // 
            this.dg_Tenant.HeaderText = "Tenant";
            this.dg_Tenant.Name = "dg_Tenant";
            this.dg_Tenant.ReadOnly = true;
            // 
            // dg_movedIn
            // 
            this.dg_movedIn.HeaderText = "Moved In";
            this.dg_movedIn.Name = "dg_movedIn";
            this.dg_movedIn.ReadOnly = true;
            // 
            // dg_movedOut
            // 
            this.dg_movedOut.HeaderText = "Moved Out";
            this.dg_movedOut.Name = "dg_movedOut";
            this.dg_movedOut.ReadOnly = true;
            // 
            // btn_addRoom
            // 
            this.btn_addRoom.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addRoom.Image = ((System.Drawing.Image)(resources.GetObject("btn_addRoom.Image")));
            this.btn_addRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_addRoom.Location = new System.Drawing.Point(878, 73);
            this.btn_addRoom.Name = "btn_addRoom";
            this.btn_addRoom.Size = new System.Drawing.Size(83, 41);
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
            this.lbl_roomNo.Location = new System.Drawing.Point(99, 25);
            this.lbl_roomNo.Name = "lbl_roomNo";
            this.lbl_roomNo.Size = new System.Drawing.Size(43, 14);
            this.lbl_roomNo.TabIndex = 2;
            this.lbl_roomNo.Text = "Room:";
            // 
            // txt_RoomNo
            // 
            this.txt_RoomNo.Location = new System.Drawing.Point(143, 22);
            this.txt_RoomNo.Name = "txt_RoomNo";
            this.txt_RoomNo.Size = new System.Drawing.Size(100, 20);
            this.txt_RoomNo.TabIndex = 3;
            // 
            // lbl_tenant
            // 
            this.lbl_tenant.AutoSize = true;
            this.lbl_tenant.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tenant.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tenant.Location = new System.Drawing.Point(93, 86);
            this.lbl_tenant.Name = "lbl_tenant";
            this.lbl_tenant.Size = new System.Drawing.Size(48, 14);
            this.lbl_tenant.TabIndex = 4;
            this.lbl_tenant.Text = "Tenant:";
            // 
            // txt_tenant
            // 
            this.txt_tenant.Location = new System.Drawing.Point(143, 82);
            this.txt_tenant.Name = "txt_tenant";
            this.txt_tenant.Size = new System.Drawing.Size(100, 20);
            this.txt_tenant.TabIndex = 5;
            // 
            // lbl_movedIn
            // 
            this.lbl_movedIn.AutoSize = true;
            this.lbl_movedIn.BackColor = System.Drawing.Color.Transparent;
            this.lbl_movedIn.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_movedIn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_movedIn.Location = new System.Drawing.Point(530, 25);
            this.lbl_movedIn.Name = "lbl_movedIn";
            this.lbl_movedIn.Size = new System.Drawing.Size(62, 14);
            this.lbl_movedIn.TabIndex = 6;
            this.lbl_movedIn.Text = "Moved In:";
            // 
            // lbl_movedOut
            // 
            this.lbl_movedOut.AutoSize = true;
            this.lbl_movedOut.BackColor = System.Drawing.Color.Transparent;
            this.lbl_movedOut.Font = new System.Drawing.Font("Calisto MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_movedOut.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_movedOut.Location = new System.Drawing.Point(520, 82);
            this.lbl_movedOut.Name = "lbl_movedOut";
            this.lbl_movedOut.Size = new System.Drawing.Size(72, 14);
            this.lbl_movedOut.TabIndex = 7;
            this.lbl_movedOut.Text = "Moved Out:";
            this.lbl_movedOut.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_MovedIn
            // 
            this.txt_MovedIn.Location = new System.Drawing.Point(595, 22);
            this.txt_MovedIn.Name = "txt_MovedIn";
            this.txt_MovedIn.Size = new System.Drawing.Size(100, 20);
            this.txt_MovedIn.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(595, 79);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            // 
            // btn_UpdateRoom
            // 
            this.btn_UpdateRoom.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdateRoom.Image = ((System.Drawing.Image)(resources.GetObject("btn_UpdateRoom.Image")));
            this.btn_UpdateRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_UpdateRoom.Location = new System.Drawing.Point(789, 73);
            this.btn_UpdateRoom.Name = "btn_UpdateRoom";
            this.btn_UpdateRoom.Size = new System.Drawing.Size(83, 41);
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
            this.btn_editRoom.Location = new System.Drawing.Point(878, 22);
            this.btn_editRoom.Name = "btn_editRoom";
            this.btn_editRoom.Size = new System.Drawing.Size(83, 43);
            this.btn_editRoom.TabIndex = 11;
            this.btn_editRoom.Text = "    Edit";
            this.btn_editRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_editRoom.UseVisualStyleBackColor = true;
            // 
            // btn_deleteRoom
            // 
            this.btn_deleteRoom.BackColor = System.Drawing.Color.Transparent;
            this.btn_deleteRoom.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteRoom.Image = ((System.Drawing.Image)(resources.GetObject("btn_deleteRoom.Image")));
            this.btn_deleteRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_deleteRoom.Location = new System.Drawing.Point(789, 22);
            this.btn_deleteRoom.Name = "btn_deleteRoom";
            this.btn_deleteRoom.Size = new System.Drawing.Size(83, 43);
            this.btn_deleteRoom.TabIndex = 12;
            this.btn_deleteRoom.Text = "Delete";
            this.btn_deleteRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_deleteRoom.UseVisualStyleBackColor = false;
            this.btn_deleteRoom.Click += new System.EventHandler(this.btn_deleteRoom_Click);
            // 
            // frm_room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btn_deleteRoom);
            this.Controls.Add(this.btn_editRoom);
            this.Controls.Add(this.btn_UpdateRoom);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txt_MovedIn);
            this.Controls.Add(this.lbl_movedOut);
            this.Controls.Add(this.lbl_movedIn);
            this.Controls.Add(this.txt_tenant);
            this.Controls.Add(this.lbl_tenant);
            this.Controls.Add(this.txt_RoomNo);
            this.Controls.Add(this.lbl_roomNo);
            this.Controls.Add(this.btn_addRoom);
            this.Controls.Add(this.dg_ManageRoom);
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
        private System.Windows.Forms.Label lbl_movedOut;
        private System.Windows.Forms.TextBox txt_MovedIn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_UpdateRoom;
        private System.Windows.Forms.Button btn_editRoom;
        private System.Windows.Forms.Button btn_deleteRoom;
    }
}