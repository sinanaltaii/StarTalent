﻿using System;
using System.Collections.Generic;

namespace Star.Data.Models
{
    public partial class DjangoMigrations
    {
        public int Id { get; set; }
        public string App { get; set; }
        public string Name { get; set; }
        public DateTime Applied { get; set; }
    }
}
