using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Strings
{

    //----------------------------------------------------Assignment 18-----------------------------------------------------------------------
    //class Program
    //{
    //    static void Main()
    //    {
    //        string input = "12345";  

    //        bool isOnlyDigits = input.All(char.IsDigit);

    //        if (isOnlyDigits)
    //        {
    //            Console.WriteLine("The string contains only digits");
    //        }
    //        else
    //        {
    //            Console.WriteLine("The string contains non-digit characters");
    //        }
    //        Console.ReadLine();
    //    }
    //}



    //-----------------------------------------------------Assignment 17-----------------------------------------------------------------------
    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        Console.WriteLine("Enter a sentence:");
    //        string input = Console.ReadLine();

    //        // Reverse the words in the sentence
    //        string reversedSentence = ReverseWords(input);

    //        Console.WriteLine("Sentence with reversed words: " + reversedSentence);
    //        Console.ReadLine();
    //    }

    //    public static string ReverseWords(string sentence)
    //    {
    //        // Split the sentence into words
    //        string[] words = sentence.Split(' ');

    //        // Reverse the order of words
    //        Array.Reverse(words);

    //        // Join the reversed words into a new sentence
    //        return string.Join(" ", words);
    //    }
    //}


    //-----------------------------------------------------------------Assignment 16------------------------------------------------------------
    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        Console.WriteLine("Enter a string:");
    //        string input = Console.ReadLine();

    //        // Find the first non-repeating character
    //        char? firstNonRepeatingChar = FindFirstNonRepeatingCharacter(input);

    //        if (firstNonRepeatingChar != null)
    //        {
    //            Console.WriteLine("The first non-repeating character is: " + firstNonRepeatingChar);
    //        }
    //        else
    //        {
    //            Console.WriteLine("No non-repeating character found.");
    //        }
    //        Console.ReadLine();
    //    }

    //    public static char? FindFirstNonRepeatingCharacter(string str)
    //    {
    //        // Dictionary to store character frequencies
    //        Dictionary<char, int> frequencyDict = new Dictionary<char, int>();

    //        // First pass: Count the frequency of each character
    //        foreach (char c in str)
    //        {
    //            if (frequencyDict.ContainsKey(c))
    //            {
    //                frequencyDict[c]++;
    //            }
    //            else
    //            {
    //                frequencyDict[c] = 1;
    //            }
    //        }

    //        // Second pass: Find the first character with a frequency of 1
    //        foreach (char c in str)
    //        {
    //            if (frequencyDict[c] == 1)
    //            {
    //                return c;
    //            }
    //        }

    //        return null; // No non-repeating character found
    //    }
    //}


    //------------------------------------------------------------------Assignment 15------------------------------------------------
    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        Console.WriteLine("Enter a string:");
    //        string input = Console.ReadLine();

    //        // Find and display character frequencies
    //        Dictionary<char, int> frequencies = FindCharacterFrequencies(input);

    //        Console.WriteLine("Character frequencies:");
    //        foreach (var item in frequencies)
    //        {
    //            Console.WriteLine($"{item.Key}: {item.Value}");
    //        }
    //        Console.ReadLine();
    //    }

    //    public static Dictionary<char, int> FindCharacterFrequencies(string str)
    //    {
    //        // Dictionary to store character frequencies
    //        Dictionary<char, int> frequencyDict = new Dictionary<char, int>();

    //        foreach (char c in str)
    //        {
    //            if (frequencyDict.ContainsKey(c))
    //            {
    //                frequencyDict[c]++;
    //            }
    //            else
    //            {
    //                frequencyDict[c] = 1;
    //            }
    //        }

    //        return frequencyDict;
    //    }
    //}



    //---------------------------------------------Assignment 14--------------------------------------------------------------
    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        Console.WriteLine("Enter the first string:");
    //        string str1 = Console.ReadLine().ToLower(); // Convert to lowercase to ignore case sensitivity

    //        Console.WriteLine("Enter the second string:");
    //        string str2 = Console.ReadLine().ToLower(); // Convert to lowercase to ignore case sensitivity

    //        // Check if the two strings are anagrams
    //        bool areAnagrams = AreAnagrams(str1, str2);

    //        if (areAnagrams)
    //        {
    //            Console.WriteLine("The two strings are anagrams");
    //        }
    //        else
    //        {
    //            Console.WriteLine("The two strings are not anagrams");
    //        }
    //        Console.ReadLine();
    //    }

    //    public static bool AreAnagrams(string str1, string str2)
    //    {
    //        // If lengths are different, they cannot be anagrams
    //        if (str1.Length != str2.Length)
    //        {
    //            return false;
    //        }

    //        // Sort the characters in both strings and compare them
    //        var sortedStr1 = new string(str1.OrderBy(c => c).ToArray());
    //        var sortedStr2 = new string(str2.OrderBy(c => c).ToArray());

    //        return sortedStr1 == sortedStr2;
    //    }
    //}


    //-------------------------------------Assignment 13--------------------------------------------------
    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        Console.WriteLine("Enter a string:");
    //        string input = Console.ReadLine();

    //        // Remove duplicate characters
    //        string result = RemoveDuplicateCharacters(input);

    //        Console.WriteLine("String after removing duplicates: " + result);
    //        Console.ReadLine();
    //    }

    //    public static string RemoveDuplicateCharacters(string str)
    //    {
    //        string result = "";

    //        foreach (char c in str)
    //        {
    //            // If the character is not already in the result string, add it
    //            if (!result.Contains(c))
    //            {
    //                result += c;
    //            }
    //        }

    //        return result;
    //    }
    //}


    //--------------------------------------Assignment 12------------------------------------------------------
    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        Console.WriteLine("Enter a sentence:");
    //        string sentence = Console.ReadLine();

    //        // Count the number of words
    //        int wordCount = CountWords(sentence);

    //        Console.WriteLine($"The number of words in the sentence is: {wordCount}");
    //        Console.ReadLine();
    //    }

    //    public static int CountWords(string sentence)
    //    {
    //        // Split the sentence into words by whitespace and filter out any empty entries
    //        string[] words = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

    //        // Return the number of words
    //        return words.Length;
    //    }
    //}


    //--------------------------------------------------Assignment 11------------------------------------------
    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        Console.WriteLine("Enter a sentence:");
    //        string sentence = Console.ReadLine();

    //        // Finding the longest word
    //        string longestWord = FindLongestWord(sentence);

    //        Console.WriteLine("The longest word is: " + longestWord);
    //        Console.ReadLine();
    //    }

    //    public static string FindLongestWord(string sentence)
    //    {
    //        string[] words = sentence.Split(' ');
    //        string longestWord = "";

    //        foreach (string word in words)
    //        {
    //            if (word.Length > longestWord.Length)
    //            {
    //                longestWord = word;
    //            }
    //        }

    //        return longestWord;
    //    }
    //}


    //------------------------------------------Assignment 10--------------------------------------------------------
    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        Console.WriteLine("Enter the main string:");
    //        string mainString = Console.ReadLine();

    //        Console.WriteLine("Enter the substring to replace:");
    //        string oldSubstring = Console.ReadLine();

    //        Console.WriteLine("Enter the new substring:");
    //        string newSubstring = Console.ReadLine();

    //        // Replace all occurrences with newSubstring
    //        string result = mainString.Replace(oldSubstring, newSubstring);

    //        Console.WriteLine("Updated string: " + result);
    //        Console.ReadLine();
    //    }
    //}


    //--------------------------------------Assignment 9----------------------------------------------------------------
    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        Console.WriteLine("Enter a string with whitespace:");
    //        string input = Console.ReadLine();

    //        // Remove whitespace
    //        string result = RemoveWhitespace(input);

    //        Console.WriteLine("String without whitespace: " + result);
    //        Console.ReadLine();
    //    }

    //    public static string RemoveWhitespace(string str)
    //    {
    //        return str.Replace(" ", ""); // Replace spaces with empty string
    //    }
    //}


    //---------------------------------------------Assignment 8-----------------------------------------------------
    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        Console.WriteLine("Enter a string:");
    //        string input = Console.ReadLine();

    //        // Convert to uppercase
    //        string upperCase = input.ToUpper();
    //        Console.WriteLine("Uppercase: " + upperCase);

    //        // Convert to lowercase
    //        string lowerCase = input.ToLower();
    //        Console.WriteLine("Lowercase: " + lowerCase);

    //        // Convert to title case
    //        string titleCase = ToTitleCase(input);
    //        Console.WriteLine("Title Case: " + titleCase);
    //        Console.ReadLine();
    //    }

    //    // Method to convert a string to title case
    //    public static string ToTitleCase(string str)
    //    {
    //        CultureInfo cultureInfo = CultureInfo.CurrentCulture;
    //        TextInfo textInfo = cultureInfo.TextInfo;
    //        return textInfo.ToTitleCase(str.ToLower());
    //    }
    //}


    //-----------------------------------------Assignment 7------------------------------------------------------
    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        Console.WriteLine("Enter the main string:");
    //        string mainString = Console.ReadLine();

    //        Console.WriteLine("Enter the substring to find:");
    //        string subString = Console.ReadLine();

    //        int occurrences = CountSubstringOccurrences(mainString, subString);

    //        Console.WriteLine($"The substring '{subString}' appears {occurrences} times ");
    //        Console.ReadLine();
    //    }

    //    public static int CountSubstringOccurrences(string mainString, string subString)
    //    {
    //        int count = 0;
    //        int index = 0;

    //        // Loop to find each occurrence of the substring
    //        while ((index = mainString.IndexOf(subString, index)) != -1)
    //        {
    //            count++;
    //            index += subString.Length; // Move past the last found substring to continue searching
    //        }

    //        return count;
    //    }
    //}


    //-------------------------------------Assignment6--------------------------------------------------------
    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        Console.WriteLine("Enter a string to reverse: ");
    //        string input = Console.ReadLine();

    //        // Reverse the string using built-in method
    //        string reversedString = ReverseString(input);

    //        Console.WriteLine("Reversed string: " + reversedString);
    //        Console.ReadLine();
    //    }

    //    public static string ReverseString(string str)
    //    {
    //        char[] charArray = str.ToCharArray();  // Convert string to char array
    //        Array.Reverse(charArray);              // Reverse the char array
    //        return new string(charArray);          // Convert char array back to string
    //    }
    //}


    //----------------------------------------Assignment 5------------------------------------------------
    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        Console.WriteLine("Enter a string: ");
    //        string input = Console.ReadLine();

    //        int vowels = 0;
    //        int consonants = 0;
    //        int specialCharacters = 0;

    //        foreach (char c in input)
    //        {
    //            if (IsVowel(c))
    //            {
    //                vowels++;
    //            }
    //            else if (char.IsLetter(c))
    //            {
    //                consonants++;
    //            }
    //            else if (!char.IsWhiteSpace(c))
    //            {
    //                specialCharacters++;
    //            }
    //        }

    //        Console.WriteLine($"Vowels: {vowels}");
    //        Console.WriteLine($"Consonants: {consonants}");
    //        Console.WriteLine($"Special Characters: {specialCharacters}");
    //        Console.ReadLine();
    //    }

    //    public static bool IsVowel(char c)
    //    {
    //        // Convert character to lowercase for case-insensitive comparison
    //        c = char.ToLower(c);

    //        // Check if character is a vowel
    //        return (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u');
    //    }
    //}


    //-----------------------------------------Assignment 4------------------------------------------------------------

    //Median,Mode,Highest,Second Highest,Duplicates
    //class ArrayCalculations
    //{
    //    static void Main(string[] args)
    //    {
    //        int[] array = { 4, 1, 2, 2, 5, 3, 5, 4, 6 };

    //        Console.Write("Array: ");
    //        for (int i = 0; i < array.Length; i++)
    //        {
    //            Console.Write(array[i]);
    //            if (i < array.Length - 1) // Avoid adding comma after the last element
    //                Console.Write(", ");
    //        }
    //        Console.WriteLine();
    //        Console.WriteLine($"Median: {FindMedian(array)}");
    //        Console.WriteLine($"Mode: {FindMode(array)}");
    //        Console.WriteLine($"Highest: {FindHighest(array)}");
    //        Console.WriteLine($"Second Highest: {FindSecondHighest(array)}");
    //        Console.WriteLine($"Duplicate Elements: {string.Join(", ", FindDuplicates(array))}");
    //        Console.ReadLine();
    //    }

    //    // Method to find the median
    //    static double FindMedian(int[] arr)
    //    {
    //        Array.Sort(arr);
    //        int n = arr.Length;
    //        if (n % 2 == 0)
    //            return (arr[n / 2 - 1] + arr[n / 2]) / 2.0; // Average of the middle two elements
    //        return arr[n / 2]; // Middle element for odd length
    //    }

    //    // Method to find the mode
    //    static int FindMode(int[] arr)
    //    {
    //        Array.Sort(arr);
    //        int mode = arr[0], maxCount = 1, currentCount = 1;

    //        for (int i = 1; i < arr.Length; i++)
    //        {
    //            if (arr[i] == arr[i - 1])
    //            {
    //                currentCount++;
    //            }
    //            else
    //            {
    //                if (currentCount > maxCount)
    //                {
    //                    maxCount = currentCount;
    //                    mode = arr[i - 1];
    //                }
    //                currentCount = 1; // Reset count
    //            }
    //        }
    //        // Check last counted value
    //        if (currentCount > maxCount)
    //            mode = arr[arr.Length - 1];

    //        return mode;
    //    }

    //    // Method to find the highest value
    //    static int FindHighest(int[] arr)
    //    {
    //        int highest = arr[0];
    //        foreach (var num in arr)
    //        {
    //            if (num > highest)
    //                highest = num;
    //        }
    //        return highest;
    //    }

    //    // Method to find the second highest value
    //    static int FindSecondHighest(int[] arr)
    //    {
    //        int highest = FindHighest(arr);
    //        int secondHighest = int.MinValue;
    //        foreach (var num in arr)
    //        {
    //            if (num > secondHighest && num < highest)
    //                secondHighest = num;
    //        }
    //        return secondHighest;
    //    }

    //    // Method to find duplicate elements
    //    static int[] FindDuplicates(int[] arr)
    //    {
    //        int[] duplicates = new int[arr.Length];
    //        int count = 0;

    //        for (int i = 0; i < arr.Length; i++)
    //        {
    //            for (int j = i + 1; j < arr.Length; j++)
    //            {
    //                if (arr[i] == arr[j])
    //                {
    //                    // Check if it's already in the duplicates array
    //                    bool isDuplicate = false;
    //                    for (int k = 0; k < count; k++)
    //                    {
    //                        if (duplicates[k] == arr[i])
    //                        {
    //                            isDuplicate = true;
    //                            break;
    //                        }
    //                    }
    //                    if (!isDuplicate)
    //                    {
    //                        duplicates[count++] = arr[i];
    //                    }
    //                    break; // No need to check further for this element
    //                }
    //            }
    //        }

    //        Array.Resize(ref duplicates, count); // Resize to the number of duplicates found
    //        return duplicates;
    //    }
    //}

    //---------------------------------------------------Assignment 3------------------------------------------------------

    //Linear Search
    //class LinearSearchExample
    //{
    //    static void Main(string[] args)
    //    {
    //        int[] array = { 5, 2, 9, 1, 3 };
    //        int target = 3;
    //        int index = LinearSearch(array, target);

    //        if (index != -1)
    //        {
    //            Console.WriteLine($" {target} found at index {index}");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Element not found");
    //        }
    //        Console.ReadLine();
    //    }

    //    static int LinearSearch(int[] arr, int target)
    //    {
    //        for (int i = 0; i < arr.Length; i++)
    //        {
    //            if (arr[i] == target)
    //                return i; // Return the index if found
    //        }
    //        return -1; // Not found
    //    }
    //}

    //Binary Search
    //class BinarySearchExample
    //{
    //    static void Main(string[] args)
    //    {
    //        int[] array = { 1, 2, 3, 5, 9 }; // Sorted array
    //        int target = 3;
    //        int index = BinarySearch(array, target);

    //        if (index != -1)
    //        {
    //            Console.WriteLine($"Element {target} found at index {index}");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Element not found.");
    //        }
    //        Console.ReadLine();
    //    }

    //    static int BinarySearch(int[] arr, int target)
    //    {
    //        int left = 0;
    //        int right = arr.Length - 1;

    //        while (left <= right)
    //        {
    //            int mid = (left + right) / 2; // Middle index

    //            if (arr[mid] == target)
    //                return mid; // Found
    //            if (arr[mid] < target)
    //                left = mid + 1; // Search right half
    //            else
    //                right = mid - 1; // Search left half
    //        }

    //        return -1; // Not found
    //    }
    //}


    // ----------------------------------------------Assignment 2----------------------------------------------------------

    //Bubble Sort
    //public class SimpleBubbleSort
    //{
    //    static void Main(string[] args)
    //    {
    //        int[] array = { 5, 1, 4, 2, 8 };

    //        // Bubble Sort
    //        for (int i = 0; i < array.Length - 1; i++)
    //        {
    //            for (int j = 0; j < array.Length - i - 1; j++)
    //            {
    //                if (array[j] > array[j + 1])
    //                {
    //                    // Swap elements
    //                    (array[j], array[j + 1]) = (array[j + 1], array[j]);
    //                }
    //            }
    //        }
    //        Console.WriteLine("Bubble Sorted Array:");
    //foreach (int element in array)
    //        {
    //            Console.Write(element + " ");
    //        }
    //        Console.ReadLine();
    //    }
    //}


    //Insertion Sort
    //public class SimpleInsertionSort
    //{
    //    static void Main(string[] args)
    //    {
    //        int[] array = { 9, 11, 10, 5, 6 };

    //        // Insertion Sort
    //        for (int i = 1; i < array.Length; i++)
    //        {
    //            int key = array[i];
    //            int j = i - 1;

    //            while (j >= 0 && array[j] > key)
    //            {
    //                array[j + 1] = array[j];
    //                j--;
    //            }
    //            array[j + 1] = key;
    //        }

    //        // Print sorted array
    //        Console.WriteLine("Insertion Sorted Array:");
    //        foreach (int element in array)
    //        {
    //            Console.Write(element + " ");
    //        }
    //        Console.ReadLine();
    //    }
    //}


    // -------------------------------//Assignment 1---------------------------------------------------------------

    //Assignment 1
    //Matrix Addition
    //class MatrixAddition
    //{
    //    static void Main(string[] args)
    //    {
    //        int rows = 2;
    //        int cols = 2;
    //        int[,] matrixA = { { 1, 2 }, { 3, 4 } };
    //        int[,] matrixB = { { 5, 6 }, { 7, 8 } };


    //        int[,] result = new int[rows, cols];
    //        for (int i = 0; i < rows; i++)
    //        {
    //            for (int j = 0; j < cols; j++)
    //            {
    //                result[i, j] = matrixA[i, j] + matrixB[i, j];
    //            }
    //        }
    //        Console.WriteLine("Result of matrix addition");
    //        for (int i = 0; i < rows; i++)
    //        {
    //            for (int j = 0; j < cols; j++)
    //            {
    //                Console.Write(result[i, j] + "\t ");
    //            }
    //            Console.WriteLine();
    //        }
    //        Console.ReadLine();
    //    }
    //}


    //Matrix Multiplication
    //public class MatrixMultiplication
    //{
    //    static void Main(string[] args)
    //    {

    //        int rowsA = 2; int rowsB = 2; int colsA = 2; int colsB = 2;
    //        int[,] matrixA = { { 1, 2 }, { 3, 4 } };
    //        int[,] matrixB = { { 5, 6 }, { 7, 8 } };

    //        if (colsA != rowsB)
    //        {
    //            Console.WriteLine("Multiplication is not possible");
    //            return;
    //        }
    //        int[,] result = new int[rowsA, colsB];
    //        for (int i = 0; i < rowsA; i++)
    //        {
    //            for (int j = 0; j < colsB; j++)
    //            {
    //                result[i, j] = 0;
    //                for (int k = 0; k < colsA; k++)
    //                {
    //                    result[i, j] += matrixA[i, k] * matrixB[k, j];
    //                }
    //            }
    //        }
    //        Console.WriteLine("Result of multiplication");
    //        for (int i = 0; i < rowsA; i++)
    //        {
    //            for (int j = 0; j < colsB; j++)
    //            {
    //                Console.Write(result[i, j] + "\t");
    //            }
    //            Console.WriteLine();
    //        }
    //        Console.ReadLine();
    //    }
    //}

    //Transpose Matrix
    //public class TransposeMatrix
    //{
    //    static void Main(string[] args)
    //    {
    //        int rows = 2;
    //        int cols = 3;
    //        int[,] matrixA = { { 1, 2,3 }, {  4,5,6 } };
    //        Console.WriteLine("matrixA:");
    //        for (int i = 0; i < rows; i++)
    //        {
    //            for (int j = 0; j < cols; j++)
    //            {
    //                Console.Write(matrixA[i, j] + "\t");
    //            }
    //            Console.WriteLine();
    //        }
    //        int[,] transposematrix = new int[cols, rows];
    //        for (int i = 0; i < rows; i++)
    //        {
    //            for (int j = 0; j < cols; j++)
    //            {
    //                transposematrix[j, i] = matrixA[i, j];
    //            }
    //        }
    //        Console.WriteLine("Transpose matrix:");
    //        for (int i = 0; i < cols; i++)
    //        {
    //            for (int j = 0; j < rows; j++)
    //            {
    //                Console.Write(transposematrix[i, j] + "\t");
    //            }
    //            Console.WriteLine();
    //        }
    //        Console.ReadLine();
    //    }
    //}

}



