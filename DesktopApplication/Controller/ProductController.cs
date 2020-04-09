﻿using DesktopApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesktopApplication.Service;
using DesktopApplication.ProductService;

namespace DesktopApplication.Controller {

    public class ProductController {

        public CompanyProduct GetProductById(int id) {
            ServiceProduct service = new ServiceProduct();
            return service.GetProductById(id);
        }

        public bool InsertProduct(Product productToInsert) {
            ServiceProduct service = new ServiceProduct();
            return service.InsertProduct(productToInsert);
        }

        public List<string> GetAllColors() {
            ServiceProduct service = new ServiceProduct();
            return service.GetAllColors();
        }

        public List<string> GetAllSizes() {
            ServiceProduct service = new ServiceProduct();
            return service.GetAllSizes();
        }

        public List<string> GetAllCategories() {
            ServiceProduct service = new ServiceProduct();
            return service.GetAllCategories();
        }

        //public CompanyProduct CreateProduct(string name, string description, decimal price)
        //{
        //    Product prod = new Product
        //    {
        //        Name = name,
        //        Description = description,
        //        Price = price,
        //        State = true

        //    };

        //    ServiceProduct service = new ServiceProduct();
        //    return service.CreateProduct(prod);
        //}
    }
}