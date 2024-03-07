// array -  collection of fixed sets of values
// and you have a dynamic array


//fixed array
int[] intArr = new int[10]; //reference type & it will be store in the heap
string[] stringArr = new string[10];
object[] objectArr = new object[10];

intArr[0] = 1;//manipulating the spot | zero based index
intArr[1] = 2;//manipulating the spot
intArr[2] = 3;//manipulating  | 

//Console.WriteLine(intArr[2]);

//dynamic array
int[] dynamicArray  =  new int[] { 1,4,6, 2, 3 }; // dynamic array
Array.Sort(dynamicArray);
Console.WriteLine(dynamicArray[0]);
Console.WriteLine(dynamicArray.Average());

//dynamic string array
string[] stringDynamicArr = new string[] { "Jason", "Paclibar", "Evaristo" };
Array.Sort(stringDynamicArr);
Console.WriteLine("My first name is " + stringDynamicArr[0]);