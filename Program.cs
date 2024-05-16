// See https://aka.ms/new-console-template for more information
//int a = 50;
//int b = 20;
//int netice = a + b;
//Console.WriteLine(netice);:TOPLAMA;
//int a = 50;
//int b = 20;
//int netice = a - b;
//Console.WriteLine(netice);:CIXMA;
//int a = 50;
//int b = 50;
//int vurma = a * b;
//Console.WriteLine(vurma);:VURMA
//int a = 100;
//int b = 25;
//int bolme = a / b;
//Console.WriteLine(bolme);:Bolme
//string name = "eldar";
//Console.WriteLine(name);:Adlarimizi ekrana cixartma.
//Console.WriteLine("first number");
//int first=int.Parse(Console.ReadLine());
//Console.WriteLine("second number");
//int second=int.Parse(Console.ReadLine());
//Console.WriteLine("third number");
//int third=int.Parse(Console.ReadLine());
//if (first>=second && first >= third)
//{
//    Console.WriteLine("first number is the biggest:" + first);


//}else if (second>=first &&  second >= third)
//{
//    Console.WriteLine("second number is the biggest:"+second);

//}
//else
//{

//    Console.WriteLine("third number is the biggest:" + third);


Console.WriteLine("1.show name");
Console.WriteLine("2.show surname");
Console.WriteLine("3.show age");
int choice=int.Parse(Console.ReadLine());
switch (choice)
{
	case 1:
		Console.WriteLine("please enter your name");
		string name=Console.ReadLine();
		Console.WriteLine($"welcome{name}.Welcome to our wibsite");
		break;
		case 2:
		Console.WriteLine("please enter your surname");
		string surname=Console.ReadLine();
		Console.WriteLine($"Welcome{surname}welcome foundation");
		break ;
		case 3:
		Console.WriteLine("please enter your born year");
		int age=int.Parse(Console.ReadLine());
		int year = 2024 - age;
		Console.WriteLine($"you are{year}years old");
		break;

}