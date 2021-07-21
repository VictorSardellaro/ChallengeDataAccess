using System.Collections.Generic;
using Dapper.Contrib.Extensions;

namespace Blog.Models
{
    [Table("[UserRole]")]
    public class UserRole
    {
        //https://stackoverflow.com/questions/22462987/dapper-insert-into-table-that-has-a-composite-pk
        [ExplicitKey]
        public int UserId { get; set; }
        [ExplicitKey]
        public int RoleId { get; set; }

    }
}