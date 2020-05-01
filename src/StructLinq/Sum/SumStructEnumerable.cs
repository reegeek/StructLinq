

// Generated code

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
 

// ReSharper disable once CheckNamespace
namespace StructLinq
{

    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Int16 SumInt16<TEnumerator>(TEnumerator enumerator)
            where TEnumerator : struct, IStructEnumerator<Int16>
        {
            Int16 result = 0;
            while (enumerator.MoveNext())
            {
                result += enumerator.Current;
            }
            return result;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 Sum<TEnumerator>(this IStructEnumerable<Int16, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<Int16>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumInt16(enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int16 Sum<TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TEnumerable, IStructEnumerable<Int16, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<Int16>
            where TEnumerable : struct, IStructEnumerable<Int16, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumInt16(enumerator);
        }

    }


    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Int32 SumInt32<TEnumerator>(TEnumerator enumerator)
            where TEnumerator : struct, IStructEnumerator<Int32>
        {
            Int32 result = 0;
            while (enumerator.MoveNext())
            {
                result += enumerator.Current;
            }
            return result;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 Sum<TEnumerator>(this IStructEnumerable<Int32, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<Int32>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumInt32(enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int32 Sum<TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TEnumerable, IStructEnumerable<Int32, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<Int32>
            where TEnumerable : struct, IStructEnumerable<Int32, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumInt32(enumerator);
        }

    }


    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Int64 SumInt64<TEnumerator>(TEnumerator enumerator)
            where TEnumerator : struct, IStructEnumerator<Int64>
        {
            Int64 result = 0;
            while (enumerator.MoveNext())
            {
                result += enumerator.Current;
            }
            return result;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 Sum<TEnumerator>(this IStructEnumerable<Int64, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<Int64>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumInt64(enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Int64 Sum<TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TEnumerable, IStructEnumerable<Int64, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<Int64>
            where TEnumerable : struct, IStructEnumerable<Int64, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumInt64(enumerator);
        }

    }


    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static UInt16 SumUInt16<TEnumerator>(TEnumerator enumerator)
            where TEnumerator : struct, IStructEnumerator<UInt16>
        {
            UInt16 result = 0;
            while (enumerator.MoveNext())
            {
                result += enumerator.Current;
            }
            return result;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 Sum<TEnumerator>(this IStructEnumerable<UInt16, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<UInt16>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumUInt16(enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt16 Sum<TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TEnumerable, IStructEnumerable<UInt16, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<UInt16>
            where TEnumerable : struct, IStructEnumerable<UInt16, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumUInt16(enumerator);
        }

    }


    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static UInt32 SumUInt32<TEnumerator>(TEnumerator enumerator)
            where TEnumerator : struct, IStructEnumerator<UInt32>
        {
            UInt32 result = 0;
            while (enumerator.MoveNext())
            {
                result += enumerator.Current;
            }
            return result;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 Sum<TEnumerator>(this IStructEnumerable<UInt32, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<UInt32>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumUInt32(enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt32 Sum<TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TEnumerable, IStructEnumerable<UInt32, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<UInt32>
            where TEnumerable : struct, IStructEnumerable<UInt32, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumUInt32(enumerator);
        }

    }


    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static UInt64 SumUInt64<TEnumerator>(TEnumerator enumerator)
            where TEnumerator : struct, IStructEnumerator<UInt64>
        {
            UInt64 result = 0;
            while (enumerator.MoveNext())
            {
                result += enumerator.Current;
            }
            return result;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 Sum<TEnumerator>(this IStructEnumerable<UInt64, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<UInt64>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumUInt64(enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UInt64 Sum<TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TEnumerable, IStructEnumerable<UInt64, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<UInt64>
            where TEnumerable : struct, IStructEnumerable<UInt64, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumUInt64(enumerator);
        }

    }


    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Single SumSingle<TEnumerator>(TEnumerator enumerator)
            where TEnumerator : struct, IStructEnumerator<Single>
        {
            Single result = 0;
            while (enumerator.MoveNext())
            {
                result += enumerator.Current;
            }
            return result;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single Sum<TEnumerator>(this IStructEnumerable<Single, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<Single>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumSingle(enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Single Sum<TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TEnumerable, IStructEnumerable<Single, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<Single>
            where TEnumerable : struct, IStructEnumerable<Single, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumSingle(enumerator);
        }

    }


    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Double SumDouble<TEnumerator>(TEnumerator enumerator)
            where TEnumerator : struct, IStructEnumerator<Double>
        {
            Double result = 0;
            while (enumerator.MoveNext())
            {
                result += enumerator.Current;
            }
            return result;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double Sum<TEnumerator>(this IStructEnumerable<Double, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<Double>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumDouble(enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Double Sum<TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TEnumerable, IStructEnumerable<Double, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<Double>
            where TEnumerable : struct, IStructEnumerable<Double, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumDouble(enumerator);
        }

    }


    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static Byte SumByte<TEnumerator>(TEnumerator enumerator)
            where TEnumerator : struct, IStructEnumerator<Byte>
        {
            Byte result = 0;
            while (enumerator.MoveNext())
            {
                result += enumerator.Current;
            }
            return result;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte Sum<TEnumerator>(this IStructEnumerable<Byte, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<Byte>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumByte(enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Byte Sum<TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TEnumerable, IStructEnumerable<Byte, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<Byte>
            where TEnumerable : struct, IStructEnumerable<Byte, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumByte(enumerator);
        }

    }


    public static partial class StructEnumerable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static SByte SumSByte<TEnumerator>(TEnumerator enumerator)
            where TEnumerator : struct, IStructEnumerator<SByte>
        {
            SByte result = 0;
            while (enumerator.MoveNext())
            {
                result += enumerator.Current;
            }
            return result;
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte Sum<TEnumerator>(this IStructEnumerable<SByte, TEnumerator> enumerable)
            where TEnumerator : struct, IStructEnumerator<SByte>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumSByte(enumerator);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SByte Sum<TEnumerable, TEnumerator>(this TEnumerable enumerable, Func<TEnumerable, IStructEnumerable<SByte, TEnumerator>> _)
            where TEnumerator : struct, IStructEnumerator<SByte>
            where TEnumerable : struct, IStructEnumerable<SByte, TEnumerator>
        {
            var enumerator = enumerable.GetEnumerator();
            return SumSByte(enumerator);
        }

    }

}