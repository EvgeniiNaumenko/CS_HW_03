using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Завдання 1
//Створіть додаток «Калькулятор» для переведення числа
//з однієї системи обчислення до іншої. Користувач, за допомогою меню, вибирає напрямок конвертації. Наприклад, з
//десяткової до двійкової. Після вибору напряму, користувач
//вводить число у вихідній системі обчислення. Додаток має
//перевести число у потрібну систему. Передбачити випадок
//виходу за межі діапазону, який визначається типом int, —
//неправильне введення.
//Завдання 3
//Створіть клас «Закордонний паспорт». Вам необхідно
//зберігати інформацію про номер паспорта, ПІБ власника,
//дату видачі, тощо. Передбачити механізми ініціалізації
//полів класу. Якщо значення для ініціалізації неправильне,
//генеруйте виняток. 
namespace HW_03_31_05_2024
{
    internal class Program
    {
        public static string decToBin(int num)
        {
            string binNum=null;
            while (num!=0)
            {
                if (num%2 == 0)
                {
                    binNum = "0" + binNum;
                    num = num/2;
                }
                else
                {
                    binNum = "1" + binNum;
                    num = num / 2;
                }
            }
            return binNum;
        }
        public static int BinTodDec(string num)
        {
            double decNum = 0;
            char[] charArray = num.ToCharArray();
            double j = 0;
            int charNum;
            for (int i = charArray.Length-1; i >= 0; i--)
            {
                if (Convert.ToInt32(charArray[i]) == 49)
                {
                    charNum = 1;
                }
                else if (Convert.ToInt32(charArray[i]) == 48)
                {
                    charNum = 0;
                }
                else
                {
                    throw new FormatException("Недопустимые символы. только 0 или 1");
                }    
                decNum += charNum*Math.Pow(2, j);
                j++;
            }
            return Convert.ToInt32(decNum);
        }
        public static void Main(string[] args)
        {
            //HWT1
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Введите десятичное число");
            int num = Convert.ToInt32(Console.ReadLine());
            string binNum = decToBin(num);
            Console.WriteLine($"Число {num} в доичном виде будет : {binNum}");

            Console.WriteLine("Введите десятичное число");
            string decNum = Console.ReadLine();
            try
            {
                int num3 = BinTodDec(decNum);
                Console.WriteLine($"Двоичное число {decNum} в десятичном виде будет : {num3}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
            //HWT2
            Console.WriteLine("----------------------------------------------------------");
            try
            {
                InterPassport passport = new InterPassport(135467897,"Evgenii",15,7,2024);
                Console.WriteLine(passport);
                //passport.setData(45, 13, 2025); //ошибка даты
                Console.WriteLine(passport);
                passport.PassNum = 13213;
                passport.Name = "Bob";
                Console.WriteLine(passport);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}
