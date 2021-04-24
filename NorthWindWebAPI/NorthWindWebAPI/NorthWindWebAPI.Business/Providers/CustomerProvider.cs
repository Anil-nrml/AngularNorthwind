using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthWindWebAPI.Business.Entities;
using NorthWInd.GenericRepository;
using NorthWind.GenericRepository.Common.DataContext;
using NorthWindDataModel;

namespace NorthWindWebAPI.Business.Providers
{
    public static class CustomerProvider
    {
        public static IList<Customer> GetCustomer(IDataContext model, CustomerFilterVM customerFilter)
        {

            
            var repository = new Repository<Customer>(model);

            var customer=repository.Queriable().Where(c => (!string.IsNullOrEmpty(customerFilter.CompanyName) && c.CompanyName.Contains(customerFilter.CompanyName))
            || (!string.IsNullOrEmpty(customerFilter.City) && c.City.Contains(customerFilter.City)) || (!string.IsNullOrEmpty(customerFilter.Country) && c.Country.Contains(customerFilter.Country))).ToList();  
            
            return customer.Any()?customer:null;

        }

        public static IList<Customer> GetCustomer(IDataContext model)
        {
            
            var repository = new Repository<Customer>(model);
            
            return repository.Queriable().ToList();
        }
    }
}
