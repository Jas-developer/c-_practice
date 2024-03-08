﻿// array -  collection of fixed sets of values
// and you have a dynamic array


//fixed array
//int[] intArr = new int[10]; //reference type & it will be store in the heap
/*string[] stringArr = new string[10];
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
Console.WriteLine("My first name is " + stringDynamicArr[0]);*/


/*STRINGS IN DEPTH*/

using System.Text;

string testString = "test"; //string is a reference type

//char has a single 
string testStringStatic = "testStatic";

//IMPORTANT 
int testInt = 0;

//string in c# are immutable(read only) - Garbage collector
//Threading - Race Conditions
string s1 = "hello";
string s2 = s1;
s1 += "Word";


Console.WriteLine(s2);

// string interpolation + composite formatting 
string firstName = "Teddy";
string lastName = "Smith";

Console.WriteLine($"My name is {firstName} {lastName}");
Console.WriteLine("My name is {1} {0}", lastName, firstName);


//String builder
//if you are performing thousands of iterations: Example: for loop

var sb = new StringBuilder();

var testStringBuilder = sb.AppendLine("dwdd");
Console.WriteLine(testStringBuilder.ToString());
