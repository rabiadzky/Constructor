﻿using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1, FirstName = "Rabia", LastName = "Duzkaya", City = "Bolu" };//=customer cutomer3=new customer(); customer3.Id=3;... Aynı kullanım
            Customer customer2=new Customer(2,"Ayşe","Alkan","Malatya");
            Console.WriteLine(customer2.FirstName);
        }
        
    }
    class Customer
    {
        public Customer()
        {

        }
        //default constructor
        public Customer(int id, string firstName, string lastName,string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
