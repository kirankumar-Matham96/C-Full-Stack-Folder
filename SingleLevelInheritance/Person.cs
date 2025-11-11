namespace SingleLevelInheritance
{
    class Person
    {
        private int id;
        private string name;
        private int age;
        private string gender;

        // public Person()
        // {}
        public Person(int id, string name, int age, string gender)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.gender = gender;
        }

        public int getId()
        {
            return this.id;
        }
        public string getName()
        {
            return this.name;
        }
        public int getAge()
        {
            return this.age;
        }
        public string getGender()
        {
            return this.gender;
        }

        public void setId(int id)
        {
            this.id = id;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void setAge(int age)
        {
            this.age = age;
        }
        public void setGender(string gender)
        {
            this.gender = gender;
        }

        public override string ToString()
        {
            return $"\nID: {this.id}\nName: {this.name}\nAge: {this.age}\n";
        }
    }
}