using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
//Завдання 3
//Створіть клас «Закордонний паспорт». Вам необхідно
//зберігати інформацію про номер паспорта, ПІБ власника,
//дату видачі, тощо. Передбачити механізми ініціалізації
//полів класу. Якщо значення для ініціалізації неправильне,
//генеруйте виняток. 
namespace HW_03_31_05_2024
{
    internal class InterPassport
    {
        private int _passNum;
        private string _name;
        private int[] _data = new int[3];
        public InterPassport(){}
        public InterPassport(int passNum ,string name, int day, int month, int year) 
        {
            _passNum = passNum;
            _name = name;
            if (day>0 || day<32 || month>0 || month<12 || year>2024 || year<1991)// немного хардкода
            {
                _data[0] = day;
                _data[1] = month;
                _data[2] = year;
            }
            else
            {
                throw new FormatException("Неверная дата");
            }

        }
        public int PassNum 
        {
            get { return _passNum; }
            set { _passNum = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public void setData(int day, int month, int year)
        {
            if (day > 0 && day < 32 && month > 0 && month < 12 && year > 2024 && year < 1991)// немного хардкода
            {
                _data[0] = day;
                _data[1] = month;
                _data[2] = year;
            }
            else
            {
                throw new FormatException("Неверная дата");
            }
        }
        public override string ToString()
        {
            return $"Passport number: {_passNum} \nName: {_name} \nDate of issue: {_data[0]}.{_data[1]}.{_data[2]}";
        }
    }
}
