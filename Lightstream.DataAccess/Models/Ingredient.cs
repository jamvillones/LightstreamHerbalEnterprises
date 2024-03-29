﻿using System;
using System.Collections.Generic;

namespace Lightstream.DataAccess.Models
{
    public partial class Ingredient : BaseEntityModel
    {
        public Ingredient()
        {
            Recipes = new HashSet<Recipe>();
            SupplierToIngredients = new HashSet<SupplierToIngredient>();
            PurchaseOrders = new HashSet<PurchaseOrder>();
        }

        public int UnitMeasurementId { get; set; }
        public decimal Cost { get; set; }
        public decimal CriticalQty { get; set; } = 0;
        public virtual Unit UnitMeasurement { get; set; } = null!;
        public virtual ICollection<Recipe> Recipes { get; set; }
        public virtual ICollection<SupplierToIngredient> SupplierToIngredients { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
    }
}
