// Create an array to hold integer values 0 through 9
// Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
// Create an array of length 10 that alternates between true and false values, starting with true

// int[] array1 =  {0,1,2,3,4,5,6,7,8,9};
// string[] array2 = new string[] {"tim", "Martin", "Nikki", "Sara"};
// bool[] array3 = {true, false, true, false, true, false, true, false, true, false};


// Create a list of ice cream flavors that holds at least 5 different flavors (feel free to add more than 5!)
// Output the length of this list after building it
// Output the third flavor in the list, then remove this value
// Output the new length of the list (It should just be one fewer!)

// This is the list from the assignment that has you change some of the flavors
// List<string> IceCreamFlavors = new List<string>();
// IceCreamFlavors.Add("Blue Moon");
// IceCreamFlavors.Add("Reece Cup");
// IceCreamFlavors.Add("Chocolate");
// IceCreamFlavors.Add("Vanilla");
// IceCreamFlavors.Add("Oreo");
// IceCreamFlavors.Add("Strawberry");
// IceCreamFlavors.Add("Neapolitan");
// IceCreamFlavors.Add("Banana");
// IceCreamFlavors.Add("Sherbert");
// IceCreamFlavors.Add("Rocky Road");
// Console.WriteLine(IceCreamFlavors.Count);
// Console.WriteLine(IceCreamFlavors[2]);
// IceCreamFlavors.Remove(IceCreamFlavors[2]);
// Console.WriteLine(IceCreamFlavors.Count);





// I made this list longer
string[] People = {"Tim", "Martin", "Nikki", "Sara", "Logan", "Dad", "Jeff"};

// I changed the list back to normal to make the last assignment easier for me to understand
List<string> IceCreamFlavors = new List<string>();
IceCreamFlavors.Add("Blue Moon");
IceCreamFlavors.Add("Reece Cup");
IceCreamFlavors.Add("Chocolate");
IceCreamFlavors.Add("Vanilla");
IceCreamFlavors.Add("Oreo");
IceCreamFlavors.Add("Strawberry");
IceCreamFlavors.Add("Neapolitan");
IceCreamFlavors.Add("Banana");
IceCreamFlavors.Add("Sherbert");
IceCreamFlavors.Add("Rocky Road");

// Create a dictionary that will store both string keys as well as string values
// Add key/value pairs to this dictionary where:
// each key is a name from your names array
// each value is a randomly elected flavor from your flavors list.
// Loop through the dictionary and print out each user's name and their associated ice cream flavor
Dictionary<string,string> FavoriteIceCream = new Dictionary<string, string>();
foreach (string Person in People) {
    Random rnd = new Random();
    int num = rnd.Next(9);
    string FavCream = IceCreamFlavors[num];
    FavoriteIceCream.Add(Person, FavCream);
}
foreach (KeyValuePair<string, string> entry in FavoriteIceCream) {
    Console.WriteLine(entry.Key + "-" + entry.Value);
} 





