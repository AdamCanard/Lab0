

namespace Lab0;
class Program
{
    static void Main(string[] args)
    {

        int low = getLow();
        int high = getHigh(low);

        int dif = high - low;

        List<double> list = new List<double>();
        for(int i = 0; i < dif; i++)
        {
            list.Add(i+low);
        }

        using(StreamWriter sw = new StreamWriter("C:\\Users\\azcun\\source\\repos\\Lab0\\lab0\\number.txt"))
        {
            for (int i = list.Count-1; i >= 0; i--)
            {
                sw.WriteLine(list[i]);
            }
                
        
        }

        using (StreamReader sw = new StreamReader("C:\\Users\\azcun\\source\\repos\\Lab0\\lab0\\number.txt"))
        {
            int sum = 0;
            string line;
            Console.WriteLine("These are the prime numbers between your low and high number");
            while ((line = sw.ReadLine()) != null)
            {
                int.TryParse(line, out int num);
                sum += num;
                if (isPrime(num))
                {
                    Console.WriteLine("PRIME: " + num);
                }
            }
            Console.WriteLine("SUM: " + sum);
        }

    }

    private static bool isPrime(int num)
    {
        for(int i = 2;i < num;i++)
        {
            if(num % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    private static int getHigh(int low)
    {
        while (true)
        {
            Console.Write("Enter a Positive high number : ");
            string str = Console.ReadLine();
            if (int.TryParse(str, out int high) && high > low)
            {
                return high;
            }
            else
            {
                Console.WriteLine("Bad input");
            }
        }
    }

    private static int getLow()
    {
        while (true)
        {
            Console.Write("Enter a Positive low number: ");
            string str = Console.ReadLine();
            if (int.TryParse(str, out int low) && low > 0)
            {
                return low;
            }
            else
            {
                Console.WriteLine("Bad input");
            }
        }
        
    }
}