using System;
using System.Runtime.CompilerServices;
using InlineIL;
using static InlineIL.IL.Emit;
// ReSharper disable EntityNameCapturedOnly.Global

namespace StructLinq.Utils
{
    public static class UnsafeHelpers
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref TTo As<TFrom, TTo>(ref TFrom source)
        {
            Ldarg(nameof(source));
            return ref IL.ReturnRef<TTo>();
        }
    }
}
