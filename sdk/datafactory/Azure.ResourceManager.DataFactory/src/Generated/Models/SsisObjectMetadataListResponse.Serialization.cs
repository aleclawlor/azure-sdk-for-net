// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    internal partial class SsisObjectMetadataListResponse
    {
        internal static SsisObjectMetadataListResponse DeserializeSsisObjectMetadataListResponse(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<SsisObjectMetadata>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<SsisObjectMetadata> array = new List<SsisObjectMetadata>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SsisObjectMetadata.DeserializeSsisObjectMetadata(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new SsisObjectMetadataListResponse(Optional.ToList(value), nextLink.Value);
        }
    }
}
