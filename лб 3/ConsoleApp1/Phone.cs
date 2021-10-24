using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    partial class Phone
    {
        /* Вариант 8
            Создать класс Phone: id, Фамилия, Имя, Отчество,
            Адрес, Номер кредитной карточки, Дебет, Кредит,
            Время городских и междугородных разговоров. Свойства
            и конструкторы должны обеспечивать проверку
            корректности. Добавить метод расчет баланса на
            текущий момент.

            Создать массив объектов. Вывести:
            a) сведения об абонентах, у которых время внутригородских
            разговоров превышает заданное;
            b) сведения об абонентах, которые пользовались
            междугородной связью;
         */

        private static int phoneCount = 0;
        public readonly int id = phoneCount + 1;
        private string surname;
        private (string name, string middleName) nameData;
        private string adress;
        private int? cardNumber;
        private (int income, int outcome) incomeOutcome;
        private (int urbanTime, int internationalTime) timeCount;

        public const int phoneBalance = 100;

        public int PhoneCount
        {
            get => phoneCount;
        }

        public string Surname { get => surname; set => surname = value; }

        public (string name, string middleName) NameData
        {
            get => nameData;
            set => nameData = value;
        }

        public string Adress { get => adress; set => adress = value; }

        public int? CardNumber
        {
            get => cardNumber;
            set
            {
                if (value.ToString().Length == 4 || value == null)
                {
                    cardNumber = value;
                }
                else Console.WriteLine("Номер карточки введён неправильно");
            }
        }

        public (int income, int outcome) IncomeOutcome
        {
            get => incomeOutcome;
            set => incomeOutcome = value;
        }

        public (int urbanTime, int internationalTime) TimeCount
        {
            get => timeCount;
            set => timeCount = value;
        }
    }
}
