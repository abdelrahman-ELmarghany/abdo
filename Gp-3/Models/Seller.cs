using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gp_3.Models
{
    public class Seller
    {
        public int ID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int WhatsApp { get; set; }
        public bool ActivityStatus { get; set; }
        public string OnHoldAmount { get; set; }
        public string AvailableAmount { get; set; }
    }
}
