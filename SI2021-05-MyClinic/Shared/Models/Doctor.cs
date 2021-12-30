using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public bool Status{ get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PersonalNumber { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateEmployed { get; set; }
        public string Specialization { get; set; }
        public string Department { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
