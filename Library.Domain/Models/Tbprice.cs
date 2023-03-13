using System;
using System.Collections.Generic;

namespace Library.Domain.Models;

public partial class Tbprice
{
    public int Id { get; set; }

    public decimal? PriceRentBook { get; set; }

    public decimal? PriceLateBook { get; set; }

    public int? PriodId { get; set; }

    public int? BookId { get; set; }

    public virtual Tbbook? Book { get; set; }

    public virtual Tbpriod? Priod { get; set; }
}
