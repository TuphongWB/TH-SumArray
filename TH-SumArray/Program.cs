using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH_SumArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.Write("Nhập số lượng phần tử trong mảng: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhập giá trị cho phần tử thứ {0}: ", i + 1);
                arr[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += arr[i];
            }

            Console.WriteLine("Tổng các phần tử của mảng là: {0}", sum);
            Console.ReadKey();
        }
    }
}
