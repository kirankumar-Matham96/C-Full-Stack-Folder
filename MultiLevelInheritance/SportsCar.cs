namespace MultiLevelInheritance
{
    class SportsCar:Car
    {
        int horsepower;
        int speed;

        public SportsCar(int tires, int doors, string fuel, string engine, string company, int hp, int speed) : base(tires, doors, fuel, engine, company)
        {
            horsepower = hp;
            this.speed = speed;
        }

        public int getHP()
        {
            return horsepower;
        }

        public void setHP(int hp)
        {
            horsepower = hp;
        }

        public int getSpeed()
        {
            return speed;
        }
        
        public void setSpeed(int speed)
        {
            this.speed = speed;
        }
    }
}