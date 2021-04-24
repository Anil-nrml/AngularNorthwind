namespace NorthWindWebAPI.Business.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IdentityUpdate : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.Categories",
            //    c => new
            //        {
            //            CategoryID = c.Int(nullable: false, identity: true),
            //            CategoryName = c.String(nullable: false, maxLength: 15),
            //            Description = c.String(storeType: "ntext"),
            //            Picture = c.Binary(storeType: "image"),
            //        })
            //    .PrimaryKey(t => t.CategoryID);
            
            //CreateTable(
            //    "dbo.Products",
            //    c => new
            //        {
            //            ProductID = c.Int(nullable: false, identity: true),
            //            ProductName = c.String(nullable: false, maxLength: 40),
            //            SupplierID = c.Int(),
            //            CategoryID = c.Int(),
            //            QuantityPerUnit = c.String(maxLength: 20),
            //            UnitPrice = c.Decimal(storeType: "money"),
            //            UnitsInStock = c.Short(),
            //            UnitsOnOrder = c.Short(),
            //            ReorderLevel = c.Short(),
            //            Discontinued = c.Boolean(nullable: false),
            //        })
            //    .PrimaryKey(t => t.ProductID)
            //    .ForeignKey("dbo.Categories", t => t.CategoryID)
            //    .ForeignKey("dbo.Suppliers", t => t.SupplierID)
            //    .Index(t => t.SupplierID)
            //    .Index(t => t.CategoryID);
            
            //CreateTable(
            //    "dbo.Order Details",
            //    c => new
            //        {
            //            OrderID = c.Int(nullable: false),
            //            ProductID = c.Int(nullable: false),
            //            UnitPrice = c.Decimal(nullable: false, storeType: "money"),
            //            Quantity = c.Short(nullable: false),
            //            Discount = c.Single(nullable: false),
            //        })
            //    .PrimaryKey(t => new { t.OrderID, t.ProductID })
            //    .ForeignKey("dbo.Orders", t => t.OrderID)
            //    .ForeignKey("dbo.Products", t => t.ProductID)
            //    .Index(t => t.OrderID)
            //    .Index(t => t.ProductID);
            
            //CreateTable(
            //    "dbo.Orders",
            //    c => new
            //        {
            //            OrderID = c.Int(nullable: false, identity: true),
            //            CustomerID = c.String(maxLength: 5, fixedLength: true),
            //            EmployeeID = c.Int(),
            //            OrderDate = c.DateTime(),
            //            RequiredDate = c.DateTime(),
            //            ShippedDate = c.DateTime(),
            //            ShipVia = c.Int(),
            //            Freight = c.Decimal(storeType: "money"),
            //            ShipName = c.String(maxLength: 40),
            //            ShipAddress = c.String(maxLength: 60),
            //            ShipCity = c.String(maxLength: 15),
            //            ShipRegion = c.String(maxLength: 15),
            //            ShipPostalCode = c.String(maxLength: 10),
            //            ShipCountry = c.String(maxLength: 15),
            //        })
            //    .PrimaryKey(t => t.OrderID)
            //    .ForeignKey("dbo.Customers", t => t.CustomerID)
            //    .ForeignKey("dbo.Employees", t => t.EmployeeID)
            //    .ForeignKey("dbo.Shippers", t => t.ShipVia)
            //    .Index(t => t.CustomerID)
            //    .Index(t => t.EmployeeID)
            //    .Index(t => t.ShipVia);
            
            //CreateTable(
            //    "dbo.Customers",
            //    c => new
            //        {
            //            CustomerID = c.String(nullable: false, maxLength: 5, fixedLength: true),
            //            CompanyName = c.String(nullable: false, maxLength: 40),
            //            ContactName = c.String(maxLength: 30),
            //            ContactTitle = c.String(maxLength: 30),
            //            Address = c.String(maxLength: 60),
            //            City = c.String(maxLength: 15),
            //            Region = c.String(maxLength: 15),
            //            PostalCode = c.String(maxLength: 10),
            //            Country = c.String(maxLength: 15),
            //            Phone = c.String(maxLength: 24),
            //            Fax = c.String(maxLength: 24),
            //        })
            //    .PrimaryKey(t => t.CustomerID);
            
            //CreateTable(
            //    "dbo.Employees",
            //    c => new
            //        {
            //            EmployeeID = c.Int(nullable: false, identity: true),
            //            LastName = c.String(nullable: false, maxLength: 20),
            //            FirstName = c.String(nullable: false, maxLength: 10),
            //            Title = c.String(maxLength: 30),
            //            TitleOfCourtesy = c.String(maxLength: 25),
            //            BirthDate = c.DateTime(),
            //            HireDate = c.DateTime(),
            //            Address = c.String(maxLength: 60),
            //            City = c.String(maxLength: 15),
            //            Region = c.String(maxLength: 15),
            //            PostalCode = c.String(maxLength: 10),
            //            Country = c.String(maxLength: 15),
            //            HomePhone = c.String(maxLength: 24),
            //            Extension = c.String(maxLength: 4),
            //            Photo = c.Binary(storeType: "image"),
            //            Notes = c.String(storeType: "ntext"),
            //            ReportsTo = c.Int(),
            //            PhotoPath = c.String(maxLength: 255),
            //        })
            //    .PrimaryKey(t => t.EmployeeID)
            //    .ForeignKey("dbo.Employees", t => t.ReportsTo)
            //    .Index(t => t.ReportsTo);
            
            //CreateTable(
            //    "dbo.Territories",
            //    c => new
            //        {
            //            TerritoryID = c.String(nullable: false, maxLength: 20),
            //            TerritoryDescription = c.String(nullable: false, maxLength: 50, fixedLength: true),
            //            RegionID = c.Int(nullable: false),
            //        })
            //    .PrimaryKey(t => t.TerritoryID)
            //    .ForeignKey("dbo.Region", t => t.RegionID)
            //    .Index(t => t.RegionID);
            
            //CreateTable(
            //    "dbo.Region",
            //    c => new
            //        {
            //            RegionID = c.Int(nullable: false),
            //            RegionDescription = c.String(nullable: false, maxLength: 50, fixedLength: true),
            //        })
            //    .PrimaryKey(t => t.RegionID);
            
            //CreateTable(
            //    "dbo.Shippers",
            //    c => new
            //        {
            //            ShipperID = c.Int(nullable: false, identity: true),
            //            CompanyName = c.String(nullable: false, maxLength: 40),
            //            Phone = c.String(maxLength: 24),
            //        })
            //    .PrimaryKey(t => t.ShipperID);
            
            //CreateTable(
            //    "dbo.Suppliers",
            //    c => new
            //        {
            //            SupplierID = c.Int(nullable: false, identity: true),
            //            CompanyName = c.String(nullable: false, maxLength: 40),
            //            ContactName = c.String(maxLength: 30),
            //            ContactTitle = c.String(maxLength: 30),
            //            Address = c.String(maxLength: 60),
            //            City = c.String(maxLength: 15),
            //            Region = c.String(maxLength: 15),
            //            PostalCode = c.String(maxLength: 10),
            //            Country = c.String(maxLength: 15),
            //            Phone = c.String(maxLength: 24),
            //            Fax = c.String(maxLength: 24),
            //            HomePage = c.String(storeType: "ntext"),
            //        })
            //    .PrimaryKey(t => t.SupplierID);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.UserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.Roles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.UserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.UserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            //CreateTable(
            //    "dbo.EmployeeTerritories",
            //    c => new
            //        {
            //            EmployeeID = c.Int(nullable: false),
            //            TerritoryID = c.String(nullable: false, maxLength: 20),
            //        })
            //    .PrimaryKey(t => new { t.EmployeeID, t.TerritoryID })
            //    .ForeignKey("dbo.Employees", t => t.EmployeeID, cascadeDelete: true)
            //    .ForeignKey("dbo.Territories", t => t.TerritoryID, cascadeDelete: true)
            //    .Index(t => t.EmployeeID)
            //    .Index(t => t.TerritoryID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserRoles", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserLogins", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserClaims", "UserId", "dbo.Users");
            DropForeignKey("dbo.UserRoles", "RoleId", "dbo.Roles");
            DropForeignKey("dbo.Products", "SupplierID", "dbo.Suppliers");
            DropForeignKey("dbo.Order Details", "ProductID", "dbo.Products");
            DropForeignKey("dbo.Orders", "ShipVia", "dbo.Shippers");
            DropForeignKey("dbo.Order Details", "OrderID", "dbo.Orders");
            DropForeignKey("dbo.EmployeeTerritories", "TerritoryID", "dbo.Territories");
            DropForeignKey("dbo.EmployeeTerritories", "EmployeeID", "dbo.Employees");
            DropForeignKey("dbo.Territories", "RegionID", "dbo.Region");
            DropForeignKey("dbo.Orders", "EmployeeID", "dbo.Employees");
            DropForeignKey("dbo.Employees", "ReportsTo", "dbo.Employees");
            DropForeignKey("dbo.Orders", "CustomerID", "dbo.Customers");
            DropForeignKey("dbo.Products", "CategoryID", "dbo.Categories");
            DropIndex("dbo.EmployeeTerritories", new[] { "TerritoryID" });
            DropIndex("dbo.EmployeeTerritories", new[] { "EmployeeID" });
            DropIndex("dbo.UserLogins", new[] { "UserId" });
            DropIndex("dbo.UserClaims", new[] { "UserId" });
            DropIndex("dbo.Users", "UserNameIndex");
            DropIndex("dbo.UserRoles", new[] { "RoleId" });
            DropIndex("dbo.UserRoles", new[] { "UserId" });
            DropIndex("dbo.Roles", "RoleNameIndex");
            DropIndex("dbo.Territories", new[] { "RegionID" });
            DropIndex("dbo.Employees", new[] { "ReportsTo" });
            DropIndex("dbo.Orders", new[] { "ShipVia" });
            DropIndex("dbo.Orders", new[] { "EmployeeID" });
            DropIndex("dbo.Orders", new[] { "CustomerID" });
            DropIndex("dbo.Order Details", new[] { "ProductID" });
            DropIndex("dbo.Order Details", new[] { "OrderID" });
            DropIndex("dbo.Products", new[] { "CategoryID" });
            DropIndex("dbo.Products", new[] { "SupplierID" });
            DropTable("dbo.EmployeeTerritories");
            DropTable("dbo.UserLogins");
            DropTable("dbo.UserClaims");
            DropTable("dbo.Users");
            DropTable("dbo.UserRoles");
            DropTable("dbo.Roles");
            DropTable("dbo.Suppliers");
            DropTable("dbo.Shippers");
            DropTable("dbo.Region");
            DropTable("dbo.Territories");
            DropTable("dbo.Employees");
            DropTable("dbo.Customers");
            DropTable("dbo.Orders");
            DropTable("dbo.Order Details");
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
        }
    }
}
