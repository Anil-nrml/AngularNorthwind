using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NorthWindWebAPI.Business.Entities;
using NorthWindWebAPI.Business.Providers;
using NorthWind.GenericRepository.Common.DataContext;
using NorthWindDataModel;

namespace NorthWindWebAPI.Services
{
    public class CustomerService
    {
        public static IList<Customer> GetCustomer()
        {
            using (IDataContext model = new NorhWindModel())
            {
                var customer = CustomerProvider.GetCustomer(model);

                return customer;
            }
        }
        public static IList<Customer> GetCustomer(CustomerFilterVM customerFilter)
        {
            using (IDataContext model = new NorhWindModel())
            {
                var customer = CustomerProvider.GetCustomer(model, customerFilter);

                return customer;
            }
        }       
    }
}