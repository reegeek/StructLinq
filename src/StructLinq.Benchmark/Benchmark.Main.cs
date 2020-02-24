using System;
using BenchmarkDotNet.Running;

namespace StructLinq.Benchmark
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
            Console.ReadLine();
        }
    }
}
