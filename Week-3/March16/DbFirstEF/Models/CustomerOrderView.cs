using System;
using System.Collections.Generic;

namespace DbFirstEF.Models;

public partial class CustomerOrderView
{
    public string Customerid { get; set; } = null!;

    public string Companyname { get; set; } = null!;

    public string? City { get; set; }

    public int Orderid { get; set; }

    public DateTime? Orderdate { get; set; }

    public decimal? Freight { get; set; }
}
