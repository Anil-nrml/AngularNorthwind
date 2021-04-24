using NorthWind.GenericRepository.Common.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWInd.GenericRepository.Entity
{
    public abstract class Entity : IObjectState
    {
        [NotMapped]
       public ObjectState ObjectState { get; set; }

       public  DateTime? EnteredDate { get; set; }
       public DateTime? LastModifiedDate { get; set; }
    }
}
