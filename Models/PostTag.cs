using System.Collections.Generic;
using Dapper.Contrib.Extensions;

namespace Blog.Models
{
    [Table("[PostTag]")]
    public class PostTag
    {
        //https://stackoverflow.com/questions/22462987/dapper-insert-into-table-that-has-a-composite-pk
        [ExplicitKey]
        public int PostId { get; set; }
        [ExplicitKey]
        public int TagId { get; set; }

    }
}