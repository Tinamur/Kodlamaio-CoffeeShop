using Kodlamaio_CoffeShop_Simulation_Interface_Abstract_.Abstract;
using Kodlamaio_CoffeShop_Simulation_Interface_Abstract_.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kodlamaio_CoffeShop_Simulation_Interface_Abstract_.Concrete
{
    class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
