using System;
using System.Collections.Generic;

namespace Library.Domain.Models;

public partial class Tbbook
{
    public int Id { get; set; }

    public string? BookDiscriptsion { get; set; }

    public int CategoryId { get; set; }

    public byte[]? BooksImg { get; set; }

    public Guid? Guid { get; set; }

    public int? AuthorId { get; set; }

    public virtual Tbauthor? Author { get; set; }

    public virtual Tbcategory Category { get; set; } = null!;

    public virtual ICollection<Tbprice> Tbprices { get; } = new List<Tbprice>();

    public virtual ICollection<Tbrent> Tbrents { get; } = new List<Tbrent>();
}
