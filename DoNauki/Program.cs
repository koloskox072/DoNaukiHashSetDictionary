namespace DoNauki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> set = new HashSet<int>();
            Dictionary<int, int> d = new Dictionary<int, int>();
            /*for (int i=0; i<100; i++)
            {
                Random rnd = new Random();
                int j = rnd.Next(0,101);
                set.Add(j);
            }
            for(int i=0;i<100;i++)
            {
                Console.Write($"{i}: {set.Contains(i)} ");
            }
            Console.WriteLine();
            foreach (int i in set) 
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine(" Unikalne: "+set.Count);
            */
            /*for (int i = 0; i < 100; i++)
            {
                Random rnd = new Random();
                int j = rnd.Next(0, 101);
                d.Add(i, j);
            }*/
            /*foreach (KeyValuePair<int, int> kvp in d) 
            {
                Console.Write($"{kvp.Key}: {kvp.Value}, ");
            }*/
            /*foreach (KeyValuePair<int, int> kvp in d)
            {
                int p = 1;
                foreach (KeyValuePair<int, int> kvp2 in d)
                {
                    if (kvp2.Value == kvp.Value && kvp2.Key!=kvp.Key) 
                    {
                        p++;  
                    }

                }
                Console.Write(kvp.Value + ": " + p+'\t');
            }*/
            for (int i = 0; i < 100; i++) 
            {
                d[i] = 0;
            }
            for (int i = 0; i < 1000; i++)
            {
                Random rnd = new Random();
                int j = rnd.Next(0, 100);
                d[j] = d[j]+1;
            }
            for (int i = 0; i < 100; i++)
            {
                Console.Write($"{i}: {d[i]}" + '\t');
            }



        }
    }
}
