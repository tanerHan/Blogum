using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace tanerBlog.Models
{
    public class tanerBlogContext : DbContext
    {
        public DbSet<Articles> articles { get; set; }
    }
}