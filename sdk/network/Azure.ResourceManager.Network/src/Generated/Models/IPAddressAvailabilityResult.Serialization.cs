// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class IPAddressAvailabilityResult
    {
        internal static IPAddressAvailabilityResult DeserializeIPAddressAvailabilityResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> available = default;
            Optional<IReadOnlyList<string>> availableIPAddresses = default;
            Optional<bool> isPlatformReserved = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("available"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    available = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("availableIPAddresses"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    availableIPAddresses = array;
                    continue;
                }
                if (property.NameEquals("isPlatformReserved"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isPlatformReserved = property.Value.GetBoolean();
                    continue;
                }
            }
            return new IPAddressAvailabilityResult(Optional.ToNullable(available), Optional.ToList(availableIPAddresses), Optional.ToNullable(isPlatformReserved));
        }
    }
}
