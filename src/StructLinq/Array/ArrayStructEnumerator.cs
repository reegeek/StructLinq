using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using InlineIL;
using static InlineIL.IL.Emit;

namespace StructLinq.Array
{
    public struct ArrayStructEnumerator<T> : IEnumerator<T> where T : struct
    {
        #region private fields
        private readonly object array;
        private readonly int endIndex;
        private int index;
        #endregion
        public ArrayStructEnumerator(object array, int endIndex)
        {
            this.array = array;
            this.endIndex = endIndex;
            index = -1;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            return ++index <= endIndex;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
        {
            index = -1;
        }
        readonly object IEnumerator.Current => Current;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void Dispose()
        {
        }
        public readonly T Current
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => Util.ReadValue<T>(array, index);
        }
    }

    public static class Util
    {
        //
        // The offset from an array to the start of the array data is assumed to be 8 bytes for BIT32 and 16 bytes for BIT64 (= 2 x sizeof(object)).
        // This offset was previously computed and stored in a static readonly field but in NetCore this field access introduces
        // a method call that has a strong negative impact on performance.
        //
        // Read<T> returns the element @ address = array + array_data_offset + index x sizeof(object)
        //                                       = array + (index + 2) x sizeof(object)
        //
        // ReadValue<T> returns the element @ address = array + array_data_offset + index x sizeof(T)
        //                                            = array + sizeof(object) + sizeof(object) + index x sizeof(T)
        //

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static T Read<T>(object array, int index)
            where T : class
        {
            IL.DeclareLocals(false, typeof(byte).MakeByRefType());

            Ldarg(nameof(array));
            Stloc_0(); // convert the object pointer to a byref
            Ldloc_0(); // load the object pointer as a byref

            Ldarg(nameof(index));
            Ldc_I4_2();
            Add(); // index + 2

            Sizeof(typeof(object));
            Mul(); // (index + 2) x sizeof(object)

            Add(); // array + (index + 2) x sizeof(object)

            Ldobj(typeof(T)); // load a T value from the computed address

            return IL.Return<T>();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref T ReadValue<T>(object array, int index)
            where T : struct
        {
            IL.DeclareLocals(false, typeof(byte).MakeByRefType());

            Ldarg(nameof(array));
            Stloc_0(); // convert the object pointer to a byref
            Ldloc_0(); // load the object pointer as a byref

            Ldarg(nameof(index));
            Sizeof(typeof(T));
            Mul(); // index x sizeof(T)

            Sizeof(typeof(object));
            Add(); // index x sizeof(T) +  sizeof(object)

            Sizeof(typeof(object));
            Add(); // index x sizeof(T) +  sizeof(object) +  sizeof(object)

            Add(); // array + index x sizeof(T) +  sizeof(object) +  sizeof(object)

            Ret();

            throw IL.Unreachable();
        }
    }

    public struct RefArrayStructEnumerator<T> : IEnumerator<T> where T : class
    {
        #region private fields
        private readonly object array;
        private readonly int endIndex;
        private int index;
        #endregion
        public RefArrayStructEnumerator(object array, int endIndex)
        {
            this.array = array;
            this.endIndex = endIndex;
            index = -1;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool MoveNext()
        {
            return ++index <= endIndex;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
        {
            index = -1;
        }
        readonly object IEnumerator.Current => Current;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public readonly void Dispose()
        {
        }
        public readonly T Current
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => Util.Read<T>(array, index);
        }

    }
}
