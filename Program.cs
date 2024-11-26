namespace CountOccurences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,int> Count = new Dictionary<string,int>();
            string[] input = [ "a", "b", "c","a","c", "d","h" ,"f"];

            foreach (string s in input)
            {
                if (!Count.TryAdd(s,1)) 
                {
                    Count[s]++;
                }
            }
            Console.WriteLine();
            foreach (KeyValuePair<string, int> kvp in Count)
            {
                Console.WriteLine("key = {0}, count = {1}", kvp.Key,kvp.Value);
            }  

        }
    }
}
