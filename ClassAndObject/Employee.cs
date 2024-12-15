namespace data_type_and_methods
{
    public class Employee
    {
        #region Properties
        public int EmpId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }

        #endregion

        #region Methods
        public void Display()
        {
            Console.WriteLine("Employee Id: " + EmpId);
            Console.WriteLine("Employee Name: " + Name);
            Console.WriteLine("Employee City: " + City);
        } 
        #endregion
    }
}
