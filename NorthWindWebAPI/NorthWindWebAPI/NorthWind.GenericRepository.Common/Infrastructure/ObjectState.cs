using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.GenericRepository.Common.Infrastructure
{
    public enum ObjectState
    {
        UnChanged,
        Added,
        Modified,
        Deleted
    }
}
