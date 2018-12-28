using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
1.	Составить программу вывода на экран в одну строку трех любых чисел с двумя пробелами между ними.
2.	Вывести на экран числа 5, 10 и 21 одно под другим.
3.	Дано расстояние в сантиметрах. Найти число полных метров в нем.
4.	С некоторого момента прошло 234 дня. Сколько полных недель прошло за этот период?
5.	Дано двузначное число. Найти:
  a.	число десятков в нем;
  b.	число единиц в нем;
  c.	сумму его цифр;
  d.	произведение его цифр
6.	Вычислить значение логического выражения при следующих значениях логических
величин А, В и С: А = Истина, В = Ложь, С = Ложь:
  a.	А или В; 
  b.	А и В; 
  c.	В или С.
7.	Даны радиус круга и сторона квадрата. У какой фигуры площадь больше?
8.	Даны объемы и массы двух тел из разных материалов. Материал какого из тели меет большую плотность?
9.	 Известны сопротивления двух несоединенных друг с другом участков электрической цепи
и напряжение на каждом из них. По какому участку протекает меньший ток?
10.	Напечатать "столбиком":
  a.	все целые числа от 20 до 35;
  b.	квадраты всех целых чисел от 10 до b (значение b вводится с клавиатуры;b> 10);
  c.	третьи степени всех целых чисел от a до 50 (значение a вводится с клавиатуры; a< 50);
  d.	все целые числа от a до b (значения a и b вводятся с клавиатуры; b >a).
 */
namespace Second_Homework
{
	class Program
	{
		static void Main(string[] args)
		{
			//magic numbers:
			int one = 1,
				two = 2,
				three = 3,
				five = 5,
				seven = 7,
				ten = 10,
				twentyOne = 21,
				fifty = 50,
				hundred = 100;
			//-------------------------------------1-----------------------------------

			string firstTask = one + " " + two + " " + three;
			Console.WriteLine(firstTask);

			//-------------------------------------2-----------------------------------

			string secondTask = "\n" + five + "\n" + ten + "\n" + twentyOne;
			Console.WriteLine(secondTask);

			//-------------------------------------3-----------------------------------
			int santimeter = 53;
			double meter = (double)santimeter / hundred;
			string thirdTask = "\nmeter = " + meter;
			Console.WriteLine(thirdTask);

			//-------------------------------------4-----------------------------------
			int days = 234;
			int weeks = days / seven;
			string fourthTask = "\nweeks = " + weeks;
			Console.WriteLine(fourthTask);

			//-------------------------------------5-----------------------------------
			int twoSignNumber = 31;
			int oneNumbers = twoSignNumber % ten;
			int tenNumbers = twoSignNumber / ten;
			int sumNumbers = (twoSignNumber % ten) + (twoSignNumber / ten);
			int multNumbers = (twoSignNumber % ten) * (twoSignNumber / ten);
			string fifthTask = "\noneNumbers = " + oneNumbers
				+ "\ntenNumbers = " + tenNumbers + "\nsumNumbers = " + sumNumbers
				+ "\nmultNumbers = " + multNumbers;
			Console.WriteLine(fifthTask);

			//-------------------------------------6-----------------------------------
			bool A = true, B = false, C = false;
			bool AorB = A | B;
			bool AandB = A & B;
			bool BorC = B | C;
			string sixthTask = "\nA or B = " + AorB + "\nA and B = " + AandB
				+ "\nB or C = " + BorC;
			Console.WriteLine(sixthTask);

			//-------------------------------------7-----------------------------------
			double radiusCircle = 5;
			double sideSquare = 5;

			double areaCircle = Math.PI * Math.Pow(radiusCircle, 2);
			double areaSquare = Math.Pow(sideSquare, 2);

			if (areaSquare > areaCircle)
			{
				Console.WriteLine("\nArea of Circle = " + areaSquare + " bigger than Area of Square = " + areaCircle);
			}
			else
			{
				Console.WriteLine("\nArea of Circle = " + areaSquare + " lesser than Area of Square = " + areaCircle);
			}

			//-------------------------------------8-----------------------------------
			double volumeOne = 4,
				   massOne = 4,
				   volumeTwo = 5,
				   massTwo = 4;
			double densityOne = massOne / volumeOne,
				densityTwo = massTwo / volumeTwo;
			if (densityOne > densityTwo)
			{
				Console.WriteLine("\nFirst material density = " + densityOne
					+ " bigger then Second material density = " + densityTwo);
			}
			else
			{
				Console.WriteLine("\nFirst material density = " + densityOne
					+ " lesser then Second material density = " + densityTwo);
			}

			//-------------------------------------9-----------------------------------
			int firstResist = 3;
			int firstVoltage = 18;
			int firstAmper = firstVoltage / firstResist;

			int secondResist = 4;
			int secondVoltage = 4;
			int secondAmper = secondVoltage / secondResist;

			if (firstAmper > secondAmper)
			{
				Console.WriteLine("\nFirst current strength = " + firstAmper
					+ " bigger then Second current strength = " + secondAmper);
			}
			else
			{
				Console.WriteLine("\nFirst current strength = " + firstAmper
	                + " lesser then Second current strength = " + secondAmper);
			}

			//------------------------------------10-----------------------------------
			//a:
			Console.Write("\n");
			for (int i=20; i<=35; i++)
			{
				Console.Write( $"{i} ");
			}

			//b:
			Console.Write("\n\nInsert the number: ");
			string b = Console.ReadLine();
			int bToInt = int.Parse(b);
			if (bToInt > ten)
			{
				for (int i = ten; i <= bToInt; i++)
				{
					Console.Write($"{Math.Pow(i,2)} ");
				}
			}
			else { Console.WriteLine("Wrong number - b, b should be greater then 10!"); }

			//c:
			Console.Write("\n\nInsert the number: ");
			string a = Console.ReadLine();
			int aToInt = int.Parse(a);
			if (aToInt < fifty)
			{
				for (int i = aToInt; i <= fifty; i++)
				{
					Console.Write($"{Math.Pow(i, 3)} ");
				}
			}
			else { Console.WriteLine("Wrong number - a, a should be lesser then 50!"); }

			//d:
			Console.Write("\n\nInsert first number: ");
			a = Console.ReadLine();
			aToInt = int.Parse(a);

			Console.Write("\nInsert second number: ");
			b = Console.ReadLine();
			bToInt = int.Parse(b);

			if (aToInt < bToInt)
			{
				for (int i = aToInt; i <= bToInt; i++)
				{
					Console.Write($"{i} ");
				}
			}
			else { Console.WriteLine("Wrong number - a, a should be lesser then b!"); }
			Console.ReadKey();
		}
	}
}
