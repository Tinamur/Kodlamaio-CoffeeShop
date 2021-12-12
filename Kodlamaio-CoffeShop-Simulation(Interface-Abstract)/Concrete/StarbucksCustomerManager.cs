using Kodlamaio_CoffeShop_Simulation_Interface_Abstract_.Abstract;
using Kodlamaio_CoffeShop_Simulation_Interface_Abstract_.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kodlamaio_CoffeShop_Simulation_Interface_Abstract_.Concrete
{
    public class StarbucksCustomerManager : BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }
        //Base Customer Managerdeki save i override et 
        //Base.Save yaparak basedeki save i kullan
        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid Person");
            }

        }

    }
}
