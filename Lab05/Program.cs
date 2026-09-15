/*Student ID: 1690702806
 * Name      : Itsada Jiangphukhaio
 *
 *Section    : 129C
 *No.        :
 *Course     : GI113 Computer Programming (GI)
 */

using System;

namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerHp = 100;
            int damage = 25;
            int heal = 15;

            Console.WriteLine("===== REUTHAI BATTLE TEST =====");
            Console.WriteLine();

            int hpAfterDamage = playerHp - damage;
            int hpAfterHeal = hpAfterDamage + heal;

            Console.WriteLine($"Player HP       : {playerHp}");
            Console.WriteLine($"Damage          : {damage}");
            Console.WriteLine($"HP After Damage : {hpAfterDamage}");
            Console.WriteLine($"Heal            : {heal}");
            Console.WriteLine($"HP After Heal   : {hpAfterHeal}");

            Console.WriteLine();
            Console.WriteLine("===== COMPARISON =====");

            bool isAlive = hpAfterDamage > 0;
            bool isFullHp = hpAfterHeal == playerHp;
            bool isLowHp = hpAfterDamage <= 50;

            Console.WriteLine($"Player Alive : {isAlive}");
            Console.WriteLine($"Full HP      : {isFullHp}");
            Console.WriteLine($"Low HP       : {isLowHp}");

            Console.WriteLine();
            Console.WriteLine("===== LOGICAL OPERATOR =====");

            bool hasWeapon = true;
            bool hasEnergy = true;

            bool canAttack = hasWeapon && hasEnergy;

            Console.WriteLine($"Has Weapon : {hasWeapon}");
            Console.WriteLine($"Has Energy : {hasEnergy}");
            Console.WriteLine($"Can Attack : {canAttack}");

            Console.WriteLine();
            Console.WriteLine("===== OTHER OPERATORS =====");

            int coins = 10;
            coins += 5;

            int monsterCount = 3;
            monsterCount--;

            Console.WriteLine($"Coins        : {coins}");
            Console.WriteLine($"Monster Left : {monsterCount}");
        }
    }
}