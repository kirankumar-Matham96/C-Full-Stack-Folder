namespace MultiLevelInheritance
{
    class Vehicle
    {
        private int numberOfTires;
        private int numberOfDoors;
        private string fuelType;

        public Vehicle(int tires, int doors, string fuel)
        {
            numberOfTires = tires;
            numberOfDoors = doors;
            fuelType = fuel;
        }

        public int getTires()
        {
            return numberOfTires; // testing what happens if we don't give this keyword
        }

        public int getDoors()
        {
            return this.numberOfDoors;
        }

        public string getFuelType()
        {
            return this.fuelType;
        }

        public void setTires(int tires)
        {
            numberOfTires = tires;
        }

        public void setDoors(int doors)
        {
            numberOfTires = doors;
        }
        
        public void setFuelType(string fuel)
        {
            fuelType = fuel;
        }
    }
}