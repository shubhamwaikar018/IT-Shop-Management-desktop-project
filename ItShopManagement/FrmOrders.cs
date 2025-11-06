using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyDataBaseManager;

namespace ItShopManagement
{
    public partial class FrmOrders : Form
    {
        DBManager dbm = new DBManager();
        DBManager dbmStock = new DBManager();

        BindingSource bsVT = new BindingSource();
        BindingSource bsV = new BindingSource();
        BindingSource bsO = new BindingSource();
        BindingSource bsOS = new BindingSource();
        BindingSource bsPR = new BindingSource();
        BindingSource bsP = new BindingSource();
        BindingSource bsPM = new BindingSource();
        BindingSource bsPT = new BindingSource();
        BindingSource bsPC = new BindingSource();
        BindingSource bsOD = new BindingSource();
        BindingSource bsStockProducts;

        public FrmOrders()
        {
            InitializeComponent();
        }

        private void FrmOrders_Load(object sender, EventArgs e)
        {
            dbm.cdaVendorType();
            dbm.cdaVendors();

            dbm.CDA_OrderStatus();
            dbm.CDA_Orders();

            dbm.CDA_ProductType();
            dbm.CDA_ProductCategory();
            dbm.CDA_Products();

            dbm.CDA_OrderDetails();
            dbm.CDA_Payment_Mode();
            dbm.CDA_Payments();
            dbmStock.CDA_Products();


            dbm.crVendorType_Vendors();
            dbm.crProductType_ProductCat();
            dbm.crProductcat_Products();
            dbm.crVendor_Orders();
            dbm.crOrders_OrderDetails();
            dbm.crOrders_Payments();


            bsPT = dbm.bsProductType;
            bsPC = dbm.bsProductCategory;
            bsPR = dbm.bsProducts;
            bsOS = dbm.bsOrderStatus;
            bsVT = dbm.bsVendorType;
            bsV = dbm.bsVendors;

            bsO = dbm.bsOrders;
            bsP = dbm.bsPayments;
            bsPM = dbm.bsPaymentMode;
            bsOD = dbm.bsOrderDetails;

            bsStockProducts = dbmStock.bsProducts;
            dgvproductstock.DataSource = bsStockProducts;

            dbm.DSmydataset.Tables["OrderDetails"].Columns.Add("LineTotal", System.Type.GetType("System.Int32"));
            dbm.DSmydataset.Tables["OrderDetails"].Columns["LineTotal"].Expression = "Quantity*Price";

            dbm.DSmydataset.Tables["Orders"].Columns.Add("OrderTotal", System.Type.GetType("System.Int32"));
            dbm.DSmydataset.Tables["Orders"].Columns["OrderTotal"].Expression = "IsNull(sum(child(Orders2OrderDetails).LineTotal),0)";

            dbm.DSmydataset.Tables["Orders"].Columns.Add("TotalDiscount", System.Type.GetType("System.Int32"));
            dbm.DSmydataset.Tables["Orders"].Columns["TotalDiscount"].Expression = "IsNull((OrderTotal*Discount)/100,0)";

            dbm.DSmydataset.Tables["Orders"].Columns.Add("FinalTotal", System.Type.GetType("System.Int32"));
            dbm.DSmydataset.Tables["Orders"].Columns["FinalTotal"].Expression = "IsNull((OrderTotal-TotalDiscount),0)";

            dbm.DSmydataset.Tables["Orders"].Columns.Add("Paid", System.Type.GetType("System.Int32"));
            dbm.DSmydataset.Tables["Orders"].Columns["Paid"].Expression = "IsNull(sum(child(Orders2Payments).Amount),0)";

            dbm.DSmydataset.Tables["Orders"].Columns.Add("Due", System.Type.GetType("System.Int32"));
            dbm.DSmydataset.Tables["Orders"].Columns["Due"].Expression = "IsNull((FinalTotal-Paid),0)";

            /* if (dbm.DSmydataset != null)
             {*/
            //Vendors tab
            lstVendors.DataSource = bsV;
            lstVendors.DisplayMember = "VendorName";
            lstVendors.ValueMember = "VendorId";

            cmbVendorType.DataSource = bsVT;
            cmbVendorType.DisplayMember = "VendorTypeName";
            cmbVendorType.ValueMember = "VendorTypeId";

            //Orders Tab
            lblVendorTypeOrder.DataBindings.Add(new Binding("Text", bsVT, "VendorTypeName", true));
            lblVendorOrder.DataBindings.Add(new Binding("Text", bsV, "VendorName", true));
            tbOrderId.DataBindings.Add(new Binding("Text", bsO, "OrderId", true));
            tbOrderDate.DataBindings.Add(new Binding("Value", bsO, "OrderDate", true));
            cmbOrderStatus.DataBindings.Add(new Binding("SelectedValue", bsO, "OrderStatusId", true));
            tbOrderDiscount.DataBindings.Add(new Binding("Text", bsO, "Discount", true));


            cmbOrderStatus.DataSource = bsOS;
            cmbOrderStatus.DisplayMember = "OrderStatusName";
            cmbOrderStatus.ValueMember = "OrderStatusId";

            dgvVendor.DataSource = bsO;
            dgvVendor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            //OrderDetails

            lblCgstOD.DataBindings.Add(new Binding("Text", bsPT, "CGST", true));
            lblSgstOD.DataBindings.Add(new Binding("Text", bsPT, "SGST", true));

            tbOrderID_OD.DataBindings.Add(new Binding("Text", bsOD, "OrderId", true));
            cmbPOrderDetails.DataBindings.Add(new Binding("SelectedValue", bsOD, "ProductId", true));
            tbQuantityOD.DataBindings.Add(new Binding("Text", bsOD, "Quantity", true));
            tbFinalPriceOD.DataBindings.Add(new Binding("Text", bsOD, "Price", true));

            tbUnitPriceProduct.DataBindings.Add(new Binding("Text", bsPR, "UnitPrice", true));
            tbMarginProduct.DataBindings.Add(new Binding("Text", bsPR, "Margin", true));
            tbStockProduct.DataBindings.Add(new Binding("Text", bsPR, "Quantity", true));

            cmbPtOrderDetails.DataSource = bsPT;
            cmbPtOrderDetails.DisplayMember = "ProductTypeName";
            cmbPtOrderDetails.ValueMember = "ProductTypeId";

            cmbPcOrderDetails.DataSource = bsPC;
            cmbPcOrderDetails.DisplayMember = "ProductCategoryName";
            cmbPcOrderDetails.ValueMember = "ProductCategoryId";

            cmbPOrderDetails.DataSource = bsPR;
            cmbPOrderDetails.DisplayMember = "ProductName";
            cmbPOrderDetails.ValueMember = "ProductId";

            dgvOrderDetails.DataSource = bsOD;
            dgvOrderDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;


            //Stock
            btnsellproduct.DataBindings.Add(new Binding("Visible", bsO, "OrderStatusId", true));

            //Payments Tab
            lblOrderTotalPayment.DataBindings.Add(new Binding("Text", bsO, "FinalTotal", true));
            lblPaidAmountPayment.DataBindings.Add(new Binding("Text", bsO, "Paid", true));
            lblDueAmountPayment.DataBindings.Add(new Binding("Text", bsO, "Due", true));

            tbPaymentID.DataBindings.Add(new Binding("Text", bsP, "PaymentId", true));
            dtpPaymentDate.DataBindings.Add(new Binding("Value", bsP, "PaymentDate", true));
            tbPaymentAmount.DataBindings.Add(new Binding("Text", bsP, "Amount", true));
            cmbPaymentMode.DataBindings.Add(new Binding("SelectedValue", bsP, "PaymentModeId", true));
            tbPaymentDescription.DataBindings.Add(new Binding("Text", bsP, "Description", true));
            tbOrderIDPayments.DataBindings.Add(new Binding("Text", bsP, "OrderId", true));

            cmbPaymentMode.DataSource = bsPM;
            cmbPaymentMode.DisplayMember = "PaymentModeName";
            cmbPaymentMode.ValueMember = "PaymentModeId";

            dgvPayments.DataSource = bsP;
            dgvPayments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

       

        private void btnAddPayments_Click(object sender, EventArgs e)
        {
            tbPaymentID.Text = dbm.AddNewData(bsP, "Payments", "PaymentId");

        }

        private void btnSavePyments_Click(object sender, EventArgs e)
        {
            dbm.SaveData(bsP, dbm.daPayments, "Payments");
        }

        private void btnDeletePayments_Click(object sender, EventArgs e)
        {
            dbm.DeleteData(bsP);
        }
        

        private void btnUpdateOrderStatusPayment_Click(object sender, EventArgs e)
        {
            try
            {

                DataRowView OrderRV = (DataRowView)bsO.Current;
                DataRow OrderR = (DataRow)OrderRV.Row;

                if (Convert.ToInt32(OrderR["Due"]) > 0)
                {
                }
                else
                {
                    OrderR["OrderStatusID"] = 3;
                }

                    this.Validate();
                    dbm.bsOrders.EndEdit();
                    dbm.daOrders.Update(dbm.DSmydataset, "Orders");
                    dbm.DSmydataset.AcceptChanges();
                    MessageBox.Show("Order Status Updated successfully...!!!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "SqlException", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
           
        }

        private void tbQuantityOD_TextChanged(object sender, EventArgs e)
        {
            int StockMargin = int.Parse(tbMarginProduct.Text);
            if (Convert.ToInt32(cmbVendorType.SelectedValue) == 1)
            {
                int stockUnitPrice = int.Parse(tbUnitPriceProduct.Text);
                tbFinalPriceOD.Text = stockUnitPrice.ToString();
            }
            else
            {
                int stockUnitPrice = int.Parse(tbUnitPriceProduct.Text);
                tbFinalPriceOD.Text = (stockUnitPrice + (stockUnitPrice * StockMargin) / 100).ToString();
            }
        }
        private void btnAddOD_Click_1(object sender, EventArgs e)
        {
            tbOrderId.Text = dbm.AddNewData(bsOD, "Orders", "OrderId");
        }

        private void btnSaveOD_Click_1(object sender, EventArgs e)
        {
            dbm.SaveData(bsOD, dbm.daOrderDetails, "Orders");
        }

        private void btnDeleteOD_Click_1(object sender, EventArgs e)
        {
            dbm.DeleteData(bsOD);
        }

        private void btnsellproduct_Click(object sender, EventArgs e)
        {
            DataRowView OrderRV = (DataRowView)bsO.Current;
            DataRow OrderR = (DataRow)OrderRV.Row;
            if (Convert.ToInt32(OrderR["OrderStatusId"]) == 1)
            {
                int OldStock = 0;
                int OrderedMaterial = 0;
                for (int i = 0; i < bsOD.Count; i++)
                {
                    DataRowView OrderDetailsRV = (DataRowView)bsOD.List[i];
                    DataRow OrderDetailsR = (DataRow)OrderDetailsRV.Row;
                    DataRowView StockRV = (DataRowView)dbmStock.bsProducts.List[i];
                    DataRow StockR = (DataRow)StockRV.Row;
                    OldStock = Convert.ToInt32(StockR["Quantity"]);
                    OrderedMaterial = Convert.ToInt32(OrderDetailsR["Quantity"]);
                    DataRowView VendorTypesRV = (DataRowView)dbm.bsVendorType.Current;
                    DataRow VendorTypesR = (DataRow)VendorTypesRV.Row;
                    switch (Convert.ToInt32(VendorTypesR["VendorTypeId"]))
                    {
                        case 1:
                            StockR["Quantity"] = OldStock + OrderedMaterial;
                            OrderR["OrderStatusId"] = 2;
                            break;
                        case 2:
                            StockR["Quantity"] = OldStock - OrderedMaterial;
                            OrderR["OrderStatusId"] = 2;
                            break;
                    }
                }
            }
            //Update Stock In Table
            try
            {
                this.Validate();
                dbmStock.bsProducts.EndEdit();
                dbmStock.daProducts.Update(dbmStock.DSmydataset, "Products");
                dbmStock.DSmydataset.AcceptChanges();
                MessageBox.Show("Stock Updated Successfully...!!!!");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "SqlException", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Change Order Status As Pending
            OrderR["OrderStatusId"] = 2;
            try
            {
                this.Validate();
                dbm.bsOrders.EndEdit();
                dbm.daOrders.Update(dbm.DSmydataset, "Orders");
                dbm.DSmydataset.AcceptChanges();
                MessageBox.Show("Order Status Updated successfully...!!!!");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "SqlException", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnsellproduct.Visible = false;
        }



        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int value = (Convert.ToInt32(tabControl1.SelectedIndex));
           

            dgvproductstock.DataSource = bsStockProducts;
            dgvproductstock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        

        private void tbQuantityOD_TextChanged_1(object sender, EventArgs e)
        {
            int StockMargin = int.Parse(tbMarginProduct.Text);
            if (Convert.ToInt32(cmbVendorType.SelectedValue) == 1)
            {
                int stockUnitPrice = int.Parse(tbUnitPriceProduct.Text);
                tbFinalPriceOD.Text = stockUnitPrice.ToString();
            }
            else
            {
                int stockUnitPrice = int.Parse(tbUnitPriceProduct.Text);
                tbFinalPriceOD.Text = (stockUnitPrice + (stockUnitPrice * StockMargin) / 100).ToString();
            }
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            tbOrderId.Text = dbm.AddNewData(bsO, "Orders", "OrderId");
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            dbm.SaveData(bsO, dbm.daOrders, "Orders");
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            dbm.DeleteData(bsO);
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstVendors_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btndel_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            main Main = new main();
            Main.Show();
        }
    }
}