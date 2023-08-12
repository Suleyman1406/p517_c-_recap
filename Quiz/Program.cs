//List<int> ints = new List<int>();
//ints.Add(12);

//using Quiz;

//CustomList<string> animals = new();
//animals.Add("meymun");
//animals.Add("zurafe");


//animals.Print();

//Dictionary<int, string> keyValuePairs = new();

//keyValuePairs.Add(1, "asd");
//keyValuePairs.Add(3, "asd");

//string a;
//keyValuePairs.TryGetValue(2, out a);

//Console.WriteLine(a);


//using Quiz;

//CustomDictinoary<string, int> dictinoary = new();
//dictinoary.Add("key", 12);
//dictinoary.Add("pass",18);

//int result;

//dictinoary.TryGetValue("pass", out result);
//Console.WriteLine(result);


//dictinoary.RemoveItem("pass");


//dictinoary.TryGetValue("pass", out result);
//Console.WriteLine(result);

//SumOfNumbers(new List<int>() { 3,4,5}, IsEven);

//SumOfNumbers(new List<int>() { 3,4,5}, at => at % 2 == 0 );




//CheckNumber check = IsEven;
//check.Invoke(13);

//IsEven(12);


//CheckNumber check = n => n > 2;

//bool IsEven(int number)
//{
//    return number % 2 == 0;
//}

//void SumOfNumbers(List<int> numbers, CheckNumber func)
//{
//    int sum = 0;
//    foreach (int num in numbers)
//    {
//        if (func(num))
//        {
//            sum += num;
//        }
//    }
//    Console.WriteLine(sum);
//}

//delegate bool CheckNumber(int number);



//PrintSum print = PrintAny;



//int PrintAny(int c, int d)
//{
//    return c + d;
//}



//PrintSum print = (a, b) => a + b;

//Console.WriteLine( print(1,2));

//delegate int PrintSum(int a, int b);

//PrintYourName print = ()=>"kamil";

//Console.WriteLine(print());

//delegate string PrintYourName();

//PrintText print = (name) =>
//{
//    string text = "hello";
//    text += " " + name;
//    Console.WriteLine(text);
//    return text;
//};

//print("Aynur");

//delegate string PrintText(string name);

//List<string> strings = new() { "alca", "nar", "heyva", "alma" };
//List<int> numbers = new() { 1, 2, 3, 4 };
//Console.WriteLine( strings.Exists((m) => m == "alcas"));

//SumOfNumbers(numbers, (num) => num % 2 == 0);

//bool IsEven(int num)
//{
//    return num % 2 == 0;
//}

//void SumOfNumbers(List<int> nums, Predicate<int> function)
//{
//    int sum = 0;
//    foreach(var num in nums)
//    {
//        if (function(num))
//        {
//            sum += num;

//        }
//    }
//    Console.WriteLine(sum);
//}


DoSomethingInteresting(12, (at,it,ot) => {
    Console.WriteLine(
    at + it + ot);
});

//void PrintSum(int a, int b, int c)
//{
//    Console.WriteLine(a+b+c);
//}


void DoSomethingInteresting(int num, Action<int,int,int> action){
    action(num, num / 2, num / 4);
}
