using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
                int[] array = { 1, 2, 2, 1 };

                Console.WriteLine("Mảng ban đầu:");
                PrintArray(array);

                // Sắp xếp mảng
                SortArray(array);
                Console.WriteLine("\nMảng sau khi sắp xếp:");
                PrintArray(array);

                // In ra phần tử max, min trong mảng
                int max = FindMax(array);
                int min = FindMin(array);
                Console.WriteLine($"\nPhần tử lớn nhất trong mảng: {max}");
                Console.WriteLine($"Phần tử nhỏ nhất trong mảng: {min}");

                // Kiểm tra mảng đối xứng
                bool isSymmetric = CheckSymmetry(array);
                Console.WriteLine($"\nMảng có đối xứng không? {isSymmetric}");
            }

            static void PrintArray(int[] arr)
            {
                foreach (var item in arr)
                {
                    Console.Write(item + " ");
                }
            }

            static void SortArray(int[] arr)
            {
                Array.Sort(arr);
            }

            static int FindMax(int[] arr)
            {
                int max = arr[0];
                foreach (var item in arr)
                {
                    if (item > max)
                    {
                        max = item;
                    }
                }
                return max;
            }

            static int FindMin(int[] arr)
            {
                int min = arr[0];
                foreach (var item in arr)
                {
                    if (item < min)
                    {
                        min = item;
                    }
                }
                return min;
            }

            static bool CheckSymmetry(int[] arr)
            {
                int length = arr.Length;
                for (int i = 0; i < length / 2; i++)
                {
                    if (arr[i] != arr[length - 1 - i])
                    {
                        return false;
                    }
                }
                return true;
            }
        }

    }


