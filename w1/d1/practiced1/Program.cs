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
Dictionary<string,string> profile = new Dictionary<string,string>();
//Almost all the methods that exists with Lists are the same with Dictionaries
profile.Add("Name", "Speros");
profile.Add("Language", "PHP");
profile.Add("Location", "Greece");
Console.WriteLine("Instructor Profile");
Console.WriteLine("Name - " + profile["Name"]);
Console.WriteLine("From - " + profile["Location"]);
Console.WriteLine("Favorite Language - " + profile["Language"]);


foreach (KeyValuePair<string,string> entry in profile)
{
    Console.WriteLine(entry.Key + " - " + entry.Value);
}

