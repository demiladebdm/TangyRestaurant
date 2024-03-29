﻿using Tangy.Models;

namespace Tangy.Models.HomeViewModel
{
    public class IndexViewModel
    {
        public IEnumerable<MenuItem> MenuItem { get; set; }
        public IEnumerable<Category> Category { get; set; }
        public IEnumerable<Coupons> Coupons { get; set; }

        public string StatusMessage { get; set; }
    }
}