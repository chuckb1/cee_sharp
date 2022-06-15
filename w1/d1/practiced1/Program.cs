// namespace HelloWorld
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("What is your name?");
//             var name = Console.ReadLine();
//             var currentDate = DateTime.Now;
//             Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
//             Console.Write($"{Environment.NewLine}Press any key to exit...");
//             Console.ReadKey(true);    
//             // Console.WriteLine("Hello World!");
//         }
//     }
// }

// Random rand = new Random();
// for(int val = 0; val < 10; val++)
// {
//     //Prints the next random value between 2 and 8
//     Console.WriteLine(rand.Next(2,8));
// }
// 

// int IntegerValue = 65;
// Console.WriteLine(IntegerValue);
// double DoubleValue = IntegerValue;
// Console.WriteLine(IntegerValue);


// object ActuallyString = "a string";
// string ExplicitString = ActuallyString as string;
 
// // THIS WON'T WORK!!
// object ActuallyInt = 256;
// int ExplicitInt = ActuallyInt as int;

// Random rand = new Random();
// for(int val = 0; val < 10; val++)
// {
//     //Prints the next random value between 2 and 8
//     Console.WriteLine(rand.Next(2,8));
// }

// C# program to generate random alphanumeric strings
using System;
  
class GFG{
  
public static void Main(string[] args)
{
    Random res = new Random();
  
    // String that contain both alphabets and numbers
    String str = "abcdefghijklmnopqrstuvwxyz0123456789";
    int size = 8;
  
    // Initializing the empty string
    String randomstring = "";
  
    for (int i = 0; i < size; i++)
    {
  
        // Selecting a index randomly
        int x = res.Next(str.Length);
  
        // Appending the character at the 
        // index to the random alphanumeric string.
        randomstring = randomstring + str[x];
    }
  
    Console.WriteLine("Random alphanumeric String:" + randomstring);
}
}