using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_Fundamentals_ExamP_2___Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] field = new int[fieldSize];
            var ladybugsIndexes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


            for (int i = 0; i < ladybugsIndexes.Length; i++)
            {
                if (ladybugsIndexes[i] >= 0 && ladybugsIndexes[i] <= fieldSize - 1)
                {
                    int currentField = ladybugsIndexes[i];
                    field[currentField] = 1;
                }
            }

            string rows = string.Empty;

            while ((rows = Console.ReadLine()) != "end")
            {
                string[] inputDirection = rows.Split(' ');
                int ladybugIndex = int.Parse(inputDirection[0]);
                var direction = inputDirection[1];
                var flyLenght = int.Parse(inputDirection[2]);

                if (ladybugIndex >= 0 && ladybugIndex <= fieldSize - 1 && field[ladybugIndex] == 1)
                {
                    field[ladybugIndex] = 0;


                    if (direction == "right")
                    {
                        int landIndex = ladybugIndex + flyLenght;
                        if (landIndex >= fieldSize)
                        {
                            continue;
                        }

                        if (field[landIndex] == 1)
                        {
                            while (field[landIndex] == 1)
                            {
                                landIndex = landIndex + flyLenght;
                                if (landIndex >= fieldSize)
                                {
                                    break;
                                }
                            }
                        }
                        if (landIndex < fieldSize)
                        {
                            field[landIndex] = 1;
                        }
                    }
                    else if (direction == "left")
                    {
                        int landIndex = ladybugIndex - flyLenght;
                        if (landIndex < 0)
                        {
                            continue;
                        }
                        if (field[landIndex] == 1)
                        {
                            while (field[landIndex] == 1)
                            {
                                landIndex = landIndex - flyLenght;
                                if (landIndex < 0)
                                {
                                    break;
                                }
                            }

                        }
                        if (landIndex >= 0)
                        {
                            field[landIndex] = 1;
                        }
                    }
                }
                else
                {
                    continue;
                }

            }
            Console.WriteLine(string.Join(" ", field));
        }
    }
}
