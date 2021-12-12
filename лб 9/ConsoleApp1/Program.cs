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
            Boss PersonWill = new Boss("PersonWill", "person", 2, 0);
            Boss RobotWill = new Boss("RobotWill", "robot", 0, 0);

            Boss.UpgradeLevel upgrade = (Boss machine, int level) => Console.WriteLine($"{machine.Name} was upgraded by {level} levels");
            Boss.TurnOnMachine turnOn = (Boss machine, double currentStrain) => Console.WriteLine($"{machine.Name} trying to turn on with {currentStrain} strain...");

            PersonWill.UpgradeEvent += upgrade;
            PersonWill.TurnOnEvent += turnOn;

            RobotWill.UpgradeEvent += upgrade;

            PersonWill.Upgrade(5);
            PersonWill.TurnOnEvent += StrainMaxCapacity;
            PersonWill.TurnOn(10.7);
            Console.WriteLine();

            RobotWill.Upgrade(19);
            RobotWill.TurnOn(17.23);

            Console.ReadKey();
        }

        // обработчик максимального напряжения
        private static void StrainMaxCapacity(Boss machine, double currentStrain)
        {
            if (machine.Type == "person" && currentStrain > 9.5)
                Console.WriteLine($"{machine.Name} broke under this strain while trying to turn on!");
            else if (machine.Type == "robot" && currentStrain > 24.2)
                Console.WriteLine($"{machine.Name} broke under this strain while trying to turn on!");
        }
    }
}
