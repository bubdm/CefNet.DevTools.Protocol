//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.Input
{
    public sealed class DispatchMouseEventRequest
    {
        /// <summary>Type of the mouse event.</summary>
        public CefNet.DevTools.Protocol.Input.DispatchMouseEventRequestType Type { get; set; }

        /// <summary>
        /// X coordinate of the event relative to the main frame's viewport in CSS pixels.
        /// </summary>
        public double X { get; set; }

        /// <summary>
        /// Y coordinate of the event relative to the main frame's viewport in CSS pixels. 0 refers to
        /// the top of the viewport and Y increases as it proceeds towards the bottom of the viewport.
        /// </summary>
        public double Y { get; set; }

        /// <summary>
        /// Bit field representing pressed modifier keys. Alt=1, Ctrl=2, Meta/Command=4, Shift=8
        /// (default: 0).
        /// </summary>
        public int? Modifiers { get; set; }

        /// <summary>Time at which the event occurred.</summary>
        public CefNet.DevTools.Protocol.Input.TimeSinceEpoch? Timestamp { get; set; }

        /// <summary>Mouse button (default: "none").</summary>
        public CefNet.DevTools.Protocol.Input.MouseButton? Button { get; set; }

        /// <summary>
        /// A number indicating which buttons are pressed on the mouse when a mouse event is triggered.
        /// Left=1, Right=2, Middle=4, Back=8, Forward=16, None=0.
        /// </summary>
        public int? Buttons { get; set; }

        /// <summary>
        /// Number of times the mouse button was clicked (default: 0).
        /// </summary>
        public int? ClickCount { get; set; }

        /// <summary>
        /// [Experimental] The normalized pressure, which has a range of [0,1] (default: 0).
        /// </summary>
        public double? Force { get; set; }

        /// <summary>
        /// [Experimental] The normalized tangential pressure, which has a range of [-1,1] (default: 0).
        /// </summary>
        public double? TangentialPressure { get; set; }

        /// <summary>
        /// [Experimental] The plane angle between the Y-Z plane and the plane containing both the stylus axis and the Y axis, in degrees of the range [-90,90], a positive tiltX is to the right (default: 0).
        /// </summary>
        public int? TiltX { get; set; }

        /// <summary>
        /// [Experimental] The plane angle between the X-Z plane and the plane containing both the stylus axis and the X axis, in degrees of the range [-90,90], a positive tiltY is towards the user (default: 0).
        /// </summary>
        public int? TiltY { get; set; }

        /// <summary>
        /// [Experimental] The clockwise rotation of a pen stylus around its own major axis, in degrees in the range [0,359] (default: 0).
        /// </summary>
        public int? Twist { get; set; }

        /// <summary>
        /// X delta in CSS pixels for mouse wheel event (default: 0).
        /// </summary>
        public double? DeltaX { get; set; }

        /// <summary>
        /// Y delta in CSS pixels for mouse wheel event (default: 0).
        /// </summary>
        public double? DeltaY { get; set; }

        /// <summary>Pointer type (default: "mouse").</summary>
        public CefNet.DevTools.Protocol.Input.DispatchMouseEventRequestPointerType? PointerType { get; set; }
    }
}
