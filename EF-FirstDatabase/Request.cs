using System;
using System.Collections.Generic;

namespace EF_FirstDatabase;

public partial class Request
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public string Justification { get; set; } = null!;

    public string? RejectionReason { get; set; }

    public string DeliveryMode { get; set; } = null!;

    public string Status { get; set; } = null!;

    public decimal Total { get; set; }

    public int UserId { get; set; }

    public virtual ICollection<Requestline> Requestlines { get; set; } = new List<Requestline>();

    public virtual User User { get; set; } = null!;
}
