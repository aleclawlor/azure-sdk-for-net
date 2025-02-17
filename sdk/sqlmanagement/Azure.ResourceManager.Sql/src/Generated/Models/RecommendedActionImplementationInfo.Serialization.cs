// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class RecommendedActionImplementationInfo
    {
        internal static RecommendedActionImplementationInfo DeserializeRecommendedActionImplementationInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ImplementationMethod> method = default;
            Optional<string> script = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("method"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    method = property.Value.GetString().ToImplementationMethod();
                    continue;
                }
                if (property.NameEquals("script"u8))
                {
                    script = property.Value.GetString();
                    continue;
                }
            }
            return new RecommendedActionImplementationInfo(Optional.ToNullable(method), script.Value);
        }
    }
}
