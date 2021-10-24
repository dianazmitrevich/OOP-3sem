using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone Diana = new Phone("Zmitrevich", "Diana", "A.", "Upper str.", 4786, 1200, 300, 24, 0);
            Phone Yanis = new Phone("Zmitrevich", "Yanis", "A.", "Lower str.", 8635, 1344, 100, 54, 4);
            Phone Lauren = new Phone("Grennish", "Lauren", "D.", "Cap str.", 2964, 844, 250, 344, 20);
            Phone WarrenG = new Phone("G", "Warren", "P.", "Swag str.", 2694, 4000, 6000, 10, 100);
            Phone[] array = { Diana, Yanis, Lauren, WarrenG };

            Phone.showThePhoneCount();

            Console.WriteLine("Абоненты, наговорившие по городской связи более 30 минут:");
            foreach (Phone name in Phone.highUrbanTime(ref array, 30)) Console.WriteLine(name.NameData);

            Console.WriteLine("Абоненты, говорившие по международной связи:");
            foreach (Phone name in Phone.useInternationalTime(ref array)) Console.WriteLine(name.NameData);

            Console.WriteLine("Адрес рандомного объекта {0}\n" +
                "Сравнение объектов {1}\n" +
                "Тип созданного объекта {2}", WarrenG.Adress, Diana.Equals(Yanis), Diana.GetType());

            var anonym = new
            {
                id = 999,
                surname = "anonym",
                cardNumber = 3963,
                timeCount = (23, 966)
            };
            Console.WriteLine(anonym);

            Console.ReadKey();
        }
    }
}
