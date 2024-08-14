using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CC_MVC.Models
{
    public class movie
    {
        
        [Key]
        public int Mid { get; set; }
        public string Moviename { get; set; }
        public DateTime DateofRelease { get; set; }
    }
}
    