using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.GenericRepository.Common.Infrastructure
{
    public interface IObjectState
    {
        [NotMapped]
        ObjectState ObjectState { get; set; }

        DateTime? EnteredDate { get; set; }
        DateTime? LastModifiedDate { get; set; }


    }
}
