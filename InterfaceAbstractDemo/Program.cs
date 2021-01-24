using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth=new DateTime(1995,5,15), FirstName="Yasin", LastName="ÖZDEL",NationalityId="12345678901" });
            Console.WriteLine();
        }
    }

}
