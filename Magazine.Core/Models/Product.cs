﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine.Core.Models
{
    internal class Product
    {
        public int Id { get; set; }
        public string Definition { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Image {  get; set; } 
        
    }
}
