// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RedisEnterprise.Models
{
    public partial class RedisEnterpriseRegionSkuDetail
    {
        internal static RedisEnterpriseRegionSkuDetail DeserializeRedisEnterpriseRegionSkuDetail(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceType> resourceType = default;
            Optional<RedisEnterpriseLocationInfo> locationInfo = default;
            Optional<SkuDetail> skuDetails = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    resourceType = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("locationInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    locationInfo = RedisEnterpriseLocationInfo.DeserializeRedisEnterpriseLocationInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("skuDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    skuDetails = SkuDetail.DeserializeSkuDetail(property.Value);
                    continue;
                }
            }
            return new RedisEnterpriseRegionSkuDetail(Optional.ToNullable(resourceType), locationInfo.Value, skuDetails.Value);
        }
    }
}
