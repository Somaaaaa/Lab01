using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1. feladat
            // Console.WriteLine("Hello World!");
            #endregion
            #region 2. feladat
            /*
            Console.Clear();

            Console.WindowHeight = 200;
            Console.WindowWidth = 200;

            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.SetCursorPosition(5,5);
            Console.CursorVisible = false;
            */
            #endregion
            #region 3. feladat
            /*
            string name = Console.ReadLine();
            Console.WriteLine($"Szia {name}!");
            */
            #endregion
            #region 4. feladat
            /*
            int birthYear = int.Parse(Console.ReadLine());
            birthYear = 2023 - birthYear;
            Console.WriteLine($"{birthYear} éves");
            Console.WriteLine($"{birthYear+1} éves lesz jövőre");
            */
            #endregion
            #region 5. feladat
            /*
            int height = int.Parse(Console.ReadLine());
            int weight = int.Parse(Console.ReadLine());
            int BMI = weight / (weight * weight);
            Console.WriteLine(BMI);
            */
            #endregion
            #region 6. feladat
            /*
            int number = int.Parse(Console.ReadLine());
            int seconds = number % 60;
            int minutes = number / 60;
            Console.WriteLine($"{minutes}:{seconds}");
            */
            #endregion
            #region 7. feladat
            /*
            string[] answers = Console.ReadLine().Split(' ');
            string address1 = answers[0];
            string address2 = answers[1];
            string address3 = answers[2];

            answers = Console.ReadLine().Split(' ');
            double distance1 = int.Parse(answers[0]);
            double distance2 = int.Parse(answers[1]);
            double distance3 = int.Parse(answers[2]);

            int speed = int.Parse(Console.ReadLine());

            double time1 = distance1 / speed;
            double time2 = distance2 / speed;
            double time3 = distance3 / speed;

            double averageTime = (time1 + time2 + time3) / 3;

            Console.WriteLine($"A {address1} címre, ami {distance1} km távolságra van {time1} óra alatt ér el");
            Console.WriteLine($"A {address2} címre, ami {distance2} km távolságra van {time2} óra alatt ér el");
            Console.WriteLine($"A {address3} címre, ami {distance3} km távolságra van {time3} óra alatt ér el");
            Console.WriteLine($" Az átlagos kiszállítás: {averageTime}");
            */
            #endregion
            #region 8. feladat
            /*
            string password = Console.ReadLine();
            int attempts = 0;
            while(attempts != 3 && password != Console.ReadLine())
            {
                Console.WriteLine("rossz jelszó");
                attempts++;
            }
            if(attempts < 3) {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("A jelszó helyes volt");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("A jelszó helytelen volt 3x egymás után");
            }
            */
            #endregion
            #region 9. feladat
            /*
            string[] answer = Console.ReadLine().Split(' ');
            int number1 = int.Parse(answer[0]);
            int number2 = int.Parse(answer[1]);
            
            string type = Console.ReadLine();
            if( type == "+") Console.WriteLine(number1 + number2);
            else if ( type == "-") Console.WriteLine(number1 - number2);
            else if ( type == "*") Console.WriteLine(number1 * number2);
            else if ( type == "/") Console.WriteLine(number1 / number2);
            */
            #endregion
            Console.ReadLine();
        }
    }
}
