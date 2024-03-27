using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            products.Add(new Product { ProductID = 1, Name = "LL Road Frame - Red, 44", ProductNumber = "FR-R38R-44", Color = "Red", StandardCost = 187.1571, ListPrice = 337.22, Size = 44, Weight = 1052.33, ProductCategoryID = 18, ProductModelID = 9 });
            products.Add(new Product { ProductID = 2, Name = "LL Road Frame - Red, 48", ProductNumber = "FR-R38R-48", Color = "Red", StandardCost = 187.1571, ListPrice = 337.22, Size = 48, Weight = 1070.47, ProductCategoryID = 18, ProductModelID = 9 });
            products.Add(new Product { ProductID = 3, Name = "LL Road Frame - Red, 52", ProductNumber = "FR-R38R-52", Color = "Red", StandardCost = 187.1571, ListPrice = 337.22, Size = 52, Weight = 1088.62, ProductCategoryID = 18, ProductModelID = 9 });
            products.Add(new Product { ProductID = 4, Name = "LL Road Frame - Red, 58", ProductNumber = "FR-R38R-58", Color = "Red", StandardCost = 187.1571, ListPrice = 337.22, Size = 58, Weight = 1115.83, ProductCategoryID = 18, ProductModelID = 9 });
            products.Add(new Product { ProductID = 5, Name = "LL Road Frame - Red, 60", ProductNumber = "FR-R38R-60", Color = "Red", StandardCost = 187.1571, ListPrice = 337.22, Size = 60, Weight = 1124.9, ProductCategoryID = 18, ProductModelID = 9 });
            products.Add(new Product { ProductID = 6, Name = "LL Road Frame - Red, 62", ProductNumber = "FR-R38R-62", Color = "Red", StandardCost = 187.1571, ListPrice = 337.22, Size = 62, Weight = 1133.98, ProductCategoryID = 18, ProductModelID = 9 });
            products.Add(new Product { ProductID = 7, Name = "ML Road Frame - Red, 44", ProductNumber = "FR-R72R-44", Color = "Red", StandardCost = 352.1394, ListPrice = 594.83, Size = 44, Weight = 1006.97, ProductCategoryID = 18, ProductModelID = 16 });
            products.Add(new Product { ProductID = 8, Name = "ML Road Frame - Red, 48", ProductNumber = "FR-R72R-48", Color = "Red", StandardCost = 352.1394, ListPrice = 594.83, Size = 48, Weight = 1025.11, ProductCategoryID = 18, ProductModelID = 16 });
            products.Add(new Product { ProductID = 9, Name = "ML Road Frame - Red, 52", ProductNumber = "FR-R72R-52", Color = "Red", StandardCost = 352.1394, ListPrice = 594.83, Size = 52, Weight = 1043.26, ProductCategoryID = 18, ProductModelID = 16 });
            products.Add(new Product { ProductID = 10, Name = "ML Road Frame - Red, 58", ProductNumber = "FR-R72R-58", Color = "Red", StandardCost = 352.1394, ListPrice = 594.83, Size = 58, Weight = 1070.47, ProductCategoryID = 18, ProductModelID = 16 });
            products.Add(new Product { ProductID = 11, Name = "ML Road Frame - Red, 60", ProductNumber = "FR-R72R-60", Color = "Red", StandardCost = 352.1394, ListPrice = 594.83, Size = 60, Weight = 1079.54, ProductCategoryID = 18, ProductModelID = 16 });
            products.Add(new Product { ProductID = 12, Name = "HL Mountain Frame - Silver, 44", ProductNumber = "FR-M94S-44", Color = "Silver", StandardCost = 706.811, ListPrice = 1364.5, Size = 44, Weight = 1251.91, ProductCategoryID = 16, ProductModelID = 5 });
            products.Add(new Product { ProductID = 13, Name = "HL Mountain Frame - Silver, 48", ProductNumber = "FR-M94S-52", Color = "Silver", StandardCost = 706.811, ListPrice = 1364.5, Size = 48, Weight = 1270.05, ProductCategoryID = 16, ProductModelID = 5 });
            products.Add(new Product { ProductID = 14, Name = "HL Mountain Frame - Black, 44", ProductNumber = "FR-M94B-44", Color = "Black", StandardCost = 699.0928, ListPrice = 1349.6, Size = 44, Weight = 1251.91, ProductCategoryID = 16, ProductModelID = 5 });
            products.Add(new Product { ProductID = 15, Name = "HL Mountain Frame - Black, 48", ProductNumber = "FR-M94B-48", Color = "Black", StandardCost = 699.0928, ListPrice = 1349.6, Size = 48, Weight = 1270.05, ProductCategoryID = 16, ProductModelID = 5 });


            List<ProductCategory> productCategories = new List<ProductCategory>();
            productCategories.Add(new ProductCategory { ProductCategoryID = 1, Name = "Bikes" });
            productCategories.Add(new ProductCategory { ProductCategoryID = 2, Name = "Components" });
            productCategories.Add(new ProductCategory { ProductCategoryID = 3, Name = "Clothing" });
            productCategories.Add(new ProductCategory { ProductCategoryID = 4, Name = "Accessories" });
            productCategories.Add(new ProductCategory { ProductCategoryID = 5, Name = "Mountain Bikes" });
            productCategories.Add(new ProductCategory { ProductCategoryID = 6, Name = "Road Bikes" });
            productCategories.Add(new ProductCategory { ProductCategoryID = 7, Name = "Touring Bikes" });
            productCategories.Add(new ProductCategory { ProductCategoryID = 8, Name = "Handlebars" });
            productCategories.Add(new ProductCategory { ProductCategoryID = 9, Name = "Bottom Brackets" });
            productCategories.Add(new ProductCategory { ProductCategoryID = 10, Name = "Brakes" });
            productCategories.Add(new ProductCategory { ProductCategoryID = 11, Name = "Chains" });
            productCategories.Add(new ProductCategory { ProductCategoryID = 12, Name = "Cranksets" });
            productCategories.Add(new ProductCategory { ProductCategoryID = 13, Name = "Derailleurs" });
            productCategories.Add(new ProductCategory { ProductCategoryID = 14, Name = "Forks" });
            productCategories.Add(new ProductCategory { ProductCategoryID = 15, Name = "Headsets" });
            productCategories.Add(new ProductCategory { ProductCategoryID = 16, Name = "Mountain Frames" });
            productCategories.Add(new ProductCategory { ProductCategoryID = 17, Name = "Pedals" });
            productCategories.Add(new ProductCategory { ProductCategoryID = 18, Name = "Road Frames" });
            productCategories.Add(new ProductCategory { ProductCategoryID = 19, Name = "Saddles" });
            productCategories.Add(new ProductCategory { ProductCategoryID = 20, Name = "Touring Frames" });

            List<ProductModel> productModels = new List<ProductModel>();
            productModels.Add(new ProductModel { ProductModelID = 1, Name = "Classic Vest" });
            productModels.Add(new ProductModel { ProductModelID = 2, Name = "Cycling Cap" });
            productModels.Add(new ProductModel { ProductModelID = 3, Name = "Full-Finger Gloves" });
            productModels.Add(new ProductModel { ProductModelID = 4, Name = "Half-Finger Gloves" });
            productModels.Add(new ProductModel { ProductModelID = 5, Name = "HL Mountain Frame" });
            productModels.Add(new ProductModel { ProductModelID = 6, Name = "HL Road Frame" });
            productModels.Add(new ProductModel { ProductModelID = 7, Name = "HL Touring Frame" });
            productModels.Add(new ProductModel { ProductModelID = 8, Name = "LL Mountain Frame" });
            productModels.Add(new ProductModel { ProductModelID = 9, Name = "LL Road Frame" });
            productModels.Add(new ProductModel { ProductModelID = 10, Name = "LL Touring Frame" });

            var data = from p in products
                       join c in productCategories
                       on p.ProductCategoryID equals c.ProductCategoryID
                       join m in productModels
                       on p.ProductModelID equals m.ProductModelID                      
                     select new { p.ProductID, p.Name, p.ProductNumber, p.ProductModelID, c.ProductCategoryID };
                      

            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
           
            Console.ReadLine();

        }
    }
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string ProductNumber { get; set; }
        public string Color { get; set; }
        public double StandardCost { get; set; }
        public double ListPrice { get; set; }
        public int Size { get; set; }
        public double Weight { get; set; }
        public int ProductCategoryID { get; set; }
        public int ProductModelID { get; set; }

    }
    public class ProductCategory
    {
        public int ProductCategoryID { get; set; }
        public string Name { get; set; }

    }
    public class ProductModel
    {
        public int ProductModelID { get; set; }
        public string Name { get; set; }

    }
}
