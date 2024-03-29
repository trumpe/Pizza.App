﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.PizzApp.WebApp.Models
{
    public class OrderItemViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Price { get; set; }
        public List<PizzaViewModel> Pizzas { get; set; }
    }
}
