using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер массива: ");
            int N = int.Parse(Console.ReadLine());

            Console.Write("Введите целевое значение: ");
            int target = int.Parse(Console.ReadLine());

            int[] candidates = new int[N]; 
            Random rand = new Random();
            for (int l = 0; l < N; l++)
            {
                candidates[l] = rand.Next(1, 10);
            }

            List<List<int>> list_target = new List<List<int>>();
            
            GenerateCombinations(candidates, target, 0, new List<int>(), list_target);
            
            Console.WriteLine("Исходный массив:");
            Console.WriteLine(string.Join(", ", candidates));
            
            Console.WriteLine("Все возможные комбинации:");
            Console.WriteLine("[");
            foreach (var list in list_target)
            {
                Console.WriteLine($"[{string.Join(", ", list)}],");
            }
            Console.WriteLine("]");
        }
        
        static void GenerateCombinations(int[] candidates, int target, int start, List<int> combination, List<List<int>> result)
        {
            if (target == 0)
            {
                result.Add(new List<int>(combination));
            }

            for (int i = start; i < candidates.Length; i++)
            {
                if (target - candidates[i] >= 0)
                {
                    combination.Add(candidates[i]);
                    GenerateCombinations(candidates, target - candidates[i], i + 1, combination, result);
                    combination.Clear();
                }
            }
        }
    }
}