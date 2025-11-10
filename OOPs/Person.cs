namespace OOPs
{
    class Person
    {
        int minAge = 18;
        int maleMaxWeight;
        int maleMinWeight;
        int femaleMaxWeight;
        int femaleMinWeight;

        public Person(int age, int maleMaxWeight, int maleMinWeight, int femaleMaxWeight, int femaleMinWeight)
        {
            minAge = age;
            this.maleMaxWeight = maleMaxWeight;
            this.maleMinWeight = maleMinWeight;
            this.femaleMaxWeight = femaleMaxWeight;
            this.femaleMinWeight = femaleMinWeight;
        }

        public void CanDonateBlood(string gender, int age, double weight)
        {
            if (age >= this.minAge)
            {
                if (gender.ToLower() == "male" && weight >= this.maleMinWeight && weight <= this.maleMaxWeight)
                {
                    Console.WriteLine("Yes, can donate blood");
                }
                else
                {
                    Console.WriteLine($"No, the weight for the Male should be between {this.maleMinWeight} and {this.maleMinWeight} to donate the blood!");
                }
                if (gender.ToLower() == "male" && weight >= this.femaleMinWeight && weight < this.femaleMaxWeight)
                {
                    Console.WriteLine("Yes, can donate blood");
                }
                else
                {
                    Console.WriteLine("No, the weight for the Male should be between 50 and 85 to donate the blood!");
                }
            }
            else
            {
                Console.WriteLine($"Cannot donate blood: age must be more that or equal to {this.minAge}!");
            }
        }
        
    }
}