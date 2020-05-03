using System.Runtime.CompilerServices;
using InlineIL;
using static InlineIL.IL.Emit;

namespace StructLinq.Utils
{
    static class Unsafe
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref TTo As<TFrom, TTo>(ref TFrom source)
        {
            Ldarg(nameof(source));
            return ref IL.ReturnRef<TTo>();
        }
    }
}
