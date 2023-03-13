using System;
using System.Collections.Generic;

namespace Library.Domain.Models;

public partial class Tbpriod
{
    public int Id { get; set; }

    public string? PriodDescription { get; set; }

    public virtual ICollection<Tbprice> Tbprices { get; } = new List<Tbprice>();

    public virtual ICollection<Tbrent> Tbrents { get; } = new List<Tbrent>();
}
