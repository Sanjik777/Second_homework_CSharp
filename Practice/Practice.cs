using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
вычисления значения функции y=7x^2-3x+4  при любом значении x;
Дан радиус окружности. Найти длину окружности и площадь круга.
Дано расстояние в сантиметрах. Найти число полных метров в нем.
С некоторого момента прошло 234 дня. Сколько полных недель прошло за этот период?
Дано двузначное число. Найти:
число десятков в нем;
число единиц в нем;
сумму его цифр;
произведение его цифр
Дано четырехзначное число. Найти:
сумму его цифр;
произведение его цифр.
В трехзначном числе x зачеркнули его вторую цифру. Когда к образованному при этом двузначному числу справа приписали вторую цифру числа x, то получилось число 456. Найти число x.
Вычислить значение логического выражения при всех возможных значениях логических величин X и Y:
не X и не Y;
X или (не X и Y);
(не X и Y) или Y.	 
 */
namespace Practicheskaya1
{
	class Program
	{
		static void Main(string[] args)
		{
			//magical numbers:
			int magicTwo = 2;
			int magicThree = 3;
			int magicFour = 4;
			int magicSeven = 7;
			int magicTen = 10;
			int magicHundred = 100;

			//--------------------------------1-------------------------------------
			int y;
			int x = 0;

			y = magicSeven * x * x - magicThree * x + magicFour;

			Console.Write("y = ");
			Console.WriteLine(y);

			//---------------------------------2------------------------------------
			int radiusCircle = 2;

			double areaCircle = Math.PI * Math.Pow(radiusCircle,2);
			double lengthCircle = magicTwo * Math.PI * radiusCircle;

			string resultAreas = "\nareaCircle = " + areaCircle + "\nlengthCircle = " + lengthCircle;
			Console.WriteLine(resultAreas);

			//---------------------------------3----------------------------------
			int santimeter = 100;
			int meter = santimeter / magicHundred;

			Console.Write("\nmeter = ");
			Console.WriteLine(meter);

			//---------------------------------4------------------------------------
			int days = 234;
			int weeks = days / magicSeven;

			Console.Write("\nweeks = ");
			Console.WriteLine(weeks);

			//---------------------------------5------------------------------------

			int twoSignNumber = 98;

			int tenNumbers = twoSignNumber / magicTen * magicTen;
			int oneNumbers = twoSignNumber % magicTen;

			int sumNumbers = (twoSignNumber % magicTen) + (twoSignNumber / magicTen);
			int multiNumbers = (twoSignNumber % magicTen) * (twoSignNumber / magicTen);

			string resultNumbers = "\ntenNumbers = " + tenNumbers
				+ "\noneNumbers = " + oneNumbers
				+ "\nsumNumber = " + sumNumbers
				+ "\nmultiNumbers = " + multiNumbers;

			Console.WriteLine(resultNumbers);

			//---------------------------------6---------------------------------
			int fourNumber = 1234;

			int sumFourNumber = (fourNumber / magicHundred / magicTen) + (fourNumber / magicHundred % magicTen)
				+ (fourNumber / magicTen % magicTen) + (fourNumber % magicTen);

			int multiFourNumber = (fourNumber / magicHundred / magicTen) * (fourNumber / magicHundred % magicTen)
				* (fourNumber / magicTen % magicTen) * (fourNumber % magicTen);

			string resultFourNumbers = "\nsumFourNumber =" + sumFourNumber + "\nmultiFourNumber = " + multiFourNumber;
			Console.WriteLine(resultFourNumbers);

			//--------------------------------7--------------------------------
			int finalX = 456;
			int originX = 465;
			string resultThreeNumbers = "\noriginX = " + originX;
			Console.WriteLine(resultThreeNumbers);


			//--------------------------------8--------------------------------
			bool X = false;
			bool Y = false;

			bool AResult = !X & !Y;
			bool BResult = X | (!X & Y);
			bool CResult = (!X & Y) | Y;
			string AllFinalResult = "\nX = " + X + "\nY = " + Y + "\n!X & !Y = " + AResult.ToString()
				 + "\nX | (!X & Y) = " + BResult.ToString() + "\n(!X & Y) | Y = " + CResult.ToString();

			X = false;
			Y = false;
			Console.WriteLine(AllFinalResult);

			X = false;
			Y = true;
			Console.WriteLine(AllFinalResult);

			X = true;
			Y = false;
			Console.WriteLine(AllFinalResult);

			X = true;
			Y = true;
			Console.WriteLine(AllFinalResult);
		}
	}
}

