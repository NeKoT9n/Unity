using System;
using System.Collections.Generic;

namespace WEB.Data.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string description { get; set; }
        List<Car> Cars { get; set; }

    }
}