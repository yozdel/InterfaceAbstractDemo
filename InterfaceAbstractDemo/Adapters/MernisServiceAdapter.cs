using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using MernisServiceReference1;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrulaAsync(customer.NationalityId, customer.FirstName.ToUpper(), customer.LastName.ToUpper(), customer.DateOfBirth.Year);
        }
    }
}
