/*Student ID: 1690702806
 * Name      : Itsada Jiangphukhaio
 *
 *Section    : 129C
 *No.        :
 *Course     : GI113 Computer Programming (GI)
 */

using System;

namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            const string GameTitle = "Reuthai";
            var characterName = "Mali";
            var characterRank = 'B';
            int characterAge = 20;
            float spiritResistance = 42.5f;
            double supernaturalEnergy = 89.6;
            bool isHuman = true;

          
            Console.WriteLine("================================");
            Console.WriteLine($"          {GameTitle}");
            Console.WriteLine("       CHARACTER STAT CARD");
            Console.WriteLine("================================");
            Console.WriteLine($"Name              : {characterName}");
            Console.WriteLine($"Rank              : {characterRank}");
            Console.WriteLine($"Age               : {characterAge}");
            Console.WriteLine($"Spirit Resistance : {spiritResistance}");
            Console.WriteLine($"Energy            : {supernaturalEnergy}");
            Console.WriteLine($"Human             : {isHuman}");
            Console.WriteLine("================================");

            double ageAsDouble = characterAge;

            Console.WriteLine();
            Console.WriteLine("        DATA CONVERSION");
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Age as double     : {ageAsDouble}");

            int energyCast = (int)supernaturalEnergy;
            int energyConverted = Convert.ToInt32(supernaturalEnergy);

            Console.WriteLine($"Energy Cast       : {energyCast}");
            Console.WriteLine($"Energy Converted  : {energyConverted}");
            Console.WriteLine("================================");
        }
    }
}