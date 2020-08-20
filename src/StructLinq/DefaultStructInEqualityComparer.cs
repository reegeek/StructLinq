
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace StructLinq
{
    public readonly struct DefaultStructInEqualityComparer :
        IInEqualityComparer<Int16> 
            ,
        IInEqualityComparer<Int32> 
            ,
        IInEqualityComparer<Int64> 
            ,
        IInEqualityComparer<UInt16> 
            ,
        IInEqualityComparer<UInt32> 
            ,
        IInEqualityComparer<UInt64> 
            ,
        IInEqualityComparer<Single> 
            ,
        IInEqualityComparer<Double> 
            ,
        IInEqualityComparer<Byte> 
            ,
        IInEqualityComparer<SByte> 
            ,
        IInEqualityComparer<DateTime> 
        {
                 [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Equals(in Int16 x,in Int16 y) => x == y;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public int GetHashCode(in Int16 value) => value.GetHashCode();

                 [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Equals(in Int32 x,in Int32 y) => x == y;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public int GetHashCode(in Int32 value) => value.GetHashCode();

                 [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Equals(in Int64 x,in Int64 y) => x == y;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public int GetHashCode(in Int64 value) => value.GetHashCode();

                 [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Equals(in UInt16 x,in UInt16 y) => x == y;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public int GetHashCode(in UInt16 value) => value.GetHashCode();

                 [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Equals(in UInt32 x,in UInt32 y) => x == y;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public int GetHashCode(in UInt32 value) => value.GetHashCode();

                 [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Equals(in UInt64 x,in UInt64 y) => x == y;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public int GetHashCode(in UInt64 value) => value.GetHashCode();

                 [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Equals(in Single x,in Single y) => x == y;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public int GetHashCode(in Single value) => value.GetHashCode();

                 [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Equals(in Double x,in Double y) => x == y;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public int GetHashCode(in Double value) => value.GetHashCode();

                 [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Equals(in Byte x,in Byte y) => x == y;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public int GetHashCode(in Byte value) => value.GetHashCode();

                 [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Equals(in SByte x,in SByte y) => x == y;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public int GetHashCode(in SByte value) => value.GetHashCode();

                 [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public bool Equals(in DateTime x,in DateTime y) => x == y;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public int GetHashCode(in DateTime value) => value.GetHashCode();

    
    }
}
