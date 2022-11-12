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
            MaterialInventories = new HashSet<MaterialInventory>();
        }

        public int UnitMeasurementId { get; set; }
        public decimal Cost { get; set; }
        public virtual Unit UnitMeasurement { get; set; } = null!;
        public virtual ICollection<Recipe> Recipes { get; set; }
        public virtual ICollection<SupplierToIngredient> SupplierToIngredients { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; }
        public virtual ICollection<MaterialInventory> MaterialInventories { get; set; }
    }
}
