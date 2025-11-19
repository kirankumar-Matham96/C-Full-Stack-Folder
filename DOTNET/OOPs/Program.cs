using System;
using System.Runtime.Intrinsics.Arm;
namespace OOPs
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n**** Welcome to OOPs concepts! ****\n\n");

            // question: 24 (Student Class)
            // Student s1 = new Student(1001, "Ajay", 500.00);
            // Student s2 = new Student(1002, "Vijay", 600.00);
            // Student s3 = new Student(1003, "Uday", 700.00);

            // Console.WriteLine("Output for question: 24\n###################\n");
            // Console.WriteLine($"student id: {s1.id}, student name: {s1.name}, fees: {s1.fees}");
            // Console.WriteLine($"student id: {s2.id}, student name: {s2.name}, fees: {s2.fees}");
            // Console.WriteLine($"student id: {s3.id}, student name: {s3.name}, fees: {s3.fees}\n");
            // Console.WriteLine("###################\n\n");

            /**
                Required class instantiations
            */
            PracticeMethods pm = new PracticeMethods();
            Person p = new Person(18, 85, 50, 75, 40);
            Employee e = new Employee(1, "employee-1", 400000, "h.no: 8-7/A-12, near police station, some village, some district, some state, 50000052.", "Software Engineer");

            // question: 25 (Employee Class)
            // Console.WriteLine("Output for question: 25\n###################\n");
            // Console.WriteLine($"ID: {e.employeeId}\nName:{e.employeeName}\nSalary: {e.employeeSalary}\nAddress: {e.employeeAddress}\nDesignation: {e.employeeDesignation}");
            // Console.WriteLine("\n###################\n\n");

            // question: 34 (Product Class)
            // Product p = new Product("Product-123", "Smart TV", 20000, 5);
            // Console.WriteLine("Output for question: 34\n###################\n");
            // p.PrintProductData();
            // Console.WriteLine("\n###################\n\n");


            /* Methods */

            // (isPrime)
            // Console.WriteLine("isPrime question:\n###################\n");
            // Console.WriteLine("Enter any integer");
            // // int x = int.Parse(Console.ReadLine());
            // int x = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine($"{x.GetType()}");
            // PracticeMethods.isPrime(x);
            // Console.WriteLine("\n###################\n\n");

            // multiplication table
            // Console.WriteLine("Multiplication Table question:\n###################\n");
            // int num = Convert.ToInt32(Console.ReadLine());
            // PracticeMethods.table(num);
            // Console.WriteLine("\n###################\n\n");

            // can vote (returns a value)
            // Console.WriteLine("Can Vote question:\n###################\n");
            // bool valid = PracticeMethods.CanVote(25);
            // Console.WriteLine(valid ? "Yes" : "No");
            // Console.WriteLine("\n###################\n\n");

            // // Find the big number (returns a value) static method
            // Console.WriteLine("Can Vote question:\n###################\n");
            // string result = PracticeMethods.findTheBigNumber(25, 125, 100);
            // Console.WriteLine(result);
            // Console.WriteLine("\n###################\n\n");

            // // Find the big number (returns a value) static method
            // Console.WriteLine("Can Vote question:\n###################\n");
            // string result = PracticeMethods.findTheBigNumber(25, 125, 100);
            // Console.WriteLine(result);
            // Console.WriteLine("\n###################\n\n");

            // Is Even Number (instance method call)
            // Console.WriteLine("Is even number question:\n###################\n");
            // string result1 = pm.isEven(8);
            // string result2 = pm.isEven(9);
            // Console.WriteLine($"{result1}");
            // Console.WriteLine($"{result2}");
            // Console.WriteLine("\n###################\n\n");

            // Console.WriteLine("Is alphabet question:\n###################\n");
            // Console.WriteLine("Please enter a character\n");
            // var input = Console.ReadKey().KeyChar;
            // PracticeMethods.IsAlphabet(input);
            // Console.WriteLine("\n###################\n\n");

            // Console.WriteLine("Is alphanumeric question:\n###################\n");
            // Console.WriteLine("Please enter the character\n");
            // pm.IsAlphaNumeric(Console.ReadKey().KeyChar);
            // Console.WriteLine("\n###################\n\n");

            // Console.WriteLine("Can donate blood question:\n###################\n");
            // p.CanDonateBlood("Male", 16, 45);           
            // Console.WriteLine("\n###################\n\n");

            // Console.WriteLine("Can donate blood question:\n###################\n");
            // Console.WriteLine("\nPlease enter the employee id\n");
            // int empId = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("\nPlease enter the employee name\n");
            // string empName = Console.ReadLine();
            // Console.WriteLine("\nPlease enter the employee salary\n");
            // double empSalary = Convert.ToDouble(Console.ReadLine());
            // e.EmpDetails(empId, empName, empSalary);
            // Console.WriteLine("\n###################\n\n");

            /* setters and getters */
            // getting min age to donate blood
            Console.WriteLine(p.GetMinAge());
            // setting min age to donate blood
            p.SetMinAge(21);
            Console.WriteLine(p.GetMinAge());
            // getting max age of student (static variable)
            Console.WriteLine(Student.GetMaxAge());
        }
    }
}