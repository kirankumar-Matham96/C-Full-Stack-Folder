namespace HierarchealInheritance
{
    class Daughter:Father
    {
        string college;
        
        public Daughter(string name, string sirName, int age, string college): base(name, sirName, age)
        {
            this.college = college;
        }
    }
}