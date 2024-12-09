namespace AppartmentSystem.ManageRoom
{
    partial class frm_Archive
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Archive));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dg_archiveRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_archiveTenant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_archiveMovedIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_archivePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_archive = new System.Windows.Forms.Label();
            this.btn_archiveBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dg_archiveRoom,
            this.dg_archiveTenant,
            this.dg_archiveMovedIn,
            this.dg_archivePrice});
            this.dataGridView1.Location = new System.Drawing.Point(20, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(963, 416);
            this.dataGridView1.TabIndex = 0;
            // 
            // dg_archiveRoom
            // 
            this.dg_archiveRoom.HeaderText = "Room Number ";
            this.dg_archiveRoom.Name = "dg_archiveRoom";
            // 
            // dg_archiveTenant
            // 
            this.dg_archiveTenant.HeaderText = "Tenant";
            this.dg_archiveTenant.Name = "dg_archiveTenant";
            // 
            // dg_archiveMovedIn
            // 
            this.dg_archiveMovedIn.HeaderText = "Moved In";
            this.dg_archiveMovedIn.Name = "dg_archiveMovedIn";
            // 
            // dg_archivePrice
            // 
            this.dg_archivePrice.HeaderText = "Price ";
            this.dg_archivePrice.Name = "dg_archivePrice";
            // 
            // lbl_archive
            // 
            this.lbl_archive.AutoSize = true;
            this.lbl_archive.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_archive.Location = new System.Drawing.Point(12, 9);
            this.lbl_archive.Name = "lbl_archive";
            this.lbl_archive.Size = new System.Drawing.Size(122, 43);
            this.lbl_archive.TabIndex = 1;
            this.lbl_archive.Text = "Archive";
            // 
            // btn_archiveBack
            // 
            this.btn_archiveBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_archiveBack.Image = ((System.Drawing.Image)(resources.GetObject("btn_archiveBack.Image")));
            this.btn_archiveBack.Location = new System.Drawing.Point(909, 33);
            this.btn_archiveBack.Name = "btn_archiveBack";
            this.btn_archiveBack.Size = new System.Drawing.Size(55, 43);
            this.btn_archiveBack.TabIndex = 2;
            this.btn_archiveBack.UseVisualStyleBackColor = true;
            // 
            // frm_Archive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btn_archiveBack);
            this.Controls.Add(this.lbl_archive);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frm_Archive";
            this.Text = "Archive";
            this.Load += new System.EventHandler(this.Archive_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_archiveRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_archiveTenant;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_archiveMovedIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_archivePrice;
        private System.Windows.Forms.Label lbl_archive;
        private System.Windows.Forms.Button btn_archiveBack;
    }
}