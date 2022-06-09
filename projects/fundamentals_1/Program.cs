// See https://aka.ms/new-console-template for more information

//count 1-255
// for (int i = 1; i <= 255; i++) {
//     Console.WriteLine(i);
//     if ( i == 255 ) {
//         Console.WriteLine("Counted to 255!");
//     }
// }
//Count 1-255 while loop
// int i = 1;
// while (i <= 255) {
//     Console.WriteLine(i);
//     i++;
// }



//loop from 1 to 100 print numbers that are divisable by 3 or 5 but not both

//for loop
// for (int i = 1; i <= 100; i++) {
// //condition 1
//     if (i % 3 == 0 && i % 5 != 0) {
//         Console.WriteLine(i);
//     }
// //condition 2
//     if (i % 5 == 0 && i % 3 != 0) {
//         Console.WriteLine(i);
//     }
// }
// int i = 1;
// while(i <= 100){
//     if (i % 3 == 0 && i % 5 != 0) {
//         Console.WriteLine(i);
//     }
//     if (i % 5 == 0 && i % 3 != 0) {
//         Console.WriteLine(i);
//     }
//     i++;
// }



// // loop from 1 to 100 print fis buzz fizzbuzz for the multiples
// // for loop
// for (int i = 1; i <= 100; i++) {
// //condition 1
//     if (i % 3 == 0 && i % 5 != 0) {
//         Console.WriteLine("Fizz");
//     }
// //condition 2
//     if (i % 5 == 0 && i % 3 != 0) {
//         Console.WriteLine("Buzz");
//     }
// // both conditions
//     if (i % 3 == 0 && i % 5 == 0){
//         Console.WriteLine("FizzBuzz");
//     }
// }

// for (int i = 1; i <= 100; i++) {
// //condition 1
//     if (i % 3 == 0 && i % 5 != 0) {
//         Console.WriteLine("Fizz");
//     }
// //condition 2
//     if (i % 5 == 0 && i % 3 != 0) {
//         Console.WriteLine("Buzz");
//     }
// // both conditions
//     if (i % 3 == 0 && i % 5 == 0){
//         Console.WriteLine("FizzBuzz");
//     }
// }
// While loop for above code 

int i = 1;
while (i <= 100) {
//condition 1
    if (i % 3 == 0 && i % 5 != 0) {
        Console.WriteLine("Fizz");
    }
//condition 2
    if (i % 5 == 0 && i % 3 != 0) {
        Console.WriteLine("Buzz");
    }
// both conditions
    if (i % 3 == 0 && i % 5 == 0){
        Console.WriteLine("FizzBuzz");
    }
    i++;
}








