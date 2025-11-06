
# IT-Shop Management Desktop Project

## 🚀 Project Overview  

This desktop application aims to manage the operations of an IT shop — including inventory, billing, customer records, and staff/admin control. It’s built using C# and Windows Forms (or WPF) for the front-end, and uses a relational database (for example SQL Server / SQLite) to persist data.  
It is ideal for small to medium sized IT retail outlets who need a local solution to track products, sales, and customers.

## 📌 Key Features  

- Product management: add, edit, delete IT-shop items (PCs, laptops, accessories, parts)  
- Inventory tracking: monitor stock levels, low stock alerts  
- Billing & sales: create new sales invoices, apply discounts, track payment status  
- Customer records: capture customer information, view purchase history  
- Staff & admin roles: login system, role-based access (Admin / Staff)  
- Reports & analytics: generate sales summary, inventory status, date-range filtering  
- Backup & restore: database backup feature (optional)  
- User-friendly UI: intuitive forms, grid views, search and filter capabilities  

## 🧰 Tech Stack  

- **Language**: C#  
- **UI**: Windows Forms (or WPF)  
- **Database**: SQL Server / SQLite / LocalDB  
- **IDE**: Microsoft Visual Studio  
- **Project type**: `.sln` solution file included (`ItShopManagement.sln`)  
- **Structure**:  
  - `ItShopManagement` — main application project  
  - `MyDataBaseManager` — helper library / data-access layer  
  - `packages` — NuGet dependencies  

## 🎯 Setup & Installation  

1. Clone the repository:  
   ```bash
   git clone https://github.com/shubhamwaikar018/IT-Shop-Management-desktop-project.git
2. Open ItShopManagement.sln in Visual Studio.
3. Restore NuGet packages (via Visual Studio or dotnet restore).
4. Update the connection string in App.config (or relevant config) to point to your local database.   
   <add name="ShopDB" connectionString="Server=.;Database=ITShopDB;Trusted_Connection=True;" providerName="System.Data.SqlClient"/>
5. Create the database and required tables — either via included .sql script or using an ORM / code-first approach.
6. Build the solution (Build → Build Solution).
7. Run the application (Start or Ctrl+F5) and login with default credentials (if any).
8. Begin by adding products, customers, and creating sales.

## 🧩 Database Schema (sample)

| Table Name   | Description                                                      |
| ------------ | ---------------------------------------------------------------- |
| `Products`   | Stores product info: ID, name, category, price, stock            |
| `Customers`  | Stores customer details: ID, name, contact, email                |
| `Sales`      | Records of each sale: SaleID, CustomerID, Date, Total            |
| `SaleItems`  | Items in a sale: SaleItemID, SaleID, ProductID, Quantity, Price  |
| `Users`      | System users (staff/admin): UserID, Username, PasswordHash, Role |
| `Categories` | Product categories (optional)                                    |

## 🧑‍💼 Default Credentials

| Role  | Username | Password   |
| ----- | -------- | ---------- |
| Admin | `admin`  | `admin123` |
| Staff | `staff1` | `staff123` |
Important: Change the default credentials on first run for security.

## 🔧 Usage Instructions

1. Login: Enter your credentials to access the system.
2. Product Management: Navigate to “Products” tab → Add/Edit/Delete products → Manage stock.
3. Customer Management: Under “Customers” tab → Add new customer or search existing.
4. Sales / Billing: Under “Sales” tab → Create new invoice → Select customer → Add items → Apply discount → Save sale.
5. Reports: Use the “Reports” section to view sales in a given date range, low stock items etc.
6. Backup / Restore (if implemented): Use “Database Utilities” to backup current state or restore from file.

## 🧪 Testing & Validation

- Ensure data validation: no negative stock, mandatory fields filled, duplicate entries prevented.
- Verify report accuracy: totals should match sum of sale items.
- Test role-based access: staff should not have admin privileges.
- Backup & restore: verify integrity after restore.

## 📂 Folder Structure

/ItShopManagement-desktop-project
│── /ItShopManagement           # Main UI project  
│── /MyDataBaseManager          # Data access / business logic  
│── /packages                   # NuGet packages  
│── ItShopManagement.sln        # Solution file  
│── README.md                   # This file  

## 🎉 Future Enhancements

- Add search & filter UI enhancements (e.g., autocomplete, category filtering)
- Implement barcode scanning for faster billing
- Add export to Excel/PDF for reports
- Add commission module for staff sales tracking
- Integrate cloud sync for multi-shop setups
- Provide mobile companion app/web dashboard

## 🤝 Contribution

Contributions, issues, and feature requests are welcome. Please fork the repo, create a branch for your feature/bugfix, and submit a pull request.

1. Fork it
2. Create your feature branch (git checkout -b feature/AmazingFeature)
3. Commit your changes (git commit -m 'Add some AmazingFeature')
4. Push to the branch (git push origin feature/AmazingFeature)
5. Open a Pull Request

## 📝 License

This project is licensed under the MIT License — see the LICENSE
 file for details.