//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.DOM
{
    public sealed class PseudoElementAddedEventArgs
        : System.EventArgs
    {
        /// <summary>Pseudo element's parent element id.</summary>
        public CefNet.DevTools.Protocol.DOM.NodeId ParentId { get; set; }

        /// <summary>The added pseudo element.</summary>
        public CefNet.DevTools.Protocol.DOM.Node PseudoElement { get; set; }
    }
}
