using System;
using System.Collections.Generic;
using System.Text;
using Kodlamaio_CoffeShop_Simulation_Interface_Abstract_.Entities;

namespace Kodlamaio_CoffeShop_Simulation_Interface_Abstract_.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
