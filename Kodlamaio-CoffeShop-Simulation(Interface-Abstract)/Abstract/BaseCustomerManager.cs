using Kodlamaio_CoffeShop_Simulation_Interface_Abstract_.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kodlamaio_CoffeShop_Simulation_Interface_Abstract_.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        //Virtual demek Bu Method İmplemente edilen yerlerde ezilebilir demek
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved To Db: "+customer.FirstName);
        }
    }
}
