﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Note:EntityBase
    {
        public string Title { get; set; } = default!;
        public string? Description { get; set; }
    }
}