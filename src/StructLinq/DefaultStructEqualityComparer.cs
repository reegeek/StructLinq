
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;


namespace StructLinq
{
    public readonly struct DefaultStructEqualityComparer :
        IEqualityComparer<Int16> 
            ,
        IEqualityComparer<Int32> 
            ,
        IEqualityComparer<Int64> 
            ,
        IEqualityComparer<UInt16> 
            ,
        IEqualityComparer<UInt32> 
            ,
        IEqualityComparer<UInt64> 
            ,
        IEqualityComparer<Single> 
            ,
        IEqualityComparer<Double> 
            ,
        IEqualityComparer<Byte> 
            ,
        IEqualityComparer<SByte> 
            ,
        IEqualityComparer<DateTime> 
        {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Equals(Int16 x, Int16 y) => x == y;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public int GetHashCode(Int16 value) => value.GetHashCode();

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Equals(Int32 x, Int32 y) => x == y;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public int GetHashCode(Int32 value) => value.GetHashCode();

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Equals(Int64 x, Int64 y) => x == y;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public int GetHashCode(Int64 value) => value.GetHashCode();

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Equals(UInt16 x, UInt16 y) => x == y;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public int GetHashCode(UInt16 value) => value.GetHashCode();

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Equals(UInt32 x, UInt32 y) => x == y;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public int GetHashCode(UInt32 value) => value.GetHashCode();

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Equals(UInt64 x, UInt64 y) => x == y;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public int GetHashCode(UInt64 value) => value.GetHashCode();

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Equals(Single x, Single y) => x == y;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public int GetHashCode(Single value) => value.GetHashCode();

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Equals(Double x, Double y) => x == y;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public int GetHashCode(Double value) => value.GetHashCode();

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Equals(Byte x, Byte y) => x == y;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public int GetHashCode(Byte value) => value.GetHashCode();

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Equals(SByte x, SByte y) => x == y;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public int GetHashCode(SByte value) => value.GetHashCode();

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Equals(DateTime x, DateTime y) => x == y;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public int GetHashCode(DateTime value) => value.GetHashCode();

    
    }
}
