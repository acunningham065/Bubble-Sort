using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            //-------------------Declaration of Variables-------------------\\
            int temp = 0;
            bool swap = false;
            int[] numbers = new int[]{3, 5, 6, 8, 4, 2, 1, 7, 9, 8};

            for (int currentPosition = 0; currentPosition < numbers.Length; currentPosition++)
            {
                for (int pos2 = 0; pos2 < numbers.Length - 1; pos2++)
                {

                    if (numbers[pos2] > numbers[pos2 + 1])
                    {
                        //Swap variable to true
                        swap = true;

                        //Store number temporarily
                        temp = numbers[pos2];

                        //Swap original to other
                        numbers[pos2] = numbers[pos2 + 1];

                        //Set other to original
                        numbers[pos2 + 1] = temp;

                    }
                    else
                    {
                        //Swap variable to false
                        swap = false;

                    }//End If

                }//End For

                //Write the header
                Console.Write("Pass " +  (currentPosition + 1).ToString() + ": ");
                
                //Write out pass
                for (int currentPos = 0; currentPos < numbers.Length; currentPos++)
                {
                    Console.Write(numbers[currentPos].ToString() + " ");
                }

                //Write blank line
                Console.WriteLine();
                
            }//End For

            //Pause
            Console.ReadKey();


        }
    }
}
