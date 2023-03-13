using System;
using System.Collections.Generic;

namespace Library.Domain.Models;

public partial class Tbrent
{
    public int Id { get;private set; }

    public int? BookId { get; set; }

    public int? PriodId { get; set; }

    public int? ReRent { get; set; }

    public DateTime? RentDate { get; set; }

    public string? FullName { get; set; }

    public string? PhoneNumber { get; set; }

    public int? StatusId { get; set; }

    public DateTime? ReRentDate { get; set; }

    public DateTime? ReciveDate { get; set; }

    public virtual Tbbook? Book { get; set; }

    public virtual Tbpriod? Priod { get; set; }

    public virtual Tbstatus? Status { get; set; }
}
