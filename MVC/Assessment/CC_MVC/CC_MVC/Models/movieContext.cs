using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CC_MVC.Models
{
    public class movieContext
    {
        
        public moviesContext() : base("connectstr")
        { }

        public DbSet<movie> Movies { get; set; }
    }
}
    