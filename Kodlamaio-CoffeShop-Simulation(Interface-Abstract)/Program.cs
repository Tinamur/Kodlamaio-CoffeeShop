using Kodlamaio_CoffeShop_Simulation_Interface_Abstract_.Abstract;
using Kodlamaio_CoffeShop_Simulation_Interface_Abstract_.Adapters;
using Kodlamaio_CoffeShop_Simulation_Interface_Abstract_.Concrete;
using Kodlamaio_CoffeShop_Simulation_Interface_Abstract_.Entities;
using System;

namespace Kodlamaio_CoffeShop_Simulation_Interface_Abstract_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Starbucks Mernis Doğrulaması istiyor
            //Gerçek bilgiler ile çalıştığı kontrol edildi
            BaseCustomerManager customerManager1 = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager1.Save(new Customer
            {
                DateOfBirth = new DateTime(Y, M, D),
                FirstName = "",
                LastName="",
                NationalityId="",
                Id=1
            });


            //Nero Kontrol istemiyor
            BaseCustomerManager customerManager2 = new NeroCustomerManager();
            customerManager2.Save(new Customer
            {
                DateOfBirth = new DateTime(Y, M, D),
                FirstName = "",
                LastName = "",
                NationalityId = "",
                Id = 2
            });
        }
    }
}
