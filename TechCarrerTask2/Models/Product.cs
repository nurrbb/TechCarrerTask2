﻿namespace TechCarrerTask2.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }
    }
}
