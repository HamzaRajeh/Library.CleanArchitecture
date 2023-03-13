using System;
using System.Collections.Generic;

namespace Library.Domain.Models;

public partial class Tbstatus
{
    public int Id { get; set; }

    public string? StatusDescription { get; set; }

    public virtual ICollection<Tbrent> Tbrents { get; } = new List<Tbrent>();
}
