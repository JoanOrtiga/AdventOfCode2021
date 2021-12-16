using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Day3.Part1
{
    class Program
    {
        const string FILE_DIRECTORY = @"D:\GAMEDEV\Csharp\Github\AdventOfCode2021\AdventOfCode\Resources\Day3\input.txt";
        
        static void Main(string[] args)
        {
            ReadFileToInstructions();
            Console.WriteLine($"Result: ");
        }

        static List<bool[]> ReadFileToInstructions()
        {
            List<bool[]> bitArraysList = new List<bool[]>();
            StreamReader dataStream = new StreamReader(FILE_DIRECTORY);
            
            while (!dataStream.EndOfStream)
            {
                string line = dataStream.ReadLine();
                
                bool[] bits = new bool[line.Length];
                for (int i = 0; i < line.Length; i++)
                {
                    bits[i] = line[i] == '1';
                }
                
                bitArraysList.Add(bits);
            }

            for (int i = 0; i < bitArraysList.Count; i++)
            {
                for (int j = 0; j < bitArraysList[i].Length; j++)
                {
                    Console.Write(bitArraysList[i][j]);
                }

                Console.WriteLine();
            }
            
            return bitArraysList;
        }
    }
}