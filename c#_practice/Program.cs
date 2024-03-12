// For Loop In c#


// for ( initializer; condition; iterator)
//{
//   do some task over and over 
//
//}

for (int i = 0; i < 10; i++)
{
    string print = $"Value of {i}";
    Console.WriteLine(print);
}

//for each
//declare a list
var fibNumbers = new List<int> {0,1,1,2,3,5,8,13 };

foreach (int num in fibNumbers)
{
    string testEachNum = $"each num is {num}";
    Console.WriteLine(testEachNum);
}
//for looping the list

for (int i = 0; i < fibNumbers.Count; i++) {
    string forLooop = $"This num {i} came from foor loop";
    Console.WriteLine(forLooop);
}