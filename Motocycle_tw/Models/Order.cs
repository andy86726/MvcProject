﻿using Motocycle_tw.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Motocycle_tw.Models
{
    public class Order
    {
        [Key]
        public int o_id { get; set; }
        public DateTime o_date { get; set; }
        public string o_receiver { get; set; }
        public string o_address { get; set; }
        public DateTime o_delivedate { get; set; }
        public string o_status { get; set; }
        public int pay_id { get; set; }
        public int dw_id { get; set; }
        public int m_id { get; set; }

        public virtual Delive_Way Delive_Way { get; set; }
        public virtual Member Member { get; set; }
        public virtual ICollection<Order_Detail> Order_Detail { get; set; }
        public virtual Payment Payment { get; set; }
    }
}