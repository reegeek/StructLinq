using System.Linq;
using BenchmarkDotNet.Attributes;

namespace StructLinq.Benchmark
{
    
    //``` ini

    //BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18363
    //Intel Core i7-7700 CPU 3.60GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
    //.NET Core SDK=3.1.301
    //[Host]     : .NET Core 3.1.5 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.27001), X64 RyuJIT
    //DefaultJob : .NET Core 3.1.5 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.27001), X64 RyuJIT


    //```
    //|                             Method |     Mean |    Error |   StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
    //|----------------------------------- |---------:|---------:|---------:|------:|------:|------:|----------:|
    //|                            SysLinq | 55.27 us | 0.606 us | 0.537 us |     - |     - |     - |     104 B |
    //|             StructLinqWithDelegate | 54.92 us | 0.551 us | 0.488 us |     - |     - |     - |         - |
    //| StructLinqWithDelegateAsEnumerable | 93.33 us | 1.596 us | 1.493 us |     - |     - |     - |      96 B |
    //|                         StructLinq | 17.52 us | 0.264 us | 0.247 us |     - |     - |     - |         - |
    //|             StructLinqAsEnumerable | 52.92 us | 1.159 us | 1.625 us |     - |     - |     - |      96 B |


    
    [MemoryDiagnoser]
    public class ForEachOnArrayWhereSelect
    {
        private const int Count = 10000;
        private readonly int[] array;

        public ForEachOnArrayWhereSelect()
        {
            array = Enumerable.Range(0, Count).ToArray();
        }


        [Benchmark]
        public int SysLinq()
        {
            var enumerable = array
                             .Where(x => (x & 1) == 0)
                             .Select(x => x * 2);
            var sum = 0;
            foreach (var i in enumerable)
            {
                sum += i;
            }

            return sum;
        }

        [Benchmark]
        public int StructLinqWithDelegate()
        {
            var enumerable = array
                             .ToStructEnumerable()
                             .Where(x => (x & 1) == 0, x => x)
                             .Select(x => x * 2, x => x);
            var sum = 0;
            foreach (var i in enumerable)
            {
                sum += i;
            }

            return sum;
        }

        [Benchmark]
        public int StructLinqWithDelegateAsEnumerable()
        {
            var enumerable = array
                             .ToStructEnumerable()
                             .Where(x => (x & 1) == 0, x => x)
                             .Select(x => x * 2, x => x);

            var sum = 0;
            foreach (var i in enumerable.ToEnumerable())
            {
                sum += i;
            }

            return sum;
        }

        [Benchmark]
        public int StructLinq()
        {
            var where = new WherePredicate();
            var select = new SelectFunction();
            var enumerable = array
                             .ToStructEnumerable()
                             .Where(ref @where, x => x)
                             .Select(ref @select, x => x, x => x);

            var sum = 0;
            foreach (var i in enumerable)
            {
                sum += i;
            }

            return sum;
        }

        [Benchmark]
        public int StructLinqAsEnumerable()
        {
            var where = new WherePredicate();
            var select = new SelectFunction();
            var enumerable = array
                             .ToStructEnumerable()
                             .Where(ref @where, x => x)
                             .Select(ref @select, x => x, x => x);

            var sum = 0;
            foreach (var i in enumerable.ToEnumerable())
            {
                sum += i;
            }

            return sum;
        }

    }
}
