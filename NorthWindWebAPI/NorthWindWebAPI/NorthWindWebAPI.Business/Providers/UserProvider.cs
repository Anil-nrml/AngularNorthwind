
using NorthWind.GenericRepository.Common.DataContext;
using NorthWInd.GenericRepository;
using NorthWindWebAPI.Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWindWebAPI.Business.Providers
{
    public static class UserProvider
    {
        public static List<User> GetUsers(IDataContext model)
        {
            var repository = new Repository<User>(model);

            var users = repository.Queriable().ToList();

            return users;
        }

        public static  bool IsAuthenticated(IDataContext model, string userName, string passWord)
        {
            var repository = new Repository<User>(model);
            var result = repository.Queriable().Any(u => u.FirstName == userName && u.Password == passWord);
            return result;

        }
    }
}
