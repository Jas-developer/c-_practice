// array -  collection of fixed sets of values
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

/*using System.Text;

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
Console.WriteLine(testStringBuilder.ToString());*/



/*using System.Net.NetworkInformation;
using System.Text;
//heap are reference type
//DNS domain name server

Ping pingSender  = new Ping(); //classes are stored in the heap
PingOptions pingOptions = new PingOptions();


pingOptions.DontFragment = true;

string data = "Learn how to code";
byte[] buffer = Encoding.ASCII.GetBytes(data); //byte is bellow 255
int timeout = 120;
string address = "4.2.2.2";
PingReply reply = pingSender.Send(address,timeout, buffer,pingOptions); //reference type

if(reply.Status == IPStatus.Success)
{
    Console.WriteLine("Response: {0}", reply.Status.ToString());
    Console.WriteLine("RoundTrip: {0}", reply.RoundtripTime.ToString());
    Console.WriteLine("Time to live: {0}", reply.Options.Ttl.ToString());
    Console.WriteLine("Buffer size: {0}", reply.Buffer.Length.ToString());
}

*/




//when you are declaring a reference type you have to use a new


/*LIST IN C#*/


/*using Practice;

/*All object added will be on the list*/////you are putting it in a stack if it is small 

/*lst.Add(new Part { PartName = "HeadLight", PartId = 1 }); //adding properties to the object
lst.Add(new Part { PartName = "Bumper", PartId = 2 }); // adding properties to the object
lst.Add(new Part { PartName = "SideMirror", PartId = 1 }); // adding properties to the object
lst.Add(new Part { PartName = "Mugs", PartId = 2 }); // adding properties to the object

foreach (Part part in lst)
{
    Console.WriteLine(part.PartName.ToString().ToLower());
    Console.WriteLine(part.PartId.ToString().ToLower());
}

*/



//IF/ELSE CONDITIONAL STATEMENT

var test = 0;
var test3 = 3;

if(test == 0 && test3 == 3)
{
    Console.WriteLine("This part is executed");
}else
{
    Console.WriteLine("I dont know what you want");
}

//boolean else if statement

bool notEqual = 5 == 7;// will print false
Console.WriteLine(notEqual);
//will print true
bool isEqual = 5 != 3;//will print true
Console.WriteLine(isEqual);


bool greaterThan = 5 > 2; // true
bool lessThan = 5 < 2; //false

int num1 = 4;
int num2 = 5;

bool whichGreater = num1 > num2; // false

Console.WriteLine($"num1 is greaster than num2? {whichGreater}");

//greater than equal 
bool greaterThanOrEqual = 5 >= 5;//true
bool lessThanOrEqual = 5 <= 5; //true

string Greater = $" is 5 less than 5 or equal to 5 ? {lessThanOrEqual} the opposite of it is also {greaterThanOrEqual}";
Console.WriteLine(Greater);


//AND OR  OPERATOR
Console.WriteLine("AND OR Operator");

bool andAnd = 5 == 5 && 3 != 7; // this will evaluate to true

Console.WriteLine($"and or will result to {andAnd}");

Console.WriteLine("IF AND ELSE STATEMENT");

if(5 == num1)
{
    Console.WriteLine("true");
} else if ( 3 == num2 )
{
    Console.WriteLine("Else if true");
}else
{
    Console.WriteLine("Else true");
}

