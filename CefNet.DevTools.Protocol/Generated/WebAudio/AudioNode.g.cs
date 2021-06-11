//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.WebAudio
{
    /// <summary>Protocol object for AudioNode</summary>
    public sealed class AudioNode
    {
        public CefNet.DevTools.Protocol.WebAudio.GraphObjectId NodeId { get; set; }

        public CefNet.DevTools.Protocol.WebAudio.GraphObjectId ContextId { get; set; }

        public CefNet.DevTools.Protocol.WebAudio.NodeType NodeType { get; set; }

        public double NumberOfInputs { get; set; }

        public double NumberOfOutputs { get; set; }

        public double ChannelCount { get; set; }

        public CefNet.DevTools.Protocol.WebAudio.ChannelCountMode ChannelCountMode { get; set; }

        public CefNet.DevTools.Protocol.WebAudio.ChannelInterpretation ChannelInterpretation { get; set; }
    }
}
