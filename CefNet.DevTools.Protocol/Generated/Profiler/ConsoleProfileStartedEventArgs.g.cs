//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Profiler
{
    public sealed class ConsoleProfileStartedEventArgs
        : System.EventArgs
    {
        public string Id { get; set; }

        /// <summary>Location of console.profile().</summary>
        public CefNet.DevTools.Protocol.Debugger.Location Location { get; set; }

        /// <summary>
        /// Profile title passed as an argument to console.profile().
        /// </summary>
        public string? Title { get; set; }
    }
}
