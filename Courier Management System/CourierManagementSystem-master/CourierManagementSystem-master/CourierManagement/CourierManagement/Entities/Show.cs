namespace CourierManagement.Entities
{
    class Show
    {
        public enum AdminShow
        {
            workerList =1,
            workerProblem,
            allBranch
        }
        public int adminShow;
        public enum EmployeeShow
        {
            varifyCustomers = 1,
            shippedOrders,
            releasedOrders,
            viewCustomers,
            serviceHistory
        }
        public int employeeShow;
    }
}
