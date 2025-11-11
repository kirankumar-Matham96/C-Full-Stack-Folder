namespace HierarchealInheritance
{
    class Son:Father
    {
        string school;
        
        public Son(string name, string sirName, int age, string school): base(name, sirName, age)
        {
            this.school = school;
        }
    }
}