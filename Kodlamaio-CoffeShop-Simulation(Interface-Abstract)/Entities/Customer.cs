using Kodlamaio_CoffeShop_Simulation_Interface_Abstract_.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kodlamaio_CoffeShop_Simulation_Interface_Abstract_.Entities
{
    public class Customer: IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalityId { get; set; }
    }
}
