namespace ItShopManagement
{
    partial class frmservicemode
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvServiceMode;
        private System.Windows.Forms.TextBox txtModeID;
        private System.Windows.Forms.TextBox txtModeName;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmservicemode));
            this.dgvServiceMode = new System.Windows.Forms.DataGridView();
            this.txtModeID = new System.Windows.Forms.TextBox();
            this.txtModeName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnVexit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnVTsave = new System.Windows.Forms.Button();
            this.btnVTdel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceMode)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvServiceMode
            // 
            this.dgvServiceMode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServiceMode.Location = new System.Drawing.Point(378, 72);
            this.dgvServiceMode.Name = "dgvServiceMode";
            this.dgvServiceMode.Size = new System.Drawing.Size(554, 406);
            this.dgvServiceMode.TabIndex = 0;
            // 
            // txtModeID
            // 
            this.txtModeID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtModeID.Location = new System.Drawing.Point(175, 73);
            this.txtModeID.Name = "txtModeID";
            this.txtModeID.Size = new System.Drawing.Size(200, 20);
            this.txtModeID.TabIndex = 2;
            // 
            // txtModeName
            // 
            this.txtModeName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtModeName.Location = new System.Drawing.Point(175, 149);
            this.txtModeName.Name = "txtModeName";
            this.txtModeName.Size = new System.Drawing.Size(201, 20);
            this.txtModeName.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 72);
            this.panel1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(300, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Service Mode";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.38259F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.61741F));
            this.tableLayoutPanel1.Controls.Add(this.txtModeName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtModeID, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 72);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.78947F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.21053F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 81F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(379, 200);
            this.tableLayoutPanel1.TabIndex = 9;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Mode ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Mode Name";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 278);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(379, 98);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // btnVexit
            // 
            this.btnVexit.BackColor = System.Drawing.Color.Transparent;
            this.btnVexit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVexit.BackgroundImage")));
            this.btnVexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVexit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVexit.Location = new System.Drawing.Point(281, 3);
            this.btnVexit.Name = "btnVexit";
            this.btnVexit.Size = new System.Drawing.Size(95, 92);
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
            this.button1.Size = new System.Drawing.Size(84, 92);
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
            this.btnVTsave.Location = new System.Drawing.Point(93, 3);
            this.btnVTsave.Name = "btnVTsave";
            this.btnVTsave.Size = new System.Drawing.Size(84, 92);
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
            this.btnVTdel.Location = new System.Drawing.Point(183, 3);
            this.btnVTdel.Name = "btnVTdel";
            this.btnVTdel.Size = new System.Drawing.Size(92, 92);
            this.btnVTdel.TabIndex = 23;
            this.btnVTdel.UseVisualStyleBackColor = false;
            this.btnVTdel.Click += new System.EventHandler(this.btnVTdel_Click);
            // 
            // frmservicemode
            // 
            this.ClientSize = new System.Drawing.Size(930, 476);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvServiceMode);
            this.Name = "frmservicemode";
            this.Text = "Manage Service Mode";
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceMode)).EndInit();
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnVexit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnVTsave;
        private System.Windows.Forms.Button btnVTdel;
    }
}
