using System.Collections.Generic;
using Dapper.Contrib.Extensions;

namespace Blog.Models
{
    [Table("[UserRole]")]
    public class UserRole
    {
        [ExplicitKey]
        public int UserId { get; set; }
        [ExplicitKey]
        public int RoleId { get; set; }


    }
}