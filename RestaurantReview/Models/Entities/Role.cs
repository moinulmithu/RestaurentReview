using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestaurantReview.Models.Entities
{
    public class Role
    {
        [Key]
        public virtual Guid RoleId { get; set; }
        [Required]
        public virtual string  RoleName { get; set; }
        public virtual string Description { get; set; }
        public virtual  ICollection<UserProfile> Users { get; set; }
    }
}