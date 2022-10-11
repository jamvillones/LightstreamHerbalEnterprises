﻿using System;
using System.Collections.Generic;

namespace Lightstream.DataAccess.Models
{
    public partial class Product
    {
        public Product()
        {
            Recipes = new HashSet<Recipe>();
        }

        public int Id { get; set; }
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Recipe> Recipes { get; set; }
    }
}
