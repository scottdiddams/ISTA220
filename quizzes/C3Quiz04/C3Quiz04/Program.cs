using System;

namespace C3Quiz04
{
        class Firearm
          
        {
        public string Name;
        public string Action;
            internal void behave(string name, string action)
        {
            Name = name;
            Action = action;
            Console.WriteLine($"I am a {name}, and I go {action}");
        }
        }
        class Program
        {

            static void Main(string[] lenny)
        {
            Console.WriteLine("Welcome to C# Quiz 04");
            
            Firearm shotgun = new Firearm();
            shotgun.Name = "shotgun";
            shotgun.Action = "Boom";
            shotgun.behave(shotgun.Name, shotgun.Action);

            Firearm rifle = new Firearm();
            rifle.Name = "Rifle";
            rifle.Action = "Bang";
            rifle.behave(rifle.Name, rifle.Action);

            Firearm pistol = new Firearm();
            pistol.Name = "pistol";
            pistol.Action = "Pop";
            pistol.behave(pistol.Name, pistol.Action);

            Console.ReadLine();
        }
    }
}
