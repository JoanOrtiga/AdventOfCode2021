using System;
using System.Collections.Generic;
using System.IO;

namespace Day2.Part2
{
    class Program
    {
        const string FILE_DIRECTORY = @"D:\GAMEDEV\Csharp\Github\AdventOfCode2021\AdventOfCode\Resources\Day2\input.txt";
        
        static void Main(string[] args)
        {
            List<Instruction> instructions = ReadFileToInstructions();
            int finalHorizontalPosition = 0;
            int finalDepthPosition = 0;
            int aim = 0;
            MoveSubmarine(instructions, out aim, out finalHorizontalPosition, out finalDepthPosition);
            Console.WriteLine($"Result: Horizontal -> {finalHorizontalPosition} | Depth -> {finalDepthPosition} | Result -> {finalHorizontalPosition * finalDepthPosition}");
        }

        static List<Instruction> ReadFileToInstructions()
        {
            StreamReader dataStream = new StreamReader(FILE_DIRECTORY);
            List<Instruction> input = new List<Instruction>();
            while (!dataStream.EndOfStream)
            {
                string[] line = dataStream.ReadLine().Split(' ');
                input.Add(new Instruction(Enum.Parse<Instruction.Type>(line[0]), int.Parse(line[1])));
            }
            return input;
        }

        static void MoveSubmarine(List<Instruction> movements, out int aim, out int horizontalPosition, out int depthPosition)
        {
            horizontalPosition = 0;
            depthPosition = 0;
            aim = 0;
            
            for (int i = 0; i < movements.Count; i++)
            {
                switch (movements[i].type)
                {
                    case Instruction.Type.forward:
                    {
                        depthPosition += aim * movements[i].quantity;
                        horizontalPosition += movements[i].quantity;
                    } break;
                    case Instruction.Type.up:
                    {
                        aim -= movements[i].quantity;
                    } break;
                    case Instruction.Type.down:
                    {
                        aim += movements[i].quantity;
                    } break;
                }
            }
        }
    }

    struct Instruction
    {
        public enum Type
        {
            forward, down, up
        }

        public Type type;
        public int quantity;
        
        public Instruction(Type type, int quantity)
        {
            this.type = type;
            this.quantity = quantity;
        }
    }
}