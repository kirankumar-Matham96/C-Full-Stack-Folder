namespace SingleLevelInheritance
{
    class Teacher : Person
    {
        private string mainSubject;
        private double salary;

        public Teacher(int id, string name, int age, string gender, string subject, double salary) : base(id, name, age, gender)
        {
            mainSubject = subject;
            this.salary = salary;
        }

        public string getMainSubject()
        {
            return this.mainSubject;
        }

        public double getSalary()
        {
            return this.salary;
        }

        public void setMainSubject(string sub)
        {
            mainSubject = sub;
        }

        public void setSalary(double salary)
        {
            this.salary = salary;
        }

        public override string ToString()
        {
            return $"\nTeacher Details\nID: {base.getId()}\nName:{base.getName()}\nAge: {base.getAge()}\nGender: {base.getGender()}\nSubject: {mainSubject}\nSalary: {salary}\n";
        }
    }
}