﻿using System;
using System.Collections.Generic;

namespace IMS.Entities
{
    public partial class StockTransaction
    {
        public int StockTransactionId { get; set; }
        public string SKUID { get; set; } = null!;
        public int? StockIn { get; set; }
        public int? StockOut { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTimeOffset UpdatedAt { get; set; }
        public string UpdatedBy { get; set; } = null!;

        public virtual MasterBarang SKU { get; set; } = null!;
    }
}
