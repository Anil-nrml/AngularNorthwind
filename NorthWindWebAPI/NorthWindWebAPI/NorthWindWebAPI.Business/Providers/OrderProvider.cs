using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthWindWebAPI.Business.Entities;
using NorthWInd.GenericRepository;
using NorthWind.GenericRepository.Common.DataContext;
using System.Linq.Expressions;

namespace NorthWindWebAPI.Business.Providers
{
    public static class OrderProvider
    {

        public static Order GetOrder(IDataContext model,int OrderId)
        {
            var repository = new Repository<Order>(model);
            var order=repository.Find(OrderId);

            return order;
        }
        public static List<Order> GetOrders(IDataContext model)
        {
            var repository = new Repository<Order>(model);
            var orders = repository.Queriable().ToList();
            return orders.Any() ? orders : null;
        }

        public static List<Order> GetOrders(IDataContext model,Employee emp)
        {
            var repository = new Repository<Order>(model);
            var orders = repository.Queriable().Where(o=>o.EmployeeID==emp.EmployeeID).ToList();

            return orders.Any() ? orders : null;
        }
        //public static List<Order> GetOrders(IDataContext model, Expression<System.Func<>> inLineQuery)
        //{
        //    var repository = new Repository<Order>(model);
        //    var orders = repository.Query(inLineQuery);

        //    return orders.Any() ? orders : null;
        //}
    }
}
