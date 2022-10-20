using System;

namespace WEB.Data.Models
{
    public class Car
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public bool IsFavorite { get; set; }
        public int Availabel { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }

    }
}