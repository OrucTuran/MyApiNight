﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApiNight.EntityLayer.Concrete
{
    public class Product
    {
        public int ProductID { get; set; }
        public int ProductName { get; set; }
        public int ProductStock { get; set; }
        public int ProductPrice { get; set; }
    }
}