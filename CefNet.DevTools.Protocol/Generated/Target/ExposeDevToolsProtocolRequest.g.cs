//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Target
{
    public sealed class ExposeDevToolsProtocolRequest
    {
        public CefNet.DevTools.Protocol.Target.TargetID TargetId { get; set; }

        /// <summary>Binding name, 'cdp' if not specified.</summary>
        public string? BindingName { get; set; }
    }
}
