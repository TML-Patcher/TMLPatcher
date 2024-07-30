﻿using System.IO;

namespace Tomat.FNB.Common;

/// <summary>
///     An abstraction over traditional methods of holding onto binary data
///     (byte arrays, streams, managed and native pointers, etc.).
/// </summary>
/// <remarks>
///     This is intended for leverage in memory- and performance-critical or
///     intensive code where minimizing conversion between representations is
///     preferable.
/// </remarks>
public unsafe interface IBinaryDataView
{
    byte[] AsArray();

    Stream AsStream();

    byte* AsPointer();

    ref byte AsManagedPointer();
}
