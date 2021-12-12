using Kodlamaio_CoffeShop_Simulation_Interface_Abstract_.Abstract;
using Kodlamaio_CoffeShop_Simulation_Interface_Abstract_.Entities;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kodlamaio_CoffeShop_Simulation_Interface_Abstract_.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync
                (
                new TCKimlikNoDogrulaRequest
                (
                    new TCKimlikNoDogrulaRequestBody
                    (
                        Convert.ToInt64(customer.NationalityId),
                        customer.FirstName.ToUpper(),
                        customer.LastName.ToUpper(),
                        customer.DateOfBirth.Year
                     )
                    )
                ).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
