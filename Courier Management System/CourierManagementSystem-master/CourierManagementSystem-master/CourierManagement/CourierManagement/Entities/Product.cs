using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagement.Entities
{
    class Product : BaseEntity
    {
        public enum ProductTypeEnum
        {
            Extra_Large,
            Large,
            Medium,
            Small
        }
        public enum ProductCategoryEnum
        {
            Document,
            Package,
            Accessories,
            Electronics,
            Groceries,
            Others
        }

        public enum PaymentMethodEnum
        {
            Cash
        }

        public enum ProductStateEnum
        {
            Not_yet_Received,
            Received,
            Shipped,
            Sent_to_destination,
            Released
        }
        public int Product_State { get; set; }
        public DateTime Release_Date { get; set; }
        public int ProductType { get; set; }
        
        public int Customer_id { get; set; }
        public int Receiving_B_id { get; set; }
        public int Sending_B_id { get; set; }
        public float Delivery_charge { get; set; }
        public int Sending_Manager_id { get; set; }
        public int Receiving_Manager_id { get; set; }
        public int ProductCategory { get; set; }
        public int PaymentMethod { get; set; }
        public string RecieverName { get; set; }
        public string RecieverEmail { get; set; }
        public string RecieverContact { get; set; }
        public string RecieverAddress { get; set; }
        public string Description { get; set; }
    }
}
