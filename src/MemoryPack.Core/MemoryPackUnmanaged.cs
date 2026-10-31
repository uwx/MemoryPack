using System.Runtime.CompilerServices;

namespace MemoryPack;

/// <summary>
/// Fixed-size helpers for generated code.
/// </summary>
public static class MemoryPackUnmanaged
{
    /// <summary>
    /// The size of a generated type's unmanaged members, for the call sites that used
    /// <c>Unsafe.SizeOf</c> directly.
    /// </summary>
    /// <remarks>
    /// Generated formatters run inside the plugin sandbox, where <see cref="Unsafe"/> is
    /// denied: it takes no length, so nothing can bounds-check a reinterpretation through
    /// it. This reaches the same compile-time value from a member the policy can name.
    ///
    /// Not constrained to <c>unmanaged</c>: the generator also asks for the size of a
    /// nullable unmanaged member, which no such constraint accepts.
    /// </remarks>
    public static int SizeOf<T>() => Unsafe.SizeOf<T>();
}
