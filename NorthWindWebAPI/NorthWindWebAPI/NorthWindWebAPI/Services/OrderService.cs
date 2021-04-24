using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NorthWindWebAPI.Business.Entities;
using NorthWind.GenericRepository.Common.DataContext;
using NorthWindWebAPI.Business.Providers;

namespace NorthWindWebAPI.Services
{
    public class OrderService
    {

        public static List<Order> GetCustomer(string customerId)
        {
            using (IDataContext model = new NorhWindModel())
            {
                var orders = OrderProvider.GetOrders(model);

                return orders;
            }
        }
    }
}