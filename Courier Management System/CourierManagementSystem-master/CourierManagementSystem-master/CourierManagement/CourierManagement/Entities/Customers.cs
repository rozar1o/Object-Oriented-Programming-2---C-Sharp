using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagement.Entities
{
    class Customers : BaseEntity
    {
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public string Sequrity_Que { get; set; }
        public int User_Id { get; set; }
        public bool Is_verified { get; set; }
    }
}
