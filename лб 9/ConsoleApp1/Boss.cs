using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Boss
    {
        // Вариант 8

        // Создать класс Boss с событиями Upgrade и TurnOn(под
        // определенным напряжением, учтите что техника или человек могут
        // сломаться). В main создать некоторое количество объектов(техники
        // или полу-техники). Подпишите объекты на события произвольным
        // образом. Реакция на события у разных объектов будет разная.
        // Проверить результаты изменения состояния объектов после
        // наступления событий, возможно не однократном.

        public string Type { get; }
        public int Level { get; set; }
        public double Strain { get; set; }

        public Boss(string type = "", int level = 0, double strain = 0.0)
        {
            this.Type = type;
            this.Level = level;
            this.Strain = strain;
        }

        public delegate void Upgrade(int upgradeTo);
        public delegate void TurnOn(double currentStrain);
        public event Upgrade UpgradeEvent;
        public event TurnOn TurnOnEvent;
    }
}
