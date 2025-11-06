using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyDataBaseManager
{
   public class DBManager
    {
        public string connnectionString;
        public SqlConnection dbconnection = null;
        public DataSet DSmydataset;
        public SqlConnection con = null;

        public SqlDataAdapter daVendorType = new SqlDataAdapter();
        public SqlDataAdapter daVendor = new SqlDataAdapter();
        public SqlDataAdapter daProductType = new SqlDataAdapter();
        public SqlDataAdapter daProductCategory = new SqlDataAdapter();
        public SqlDataAdapter daProducts = new SqlDataAdapter();
        public SqlDataAdapter daOrderStatus = new SqlDataAdapter();
        public SqlDataAdapter daPaymentMode = new SqlDataAdapter();
        public SqlDataAdapter daOrders = new SqlDataAdapter();
        public SqlDataAdapter daOrderDetails = new SqlDataAdapter();
        public SqlDataAdapter daPayments = new SqlDataAdapter();
        public SqlDataAdapter dausers = new SqlDataAdapter();
        #region datadapter
        public BindingSource bsVendorType = new BindingSource();
        public BindingSource bsVendors = new BindingSource();
        public BindingSource bsProductType = new BindingSource();
        public BindingSource bsProductCategory = new BindingSource();
        public BindingSource bsProducts = new BindingSource();
        public BindingSource bsOrderStatus = new BindingSource();
        public BindingSource bsPaymentMode = new BindingSource();
        public BindingSource bsOrders = new BindingSource();
        public BindingSource bsOrderDetails = new BindingSource();
        public BindingSource bsPayments = new BindingSource();
        public BindingSource bsuser = new BindingSource();


        #endregion
        public DBManager()
        {
            connnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\ItShopManagement-20240722T064145Z-001\ItShopManagement\ItShopManagement\bin\Debug\ItShopManagment.mdf;Integrated Security=True;";
            dbconnection = new SqlConnection(connnectionString);
            DSmydataset = new DataSet();
            DSmydataset.Locale = System.Globalization.CultureInfo.InvariantCulture;
        }



        public void open()
        {
            HandleConnnection();
        }
        public void close()
        {
            dbconnection.Close();
        }
        public void HandleConnnection()
        {
            if (dbconnection.State == ConnectionState.Open)
            {
                dbconnection.Close();
                dbconnection.Open();
            }
            else if (dbconnection.State == ConnectionState.Closed)
            {
                dbconnection.Open();
            }
            else
            {
                dbconnection.Close();
                dbconnection.Open();
            }
        }


        #region createdatadapter
        public SqlDataAdapter CreateDataAdapter(String tableName)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            try
            {
                String cmd = string.Format("Select * from {0}", tableName);
                adapter.SelectCommand = new SqlCommand(cmd, dbconnection);
                adapter.SelectCommand.Connection = dbconnection;
                SqlCommandBuilder Builder = new SqlCommandBuilder(adapter);
                adapter.UpdateCommand = Builder.GetUpdateCommand();
                adapter.DeleteCommand = Builder.GetDeleteCommand();
                adapter.InsertCommand = Builder.GetInsertCommand();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return adapter;
        }
        public void cdaVendorType()
        {
            daVendorType = CreateDataAdapter("VendorType");
            daVendorType.Fill(DSmydataset, "VendorType");
            bsVendorType = new BindingSource(DSmydataset, "VendorType");
        }
        public void cdaVendors()
        {
            daVendor = CreateDataAdapter("Vendor");
            daVendor.Fill(DSmydataset, "Vendor");
            bsVendors = new BindingSource(DSmydataset, "Vendor");
        }
        public void CDA_OrderStatus()
        {
            daOrderStatus = CreateDataAdapter("OrderStatus");
            daOrderStatus.Fill(DSmydataset, "OrderStatus");
            bsOrderStatus = new BindingSource(DSmydataset, "OrderStatus");
        }

        public void CDA_OrderDetails()
        {
            daOrderDetails = CreateDataAdapter("OrderDetails");
            daOrderDetails.Fill(DSmydataset, "OrderDetails");
            bsOrderDetails = new BindingSource(DSmydataset, "OrderDetails");
        }

        public void CDA_Payment_Mode()
        {
            daPaymentMode = CreateDataAdapter("PaymentMode");
            daPaymentMode.Fill(DSmydataset, "PaymentMode");
            bsPaymentMode = new BindingSource(DSmydataset, "PaymentMode");
        }
        public void CDA_Payments()
        {
            daPayments = CreateDataAdapter("Payments");
            daPayments.Fill(DSmydataset, "Payments");
            bsPayments = new BindingSource(DSmydataset, "Payments");
        }
        public void CDA_Products()
        {
            daProducts = CreateDataAdapter("Products");
            daProducts.Fill(DSmydataset, "Products");
            bsProducts = new BindingSource(DSmydataset, "Products");
        }
        public void CDA_ProductCategory()
        {
            daProductCategory = CreateDataAdapter("ProductCategory");
            daProductCategory.Fill(DSmydataset, "ProductCategory");
            bsProductCategory = new BindingSource(DSmydataset, "ProductCategory");
        }

        public void CDA_ProductType()
        {
            daProductType = CreateDataAdapter("ProductType");
            daProductType.Fill(DSmydataset, "ProductType");
            bsProductType = new BindingSource(DSmydataset, "ProductType");
        }
        public void CDA_Orders()
        {
            daOrders = CreateDataAdapter("Orders");
            daOrders.Fill(DSmydataset, "Orders");
            bsOrders = new BindingSource(DSmydataset, "Orders");
        }
        public void CDA_Users()
        {
            dausers = CreateDataAdapter("Users");
            dausers.Fill(DSmydataset, "Users");
            bsuser = new BindingSource(DSmydataset, "Users");
        }

        #endregion

        #region Relation
        public string CreateRelation(string parentTable, string clildTable, string columnName)
        {
            string relationName = string.Concat(parentTable, "2", clildTable);
            DSmydataset.Relations.Add(relationName, DSmydataset.Tables[parentTable].Columns[columnName], DSmydataset.Tables[clildTable].Columns[columnName]);
            return relationName;
        }
        public void RemoveRelation(string RelationName)
        {
            DSmydataset.Relations.Remove(RelationName);
        }
        public BindingSource GetRelationBS(string relationName, BindingSource bsMaster)
        {
            BindingSource bs = new BindingSource(bsMaster, relationName);
            return bs;
        }
        public string crVendorType_Vendors()
        {
            string r1 = CreateRelation("VendorType", "Vendor", "VendorTypeId");
            bsVendors = GetRelationBS(r1, bsVendorType);
            return r1;
        }

        public string crProductType_ProductCat()
        {
            string r1 = CreateRelation("ProductType", "ProductCategory", "ProductTypeId");
            bsProductCategory = GetRelationBS(r1, bsProductType);
            return r1;
        }
       

        public string crProductcat_Products()
        {
            string r1 = CreateRelation("ProductCategory", "Products", "ProductCategoryId");
            bsProducts = GetRelationBS(r1, bsProductCategory);
            return r1;
        }
        public string crOrderStatus_Orders()
        {
            string r1 = CreateRelation("OrderStatus", "Orders", "OrderStatusId");
            bsOrders = GetRelationBS(r1, bsOrderStatus);
            return r1;
        }

        public string crVendor_Orders()
        {
            string r1 = CreateRelation("Vendor", "Orders", "VendorId");
            bsOrders = GetRelationBS(r1, bsVendors);
            return r1;
        }
        public string crOrders_OrderDetails()
        {
            string r1 = CreateRelation("Orders", "OrderDetails", "OrderId");
            bsOrderDetails = GetRelationBS(r1, bsOrders);
            return r1;
        }
        public string crOrders_Payments()
        {
            string r1 = CreateRelation("Orders", "Payments", "OrderId");
            bsPayments = GetRelationBS(r1, bsOrders);
            return r1;
        }

        #endregion
        #region Utils
        public int GetNextId(string TableName, string PrimaryKey)
        {
            int NextId = 0;
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter();
                da = CreateDataAdapter(TableName);
                da.Fill(ds, TableName);
                DataTable Table = ds.Tables[TableName];
                DataView Row = Table.DefaultView;
                string qry = string.Format("max({0})", PrimaryKey);
                NextId = Convert.ToInt32(Table.Compute(qry, " "));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return NextId + 1;
        }
        #endregion
        #region Crude Btn
        public string AddNewData(BindingSource bs, string tblName, string PrimaryKey)
        {
            if (bs.DataSource == null)
            {
                throw new InvalidOperationException("BindingSource DataSource is not set.");
            }

            if (!bs.AllowNew)
            {
                bs.AllowNew = true;
            }

            bs.AddNew();

            return GetNextId(tblName, PrimaryKey).ToString();
        }
        public void SaveData(BindingSource bsVendors, SqlDataAdapter daVendors, string tblName)
        {
            BindingSource bs = bsVendors;
            SqlDataAdapter da = daVendors;
            try
            {
                bs.EndEdit();
                da.Update(DSmydataset, tblName);
                DSmydataset.AcceptChanges();
                MessageBox.Show("Records Saved Successfully!!!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bs.MoveLast();
            }
            catch (Exception ex)
            {
                bs.RemoveCurrent();
                MessageBox.Show(ex.ToString());
            }

        }

        public void DeleteData(BindingSource bsVendors) 
        {
            BindingSource bs = bsVendors;
            try
            {
                bs.RemoveCurrent();
                MessageBox.Show("Records Deleted Successfully!!!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bs.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        #endregion
    }

}
