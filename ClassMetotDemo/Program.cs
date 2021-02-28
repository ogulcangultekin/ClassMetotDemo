using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
           

            Customer[] customers = new Customer[] { customer1};
     
            CustomerManager customerManager = new CustomerManager();
            int number = 0;
            Console.WriteLine("Yapacaginiz islemi seciniz:");
            Console.WriteLine("Musteri silmek icin 1 'e basiniz");
            Console.WriteLine("Musteri listelemek icin 2 'ye basiniz");
            Console.WriteLine("Musteri eklemek icin 3 'e basiniz");
            number = Convert.ToInt32(Console.ReadLine());

            
            switch (number)
            {
                case 1:
                    Console.WriteLine("Musteri id giriniz");
                    int Id=Convert.ToInt32(Console.ReadLine());
                    customerManager.Delete(Id, customer1);
                    break;
                case 2:
                    customerManager.List(customer1);
                    break;
                case 3:
                    Console.WriteLine("Musteri id giriniz.");
                    customer1.Id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Musteri adi giriniz.");
                    customer1.Name = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Musteri soyadi giriniz.");
                    customer1.Surname = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Musteri telefon giriniz.");
                    customer1.Telefon = Convert.ToString(Console.ReadLine());
                    customerManager.Add(customer1);
                    break;
            }

        }
    }
}
