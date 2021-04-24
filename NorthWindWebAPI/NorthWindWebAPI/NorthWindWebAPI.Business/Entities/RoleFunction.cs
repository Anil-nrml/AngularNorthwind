namespace NorthWindWebAPI.Business.Entities
{
    using NorthWInd.GenericRepository.Entity;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RoleFunction")]
    public partial class RoleFunction:Entity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RoleFunctionID { get; set; }

        public int? RoleID { get; set; }

        public int? FunctionID { get; set; }

        public bool? Status { get; set; }
        
        public int? EnteredBy { get; set; }
        
        public int? LastModifiedBy { get; set; }

        public virtual AppFunction AppFunction { get; set; }

        public virtual Role Role { get; set; }
    }
}
