//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.DOM
{
    public sealed class GetNodeForLocationResponse
    {
        /// <summary>Resulting node.</summary>
        public CefNet.DevTools.Protocol.DOM.BackendNodeId BackendNodeId { get; set; }

        /// <summary>Frame this node belongs to.</summary>
        public CefNet.DevTools.Protocol.Page.FrameId FrameId { get; set; }

        /// <summary>
        /// Id of the node at given coordinates, only when enabled and requested document.
        /// </summary>
        public CefNet.DevTools.Protocol.DOM.NodeId? NodeId { get; set; }
    }
}
