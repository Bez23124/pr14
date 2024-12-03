using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{/// <summary>
 ///Заполнить одномернный масив и с клавиатуры вывести
 /// </summary>
    class Program
    {
        static int GetSize()
        {
            Console.Write("Ввести размер масива");
            int size;
            while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.WriteLine("Ошибка");

            }
            return size;
        }
        /// <summary>
        /// Метод ввода одновременного масива
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>



        static int[] Input(int size)
        {
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {

                Console.Write($"array[{i}]=");
                array[i] = int.Parse(Console.ReadLine());
            }

            return array;


        }

        /// <summary>
        /// Метод ввода  значения масива
        /// </summary>
        /// <param name="array"></param>




        static void OutPut(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"array[{i}]= { array[i]} ");
            }
            
        }
        /// <summary>
        /// Метод вывода значения масива
        /// </summary>
        /// <param name="args"></param>


        static void Main(string[] args)
        {
            int size = GetSize();
            int[] array = Input(size);
        }
    }
}