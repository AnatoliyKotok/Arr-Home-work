using System;
using System.Linq;
namespace Arr_home_work
{
    class Program
    {


        static void Print<T>(T[] arr, string titel)
        {
            Console.WriteLine(titel);
            foreach (T elm in arr)
            {
                Console.Write($"{elm,10}");
            }
            Console.WriteLine();
        }
        static Random rnd = new Random();
        static void FillRand(int[] arr, int left = 0, int right = 100)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(left, right + 1);

            }

        }
       
        static void arrSwop(int[] arr,int a,int b)
        {
            int tmp = arr[a];
            arr[a] = arr[b];
            arr[b] = tmp;
        }
        static int[] FirstPositve(int[] arr)
        {

            return Array.FindAll(arr, (int x) => x > 0);  
        }
        static int PiredEl(int[] arr)
        {
            return arr.Count((x) => x % 2 == 0);
        }
        static void FoundCratne7(int[] arr)
        {
            bool found = false;
            int index = Array.Find(arr, (x) => x % 7 == 0);
            for (int i = 0; i < arr.Length; i++)
            {
                if (index == arr[i])
                {
                    Console.WriteLine($"Index cratne 7->{i+1}");
                    found = true;
                }
               
            }
            if (found == false)
            {
                Console.WriteLine("Number not found");
            }
        }
        
        static void Found_0(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    arr[i] = -1;
                }
            }
        }
        static void SwapArr(int[] arr)
        {
            int[]neg=Array.FindAll(arr, (x) => x < 0);
            int[] pos = Array.FindAll(arr, (x) => x > 0);
            neg.CopyTo(arr, 0);
            pos.CopyTo(arr, neg.Length);
          
           
        }
        static void CountNumber(int[] arr)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Count of number {a} in arr->{arr.Count(x=>x==a)}");
           
            
        }
        static void FindSum(int[] arr)
        {
            int min = arr.Min();
            int max = arr.Max();
            int indexMin = Array.FindIndex(arr, (x) => x == min);
            int indexMax = Array.FindIndex(arr, (x) => x == max);
            int sum = 0;
            for (int i = indexMin; i <indexMax; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine($"Sum from{min} to {max}={sum}");
        }
        static void FindSumInArr(int[] arr)
        {
            int[] arrSum = Array.FindAll(arr, (x) => x % 2 == 0);
            int sumPair = 0;
            for (int i = 0; i < arrSum.Length; i++)
            {
                sumPair += arrSum[i];
            }
            Console.WriteLine($"Sum pair={sumPair}");
           // Console.WriteLine($"Count of number with one literal={arr.Count(x=>x<10&&x>0)}");
          
        }
        static void SorProdukt(int []price,string[]produkt)
        {
            Array.Sort(price, (x, y) => x.CompareTo(y));
            foreach (var pri in price)
            {
                Console.WriteLine(pri);
            }
            foreach (var pro in produkt)
            {
                Console.WriteLine($"\t{pro}");
            }

        }
        static void Main(string[] args)
        {
            int size = 5;
            int[] arr = new int[size];
            FillRand(arr, -100, 100);
            Print(arr, "Arr");
            //arrSwop(arr,0,1);
            //Print(arr, "Arr after swop");
            //int []positive=FirstPositve(arr);
            //Print(positive, "First positive");
            //Console.WriteLine($"Count of pired elements->{PiredEl(arr)}");
            //FoundCratne7(arr);
            //Found_0(arr);
            //Print(arr,"with -1");
            //SwapArr(arr);
            //Print(arr, "After swop");
            //CountNumber(arr);
            // FindSum(arr);
            // FindSumInArr(arr);
            int[] price = new int[3] { 345, 234, 567 };
            string[] produkt = new string[3] { "Apple", "Lemon", "Wother melon" };
            SorProdukt(price, produkt);
;        }
    }
}
