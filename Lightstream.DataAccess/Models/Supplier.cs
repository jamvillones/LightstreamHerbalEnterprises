﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lightstream.DataAccess.Models
{
    [Table(nameof(Supplier))]
    public partial class Supplier : BaseEntityModel
    {
        public Supplier()
        {
            SupplierToIngredients = new HashSet<SupplierToIngredient>();
            PurchaseOrders = new HashSet<PurchaseOrder>();
        }
        public string? ContactPerson { get; set; } = null;
        public string? ContactDetails { get; set; } = null;
        public string? Address { get; set; } = null;

        public ICollection<SupplierToIngredient> SupplierToIngredients { get; set; }
        public ICollection<PurchaseOrder> PurchaseOrders { get; set; }
    }
}
