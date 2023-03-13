using System;
using System.Collections.Generic;

namespace Library.Domain.Models;

public partial class Tbcategory
{
    public int Id { get; set; }

    public string? CategioryDescription { get; set; }

    public virtual ICollection<Tbbook> Tbbooks { get; } = new List<Tbbook>();
}
