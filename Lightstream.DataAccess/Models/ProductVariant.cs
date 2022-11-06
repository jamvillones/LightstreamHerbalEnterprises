﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lightstream.DataAccess.Models
{
    [Table("ProductVariant")]
    public class ProductVariant : IIDModel,IArchivable
    {
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }
        public Product Product { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public decimal Cost { get; set; }
        [Required]
        public bool IsArchived { get; set; } = false;
        //public bool IsArchived { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
