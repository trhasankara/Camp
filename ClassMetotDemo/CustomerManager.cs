using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ClassMetotDemo
{
    public class CustomerManager
    {
        public List<Customer> GetList()
        {
            Console.WriteLine("Customers Listed");
            return new List<Customer>();
        }
        public Customer Get(int Id)
        {
            Console.WriteLine("Customer Listed");
            return new Customer();
        }
        public Customer Add(Customer customer)
        {
            Console.WriteLine("Customer Added");
            return customer;
        }

        public Customer Update(Customer customer)
        {
            Console.WriteLine("Customer Updated");
            return customer;
        }

        public void Deleted(Customer customer)
        {
            Console.WriteLine("Customer Deleted");
        }
    }
}
