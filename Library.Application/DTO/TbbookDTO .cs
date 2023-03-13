using Library.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.DTO
{
    public class TbbookDTO
    {
    public int Id { get; set; }

    public string? BookDiscriptsion { get; set; }

    public int CategoryId { get; set; }

    public byte[]? BooksImg { get; set; }

    public Guid? Guid { get; set; }

    public int? AuthorId { get; set; }

    public virtual Tbauthor? Author { get; set; }

    public virtual Tbcategory? Category { get; set; } = null!;

    public virtual ICollection<Tbprice> Tbprices { get; } = new List<Tbprice>();

    public virtual ICollection<Tbrent> Tbrents { get; } = new List<Tbrent>();

         
    
    }
}
