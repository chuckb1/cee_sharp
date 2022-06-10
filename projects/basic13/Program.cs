// 1.
static void PrintNumbers() {
    for (int i = 1; i < 256; i++){
    Console.WriteLine(i);
    }
}
// PrintNumbers();

// 2.
static void PrintOdds() {
    for ( int i = 1; i < 256; i++) {
        if (i % 2 != 0){
        Console.WriteLine(i);
        }
    }
}
// PrintOdds();

// 3.
static void PrintSum() {
    int x = 0;
    for ( int i = 0; i < 256; i++) {
    Console.WriteLine(i);
    x += i;
    Console.WriteLine(x);
    }
}
// PrintSum();

int[] NumArr1 = {3, 4, 5, 6};
int[] NumArr2 = {8, 3, 8, 9, 4, 1, 2, 10, 12, 7, 2};
int[] NumArr3 = {3, -5, 2, -7, 8, 10, -2, 6, -4};
int[] NumArr4 = {-3,-5,-7};
int[] NumArr5 = {-8, -9, -5, -3, -4};

// 4.
static void LoopArray(int[] MyArray) {
    for (int i = 0; i < MyArray.Length; i++) {
    Console.WriteLine(MyArray[i]);
    }
}
// LoopArray(NumArr1);
// LoopArray(NumArr2);
// LoopArray(NumArr3);

// 5.
static void FindMax(int[] MyArray) { 
    int x = MyArray[0];
    for (int i = 0; i < MyArray.Length; i++) {
//is our value at MyArray[i] larger than our current value of x
        if (MyArray[i] > x) {
            x = MyArray[i];
        }   
    }
    Console.WriteLine(x);
}
// FindMax(NumArr1);
// FindMax(NumArr2);
// FindMax(NumArr3);
// FindMax(NumArr4);
// FindMax(NumArr5);

// 6. 
static void GetAverage(int[] MyArray) { 
    int x = 0;
    for (int i = 0; i < MyArray.Length; i++) {
        x += MyArray[i];
    }
    int Average = x / MyArray.Length;
    Console.WriteLine(Average);    
}
// GetAverage(NumArr1);
// GetAverage(NumArr2);
// GetAverage(NumArr3);
// GetAverage(NumArr4);
// GetAverage(NumArr5);

// 7.
static List<int> OddArray(){
    List<int> arr1 = new List<int>();
    for (int i = 1; i <= 255; i++) {
        if (i % 2 != 0){
            arr1.Add(i);
        }
    }
    return arr1;
}

List<int> MyList = OddArray();
foreach(int list in MyList){
    System.Console.WriteLine(list);
}

