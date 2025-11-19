namespace ArithmaticOperations;

public class OOPs
{
    public int x = 5;
    static int y = 10;

    public void changeX()
    {
        this.x = 10;
    }
    public void getSum()
    {
        System.Console.WriteLine(x + y);
    }

    public static void getY()
    {
        System.Console.WriteLine(y);
    }
}

public class ArithmaticOperationsClass : OOPs
{
    public int sumOf2Numbers(int x, int y)
    {
        return x + y;
    }

    public int sumOf3Numbers(int x, int y, int z)
    {
        return x + y + z;
    }

    public double averageOf3Numbers(int x, int y, int z)
    {
        return (x + y + z) / 3;
    }

    public void getQuotientAndRemainder(int x, int y)
    {
        double quotient = x / y;
        int remainder = x % y;
        System.Console.WriteLine(quotient);
        System.Console.WriteLine(remainder);
    }
    public void getSumOfFirstNDigits(int n)
    {
        int sum = 0;
        for (var i = 1; i <= n; i++)
        {
            sum += i;
        }
        System.Console.WriteLine(sum);
    }

    public void getLastDigit(int x)
    {
        System.Console.WriteLine(x % 10);
    }

    public void removeLastDigit(int x)
    {
        System.Console.WriteLine(x / 10);
    }

    public void getSquareAndQube(int x)
    {
        System.Console.WriteLine($"Square is: {x * x} and Cube is: {x * x * x}");
    }

    public void swap2Numbers()
    {
        int x = 10;
        int y = 15;

        System.Console.WriteLine($"Before swapping: x = {x} and y = {y}");
        int temp = x;
        x = y;
        y = temp;
        System.Console.WriteLine($"After swapping: x = {x} and y = {y}");
    }

    public void swap2NumbersShort()
    {
        int x = 10;
        int y = 15;

        System.Console.WriteLine($"Before swapping: x = {x} and y = {y}");
        x = x + y;
        y = x - y;
        x = x - y;
        System.Console.WriteLine($"After swapping: x = {x} and y = {y}");
    }

    // public static void Main(string[] ags)
    // {
    //     ArithmaticOperationsClass aop = new ArithmaticOperationsClass();
    //     System.Console.WriteLine(aop.sumOf2Numbers(2, 5));
    //     System.Console.WriteLine(aop.sumOf3Numbers(5, 6, 7));
    //     System.Console.WriteLine(aop.averageOf3Numbers(10, 20, 30));
    //     aop.getQuotientAndRemainder(11, 5);
    //     aop.getSumOfFirstNDigits(10);
    //     aop.getLastDigit(12345);
    //     aop.removeLastDigit(12345);
    //     aop.getSquareAndQube(2);
    //     aop.swap2Numbers();
    //     aop.swap2NumbersShort();
    // }
}

public class SubClass:ArithmaticOperationsClass
{
    public static void Main(string[] args)
    {
        SubClass sc = new SubClass();
        int a = sc.x;
        /*
            Cannot access the static variables and methods through inheritance.
        */
        // System.Console.WriteLine(sc.y);
        // sc.getY();

        System.Console.WriteLine(sc.x);
        System.Console.WriteLine(a);
        sc.changeX();
        System.Console.WriteLine(sc.x);
        System.Console.WriteLine(a);
    }
}

