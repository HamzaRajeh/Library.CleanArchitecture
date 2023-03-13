using System;
using System.Collections.Generic;

namespace Library.Domain.Models;

public partial class Tbauthor
{
    public int Id { get; set; }

    public string? AuthorName { get; set; }

    public virtual ICollection<Tbbook> Tbbooks { get; } = new List<Tbbook>();
}
