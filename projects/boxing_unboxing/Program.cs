

class TestUnboxing {
    static void Main(){


        List<object> DifferentStuff = new List<object>();
        DifferentStuff.Add(7);
        DifferentStuff.Add(28);
        DifferentStuff.Add(-1);
        DifferentStuff.Add(true);
        DifferentStuff.Add("chair");
        int sum = 0;
        foreach (var Stuff in DifferentStuff) {
            if (Stuff is int) {
                sum += (int)Stuff;
            }
        }
        Console.WriteLine(sum);
        
    }
}



                // Console.WriteLine(Stuff);
                // Console.WriteLine(Stuff.GetType());
    // if (Stuff is int) {
    //     Convert.ToInt32(Stuff);
// object a = 5;
// int b = Convert.ToInt16(a);
// Console.WriteLine(b.GetType());
//  List<int> intStuff = new List<int>();
//         foreach (int intHere in intStuff);
//         intStuff.Add(intStuff);