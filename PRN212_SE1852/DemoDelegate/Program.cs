public delegate int[] myDelegate(int n);
class program
{
    static int[] listEven(int n)
    {
        List<int> List = new List<int>();
        for (int i = 2; i < n; i++) {
            if(i % 2 == 0) List.Add(i);
        }
        return List.ToArray();
    }

    static int[] listPrime(int n)
    {
        List<int> List = new List<int>();
        for(int i = 2; i < n; i++)
        {
            int count = 0;
            for(int j = 1; j <= i; j++)
            {
                if(i == j) count++;
                if( count == 2) List.Add(j);
            }
        }
        return List.ToArray();
    }

    public static void Main(string[] args)
    {
        myDelegate d = new myDelegate(listEven);
        int[] result = d(10);
        Console.Write("Even Number: \n");
        foreach(var n in result) Console.WriteLine(n);

    }
}

