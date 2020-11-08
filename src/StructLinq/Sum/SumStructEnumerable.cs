

// Generated code

using System;
using System.Runtime.CompilerServices;
 

// ReSharper disable once CheckNamespace
namespace StructLinq
{

    public static partial class StructEnumerable
    {
            private struct SumInt16Visitor : IVisitor<Int16>
        {
            public Int16 sum;
            public SumInt16Visitor(Int16 sum)
            {
                this.sum = sum;
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Visit(Int16 input)
            {
                sum += input;
                return true;
            }
        }

            private struct SumFuncInt16Visitor<T> : IVisitor<T>
        {
            public Int16 sum;
            private readonly Func<T, Int16> func;
            public SumFuncInt16Visitor(Int16 sum, Func<T, Int16> func)
            {
                this.sum = sum;
                this.func = func;
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Visit(T input)
            {
                sum += func(input);
                return true;
            }
        }

        private struct SumIFunctionInt16Visitor<T, TFunc> : IVisitor<T>
            where TFunc : IFunction<T, Int16>
        {
            public Int16 sum;
            private readonly TFunc func;
            public SumIFunctionInt16Visitor(Int16 sum, TFunc func)
            {
                this.sum = sum;
                this.func = func;
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Visit(T input)
            {
                sum += func.Eval(input);
                return true;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 Sum<TEnumerator>(this IStructEnumerable<Int16, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<Int16>
        {
            var sumVisitor = new SumInt16Visitor(0);
            enumerable.Visit(ref sumVisitor);
            return sumVisitor.sum;      
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 Sum<TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TEnumerable, IStructEnumerable<Int16, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<Int16>
            where TEnumerable : struct, IStructEnumerable<Int16, TEnumerator>
        {
            var sumVisitor = new SumInt16Visitor(0);
            enumerable.Visit(ref sumVisitor);
            return sumVisitor.sum;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 Sum<T,TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, Func<T, Int16> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var sumVisitor = new SumFuncInt16Visitor<T>(0, func);
            enumerable.Visit(ref sumVisitor);
            return sumVisitor.sum;        
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 Sum<T,TEnumerable,TEnumerator>(this TEnumerable enumerable, 
        Func<T, Int16> func, 
        Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var sumVisitor = new SumFuncInt16Visitor<T>(0, func);
            enumerable.Visit(ref sumVisitor);
            return sumVisitor.sum; 
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 Sum<T,TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, 
        IFunction<T,Int16> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var sumVisitor = new SumIFunctionInt16Visitor<T, IFunction<T,Int16>>(0, func);
            enumerable.Visit(ref sumVisitor);
            return sumVisitor.sum; 
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 Sum<T,TEnumerable,TEnumerator, TFunc>(this TEnumerable enumerable,
            ref TFunc func, 
            Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _,
            Func<TFunc, IFunction<T,Int16>> __)
            where TEnumerable : struct, IStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
            where TFunc : IFunction<T,Int16>
        {
            var sumVisitor = new SumIFunctionInt16Visitor<T, TFunc>(0, func);
            enumerable.Visit(ref sumVisitor);
            return sumVisitor.sum;         }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Int16 SumInt16<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, IStructEnumerator<Int16>
        {
            Int16 result = 0;
            while (enumerator.MoveNext())
            {
                result += enumerator.Current;
            }
            enumerator.Dispose();
            return result;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Int16 SumInt16<T,TEnumerator, TFunc>(ref TEnumerator enumerator, ref TFunc func)
            where TEnumerator : struct, IStructEnumerator<T>
            where TFunc : IFunction<T,Int16>
        {
            Int16 result = 0;
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                result += func.Eval(current);
            }
            enumerator.Dispose();
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Int16 SumInt16<T,TEnumerator>(ref TEnumerator enumerator, Func<T, Int16> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            Int16 result = 0;
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                result += func(current);
            }
            enumerator.Dispose();
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 Sum<TEnumerator>(this IDirectStructCollection<Int16, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<Int16>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumInt16(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 Sum<TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TEnumerable, IDirectStructCollection<Int16, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<Int16>
            where TEnumerable : struct, IDirectStructCollection<Int16, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumInt16(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 Sum<T,TEnumerator>(this IDirectStructCollection<T, TEnumerator> enumerable, Func<T, Int16> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumInt16(ref enumerator, func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 Sum<T,TEnumerable,TEnumerator>(this TEnumerable enumerable, 
        Func<T, Int16> func, 
        Func<TEnumerable, IDirectStructCollection<T, TEnumerator>> _)
            where TEnumerable : struct, IDirectStructCollection<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumInt16(ref enumerator, func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 Sum<T,TEnumerator>(this IDirectStructCollection<T, TEnumerator> enumerable, 
        IFunction<T,Int16> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumInt16<T,TEnumerator, IFunction<T,Int16>>(ref enumerator, ref func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 Sum<T,TEnumerable,TEnumerator, TFunc>(this TEnumerable enumerable,
            ref TFunc func, 
            Func<TEnumerable, IDirectStructCollection<T, TEnumerator>> _,
            Func<TFunc, IFunction<T,Int16>> __)
            where TEnumerable : struct, IDirectStructCollection<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
            where TFunc : IFunction<T,Int16>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumInt16<T,TEnumerator, TFunc>(ref enumerator,ref func);
        }

    }


    public static partial class StructEnumerable
    {
            private struct SumInt32Visitor : IVisitor<Int32>
        {
            public Int32 sum;
            public SumInt32Visitor(Int32 sum)
            {
                this.sum = sum;
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Visit(Int32 input)
            {
                sum += input;
                return true;
            }
        }

            private struct SumFuncInt32Visitor<T> : IVisitor<T>
        {
            public Int32 sum;
            private readonly Func<T, Int32> func;
            public SumFuncInt32Visitor(Int32 sum, Func<T, Int32> func)
            {
                this.sum = sum;
                this.func = func;
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Visit(T input)
            {
                sum += func(input);
                return true;
            }
        }

        private struct SumIFunctionInt32Visitor<T, TFunc> : IVisitor<T>
            where TFunc : IFunction<T, Int32>
        {
            public Int32 sum;
            private readonly TFunc func;
            public SumIFunctionInt32Visitor(Int32 sum, TFunc func)
            {
                this.sum = sum;
                this.func = func;
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Visit(T input)
            {
                sum += func.Eval(input);
                return true;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 Sum<TEnumerator>(this IStructEnumerable<Int32, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<Int32>
        {
            var sumVisitor = new SumInt32Visitor(0);
            enumerable.Visit(ref sumVisitor);
            return sumVisitor.sum;      
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 Sum<TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TEnumerable, IStructEnumerable<Int32, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<Int32>
            where TEnumerable : struct, IStructEnumerable<Int32, TEnumerator>
        {
            var sumVisitor = new SumInt32Visitor(0);
            enumerable.Visit(ref sumVisitor);
            return sumVisitor.sum;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 Sum<T,TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, Func<T, Int32> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var sumVisitor = new SumFuncInt32Visitor<T>(0, func);
            enumerable.Visit(ref sumVisitor);
            return sumVisitor.sum;        
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 Sum<T,TEnumerable,TEnumerator>(this TEnumerable enumerable, 
        Func<T, Int32> func, 
        Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var sumVisitor = new SumFuncInt32Visitor<T>(0, func);
            enumerable.Visit(ref sumVisitor);
            return sumVisitor.sum; 
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 Sum<T,TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, 
        IFunction<T,Int32> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var sumVisitor = new SumIFunctionInt32Visitor<T, IFunction<T,Int32>>(0, func);
            enumerable.Visit(ref sumVisitor);
            return sumVisitor.sum; 
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 Sum<T,TEnumerable,TEnumerator, TFunc>(this TEnumerable enumerable,
            ref TFunc func, 
            Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _,
            Func<TFunc, IFunction<T,Int32>> __)
            where TEnumerable : struct, IStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
            where TFunc : IFunction<T,Int32>
        {
            var sumVisitor = new SumIFunctionInt32Visitor<T, TFunc>(0, func);
            enumerable.Visit(ref sumVisitor);
            return sumVisitor.sum;         }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Int32 SumInt32<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, IStructEnumerator<Int32>
        {
            Int32 result = 0;
            while (enumerator.MoveNext())
            {
                result += enumerator.Current;
            }
            enumerator.Dispose();
            return result;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Int32 SumInt32<T,TEnumerator, TFunc>(ref TEnumerator enumerator, ref TFunc func)
            where TEnumerator : struct, IStructEnumerator<T>
            where TFunc : IFunction<T,Int32>
        {
            Int32 result = 0;
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                result += func.Eval(current);
            }
            enumerator.Dispose();
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Int32 SumInt32<T,TEnumerator>(ref TEnumerator enumerator, Func<T, Int32> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            Int32 result = 0;
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                result += func(current);
            }
            enumerator.Dispose();
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 Sum<TEnumerator>(this IDirectStructCollection<Int32, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<Int32>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumInt32(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 Sum<TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TEnumerable, IDirectStructCollection<Int32, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<Int32>
            where TEnumerable : struct, IDirectStructCollection<Int32, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumInt32(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 Sum<T,TEnumerator>(this IDirectStructCollection<T, TEnumerator> enumerable, Func<T, Int32> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumInt32(ref enumerator, func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 Sum<T,TEnumerable,TEnumerator>(this TEnumerable enumerable, 
        Func<T, Int32> func, 
        Func<TEnumerable, IDirectStructCollection<T, TEnumerator>> _)
            where TEnumerable : struct, IDirectStructCollection<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumInt32(ref enumerator, func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 Sum<T,TEnumerator>(this IDirectStructCollection<T, TEnumerator> enumerable, 
        IFunction<T,Int32> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumInt32<T,TEnumerator, IFunction<T,Int32>>(ref enumerator, ref func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 Sum<T,TEnumerable,TEnumerator, TFunc>(this TEnumerable enumerable,
            ref TFunc func, 
            Func<TEnumerable, IDirectStructCollection<T, TEnumerator>> _,
            Func<TFunc, IFunction<T,Int32>> __)
            where TEnumerable : struct, IDirectStructCollection<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
            where TFunc : IFunction<T,Int32>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumInt32<T,TEnumerator, TFunc>(ref enumerator,ref func);
        }

    }


    public static partial class StructEnumerable
    {
            private struct SumInt64Visitor : IVisitor<Int64>
        {
            public Int64 sum;
            public SumInt64Visitor(Int64 sum)
            {
                this.sum = sum;
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Visit(Int64 input)
            {
                sum += input;
                return true;
            }
        }

            private struct SumFuncInt64Visitor<T> : IVisitor<T>
        {
            public Int64 sum;
            private readonly Func<T, Int64> func;
            public SumFuncInt64Visitor(Int64 sum, Func<T, Int64> func)
            {
                this.sum = sum;
                this.func = func;
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Visit(T input)
            {
                sum += func(input);
                return true;
            }
        }

        private struct SumIFunctionInt64Visitor<T, TFunc> : IVisitor<T>
            where TFunc : IFunction<T, Int64>
        {
            public Int64 sum;
            private readonly TFunc func;
            public SumIFunctionInt64Visitor(Int64 sum, TFunc func)
            {
                this.sum = sum;
                this.func = func;
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Visit(T input)
            {
                sum += func.Eval(input);
                return true;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 Sum<TEnumerator>(this IStructEnumerable<Int64, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<Int64>
        {
            var sumVisitor = new SumInt64Visitor(0);
            enumerable.Visit(ref sumVisitor);
            return sumVisitor.sum;      
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 Sum<TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TEnumerable, IStructEnumerable<Int64, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<Int64>
            where TEnumerable : struct, IStructEnumerable<Int64, TEnumerator>
        {
            var sumVisitor = new SumInt64Visitor(0);
            enumerable.Visit(ref sumVisitor);
            return sumVisitor.sum;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 Sum<T,TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, Func<T, Int64> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var sumVisitor = new SumFuncInt64Visitor<T>(0, func);
            enumerable.Visit(ref sumVisitor);
            return sumVisitor.sum;        
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 Sum<T,TEnumerable,TEnumerator>(this TEnumerable enumerable, 
        Func<T, Int64> func, 
        Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var sumVisitor = new SumFuncInt64Visitor<T>(0, func);
            enumerable.Visit(ref sumVisitor);
            return sumVisitor.sum; 
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 Sum<T,TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, 
        IFunction<T,Int64> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var sumVisitor = new SumIFunctionInt64Visitor<T, IFunction<T,Int64>>(0, func);
            enumerable.Visit(ref sumVisitor);
            return sumVisitor.sum; 
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 Sum<T,TEnumerable,TEnumerator, TFunc>(this TEnumerable enumerable,
            ref TFunc func, 
            Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _,
            Func<TFunc, IFunction<T,Int64>> __)
            where TEnumerable : struct, IStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
            where TFunc : IFunction<T,Int64>
        {
            var sumVisitor = new SumIFunctionInt64Visitor<T, TFunc>(0, func);
            enumerable.Visit(ref sumVisitor);
            return sumVisitor.sum;         }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Int64 SumInt64<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, IStructEnumerator<Int64>
        {
            Int64 result = 0;
            while (enumerator.MoveNext())
            {
                result += enumerator.Current;
            }
            enumerator.Dispose();
            return result;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Int64 SumInt64<T,TEnumerator, TFunc>(ref TEnumerator enumerator, ref TFunc func)
            where TEnumerator : struct, IStructEnumerator<T>
            where TFunc : IFunction<T,Int64>
        {
            Int64 result = 0;
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                result += func.Eval(current);
            }
            enumerator.Dispose();
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Int64 SumInt64<T,TEnumerator>(ref TEnumerator enumerator, Func<T, Int64> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            Int64 result = 0;
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                result += func(current);
            }
            enumerator.Dispose();
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 Sum<TEnumerator>(this IDirectStructCollection<Int64, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<Int64>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumInt64(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 Sum<TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TEnumerable, IDirectStructCollection<Int64, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<Int64>
            where TEnumerable : struct, IDirectStructCollection<Int64, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumInt64(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 Sum<T,TEnumerator>(this IDirectStructCollection<T, TEnumerator> enumerable, Func<T, Int64> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumInt64(ref enumerator, func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 Sum<T,TEnumerable,TEnumerator>(this TEnumerable enumerable, 
        Func<T, Int64> func, 
        Func<TEnumerable, IDirectStructCollection<T, TEnumerator>> _)
            where TEnumerable : struct, IDirectStructCollection<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumInt64(ref enumerator, func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 Sum<T,TEnumerator>(this IDirectStructCollection<T, TEnumerator> enumerable, 
        IFunction<T,Int64> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumInt64<T,TEnumerator, IFunction<T,Int64>>(ref enumerator, ref func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 Sum<T,TEnumerable,TEnumerator, TFunc>(this TEnumerable enumerable,
            ref TFunc func, 
            Func<TEnumerable, IDirectStructCollection<T, TEnumerator>> _,
            Func<TFunc, IFunction<T,Int64>> __)
            where TEnumerable : struct, IDirectStructCollection<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
            where TFunc : IFunction<T,Int64>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumInt64<T,TEnumerator, TFunc>(ref enumerator,ref func);
        }

    }


    public static partial class StructEnumerable
    {
            private struct SumUInt16Visitor : IVisitor<UInt16>
        {
            public UInt16 sum;
            public SumUInt16Visitor(UInt16 sum)
            {
                this.sum = sum;
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Visit(UInt16 input)
            {
                sum += input;
                return true;
            }
        }

            private struct SumFuncUInt16Visitor<T> : IVisitor<T>
        {
            public UInt16 sum;
            private readonly Func<T, UInt16> func;
            public SumFuncUInt16Visitor(UInt16 sum, Func<T, UInt16> func)
            {
                this.sum = sum;
                this.func = func;
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Visit(T input)
            {
                sum += func(input);
                return true;
            }
        }

        private struct SumIFunctionUInt16Visitor<T, TFunc> : IVisitor<T>
            where TFunc : IFunction<T, UInt16>
        {
            public UInt16 sum;
            private readonly TFunc func;
            public SumIFunctionUInt16Visitor(UInt16 sum, TFunc func)
            {
                this.sum = sum;
                this.func = func;
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Visit(T input)
            {
                sum += func.Eval(input);
                return true;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 Sum<TEnumerator>(this IStructEnumerable<UInt16, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<UInt16>
        {
            var sumVisitor = new SumUInt16Visitor(0);
            enumerable.Visit(ref sumVisitor);
            return sumVisitor.sum;      
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 Sum<TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TEnumerable, IStructEnumerable<UInt16, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<UInt16>
            where TEnumerable : struct, IStructEnumerable<UInt16, TEnumerator>
        {
            var sumVisitor = new SumUInt16Visitor(0);
            enumerable.Visit(ref sumVisitor);
            return sumVisitor.sum;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 Sum<T,TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, Func<T, UInt16> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var sumVisitor = new SumFuncUInt16Visitor<T>(0, func);
            enumerable.Visit(ref sumVisitor);
            return sumVisitor.sum;        
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 Sum<T,TEnumerable,TEnumerator>(this TEnumerable enumerable, 
        Func<T, UInt16> func, 
        Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var sumVisitor = new SumFuncUInt16Visitor<T>(0, func);
            enumerable.Visit(ref sumVisitor);
            return sumVisitor.sum; 
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 Sum<T,TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, 
        IFunction<T,UInt16> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var sumVisitor = new SumIFunctionUInt16Visitor<T, IFunction<T,UInt16>>(0, func);
            enumerable.Visit(ref sumVisitor);
            return sumVisitor.sum; 
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 Sum<T,TEnumerable,TEnumerator, TFunc>(this TEnumerable enumerable,
            ref TFunc func, 
            Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _,
            Func<TFunc, IFunction<T,UInt16>> __)
            where TEnumerable : struct, IStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
            where TFunc : IFunction<T,UInt16>
        {
            var sumVisitor = new SumIFunctionUInt16Visitor<T, TFunc>(0, func);
            enumerable.Visit(ref sumVisitor);
            return sumVisitor.sum;         }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static UInt16 SumUInt16<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, IStructEnumerator<UInt16>
        {
            UInt16 result = 0;
            while (enumerator.MoveNext())
            {
                result += enumerator.Current;
            }
            enumerator.Dispose();
            return result;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static UInt16 SumUInt16<T,TEnumerator, TFunc>(ref TEnumerator enumerator, ref TFunc func)
            where TEnumerator : struct, IStructEnumerator<T>
            where TFunc : IFunction<T,UInt16>
        {
            UInt16 result = 0;
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                result += func.Eval(current);
            }
            enumerator.Dispose();
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static UInt16 SumUInt16<T,TEnumerator>(ref TEnumerator enumerator, Func<T, UInt16> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            UInt16 result = 0;
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                result += func(current);
            }
            enumerator.Dispose();
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 Sum<TEnumerator>(this IDirectStructCollection<UInt16, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<UInt16>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumUInt16(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 Sum<TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TEnumerable, IDirectStructCollection<UInt16, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<UInt16>
            where TEnumerable : struct, IDirectStructCollection<UInt16, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumUInt16(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 Sum<T,TEnumerator>(this IDirectStructCollection<T, TEnumerator> enumerable, Func<T, UInt16> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumUInt16(ref enumerator, func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 Sum<T,TEnumerable,TEnumerator>(this TEnumerable enumerable, 
        Func<T, UInt16> func, 
        Func<TEnumerable, IDirectStructCollection<T, TEnumerator>> _)
            where TEnumerable : struct, IDirectStructCollection<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumUInt16(ref enumerator, func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 Sum<T,TEnumerator>(this IDirectStructCollection<T, TEnumerator> enumerable, 
        IFunction<T,UInt16> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumUInt16<T,TEnumerator, IFunction<T,UInt16>>(ref enumerator, ref func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 Sum<T,TEnumerable,TEnumerator, TFunc>(this TEnumerable enumerable,
            ref TFunc func, 
            Func<TEnumerable, IDirectStructCollection<T, TEnumerator>> _,
            Func<TFunc, IFunction<T,UInt16>> __)
            where TEnumerable : struct, IDirectStructCollection<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
            where TFunc : IFunction<T,UInt16>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumUInt16<T,TEnumerator, TFunc>(ref enumerator,ref func);
        }

    }


    public static partial class StructEnumerable
    {
            private struct SumUInt32Visitor : IVisitor<UInt32>
        {
            public UInt32 sum;
            public SumUInt32Visitor(UInt32 sum)
            {
                this.sum = sum;
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Visit(UInt32 input)
            {
                sum += input;
                return true;
            }
        }

            private struct SumFuncUInt32Visitor<T> : IVisitor<T>
        {
            public UInt32 sum;
            private readonly Func<T, UInt32> func;
            public SumFuncUInt32Visitor(UInt32 sum, Func<T, UInt32> func)
            {
                this.sum = sum;
                this.func = func;
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Visit(T input)
            {
                sum += func(input);
                return true;
            }
        }

        private struct SumIFunctionUInt32Visitor<T, TFunc> : IVisitor<T>
            where TFunc : IFunction<T, UInt32>
        {
            public UInt32 sum;
            private readonly TFunc func;
            public SumIFunctionUInt32Visitor(UInt32 sum, TFunc func)
            {
                this.sum = sum;
                this.func = func;
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Visit(T input)
            {
                sum += func.Eval(input);
                return true;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 Sum<TEnumerator>(this IStructEnumerable<UInt32, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<UInt32>
        {
            var sumVisitor = new SumUInt32Visitor(0);
            enumerable.Visit(ref sumVisitor);
            return sumVisitor.sum;      
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 Sum<TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TEnumerable, IStructEnumerable<UInt32, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<UInt32>
            where TEnumerable : struct, IStructEnumerable<UInt32, TEnumerator>
        {
            var sumVisitor = new SumUInt32Visitor(0);
            enumerable.Visit(ref sumVisitor);
            return sumVisitor.sum;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 Sum<T,TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, Func<T, UInt32> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var sumVisitor = new SumFuncUInt32Visitor<T>(0, func);
            enumerable.Visit(ref sumVisitor);
            return sumVisitor.sum;        
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 Sum<T,TEnumerable,TEnumerator>(this TEnumerable enumerable, 
        Func<T, UInt32> func, 
        Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var sumVisitor = new SumFuncUInt32Visitor<T>(0, func);
            enumerable.Visit(ref sumVisitor);
            return sumVisitor.sum; 
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 Sum<T,TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, 
        IFunction<T,UInt32> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var sumVisitor = new SumIFunctionUInt32Visitor<T, IFunction<T,UInt32>>(0, func);
            enumerable.Visit(ref sumVisitor);
            return sumVisitor.sum; 
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 Sum<T,TEnumerable,TEnumerator, TFunc>(this TEnumerable enumerable,
            ref TFunc func, 
            Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _,
            Func<TFunc, IFunction<T,UInt32>> __)
            where TEnumerable : struct, IStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
            where TFunc : IFunction<T,UInt32>
        {
            var sumVisitor = new SumIFunctionUInt32Visitor<T, TFunc>(0, func);
            enumerable.Visit(ref sumVisitor);
            return sumVisitor.sum;         }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static UInt32 SumUInt32<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, IStructEnumerator<UInt32>
        {
            UInt32 result = 0;
            while (enumerator.MoveNext())
            {
                result += enumerator.Current;
            }
            enumerator.Dispose();
            return result;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static UInt32 SumUInt32<T,TEnumerator, TFunc>(ref TEnumerator enumerator, ref TFunc func)
            where TEnumerator : struct, IStructEnumerator<T>
            where TFunc : IFunction<T,UInt32>
        {
            UInt32 result = 0;
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                result += func.Eval(current);
            }
            enumerator.Dispose();
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static UInt32 SumUInt32<T,TEnumerator>(ref TEnumerator enumerator, Func<T, UInt32> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            UInt32 result = 0;
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                result += func(current);
            }
            enumerator.Dispose();
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 Sum<TEnumerator>(this IDirectStructCollection<UInt32, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<UInt32>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumUInt32(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 Sum<TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TEnumerable, IDirectStructCollection<UInt32, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<UInt32>
            where TEnumerable : struct, IDirectStructCollection<UInt32, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumUInt32(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 Sum<T,TEnumerator>(this IDirectStructCollection<T, TEnumerator> enumerable, Func<T, UInt32> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumUInt32(ref enumerator, func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 Sum<T,TEnumerable,TEnumerator>(this TEnumerable enumerable, 
        Func<T, UInt32> func, 
        Func<TEnumerable, IDirectStructCollection<T, TEnumerator>> _)
            where TEnumerable : struct, IDirectStructCollection<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumUInt32(ref enumerator, func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 Sum<T,TEnumerator>(this IDirectStructCollection<T, TEnumerator> enumerable, 
        IFunction<T,UInt32> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumUInt32<T,TEnumerator, IFunction<T,UInt32>>(ref enumerator, ref func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 Sum<T,TEnumerable,TEnumerator, TFunc>(this TEnumerable enumerable,
            ref TFunc func, 
            Func<TEnumerable, IDirectStructCollection<T, TEnumerator>> _,
            Func<TFunc, IFunction<T,UInt32>> __)
            where TEnumerable : struct, IDirectStructCollection<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
            where TFunc : IFunction<T,UInt32>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumUInt32<T,TEnumerator, TFunc>(ref enumerator,ref func);
        }

    }


    public static partial class StructEnumerable
    {
            private struct SumUInt64Visitor : IVisitor<UInt64>
        {
            public UInt64 sum;
            public SumUInt64Visitor(UInt64 sum)
            {
                this.sum = sum;
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Visit(UInt64 input)
            {
                sum += input;
                return true;
            }
        }

            private struct SumFuncUInt64Visitor<T> : IVisitor<T>
        {
            public UInt64 sum;
            private readonly Func<T, UInt64> func;
            public SumFuncUInt64Visitor(UInt64 sum, Func<T, UInt64> func)
            {
                this.sum = sum;
                this.func = func;
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Visit(T input)
            {
                sum += func(input);
                return true;
            }
        }

        private struct SumIFunctionUInt64Visitor<T, TFunc> : IVisitor<T>
            where TFunc : IFunction<T, UInt64>
        {
            public UInt64 sum;
            private readonly TFunc func;
            public SumIFunctionUInt64Visitor(UInt64 sum, TFunc func)
            {
                this.sum = sum;
                this.func = func;
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Visit(T input)
            {
                sum += func.Eval(input);
                return true;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 Sum<TEnumerator>(this IStructEnumerable<UInt64, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<UInt64>
        {
            var sumVisitor = new SumUInt64Visitor(0);
            enumerable.Visit(ref sumVisitor);
            return sumVisitor.sum;      
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 Sum<TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TEnumerable, IStructEnumerable<UInt64, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<UInt64>
            where TEnumerable : struct, IStructEnumerable<UInt64, TEnumerator>
        {
            var sumVisitor = new SumUInt64Visitor(0);
            enumerable.Visit(ref sumVisitor);
            return sumVisitor.sum;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 Sum<T,TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, Func<T, UInt64> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var sumVisitor = new SumFuncUInt64Visitor<T>(0, func);
            enumerable.Visit(ref sumVisitor);
            return sumVisitor.sum;        
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 Sum<T,TEnumerable,TEnumerator>(this TEnumerable enumerable, 
        Func<T, UInt64> func, 
        Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var sumVisitor = new SumFuncUInt64Visitor<T>(0, func);
            enumerable.Visit(ref sumVisitor);
            return sumVisitor.sum; 
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 Sum<T,TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, 
        IFunction<T,UInt64> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var sumVisitor = new SumIFunctionUInt64Visitor<T, IFunction<T,UInt64>>(0, func);
            enumerable.Visit(ref sumVisitor);
            return sumVisitor.sum; 
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 Sum<T,TEnumerable,TEnumerator, TFunc>(this TEnumerable enumerable,
            ref TFunc func, 
            Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _,
            Func<TFunc, IFunction<T,UInt64>> __)
            where TEnumerable : struct, IStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
            where TFunc : IFunction<T,UInt64>
        {
            var sumVisitor = new SumIFunctionUInt64Visitor<T, TFunc>(0, func);
            enumerable.Visit(ref sumVisitor);
            return sumVisitor.sum;         }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static UInt64 SumUInt64<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, IStructEnumerator<UInt64>
        {
            UInt64 result = 0;
            while (enumerator.MoveNext())
            {
                result += enumerator.Current;
            }
            enumerator.Dispose();
            return result;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static UInt64 SumUInt64<T,TEnumerator, TFunc>(ref TEnumerator enumerator, ref TFunc func)
            where TEnumerator : struct, IStructEnumerator<T>
            where TFunc : IFunction<T,UInt64>
        {
            UInt64 result = 0;
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                result += func.Eval(current);
            }
            enumerator.Dispose();
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static UInt64 SumUInt64<T,TEnumerator>(ref TEnumerator enumerator, Func<T, UInt64> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            UInt64 result = 0;
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                result += func(current);
            }
            enumerator.Dispose();
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 Sum<TEnumerator>(this IDirectStructCollection<UInt64, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<UInt64>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumUInt64(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 Sum<TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TEnumerable, IDirectStructCollection<UInt64, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<UInt64>
            where TEnumerable : struct, IDirectStructCollection<UInt64, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumUInt64(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 Sum<T,TEnumerator>(this IDirectStructCollection<T, TEnumerator> enumerable, Func<T, UInt64> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumUInt64(ref enumerator, func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 Sum<T,TEnumerable,TEnumerator>(this TEnumerable enumerable, 
        Func<T, UInt64> func, 
        Func<TEnumerable, IDirectStructCollection<T, TEnumerator>> _)
            where TEnumerable : struct, IDirectStructCollection<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumUInt64(ref enumerator, func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 Sum<T,TEnumerator>(this IDirectStructCollection<T, TEnumerator> enumerable, 
        IFunction<T,UInt64> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumUInt64<T,TEnumerator, IFunction<T,UInt64>>(ref enumerator, ref func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 Sum<T,TEnumerable,TEnumerator, TFunc>(this TEnumerable enumerable,
            ref TFunc func, 
            Func<TEnumerable, IDirectStructCollection<T, TEnumerator>> _,
            Func<TFunc, IFunction<T,UInt64>> __)
            where TEnumerable : struct, IDirectStructCollection<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
            where TFunc : IFunction<T,UInt64>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumUInt64<T,TEnumerator, TFunc>(ref enumerator,ref func);
        }

    }


    public static partial class StructEnumerable
    {
            private struct SumSingleVisitor : IVisitor<Single>
        {
            public Single sum;
            public SumSingleVisitor(Single sum)
            {
                this.sum = sum;
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Visit(Single input)
            {
                sum += input;
                return true;
            }
        }

            private struct SumFuncSingleVisitor<T> : IVisitor<T>
        {
            public Single sum;
            private readonly Func<T, Single> func;
            public SumFuncSingleVisitor(Single sum, Func<T, Single> func)
            {
                this.sum = sum;
                this.func = func;
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Visit(T input)
            {
                sum += func(input);
                return true;
            }
        }

        private struct SumIFunctionSingleVisitor<T, TFunc> : IVisitor<T>
            where TFunc : IFunction<T, Single>
        {
            public Single sum;
            private readonly TFunc func;
            public SumIFunctionSingleVisitor(Single sum, TFunc func)
            {
                this.sum = sum;
                this.func = func;
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Visit(T input)
            {
                sum += func.Eval(input);
                return true;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single Sum<TEnumerator>(this IStructEnumerable<Single, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<Single>
        {
            var sumVisitor = new SumSingleVisitor(0);
            enumerable.Visit(ref sumVisitor);
            return sumVisitor.sum;      
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single Sum<TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TEnumerable, IStructEnumerable<Single, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<Single>
            where TEnumerable : struct, IStructEnumerable<Single, TEnumerator>
        {
            var sumVisitor = new SumSingleVisitor(0);
            enumerable.Visit(ref sumVisitor);
            return sumVisitor.sum;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single Sum<T,TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, Func<T, Single> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var sumVisitor = new SumFuncSingleVisitor<T>(0, func);
            enumerable.Visit(ref sumVisitor);
            return sumVisitor.sum;        
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single Sum<T,TEnumerable,TEnumerator>(this TEnumerable enumerable, 
        Func<T, Single> func, 
        Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var sumVisitor = new SumFuncSingleVisitor<T>(0, func);
            enumerable.Visit(ref sumVisitor);
            return sumVisitor.sum; 
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single Sum<T,TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, 
        IFunction<T,Single> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var sumVisitor = new SumIFunctionSingleVisitor<T, IFunction<T,Single>>(0, func);
            enumerable.Visit(ref sumVisitor);
            return sumVisitor.sum; 
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single Sum<T,TEnumerable,TEnumerator, TFunc>(this TEnumerable enumerable,
            ref TFunc func, 
            Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _,
            Func<TFunc, IFunction<T,Single>> __)
            where TEnumerable : struct, IStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
            where TFunc : IFunction<T,Single>
        {
            var sumVisitor = new SumIFunctionSingleVisitor<T, TFunc>(0, func);
            enumerable.Visit(ref sumVisitor);
            return sumVisitor.sum;         }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Single SumSingle<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, IStructEnumerator<Single>
        {
            Single result = 0;
            while (enumerator.MoveNext())
            {
                result += enumerator.Current;
            }
            enumerator.Dispose();
            return result;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Single SumSingle<T,TEnumerator, TFunc>(ref TEnumerator enumerator, ref TFunc func)
            where TEnumerator : struct, IStructEnumerator<T>
            where TFunc : IFunction<T,Single>
        {
            Single result = 0;
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                result += func.Eval(current);
            }
            enumerator.Dispose();
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Single SumSingle<T,TEnumerator>(ref TEnumerator enumerator, Func<T, Single> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            Single result = 0;
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                result += func(current);
            }
            enumerator.Dispose();
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single Sum<TEnumerator>(this IDirectStructCollection<Single, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<Single>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumSingle(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single Sum<TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TEnumerable, IDirectStructCollection<Single, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<Single>
            where TEnumerable : struct, IDirectStructCollection<Single, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumSingle(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single Sum<T,TEnumerator>(this IDirectStructCollection<T, TEnumerator> enumerable, Func<T, Single> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumSingle(ref enumerator, func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single Sum<T,TEnumerable,TEnumerator>(this TEnumerable enumerable, 
        Func<T, Single> func, 
        Func<TEnumerable, IDirectStructCollection<T, TEnumerator>> _)
            where TEnumerable : struct, IDirectStructCollection<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumSingle(ref enumerator, func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single Sum<T,TEnumerator>(this IDirectStructCollection<T, TEnumerator> enumerable, 
        IFunction<T,Single> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumSingle<T,TEnumerator, IFunction<T,Single>>(ref enumerator, ref func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single Sum<T,TEnumerable,TEnumerator, TFunc>(this TEnumerable enumerable,
            ref TFunc func, 
            Func<TEnumerable, IDirectStructCollection<T, TEnumerator>> _,
            Func<TFunc, IFunction<T,Single>> __)
            where TEnumerable : struct, IDirectStructCollection<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
            where TFunc : IFunction<T,Single>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumSingle<T,TEnumerator, TFunc>(ref enumerator,ref func);
        }

    }


    public static partial class StructEnumerable
    {
            private struct SumDoubleVisitor : IVisitor<Double>
        {
            public Double sum;
            public SumDoubleVisitor(Double sum)
            {
                this.sum = sum;
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Visit(Double input)
            {
                sum += input;
                return true;
            }
        }

            private struct SumFuncDoubleVisitor<T> : IVisitor<T>
        {
            public Double sum;
            private readonly Func<T, Double> func;
            public SumFuncDoubleVisitor(Double sum, Func<T, Double> func)
            {
                this.sum = sum;
                this.func = func;
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Visit(T input)
            {
                sum += func(input);
                return true;
            }
        }

        private struct SumIFunctionDoubleVisitor<T, TFunc> : IVisitor<T>
            where TFunc : IFunction<T, Double>
        {
            public Double sum;
            private readonly TFunc func;
            public SumIFunctionDoubleVisitor(Double sum, TFunc func)
            {
                this.sum = sum;
                this.func = func;
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Visit(T input)
            {
                sum += func.Eval(input);
                return true;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double Sum<TEnumerator>(this IStructEnumerable<Double, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<Double>
        {
            var sumVisitor = new SumDoubleVisitor(0);
            enumerable.Visit(ref sumVisitor);
            return sumVisitor.sum;      
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double Sum<TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TEnumerable, IStructEnumerable<Double, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<Double>
            where TEnumerable : struct, IStructEnumerable<Double, TEnumerator>
        {
            var sumVisitor = new SumDoubleVisitor(0);
            enumerable.Visit(ref sumVisitor);
            return sumVisitor.sum;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double Sum<T,TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, Func<T, Double> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var sumVisitor = new SumFuncDoubleVisitor<T>(0, func);
            enumerable.Visit(ref sumVisitor);
            return sumVisitor.sum;        
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double Sum<T,TEnumerable,TEnumerator>(this TEnumerable enumerable, 
        Func<T, Double> func, 
        Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var sumVisitor = new SumFuncDoubleVisitor<T>(0, func);
            enumerable.Visit(ref sumVisitor);
            return sumVisitor.sum; 
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double Sum<T,TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, 
        IFunction<T,Double> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var sumVisitor = new SumIFunctionDoubleVisitor<T, IFunction<T,Double>>(0, func);
            enumerable.Visit(ref sumVisitor);
            return sumVisitor.sum; 
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double Sum<T,TEnumerable,TEnumerator, TFunc>(this TEnumerable enumerable,
            ref TFunc func, 
            Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _,
            Func<TFunc, IFunction<T,Double>> __)
            where TEnumerable : struct, IStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
            where TFunc : IFunction<T,Double>
        {
            var sumVisitor = new SumIFunctionDoubleVisitor<T, TFunc>(0, func);
            enumerable.Visit(ref sumVisitor);
            return sumVisitor.sum;         }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Double SumDouble<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, IStructEnumerator<Double>
        {
            Double result = 0;
            while (enumerator.MoveNext())
            {
                result += enumerator.Current;
            }
            enumerator.Dispose();
            return result;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Double SumDouble<T,TEnumerator, TFunc>(ref TEnumerator enumerator, ref TFunc func)
            where TEnumerator : struct, IStructEnumerator<T>
            where TFunc : IFunction<T,Double>
        {
            Double result = 0;
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                result += func.Eval(current);
            }
            enumerator.Dispose();
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Double SumDouble<T,TEnumerator>(ref TEnumerator enumerator, Func<T, Double> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            Double result = 0;
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                result += func(current);
            }
            enumerator.Dispose();
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double Sum<TEnumerator>(this IDirectStructCollection<Double, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<Double>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumDouble(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double Sum<TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TEnumerable, IDirectStructCollection<Double, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<Double>
            where TEnumerable : struct, IDirectStructCollection<Double, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumDouble(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double Sum<T,TEnumerator>(this IDirectStructCollection<T, TEnumerator> enumerable, Func<T, Double> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumDouble(ref enumerator, func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double Sum<T,TEnumerable,TEnumerator>(this TEnumerable enumerable, 
        Func<T, Double> func, 
        Func<TEnumerable, IDirectStructCollection<T, TEnumerator>> _)
            where TEnumerable : struct, IDirectStructCollection<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumDouble(ref enumerator, func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double Sum<T,TEnumerator>(this IDirectStructCollection<T, TEnumerator> enumerable, 
        IFunction<T,Double> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumDouble<T,TEnumerator, IFunction<T,Double>>(ref enumerator, ref func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double Sum<T,TEnumerable,TEnumerator, TFunc>(this TEnumerable enumerable,
            ref TFunc func, 
            Func<TEnumerable, IDirectStructCollection<T, TEnumerator>> _,
            Func<TFunc, IFunction<T,Double>> __)
            where TEnumerable : struct, IDirectStructCollection<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
            where TFunc : IFunction<T,Double>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumDouble<T,TEnumerator, TFunc>(ref enumerator,ref func);
        }

    }


    public static partial class StructEnumerable
    {
            private struct SumByteVisitor : IVisitor<Byte>
        {
            public Byte sum;
            public SumByteVisitor(Byte sum)
            {
                this.sum = sum;
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Visit(Byte input)
            {
                sum += input;
                return true;
            }
        }

            private struct SumFuncByteVisitor<T> : IVisitor<T>
        {
            public Byte sum;
            private readonly Func<T, Byte> func;
            public SumFuncByteVisitor(Byte sum, Func<T, Byte> func)
            {
                this.sum = sum;
                this.func = func;
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Visit(T input)
            {
                sum += func(input);
                return true;
            }
        }

        private struct SumIFunctionByteVisitor<T, TFunc> : IVisitor<T>
            where TFunc : IFunction<T, Byte>
        {
            public Byte sum;
            private readonly TFunc func;
            public SumIFunctionByteVisitor(Byte sum, TFunc func)
            {
                this.sum = sum;
                this.func = func;
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Visit(T input)
            {
                sum += func.Eval(input);
                return true;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte Sum<TEnumerator>(this IStructEnumerable<Byte, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<Byte>
        {
            var sumVisitor = new SumByteVisitor(0);
            enumerable.Visit(ref sumVisitor);
            return sumVisitor.sum;      
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte Sum<TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TEnumerable, IStructEnumerable<Byte, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<Byte>
            where TEnumerable : struct, IStructEnumerable<Byte, TEnumerator>
        {
            var sumVisitor = new SumByteVisitor(0);
            enumerable.Visit(ref sumVisitor);
            return sumVisitor.sum;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte Sum<T,TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, Func<T, Byte> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var sumVisitor = new SumFuncByteVisitor<T>(0, func);
            enumerable.Visit(ref sumVisitor);
            return sumVisitor.sum;        
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte Sum<T,TEnumerable,TEnumerator>(this TEnumerable enumerable, 
        Func<T, Byte> func, 
        Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var sumVisitor = new SumFuncByteVisitor<T>(0, func);
            enumerable.Visit(ref sumVisitor);
            return sumVisitor.sum; 
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte Sum<T,TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, 
        IFunction<T,Byte> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var sumVisitor = new SumIFunctionByteVisitor<T, IFunction<T,Byte>>(0, func);
            enumerable.Visit(ref sumVisitor);
            return sumVisitor.sum; 
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte Sum<T,TEnumerable,TEnumerator, TFunc>(this TEnumerable enumerable,
            ref TFunc func, 
            Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _,
            Func<TFunc, IFunction<T,Byte>> __)
            where TEnumerable : struct, IStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
            where TFunc : IFunction<T,Byte>
        {
            var sumVisitor = new SumIFunctionByteVisitor<T, TFunc>(0, func);
            enumerable.Visit(ref sumVisitor);
            return sumVisitor.sum;         }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Byte SumByte<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, IStructEnumerator<Byte>
        {
            Byte result = 0;
            while (enumerator.MoveNext())
            {
                result += enumerator.Current;
            }
            enumerator.Dispose();
            return result;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Byte SumByte<T,TEnumerator, TFunc>(ref TEnumerator enumerator, ref TFunc func)
            where TEnumerator : struct, IStructEnumerator<T>
            where TFunc : IFunction<T,Byte>
        {
            Byte result = 0;
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                result += func.Eval(current);
            }
            enumerator.Dispose();
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Byte SumByte<T,TEnumerator>(ref TEnumerator enumerator, Func<T, Byte> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            Byte result = 0;
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                result += func(current);
            }
            enumerator.Dispose();
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte Sum<TEnumerator>(this IDirectStructCollection<Byte, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<Byte>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumByte(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte Sum<TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TEnumerable, IDirectStructCollection<Byte, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<Byte>
            where TEnumerable : struct, IDirectStructCollection<Byte, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumByte(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte Sum<T,TEnumerator>(this IDirectStructCollection<T, TEnumerator> enumerable, Func<T, Byte> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumByte(ref enumerator, func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte Sum<T,TEnumerable,TEnumerator>(this TEnumerable enumerable, 
        Func<T, Byte> func, 
        Func<TEnumerable, IDirectStructCollection<T, TEnumerator>> _)
            where TEnumerable : struct, IDirectStructCollection<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumByte(ref enumerator, func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte Sum<T,TEnumerator>(this IDirectStructCollection<T, TEnumerator> enumerable, 
        IFunction<T,Byte> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumByte<T,TEnumerator, IFunction<T,Byte>>(ref enumerator, ref func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte Sum<T,TEnumerable,TEnumerator, TFunc>(this TEnumerable enumerable,
            ref TFunc func, 
            Func<TEnumerable, IDirectStructCollection<T, TEnumerator>> _,
            Func<TFunc, IFunction<T,Byte>> __)
            where TEnumerable : struct, IDirectStructCollection<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
            where TFunc : IFunction<T,Byte>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumByte<T,TEnumerator, TFunc>(ref enumerator,ref func);
        }

    }


    public static partial class StructEnumerable
    {
            private struct SumSByteVisitor : IVisitor<SByte>
        {
            public SByte sum;
            public SumSByteVisitor(SByte sum)
            {
                this.sum = sum;
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Visit(SByte input)
            {
                sum += input;
                return true;
            }
        }

            private struct SumFuncSByteVisitor<T> : IVisitor<T>
        {
            public SByte sum;
            private readonly Func<T, SByte> func;
            public SumFuncSByteVisitor(SByte sum, Func<T, SByte> func)
            {
                this.sum = sum;
                this.func = func;
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Visit(T input)
            {
                sum += func(input);
                return true;
            }
        }

        private struct SumIFunctionSByteVisitor<T, TFunc> : IVisitor<T>
            where TFunc : IFunction<T, SByte>
        {
            public SByte sum;
            private readonly TFunc func;
            public SumIFunctionSByteVisitor(SByte sum, TFunc func)
            {
                this.sum = sum;
                this.func = func;
            }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Visit(T input)
            {
                sum += func.Eval(input);
                return true;
            }
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte Sum<TEnumerator>(this IStructEnumerable<SByte, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<SByte>
        {
            var sumVisitor = new SumSByteVisitor(0);
            enumerable.Visit(ref sumVisitor);
            return sumVisitor.sum;      
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte Sum<TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TEnumerable, IStructEnumerable<SByte, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<SByte>
            where TEnumerable : struct, IStructEnumerable<SByte, TEnumerator>
        {
            var sumVisitor = new SumSByteVisitor(0);
            enumerable.Visit(ref sumVisitor);
            return sumVisitor.sum;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte Sum<T,TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, Func<T, SByte> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var sumVisitor = new SumFuncSByteVisitor<T>(0, func);
            enumerable.Visit(ref sumVisitor);
            return sumVisitor.sum;        
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte Sum<T,TEnumerable,TEnumerator>(this TEnumerable enumerable, 
        Func<T, SByte> func, 
        Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _)
            where TEnumerable : struct, IStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var sumVisitor = new SumFuncSByteVisitor<T>(0, func);
            enumerable.Visit(ref sumVisitor);
            return sumVisitor.sum; 
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte Sum<T,TEnumerator>(this IStructEnumerable<T, TEnumerator> enumerable, 
        IFunction<T,SByte> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var sumVisitor = new SumIFunctionSByteVisitor<T, IFunction<T,SByte>>(0, func);
            enumerable.Visit(ref sumVisitor);
            return sumVisitor.sum; 
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte Sum<T,TEnumerable,TEnumerator, TFunc>(this TEnumerable enumerable,
            ref TFunc func, 
            Func<TEnumerable, IStructEnumerable<T, TEnumerator>> _,
            Func<TFunc, IFunction<T,SByte>> __)
            where TEnumerable : struct, IStructEnumerable<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
            where TFunc : IFunction<T,SByte>
        {
            var sumVisitor = new SumIFunctionSByteVisitor<T, TFunc>(0, func);
            enumerable.Visit(ref sumVisitor);
            return sumVisitor.sum;         }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static SByte SumSByte<TEnumerator>(ref TEnumerator enumerator)
            where TEnumerator : struct, IStructEnumerator<SByte>
        {
            SByte result = 0;
            while (enumerator.MoveNext())
            {
                result += enumerator.Current;
            }
            enumerator.Dispose();
            return result;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static SByte SumSByte<T,TEnumerator, TFunc>(ref TEnumerator enumerator, ref TFunc func)
            where TEnumerator : struct, IStructEnumerator<T>
            where TFunc : IFunction<T,SByte>
        {
            SByte result = 0;
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                result += func.Eval(current);
            }
            enumerator.Dispose();
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static SByte SumSByte<T,TEnumerator>(ref TEnumerator enumerator, Func<T, SByte> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            SByte result = 0;
            while (enumerator.MoveNext())
            {
                var current = enumerator.Current;
                result += func(current);
            }
            enumerator.Dispose();
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte Sum<TEnumerator>(this IDirectStructCollection<SByte, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<SByte>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumSByte(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte Sum<TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TEnumerable, IDirectStructCollection<SByte, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<SByte>
            where TEnumerable : struct, IDirectStructCollection<SByte, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumSByte(ref enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte Sum<T,TEnumerator>(this IDirectStructCollection<T, TEnumerator> enumerable, Func<T, SByte> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumSByte(ref enumerator, func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte Sum<T,TEnumerable,TEnumerator>(this TEnumerable enumerable, 
        Func<T, SByte> func, 
        Func<TEnumerable, IDirectStructCollection<T, TEnumerator>> _)
            where TEnumerable : struct, IDirectStructCollection<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumSByte(ref enumerator, func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte Sum<T,TEnumerator>(this IDirectStructCollection<T, TEnumerator> enumerable, 
        IFunction<T,SByte> func)
            where TEnumerator : struct, IStructEnumerator<T>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumSByte<T,TEnumerator, IFunction<T,SByte>>(ref enumerator, ref func);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte Sum<T,TEnumerable,TEnumerator, TFunc>(this TEnumerable enumerable,
            ref TFunc func, 
            Func<TEnumerable, IDirectStructCollection<T, TEnumerator>> _,
            Func<TFunc, IFunction<T,SByte>> __)
            where TEnumerable : struct, IDirectStructCollection<T, TEnumerator>
            where TEnumerator : struct, IStructEnumerator<T>
            where TFunc : IFunction<T,SByte>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumSByte<T,TEnumerator, TFunc>(ref enumerator,ref func);
        }

    }

}