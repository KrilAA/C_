using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.task1
{
    internal class Task1 : Program
    {
        public void StartTask()
        {
            //for entering any numbers
            int[] numbers = new int[3];
            //another array to correct numbers
            int[] arr = new int[3];
            //for array arr to have correct poryadkovist
            int index = 0;
            //my number is 8 in rating
            int num = 8;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter number: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());

                if (numbers[i] < (10 + num) && numbers[i] > 0)
                {
                    arr[index] = numbers[i];
                    index++;
                }
            }

            for (int i = 0; i < index; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadLine();
        }

    }
}
