// See https://aka.ms/new-console-template for more information
Buffet b1 = new Buffet();
Ninja Goofy = new Ninja();


b1.Serve();


// Goofy.Eat(b1.Serve());
while (!Goofy.isFull){
    Goofy.Eat(b1.Serve());
    }
    Console.WriteLine("This Ninja is Full.");