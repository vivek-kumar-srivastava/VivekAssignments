using System;
using System.Collections.Generic;

namespace DbFirstEF.Models;

public partial class View2
{
    public int ProductId { get; set; }

    public decimal? LineTotal { get; set; }

    public DateTime? OrderDate { get; set; }

    public int OrderId { get; set; }

    public string ProductName { get; set; } = null!;
}
