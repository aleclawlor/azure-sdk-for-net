// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class TenantResourceProvider
    {
        internal static TenantResourceProvider DeserializeTenantResourceProvider(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> @namespace = default;
            Optional<IReadOnlyList<ProviderResourceType>> resourceTypes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("namespace"u8))
                {
                    @namespace = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceTypes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ProviderResourceType> array = new List<ProviderResourceType>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ProviderResourceType.DeserializeProviderResourceType(item));
                    }
                    resourceTypes = array;
                    continue;
                }
            }
            return new TenantResourceProvider(@namespace.Value, Optional.ToList(resourceTypes));
        }
    }
}
