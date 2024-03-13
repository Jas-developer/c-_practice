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
};


//we will gonna do it in array
int[] numbers = new int[] { 3, 2, 4, 5, 3, 5, 6 };
Console.WriteLine("BELOW ARE THE RESULT OF A FOR-LOOP ARRAY");
/*foreach(int num in numbers)
{
    string number = $"Array value {num}";
    Console.WriteLine(number);
}*/
for (int i = 0; i < numbers.Length; i++)
{
    string number = $"Array value: {numbers[i]}";
    Console.WriteLine(number);
}
