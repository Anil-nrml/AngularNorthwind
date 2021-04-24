namespace NorthWindWebAPI.Business.Entities
{
    using NorthWInd.GenericRepository.Entity;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserRole")]
    public partial class UserRole:Entity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserRoleID { get; set; }

        public int? RoleID { get; set; }

        public int? UserID { get; set; }
      
        public int? EnteredBy { get; set; }

        public int? LastModifiedBy { get; set; }

        public bool? Status { get; set; }

        public virtual Role Role { get; set; }

        public virtual User User { get; set; }
    }
}
