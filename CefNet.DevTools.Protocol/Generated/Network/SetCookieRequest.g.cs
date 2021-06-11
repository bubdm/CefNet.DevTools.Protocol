//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Network
{
    public sealed class SetCookieRequest
    {
        /// <summary>Cookie name.</summary>
        public string Name { get; set; }

        /// <summary>Cookie value.</summary>
        public string Value { get; set; }

        /// <summary>
        /// The request-URI to associate with the setting of the cookie. This value can affect the
        /// default domain, path, source port, and source scheme values of the created cookie.
        /// </summary>
        public string? Url { get; set; }

        /// <summary>Cookie domain.</summary>
        public string? Domain { get; set; }

        /// <summary>Cookie path.</summary>
        public string? Path { get; set; }

        /// <summary>True if cookie is secure.</summary>
        public bool? Secure { get; set; }

        /// <summary>True if cookie is http-only.</summary>
        public bool? HttpOnly { get; set; }

        /// <summary>Cookie SameSite type.</summary>
        public CefNet.DevTools.Protocol.Network.CookieSameSite? SameSite { get; set; }

        /// <summary>
        /// Cookie expiration date, session cookie if not set
        /// </summary>
        public CefNet.DevTools.Protocol.Network.TimeSinceEpoch? Expires { get; set; }

        /// <summary>[Experimental] Cookie Priority type.</summary>
        public CefNet.DevTools.Protocol.Network.CookiePriority? Priority { get; set; }

        /// <summary>
        /// [Experimental] True if cookie is SameParty.
        /// </summary>
        public bool? SameParty { get; set; }

        /// <summary>
        /// [Experimental] Cookie source scheme type.
        /// </summary>
        public CefNet.DevTools.Protocol.Network.CookieSourceScheme? SourceScheme { get; set; }

        /// <summary>
        /// [Experimental] Cookie source port. Valid values are {-1, [1, 65535]}, -1 indicates an unspecified port.
        /// An unspecified port value allows protocol clients to emulate legacy cookie scope for the port.
        /// This is a temporary ability and it will be removed in the future.
        /// </summary>
        public int? SourcePort { get; set; }
    }
}
