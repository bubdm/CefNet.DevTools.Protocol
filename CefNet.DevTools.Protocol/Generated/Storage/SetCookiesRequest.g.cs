//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Storage
{
    public sealed class SetCookiesRequest
    {
        /// <summary>Cookies to be set.</summary>
        public System.Collections.Generic.List<CefNet.DevTools.Protocol.Network.CookieParam> Cookies { get; set; }

        /// <summary>
        /// Browser context to use when called on the browser endpoint.
        /// </summary>
        public CefNet.DevTools.Protocol.Browser.BrowserContextID? BrowserContextId { get; set; }
    }
}
