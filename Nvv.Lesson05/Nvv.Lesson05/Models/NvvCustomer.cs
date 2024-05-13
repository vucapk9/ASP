using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nvv.Lesson05.Models
{
    public class NvvCustomer
    {
        public string CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string YearOfBirth { get; set; }
    }
}