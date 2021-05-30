using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagement.Entities
{
    class Employee_Problem:BaseEntity
    {
        public string Problem { get; set; }
        public int User_id { get; set; }
        public int Branch_id { get; set; }
    }
}
