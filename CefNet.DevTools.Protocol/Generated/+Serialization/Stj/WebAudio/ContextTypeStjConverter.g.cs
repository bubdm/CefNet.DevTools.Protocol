//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
using System;
using System.Text.Json;

namespace CefNet.DevTools.Protocol.WebAudio
{
    internal sealed class ContextTypeStjConverter
        : System.Text.Json.Serialization.JsonConverter<CefNet.DevTools.Protocol.WebAudio.ContextType>
    {
        public override CefNet.DevTools.Protocol.WebAudio.ContextType Read(
            ref Utf8JsonReader reader, 
            Type typeToConvert, 
            JsonSerializerOptions options)
        {
            var value = reader.GetString() ?? throw new JsonException();
            var result = value switch
            {
                "offline" => CefNet.DevTools.Protocol.WebAudio.ContextType.Offline,
                "realtime" => CefNet.DevTools.Protocol.WebAudio.ContextType.Realtime,
                _ => throw new NotSupportedException(value),
            };
            return result;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            CefNet.DevTools.Protocol.WebAudio.ContextType value, 
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
