using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamSuite.Entities.Models
{
    public class Member
    {
        public Guid Id { get; set; }
        public Guid SiteId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid Gender { get; set; }
        public Guid? MaritalStatus { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set;}
        public string? Address { get; set; }
        public DateTime? DateOfBirth { get; set; }

        public Site? Site { get; set; }
    }
}
