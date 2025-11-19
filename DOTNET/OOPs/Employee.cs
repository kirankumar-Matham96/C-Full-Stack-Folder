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

        public int GetEmpId()
        {
            return employeeId;
        }

        public string GetEmpName()
        {
            return employeeName;
        }

        public double GetEmpSalary()
        {
            return employeeSalary;
        }

        public void SetEmpId(int id)
        {
            employeeId = id;
        }
        
        public void SetEmpName(string name)
        {
            employeeName = name;
        }
        
        public void SetEmpSalary(double salary)
        {
            employeeSalary = salary;
        }       


        public void EmpDetails(int id, string name, double salary)
        {
            Console.WriteLine($"ID: {id}\nName: {name}\nSalary: {salary}");
        }
    }
}