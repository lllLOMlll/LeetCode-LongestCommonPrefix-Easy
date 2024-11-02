class Program 
{
 public string LongestCommonPrefix(string[] strs)
{
    if (strs == null || strs.Length == 0)
        return "";

    // Start with the first word as the initial longest common prefix
    string longestCommonPrefix = strs[0];

    // Iterate through the array starting from the second word
    for (int i = 1; i < strs.Length; i++)
    {
        string wordInTheArray = strs[i];
        int prefixLength = 0;

        // Compare characters until they differ or we reach the end of one of the words
        while (prefixLength < longestCommonPrefix.Length && prefixLength < wordInTheArray.Length &&
               longestCommonPrefix[prefixLength] == wordInTheArray[prefixLength])
        {
            prefixLength++;
        }

        // Update longestCommonPrefix to the common prefix found
        longestCommonPrefix = longestCommonPrefix.Substring(0, prefixLength);

        // If there is no common prefix, return an empty string
        if (longestCommonPrefix == "")
            return "";
    }

    return longestCommonPrefix;
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