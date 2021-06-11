//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Storage
{
    public sealed class ClearDataForOriginRequest
    {
        /// <summary>Security origin.</summary>
        public string Origin { get; set; }

        /// <summary>
        /// Comma separated list of StorageType to clear.
        /// </summary>
        public string StorageTypes { get; set; }
    }
}
