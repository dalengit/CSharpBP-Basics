using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz
{
    public class Product
    {
        private string _productName;

        public string ProductName
        {
            get { return _productName; }
            set { _productName = value; }
        }

        private string _description;

        public  string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        private int _productId;

        public int ProductId
        {
            get { return _productId; }
            set { _productId = value; }
        }

        public string SayHello()
        {
            return "Hello " + ProductName + " (" + ProductId + "): " + Description;
        }
    }
}
