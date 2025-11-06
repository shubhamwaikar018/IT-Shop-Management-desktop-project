namespace ItShopManagement
{
    partial class frmservicestatus
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvServiceStatus;
        private System.Windows.Forms.TextBox txtStatusID;
        private System.Windows.Forms.TextBox txtStatusName;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmservicestatus));
            this.dgvServiceStatus = new System.Windows.Forms.DataGridView();
            this.txtStatusID = new System.Windows.Forms.TextBox();
            this.txtStatusName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnVexit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnVTsave = new System.Windows.Forms.Button();
            this.btnVTdel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceStatus)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvServiceStatus
            // 
            this.dgvServiceStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServiceStatus.Location = new System.Drawing.Point(406, 62);
            this.dgvServiceStatus.Name = "dgvServiceStatus";
            this.dgvServiceStatus.Size = new System.Drawing.Size(533, 430);
            this.dgvServiceStatus.TabIndex = 0;
            // 
            // txtStatusID
            // 
            this.txtStatusID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStatusID.Location = new System.Drawing.Point(206, 72);
            this.txtStatusID.Name = "txtStatusID";
            this.txtStatusID.Size = new System.Drawing.Size(198, 20);
            this.txtStatusID.TabIndex = 2;
            this.txtStatusID.TextChanged += new System.EventHandler(this.txtStatusID_TextChanged);
            // 
            // txtStatusName
            // 
            this.txtStatusName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStatusName.Location = new System.Drawing.Point(206, 157);
            this.txtStatusName.Name = "txtStatusName";
            this.txtStatusName.Size = new System.Drawing.Size(198, 20);
            this.txtStatusName.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-1, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 64);
            this.panel1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(270, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Service Status";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtStatusName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtStatusID, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-1, 62);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.11258F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.88742F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(407, 211);
            this.tableLayoutPanel1.TabIndex = 9;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "StatusName";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "StatusId";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tableLayoutPanel2.Controls.Add(this.btnVexit, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnVTsave, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnVTdel, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(-1, 297);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(404, 104);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // btnVexit
            // 
            this.btnVexit.BackColor = System.Drawing.Color.Transparent;
            this.btnVexit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVexit.BackgroundImage")));
            this.btnVexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVexit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVexit.Location = new System.Drawing.Point(305, 3);
            this.btnVexit.Name = "btnVexit";
            this.btnVexit.Size = new System.Drawing.Size(96, 98);
            this.btnVexit.TabIndex = 24;
            this.btnVexit.UseVisualStyleBackColor = false;
            this.btnVexit.Click += new System.EventHandler(this.btnVexit_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 98);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVTsave
            // 
            this.btnVTsave.AutoSize = true;
            this.btnVTsave.BackColor = System.Drawing.Color.Transparent;
            this.btnVTsave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVTsave.BackgroundImage")));
            this.btnVTsave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVTsave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVTsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVTsave.Location = new System.Drawing.Point(105, 3);
            this.btnVTsave.Name = "btnVTsave";
            this.btnVTsave.Size = new System.Drawing.Size(96, 98);
            this.btnVTsave.TabIndex = 22;
            this.btnVTsave.UseVisualStyleBackColor = false;
            this.btnVTsave.Click += new System.EventHandler(this.btnVTsave_Click);
            // 
            // btnVTdel
            // 
            this.btnVTdel.AutoSize = true;
            this.btnVTdel.BackColor = System.Drawing.Color.Transparent;
            this.btnVTdel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVTdel.BackgroundImage")));
            this.btnVTdel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVTdel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVTdel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVTdel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnVTdel.Location = new System.Drawing.Point(207, 3);
            this.btnVTdel.Name = "btnVTdel";
            this.btnVTdel.Size = new System.Drawing.Size(92, 98);
            this.btnVTdel.TabIndex = 23;
            this.btnVTdel.UseVisualStyleBackColor = false;
            this.btnVTdel.Click += new System.EventHandler(this.btnVTdel_Click);
            // 
            // frmservicestatus
            // 
            this.ClientSize = new System.Drawing.Size(939, 492);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvServiceStatus);
            this.Name = "frmservicestatus";
            this.Text = "Manage Service Status";
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceStatus)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnVTsave;
        private System.Windows.Forms.Button btnVTdel;
        private System.Windows.Forms.Button btnVexit;
    }
}
