﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class Menu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        private int TotalPrice { get; set; }
    }

}
