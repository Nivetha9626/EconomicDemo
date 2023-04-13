using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EC.Model.Entity.Customer
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public string Address { get; set; }
        public int MobileNumber { get; set; }
        public string City { get; set; }
        public string Gender { get; set; }


    }
}
