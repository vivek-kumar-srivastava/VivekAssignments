using System;
using System.Collections.Generic;

namespace DbFirstEF.Models;

public partial class View1
{
    public string CustomerId { get; set; } = null!;

    public string CompanyName { get; set; } = null!;

    public string? ContactName { get; set; }

    public int OrderId { get; set; }

    public DateTime? OrderDate { get; set; }

    public DateTime? ShippedDate { get; set; }

    public decimal? Freight { get; set; }

    public string? Expr1 { get; set; }

    public string? ShipAddress { get; set; }

    public string? ShipCity { get; set; }
}
