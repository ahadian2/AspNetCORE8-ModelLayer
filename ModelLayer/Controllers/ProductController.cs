using Microsoft.AspNetCore.Mvc;
using ModelLayer.Models;

namespace ModelLayer.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult ShowProduct()
        {
            Product Myproduct = new Product();

            Myproduct.ProductId = 1;
            Myproduct.ProductName = "iphone 15 pro max";
            Myproduct.ProductDescription = "Description ...";
            Myproduct.ProductPrice = 1000;

            return View(Myproduct);
        }

        public IActionResult ListProduct()
        {
            Product products = new Product();
            List<Product> ProductList = new List<Product>() { 
                new Product(){ProductId=1, ProductName="Iphone 13",ProductDescription="Description ...",ProductPrice=1000},
                new Product(){ProductId=2, ProductName="Iphone 14",ProductDescription="Description ...",ProductPrice=2000},
                new Product(){ProductId=3, ProductName="Iphone 15",ProductDescription="Description ...",ProductPrice=3000},
                new Product(){ProductId=4, ProductName="Iphone 16",ProductDescription="Description ...",ProductPrice=4000},
                new Product(){ProductId=5, ProductName="Iphone 17",ProductDescription="Description ...",ProductPrice=5000},
                new Product(){ProductId=6, ProductName="Iphone 18",ProductDescription="Description ...",ProductPrice=6000},
                new Product(){ProductId=7, ProductName="Iphone 19",ProductDescription="Description ...",ProductPrice=7000},
                new Product(){ProductId=8, ProductName="Iphone 12",ProductDescription="Description ...",ProductPrice=8000},
                new Product(){ProductId=9, ProductName="Iphone 11",ProductDescription="Description ...",ProductPrice=9000},
                new Product(){ProductId=10, ProductName="Iphone 10",ProductDescription="Description ...",ProductPrice=5000},
            };

            return View(ProductList);
        }




    }
}
