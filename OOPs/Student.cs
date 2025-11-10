namespace OOPs
{
    public class Student
    {
        private int id;
        private string name;
        private static int maxAge = 21;
        private double fees;

        public Student(int id, string name, double fees)
        {
            this.id = id;
            this.name = name;
            this.fees = fees;
        }

        public int GetId()
        {
            return id;
        }

        public string GetName()
        {
            return name;
        }

        public double GetFees()
        {
            return fees;
        }

        public void SetId(int id)
        {
            this.id = id;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetFees(double fees)
        {
            this.fees = fees;
        }

        public static int GetMaxAge()
        {
            return maxAge;
        }

        public static void SetMaxAge(int age)
        {
            maxAge = age;
        }
    }
}