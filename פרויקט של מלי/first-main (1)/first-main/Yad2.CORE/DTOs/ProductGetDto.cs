﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yad2.CORE.Models;

namespace Yad2.CORE.DTOs
{
    public class ProductGetDTO//for advertister that dont have the last field מפרסם שלא צריך את השדה האחרון
    {
        public string Description { get; set; }
        public string Status { get; set; }

        public double Price { get; set; } = 0;
        //public int AdvId { get; set; }
    }
}
