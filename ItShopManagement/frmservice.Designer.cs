using System;

namespace ItShopManagement
{
    partial class frmservice
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvService;
        private System.Windows.Forms.TextBox txtServiceID;
        private System.Windows.Forms.TextBox txtServiceName;
        private System.Windows.Forms.TextBox txtServiceStatusName;
        private System.Windows.Forms.TextBox txtServiceModeName;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmservice));
            this.dgvService = new System.Windows.Forms.DataGridView();
            this.txtServiceID = new System.Windows.Forms.TextBox();
            this.txtServiceName = new System.Windows.Forms.TextBox();
            this.txtServiceStatusName = new System.Windows.Forms.TextBox();
            this.txtServiceModeName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnVexit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnVTsave = new System.Windows.Forms.Button();
            this.btnVTdel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvService
            // 
            this.dgvService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvService.Location = new System.Drawing.Point(466, 69);
            this.dgvService.Name = "dgvService";
            this.dgvService.Size = new System.Drawing.Size(457, 429);
            this.dgvService.TabIndex = 0;
            // 
            // txtServiceID
            // 
            this.txtServiceID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtServiceID.Location = new System.Drawing.Point(250, 43);
            this.txtServiceID.Name = "txtServiceID";
            this.txtServiceID.Size = new System.Drawing.Size(200, 20);
            this.txtServiceID.TabIndex = 2;
            // 
            // txtServiceName
            // 
            this.txtServiceName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtServiceName.Location = new System.Drawing.Point(250, 102);
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.Size = new System.Drawing.Size(200, 20);
            this.txtServiceName.TabIndex = 4;
            // 
            // txtServiceStatusID
            // 
            this.txtServiceStatusName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtServiceStatusName.Location = new System.Drawing.Point(250, 164);
            this.txtServiceStatusName.Name = "txtServiceStatusID";
            this.txtServiceStatusName.Size = new System.Drawing.Size(200, 20);
            this.txtServiceStatusName.TabIndex = 6;
            // 
            // txtServiceModeID
            // 
            this.txtServiceModeName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtServiceModeName.Location = new System.Drawing.Point(250, 230);
            this.txtServiceModeName.Name = "txtServiceModeID";
            this.txtServiceModeName.Size = new System.Drawing.Size(200, 20);
            this.txtServiceModeName.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(923, 69);
            this.panel1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(409, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Service";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtServiceModeName, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtServiceStatusName, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtServiceName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtServiceID, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-1, 69);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.26829F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.7317F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(467, 273);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Service Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(227, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Service Mode Name";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Service ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Service Status Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(-1, 348);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(467, 104);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // btnVexit
            // 
            this.btnVexit.BackColor = System.Drawing.Color.Transparent;
            this.btnVexit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVexit.BackgroundImage")));
            this.btnVexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVexit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVexit.Location = new System.Drawing.Point(369, 3);
            this.btnVexit.Name = "btnVexit";
            this.btnVexit.Size = new System.Drawing.Size(95, 98);
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
            this.button1.Size = new System.Drawing.Size(128, 98);
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
            this.btnVTsave.Location = new System.Drawing.Point(137, 3);
            this.btnVTsave.Name = "btnVTsave";
            this.btnVTsave.Size = new System.Drawing.Size(128, 98);
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
            this.btnVTdel.Location = new System.Drawing.Point(271, 3);
            this.btnVTdel.Name = "btnVTdel";
            this.btnVTdel.Size = new System.Drawing.Size(92, 98);
            this.btnVTdel.TabIndex = 23;
            this.btnVTdel.UseVisualStyleBackColor = false;
            this.btnVTdel.Click += new System.EventHandler(this.btnVTdel_Click);
            // 
            // frmservice
            // 
            this.ClientSize = new System.Drawing.Size(908, 496);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvService);
            this.Name = "frmservice";
            this.Text = "Manage Services";
            this.Load += new System.EventHandler(this.frmservice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvService)).EndInit();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnVexit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnVTsave;
        private System.Windows.Forms.Button btnVTdel;
    }
}
