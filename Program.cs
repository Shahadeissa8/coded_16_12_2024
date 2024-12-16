// See https://aka.ms/new-console-template for more information
//Fatima and Shahad's work 16/12/2024
//using System.Transactions;

using System.ComponentModel.Design;

Console.WriteLine("Hello, World!");
//string v = "yello";
//Console.Write(v);
//string l, k=["int","bro"];
//Console.Write(l);
//int o = 8, p = 9;
//Console.Write(o, p);
int num1, num2 , sum;
num1 = 5;
num2 = 7;
sum = num1 + num2;
string FirstName;
string LastName;
FirstName = "fatma";
LastName = "alheees";
Console.WriteLine("Dr. " + FirstName + " " + LastName + ", Your number is: " + (num1 + num2) +" .");
Console.WriteLine("Dr. " + FirstName + " " + LastName + ", Your number is: " + sum +" .");

string N1, N2, N3;
N1 = "3";
N2 = "4";
N3 = "5";
string t=N1+ N2+N3;
int Total = (Convert.ToInt32(N1) + Convert.ToInt32(N2) + Convert.ToInt32(N3));
//string Total = (Convert.ToInt32(N1) + Convert.ToInt32(N2) + Convert.ToInt32(N3)).ToString(); what it does is add them and print as a string
//string Total = "" + Convert.ToInt32(N1) + Convert.ToInt32(N2) + Convert.ToInt32(N3); same as previous line
Console.WriteLine(t);
Console.WriteLine(Total);

Console.WriteLine("===========================");


//Console.WriteLine("enter your full name: ");
//string FullName = Console.ReadLine();
//Console.WriteLine("enter your city: ");
//string City = Console.ReadLine();
//// difference between write and write line is that the former only writes in the same line the latter presses enter
//Console.WriteLine("Full nane:" + FullName+ " your city is: " +  City);

Console.WriteLine("===========================");


//Console.WriteLine("enter the first number: ");
//string number1 = Console.ReadLine();
//Console.WriteLine("enter the second number: ");
//string number2 = Console.ReadLine(); // we cant take int from user it has to be a string and then we convert it
// int count = (Convert.ToInt32(number1) + Convert.ToInt32(number2));
//Console.WriteLine(count);
//Console.WriteLine("===========================");

//another way to do it BEST SOLUTION
//Console.WriteLine("enter m1: ");
//int m1 = Convert.ToInt32 (Console.ReadLine());
//Console.WriteLine("enter m2: ");
//int m2 = Convert.ToInt32 (Console.ReadLine());
//int totMark = m1 + m2;
//Console.WriteLine("Total mark " + totMark);






Console.WriteLine("===========================");




// ctrl + space to change the words to caps in the beginning

Console.WriteLine("enter Avg");
double avg = Convert.ToDouble(Console.ReadLine());
//draft
//if  (avg > 100 || avg < 0)
//{
//    Console.WriteLine("Out Of Range");
//}
//else if (avg >= 50)
//{
//    Console.WriteLine("Pass");
//}
//else 
//{
//    Console.WriteLine("Fail");
//}
if  (avg >= 50  && avg <= 100)
{
    Console.WriteLine("Pass");
}
else if (avg < 50) 
// another solution: else if (avg < 50 && avg >=0)
{
    Console.WriteLine("Fail");
    Console.WriteLine("test");

}
else 
{
    Console.WriteLine("Out Of Range");
}







