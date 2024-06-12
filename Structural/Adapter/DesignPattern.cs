using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    /*
     * Bir dış kaynaktan ürünlerinizi çekiyorsunuz. 
     * Bu dış kaynak xml formatında veri döndürüyor.
     * Sizin ihtiyacınız olan ise bu verileri List<Product> formatında almak.
     */


    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    //1. Adım: Adapter interface'ini oluşturuyoruz.
    public interface IProductAdapter
    {
        List<Product> GetProducts();
    }

    //2. Adım: Adapter sınıfımızı oluşturuyoruz.

    public class XmlProductAdapter : IProductAdapter
    {
        public List<Product> GetProducts()
        {
            //Dış kaynaktan xml formatında veri çekiliyor.
            string xmlData = "<Products><Product><Name>Product1</Name><Price>100</Price></Product><Product><Name>Product2</Name><Price>200</Price></Product></Products>";

            //Xml veriyi parse ediyoruz.
            //Burada parse işlemini yapacak bir kütüphane kullanabilirsiniz.
            //Biz basit bir şekilde string manipülasyonu ile parse işlemini gerçekleştireceğiz.
            List<Product> products = new List<Product>();

            string[] productArray = xmlData.Split(new string[] { "<Product>" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var product in productArray)
            {
                if (product.Contains("</Product>"))
                {
                    string name = product.Split(new string[] { "<Name>" }, StringSplitOptions.RemoveEmptyEntries)[1].Split(new string[] { "</Name>" }, StringSplitOptions.RemoveEmptyEntries)[0];
                    decimal price = Convert.ToDecimal(product.Split(new string[] { "<Price>" }, StringSplitOptions.RemoveEmptyEntries)[1].Split(new string[] { "</Price>" }, StringSplitOptions.RemoveEmptyEntries)[0]);

                    products.Add(new Product { Name = name, Price = price });
                }
            }

            return products;
        }

        //2. Adım Json formatında veri dönen bir dış kaynak için adapter sınıfı oluşturuyoruz.
    }
        public class JsonProductAdapter : IProductAdapter
        {
            public List<Product> GetProducts()
            {
                //Dış kaynaktan json formatında veri çekiliyor.
                string jsonData = "[{\"Name\":\"Product1\",\"Price\":100},{\"Name\":\"Product2\",\"Price\":200}]";

                //Json veriyi parse ediyoruz.
                //Burada parse işlemini yapacak bir kütüphane kullanabilirsiniz.
                //Biz basit bir şekilde string manipülasyonu ile parse işlemini gerçekleştireceğiz.
                List<Product> products = new List<Product>();

                string[] productArray = jsonData.Split(new string[] { "},{" }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var product in productArray)
                {
                    string name = product.Split(new string[] { "\"Name\":\"" }, StringSplitOptions.RemoveEmptyEntries)[1].Split(new string[] { "\",\"Price\":" }, StringSplitOptions.RemoveEmptyEntries)[0];
                    decimal price = Convert.ToDecimal(product.Split(new string[] { "\"Price\":" }, StringSplitOptions.RemoveEmptyEntries)[1]);

                    products.Add(new Product { Name = name, Price = price });
                }

                return products;
            }
        }

    //3. Adım: Concrete Adapter

    public class ProductListAdapter : IProductAdapter
    {
        private readonly XmlProductAdapter source;

        public ProductListAdapter(XmlProductAdapter source)
        {
            this.source = source;
        }
        public List<Product> GetProducts()
        {
            return source.GetProducts();
        }
    }
    public class ProductManager
    {
        private IProductAdapter _productAdapter;

        public ProductManager(IProductAdapter productAdapter)
        {
            _productAdapter = productAdapter;
        }

        public List<Product> GetAllProducts()
        {
            return _productAdapter.GetProducts();
        }
    }


}
