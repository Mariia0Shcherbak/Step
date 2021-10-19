using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz08._10._21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Первое задание: ");
            int[] arr = new int[10];
            Random rand = new Random();
            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = rand.Next(3);
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();
          
            int count = 0;
            for(int i=0; i<arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    count++;
                }
                else
                {
                    arr[i - count] = arr[i];
                }
            }

            for(int j=arr.Length-count; j<arr.Length; j++)
            {
                arr[j] = -1;
            }
            for(int i = 0; i < arr.Length; i++ ){
                Console.Write(arr[i] + " ");
            }
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine();
            //////////////////////////////
            Console.WriteLine("Второе задание:");
            int[] arr1 = new int[10];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = rand.Next(-5, 2) ;
                Console.Write(arr1[i] + " ");
            }
            Console.WriteLine();
            int t;
            
            arr1= arr1.OrderByDescending(x => x < 0 ? 1 : 0).ToArray();

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i] + " ");
            }
            Console.ReadKey();
            Console.WriteLine();
            ////////////////////////////////
            Console.WriteLine("Третье задание:");
            int[] arr2 = new int[10];

            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = rand.Next(0, 10);
            }
    
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Введите число для поиска:");
            int temp = int.Parse(Console.ReadLine());
            int coun = 0;

            for (int i=0; i<arr2.Length; i++)
            {
                if (arr2[i] == temp)
                {
                    coun++;
                }
            }

            Console.WriteLine("Число встречается в массиве {0} ", coun);
            Console.ReadKey();
        }
    }
}
