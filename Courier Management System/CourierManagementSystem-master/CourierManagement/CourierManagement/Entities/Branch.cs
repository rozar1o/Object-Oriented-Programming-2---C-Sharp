using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagement.Entities
{
    class Branch:BaseEntity
    {
        public string Branch_Name { get; set; }
        public string Address { get; set; }
    }
}
