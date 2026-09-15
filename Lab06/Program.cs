/*Student ID: 1690702806
 * Name      : Itsada Jiangphukhaio
 *
 *Section    : 129C
 *No.        :
 *Course     : GI113 Computer Programming (GI)
 */

using System;

namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== The Haunted Mask Room ===");
            Console.WriteLine("A strange shadow appears behind the Khon mask.");
            Console.WriteLine();
            Console.WriteLine("Choose your action:");
            Console.WriteLine("1. Use the magic charm");
            Console.WriteLine("2. Turn on the flashlight");
            Console.WriteLine("3. Run to the exit");
            Console.WriteLine();

            Console.Write("Choose your action (1-3): ");

            bool choiceOk = int.TryParse(Console.ReadLine(), out int choice);

            if (!choiceOk || choice < 1 || choice > 3)
            {
                Console.WriteLine("Invalid input. Please enter a number from 1 to 3.");
            }
            else if (choice == 1)
            {
                Console.WriteLine("The charm glows and the shadow disappears. You are safe.");
            }
            else if (choice == 2)
            {
                Console.WriteLine("The flashlight reveals a ghost behind the mask. You freeze in fear.");
            }
            else
            {
                Console.WriteLine("You run to the exit, but the door closes before you escape.");
            }
        }
    }
}