﻿using System.Collections.Generic;

namespace Nop.Web.Models.emandateSi
{
    public class Cart
    {
        public List<Item> item { get; set; }
        public string reference { get; set; }
        public string identifier { get; set; }
        public string description { get; set; }
        public string Amount { get; set; }

        public Cart()
        {
            item = new List<Item>();
            reference = "";
            identifier = "";
            description = "";
            Amount = "";
        }
    }
}
