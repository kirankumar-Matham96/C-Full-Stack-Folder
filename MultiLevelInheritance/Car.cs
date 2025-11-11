namespace MultiLevelInheritance
{
    class Car:Vehicle
    {
        private string engineType;
        private string company;
        public Car(int tires, int doors, string fuel, string engine, string company) : base(tires, doors, fuel)
        {
            engineType = engine;
            this.company = company;
        }

        public string getEngineType()
        {
            return engineType;
        }

        public string getCompany()
        {
            return company;
        }

        public void setEngineType(string type)
        {
            engineType = type;
        }
        public void setCompany(string company)
        {
            this.company = company;
        }
    }
}