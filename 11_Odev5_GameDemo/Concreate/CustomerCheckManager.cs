using _11_Odev5_GameDemo.Abstract;
using _11_Odev5_GameDemo.Entities;
using ServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace _11_Odev5_GameDemo.Concreate
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckCustomer(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(
                new TCKimlikNoDogrulaRequest(
                    new TCKimlikNoDogrulaRequestBody(customer.NationalityId, customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth.Year)))
                .Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
