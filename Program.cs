using System;
using RPG.src.Entities;

namespace RPG // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Knight Hero = new Knight("Kirito", 10, "Knight");
           Wizard Wizard = new Wizard("Shin", 10, "White Wizard");
           Ninja Ninja = new Ninja("Naruto", 45, "Ninja");
           DarkWizard BlackW = new DarkWizard("Momonga", 999, "Necrophile");

            Console.WriteLine(Hero.Attack());
            Console.WriteLine(Wizard.Attack());
            Console.WriteLine(Ninja.Attack());
            Console.WriteLine(BlackW.Attack());

        }
    }
}