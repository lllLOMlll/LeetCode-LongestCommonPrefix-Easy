class Program 
{
     public string LongestCommonPrefix(string[] strs) {
        
        return "Hello";
    }

static void Main(string[] args)
{
      Program p = new Program();

        // Example 1
        string[] input1 = { "flower", "flow", "flight" };
        string output1 = p.LongestCommonPrefix(input1);
        Console.WriteLine("Example 1:");
        Console.WriteLine($"Input: strs = [\"flower\", \"flow\", \"flight\"]");
        Console.WriteLine($"Output: \"{output1}\"");
        Console.WriteLine();

        // Example 2
        string[] input2 = { "dog", "racecar", "car" };
        string output2 = p.LongestCommonPrefix(input2);
        Console.WriteLine("Example 2:");
        Console.WriteLine($"Input: strs = [\"dog\", \"racecar\", \"car\"]");
        Console.WriteLine($"Output: \"{output2}\"");

}
}