using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("İsim: " + customer.Name);
            Console.WriteLine("Soyisim: " + customer.Surname);
            Console.WriteLine("Telefon: " + customer.Telefon);
            Console.WriteLine("Müşteri eklendi.");
            Console.WriteLine("----------------");
            
        }
        public void Delete(int id,Customer customer)
        {
            Console.WriteLine(id+"Numarali musteri silindi.");
        }

        public void List(Customer customer)
        {
            Console.WriteLine("İsim: " + customer.Name);
            Console.WriteLine("Soyisim: " + customer.Surname);
            Console.WriteLine("Telefon: " + customer.Telefon);
            Console.WriteLine("----------------");
        }
    }
}
