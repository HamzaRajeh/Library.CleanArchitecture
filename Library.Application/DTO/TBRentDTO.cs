using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.DTO
{
    public class TBRentDTO
    {
        
        public int Id { get; set; }

        public int? BookId { get; set; }

        public int? PriodId { get; set; }

        public int? ReRent { get; set; }

        public DateTime? RentDate { get; set; }

        public string? FullName { get; set; }

        public string? PhoneNumber { get; set; }

        public int? StatusId { get; set; }

        public DateTime? ReRentDate { get; set; }

        public DateTime? ReciveDate { get; set; }
    }
}
