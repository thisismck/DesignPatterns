using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    /*
     * Senaryo: Sipariş oluşturma işlemleri
     * 
     * 
     */

    public class Customer
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Stock { get; set; }
    }

    public class CardItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }

    public class OrderItems
    {
        public int OrderId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }

    public class Order
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public DateTime OrderDate { get; set; }

        public List<OrderItems> OrderItems { get; set; }


    }

    public class OrderService
    {
        public void CreateOrder(Customer customer, List<CardItem> cardItems)
        {
            Order order = new Order() { Customer = customer, OrderItems = new List<OrderItems>(), OrderDate = DateTime.Now };
            foreach (var item in cardItems)
            {
                order.OrderItems.Add(new OrderItems
                {
                    OrderId = order.Id,
                    Product = item.Product,
                    Quantity = item.Quantity,
                    Price = item.Product.Stock
                });

                Console.WriteLine($"{customer.Name} adlı müşteri, Siparişine:{item.Product.Name} ürünü ekledi");
            }

            Console.WriteLine("Sipariş oluşturuldu. Toplam Tutar: " + order.OrderItems.Sum(x => x.Price));
        }
    }
}
