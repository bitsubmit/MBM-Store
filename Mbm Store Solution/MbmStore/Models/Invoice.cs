using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class Invoice
    {
        //private decimal totalPrice;
        private List<OrderItem> orderItems = new List<OrderItem>();
        public int InvoiceId { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalPrice { get; set; }
        public Customer Customer { get; set; }
        public List<OrderItem> OrderItems { get { return orderItems; } }
        public Invoice(int invoiceid, DateTime orderDate, Customer customer)
        {
            InvoiceId = invoiceid;
            OrderDate = orderDate;
            Customer = customer;
        } 
        //methods
        public void AddOrderItem(Product product, int quantity)
        {
            orderItems.Add(new OrderItem(product, quantity));
        }

        public Decimal GetTotalPrice()
        {
            Decimal zum = new Decimal();
            foreach (OrderItem oi in orderItems)
            {
                zum += oi.Product.Price * oi.Quantity;
            }
            return zum;
        }

    }
}