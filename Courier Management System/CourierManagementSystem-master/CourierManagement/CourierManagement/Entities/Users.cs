namespace CourierManagement
{
    class Users: BaseEntity
    {
        public enum UserTypeEnum
        {
            Admin,
            Employee,
            Customer
        };
        public string UserName { get; set; }
        public string Password { get; set; }
        public string EmailAddress { get; set; }
        public int UserType { get; set; }
        public bool Information_given { get; set; }
    }
}
