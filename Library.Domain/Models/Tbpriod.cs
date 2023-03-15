using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Domain.Models;

public partial class Tbpriod
{
    public int Id { get; set; }

    public string? PriodDescription { get; set; }

    public virtual ICollection<Tbprice> Tbprices { get; } = new List<Tbprice>();
    [InverseProperty(nameof(Tbrent.Priod))]
    public virtual ICollection<Tbrent> Tbrents { get; } = new List<Tbrent>();
}
