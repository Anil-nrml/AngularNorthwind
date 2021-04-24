using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NorthWindWebAPI.Business.Entities;
namespace NorthWindWebAPI.Business.Providers
{
    public static class EmplyeeProvider
    {

        public static List<Employee> GetEmplyees(NorhWindModel Context)
        {

           var query= Context.Employees.ToList();

            return query.Any<Employee>() ? query : null;
        }
    }
}
