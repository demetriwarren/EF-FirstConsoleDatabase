using System;
using System.Collections.Generic;

namespace EF_FirstDatabase;

public partial class Product
{
    public int Id { get; set; }

    public string PartNbr { get; set; } = null!;

    public string Name { get; set; } = null!;

    public decimal Price { get; set; }

    public string Unit { get; set; } = null!;

    public string? PhotoPath { get; set; }

    public int VendorId { get; set; }

    public virtual ICollection<Requestline> Requestlines { get; set; } = new List<Requestline>();

    public virtual Vendor Vendor { get; set; } = null!;
}
