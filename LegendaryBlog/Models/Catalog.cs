using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LegendaryBlog.Models
{
    public class Catalog
    {
            [Key]
            public int Id { set; get; }

            [StringLength(50)]
            public string Name { set; get; }
            public DateTime AddTime { set; get; }
            public bool Status { set; get; }
            public virtual ICollection<Blog> Blogs { get; set; }
    }
}