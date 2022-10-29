﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lightstream.DataAccess.Models
{
    public class BaseEntityModel : IIDModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
    }
}
