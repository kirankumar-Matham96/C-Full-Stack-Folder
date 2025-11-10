namespace OOPs
{
    public class Employee
    {
        public int employeeId;
        public string employeeName;
        public double employeeSalary;
        public string employeeAddress;
        public string employeeDesignation;

        public Employee(int id, string name, double salary, string address, string designation)
        {
            employeeId = id;
            employeeName = name;
            employeeSalary = salary;
            employeeAddress = address;
            employeeDesignation = designation;
        }

        public void EmpDetails(int id, string name, double salary)
        {
            Console.WriteLine($"ID: {id}\nName: {name}\nSalary: {salary}");
        }
    }
}