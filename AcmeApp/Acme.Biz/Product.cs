﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz
{
    public class Product
    {
        // Ctor
        public Product()
        {
            Console.WriteLine("Product instance created");
        }

        public Product(int productId, string productName, string description) : this()
        {
            this.ProductId = productId;
            this.ProductName = productName;
            this.Description = description;
            Console.WriteLine("Product instance has a name: " + productName);
        }

        public string ProductName { get; set; }
        public string Description { get; set; }
        
        private int _productId;

        public int ProductId
        {
            get { return _productId; }
            set { ProductId = value;  }
        }

        public string SayHello()
        {
            return "Hello " + ProductName + " (" + ProductId + "): " + Description;
        }
    }
}
