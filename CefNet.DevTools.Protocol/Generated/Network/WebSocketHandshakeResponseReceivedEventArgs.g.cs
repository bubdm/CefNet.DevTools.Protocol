//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Network
{
    public sealed class WebSocketHandshakeResponseReceivedEventArgs
        : System.EventArgs
    {
        /// <summary>Request identifier.</summary>
        public CefNet.DevTools.Protocol.Network.RequestId RequestId { get; set; }

        /// <summary>Timestamp.</summary>
        public CefNet.DevTools.Protocol.Network.MonotonicTime Timestamp { get; set; }

        /// <summary>WebSocket response data.</summary>
        public CefNet.DevTools.Protocol.Network.WebSocketResponse Response { get; set; }
    }
}
