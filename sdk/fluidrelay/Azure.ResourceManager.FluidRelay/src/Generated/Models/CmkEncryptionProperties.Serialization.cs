// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.FluidRelay.Models
{
    public partial class CmkEncryptionProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(KeyEncryptionKeyIdentity))
            {
                writer.WritePropertyName("keyEncryptionKeyIdentity"u8);
                writer.WriteObjectValue(KeyEncryptionKeyIdentity);
            }
            if (Optional.IsDefined(KeyEncryptionKeyUri))
            {
                writer.WritePropertyName("keyEncryptionKeyUrl"u8);
                writer.WriteStringValue(KeyEncryptionKeyUri.AbsoluteUri);
            }
            writer.WriteEndObject();
        }

        internal static CmkEncryptionProperties DeserializeCmkEncryptionProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<CmkIdentity> keyEncryptionKeyIdentity = default;
            Optional<Uri> keyEncryptionKeyUrl = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyEncryptionKeyIdentity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    keyEncryptionKeyIdentity = CmkIdentity.DeserializeCmkIdentity(property.Value);
                    continue;
                }
                if (property.NameEquals("keyEncryptionKeyUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        keyEncryptionKeyUrl = null;
                        continue;
                    }
                    keyEncryptionKeyUrl = new Uri(property.Value.GetString());
                    continue;
                }
            }
            return new CmkEncryptionProperties(keyEncryptionKeyIdentity.Value, keyEncryptionKeyUrl.Value);
        }
    }
}
