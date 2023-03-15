using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Domain.Models;

public partial class Tbstatus
{
    public int Id { get; set; }

    public string? StatusDescription { get; set; }
    [InverseProperty(nameof(Tbrent.Status))]

    public virtual ICollection<Tbrent> Tbrents { get; } = new List<Tbrent>();
}
