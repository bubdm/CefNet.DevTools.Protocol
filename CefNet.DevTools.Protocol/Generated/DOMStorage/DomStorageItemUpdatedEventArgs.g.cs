//
// DO NOT MODIFY. THIS IS AUTOMATICALLY GENERATED FILE.
//
#nullable enable
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
using System;
using System.Collections.Generic;

namespace CefNet.DevTools.Protocol.DOMStorage
{
    public sealed class DomStorageItemUpdatedEventArgs
        : System.EventArgs
    {
        public CefNet.DevTools.Protocol.DOMStorage.StorageId StorageId { get; set; }

        public string Key { get; set; }

        public string OldValue { get; set; }

        public string NewValue { get; set; }
    }
}
