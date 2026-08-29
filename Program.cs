using System;

namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string bossName = "ANON";
            char rank = 'A';
            int level = 99;
            int maxHp = 5000;
            int currentHp = 250;
            float attackPower = 42.5f;
            double critMultiplier = 5.55;
            bool isBoss = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier}");
            Console.WriteLine($"Is Boss: {isBoss}");

            int hpPercentage = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercentage}%");

            Console.WriteLine();
            Console.WriteLine($"{bossName} takes 50 damage!");

            currentHp -= 50;

            Console.WriteLine();
            Console.WriteLine("===== BOSS STATUS: AFTER DAMAGE =====");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");

            int newHpPercentage = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {newHpPercentage}%");

            string[] monsters =
            {
                "MONK",
                "SHE",
                "NEN",
                "DOG",
                "CAT"
            };

            string[] loots =
            {
                "MAGIC",
                "POSITIVE",
                "Merit"
            };

            Random rnd = new Random();

            string monsterName = monsters[rnd.Next(monsters.Length)];

            Console.WriteLine();
            Console.WriteLine($"{monsterName} appears!");
            Console.WriteLine($"You killed the {monsterName}!");

            int Pudjai = 50;
            int good = 50;

            switch (monsterName)
            {
                case "MONK":
                    Pudjai = 500;
                    good = 95;
                    break;

                case "SHE":
                    Pudjai = 250;
                    good = 85;
                    break;

                case "NEN":
                    Pudjai = 150;
                    good = 55;
                    break;

                case "DOG":
                    Pudjai = 50;
                    good = 20;
                    break;

                case "CAT":
                    Pudjai = 25;
                    good = 10;
                    break;
            }

            Console.WriteLine($"You got {Pudjai} Pudjai and {good} good!");

            string loot = loots[rnd.Next(loots.Length)];
            Console.WriteLine($"You also found a {loot}!");
        }
    }
}