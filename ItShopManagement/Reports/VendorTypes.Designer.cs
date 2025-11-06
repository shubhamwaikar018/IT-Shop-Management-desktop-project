namespace ItShopManagement.Reports
{
    partial class VendorTypes
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.itShopManagmentDataSet1 = new ItShopManagement.ItShopManagmentDataSet1();
            this.vendorTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendorTypeTableAdapter = new ItShopManagement.ItShopManagmentDataSet1TableAdapters.VendorTypeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.itShopManagmentDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vendorTypeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ItShopManagement.Reports.VendorType.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(968, 540);
            this.reportViewer1.TabIndex = 0;
            // 
            // itShopManagmentDataSet1
            // 
            this.itShopManagmentDataSet1.DataSetName = "ItShopManagmentDataSet1";
            this.itShopManagmentDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendorTypeBindingSource
            // 
            this.vendorTypeBindingSource.DataMember = "VendorType";
            this.vendorTypeBindingSource.DataSource = this.itShopManagmentDataSet1;
            // 
            // vendorTypeTableAdapter
            // 
            this.vendorTypeTableAdapter.ClearBeforeFill = true;
            // 
            // VendorTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 540);
            this.Controls.Add(this.reportViewer1);
            this.Name = "VendorTypes";
            this.Text = "VendorTypes";
            this.Load += new System.EventHandler(this.VendorTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itShopManagmentDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorTypeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ItShopManagmentDataSet1 itShopManagmentDataSet1;
        private System.Windows.Forms.BindingSource vendorTypeBindingSource;
        private ItShopManagmentDataSet1TableAdapters.VendorTypeTableAdapter vendorTypeTableAdapter;
    }
}