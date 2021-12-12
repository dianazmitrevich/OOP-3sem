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

        public string Name { get; }
        public string Type { get; }
        public int Level { get; set; }
        public double Strain { get; set; }

        public Boss(string name = "", string type = "", int level = 0, double strain = 0.0)
        {
            this.Name = name;
            this.Type = type;
            this.Level = level;
            this.Strain = strain;
        }

        public delegate void UpgradeLevel(Boss machine, int upgradeTo);
        public delegate void TurnOnMachine(Boss machine, double currentStrain);
        public event UpgradeLevel UpgradeEvent;
        public event TurnOnMachine TurnOnEvent;

        public void Upgrade(int upgradeTo)
        {
            this.Level = this.Level + upgradeTo;
            this.UpgradeEvent?.Invoke(this, upgradeTo);
        }

        public void TurnOn(double currentStrain)
        {
            this.Strain = currentStrain;
            this.TurnOnEvent?.Invoke(this, currentStrain);
        }
    }
}
