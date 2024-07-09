using System;
using System.Linq;

/*
 ** Sample I/O
 **
 ** INPUT: 
 ** 
 ** Two words in each line to compare if they are anagrams.
 **
 ** Example Input: 
 ** CAT
 ** TAC
 **
 ** OUTPUT:
 **
 ** If the strings are anagrams, "The strings are anagrams" is the printed output. Otherwise,
 ** if they are not anagrams, "The strings are not anagrams" is the printed output.
 **
 ** Example Output for previous example input:
 ** The strings are anagrams
 **
 ** Time complexity - O(n)
 **
 ** Space complexity - O(n)
 **
 */					
public class Program
{
	private static bool AreAnagrams(string firstString, string secondString)
	{
		 if (firstString == null || secondString == null)
    {
        throw new ArgumentNullException("Both strings must be non-null.");
    }

    if (firstString.Length != secondString.Length)
    {
        return false; // Anagrams must have the same length
    }

    // Convert strings to lowercase character arrays
    char[] firstStringChars = firstString.ToLower().ToCharArray();
    char[] secondStringChars = secondString.ToLower().ToCharArray();

    // Sort character arrays
    Array.Sort(firstStringChars);
    Array.Sort(secondStringChars);

    // Compare sorted character arrays
    return firstStringChars.SequenceEqual(secondStringChars);
	}
	
	public static void Main()
	{
		Console.Write("Enter the first word: ");
		var firstString = Console.ReadLine();
		Console.Write("Enter the second word: ");
		var secondString = Console.ReadLine();
		var result = AreAnagrams(firstString, secondString);
		if(result)
		{
			Console.WriteLine("The strings are anagrams");
		}
		else
		{
			Console.WriteLine("The strings are not anagrams");
		}
	}
}