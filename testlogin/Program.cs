using ChapeauModel;
using ChapeauService;

namespace testlogin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Test";
            employee.Password = "123";
            employee.LastName = "Test";
            employee.EmployeeType = EmployeeType.Waiter;

            EmployeeService employeeService = new EmployeeService();

            string hashedpassword = employeeService.HashPassword("4567");
            /*employeeService.AddEmployee(employee);*/
            bool loginSucces = employeeService.VerifyLogin("Andrew", "4567");

            if (loginSucces)
            {
                Console.WriteLine("GJ continue");
            }
            else
            {
                Console.WriteLine("Still needs some work");
            }
        }
    }
}