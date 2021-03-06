using System;
using System.Collections.Generic;
using System.IO;

namespace Day1.Part1
{
    class Program
    {
        const string FILE_DIRECTORY = @"D:\GAMEDEV\Csharp\Github\AdventOfCode2021\AdventOfCode\Resources\Day1\input.txt";
        
        static void Main(string[] args)
        {
            Console.WriteLine($"Result: {TimesDepthIncreased(ReadFileToIntList())}");
        }

        static List<int> ReadFileToIntList()
        {
            StreamReader dataStream = new StreamReader(FILE_DIRECTORY);
            List<int> input = new List<int>();
            while (!dataStream.EndOfStream)
            {
                input.Add(int.Parse(dataStream.ReadLine()));
            }
            return input;
        }
        
        static int TimesDepthIncreased(List<int> input)
        {
            int result = 0;
            for (int i = 1; i < input.Count; i++)
            {
                if (input[i] > input[i - 1])
                    result++;
            }
            return result;
        }
    }
}