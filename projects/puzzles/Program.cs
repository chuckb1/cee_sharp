

// static int  [] RandomArray() {
//     int[] MyArray = new int[10];

//     for ( int i = 1; i <= 10; i++) {
//         Random rand = new Random();
//         Console.WriteLine(i);
        
        
//     }
// }

// RandomArray();

static int[] RandomNumber(){
    int x = 0;
    int y = 100;
    int[] MyArray = new int[10];
    for (int i = 0; i <= 9; i++) {
        Random rnd = new Random();
        int Number = rnd.Next(5,25);
        MyArray[i] = Number;
            if (MyArray[i] > x) {
                x = MyArray[i];
            }
            if (MyArray[i] < y){
                y = MyArray[i];
            }
        Console.WriteLine(Number);
    }
    Console.WriteLine("The low number is " + y);
    Console.WriteLine("The high number is " + x);
    return MyArray;
}
// RandomNumber();

// int[] MyArray = RandomNumber();
// foreach(int list2 in MyArray){
//     if (list2 > x) {
//         x = list2;
//     }
//     if (list2 < y){
//         y = list2;

static string TossCoin() {
    Console.WriteLine("Tossing a Coin");
    Random Flip = new Random();
    int Coin = Flip.Next(2);
    if (Coin == 1){
        Console.WriteLine("Heads");
        return "Heads";
    }
    else{
        Console.WriteLine("Tails");
        return "Heads";
    }
}
// TossCoin();

static void Names() {
    
    List<string> Names = new List<string>();
    Names.Add("Todd");
    Names.Add("Tiffany");
    Names.Add("Charlie");
    Names.Add("Geneva");
    Names.Add("Sydney");
    foreach (string name in Names){
        if (name.Length > 5){
        Console.WriteLine(name);
        }
    }
}
Names();
