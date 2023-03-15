using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Domain.Models;

public partial class Tbrent
{
    public Tbrent()
    {
        Priod=new Tbpriod();
        Status=new Tbstatus();  
        Book=new Tbbook();
    }

    public int Id { get;private set; }

    public int? BookId { get; set; }

    public int? PriodId { get; set; }

    public int? ReRent { get; set; }
    [DisplayFormat(DataFormatString = "{MM/dd/yyyy}")]
    public DateTime? RentDate { get; set; }

    public string? FullName { get; set; }

    public string? PhoneNumber { get; set; }

    public int? StatusId { get; set; }
    [DisplayFormat(DataFormatString = "{MM/dd/yyyy}")]

    public DateTime? ReRentDate { get; set; }
    [DisplayFormat(DataFormatString = "{MM/dd/yyyy}")]

    public DateTime? ReciveDate { get; set; }
    [ForeignKey(nameof(BookId))]
    [InverseProperty("Tbrents")]

    public virtual Tbbook? Book { get; set; }

    [ForeignKey(nameof(PriodId))]
    [InverseProperty("Tbrents")]
    public virtual Tbpriod? Priod { get; set; }

    [ForeignKey(nameof(StatusId))]
    [InverseProperty("Tbrents")]

    public virtual Tbstatus? Status { get; set; }
    
 }
