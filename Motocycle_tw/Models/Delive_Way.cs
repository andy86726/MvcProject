using Motocycle_tw.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Motocycle_tw.Models
{
    public class Delive_Way
    {
        [Key]
        public int dw_id { get; set; }
        public string dw_name { get; set; }

        public virtual ICollection<Order> Order { get; set; }
    }
}