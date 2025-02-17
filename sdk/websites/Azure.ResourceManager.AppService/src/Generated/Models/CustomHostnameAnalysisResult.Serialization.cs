// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class CustomHostnameAnalysisResult : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(CNameRecords))
            {
                writer.WritePropertyName("cNameRecords"u8);
                writer.WriteStartArray();
                foreach (var item in CNameRecords)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(TxtRecords))
            {
                writer.WritePropertyName("txtRecords"u8);
                writer.WriteStartArray();
                foreach (var item in TxtRecords)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ARecords))
            {
                writer.WritePropertyName("aRecords"u8);
                writer.WriteStartArray();
                foreach (var item in ARecords)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AlternateCNameRecords))
            {
                writer.WritePropertyName("alternateCNameRecords"u8);
                writer.WriteStartArray();
                foreach (var item in AlternateCNameRecords)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(AlternateTxtRecords))
            {
                writer.WritePropertyName("alternateTxtRecords"u8);
                writer.WriteStartArray();
                foreach (var item in AlternateTxtRecords)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static CustomHostnameAnalysisResult DeserializeCustomHostnameAnalysisResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<bool> isHostnameAlreadyVerified = default;
            Optional<DnsVerificationTestResult> customDomainVerificationTest = default;
            Optional<ResponseError> customDomainVerificationFailureInfo = default;
            Optional<bool> hasConflictOnScaleUnit = default;
            Optional<bool> hasConflictAcrossSubscription = default;
            Optional<string> conflictingAppResourceId = default;
            Optional<IList<string>> cNameRecords = default;
            Optional<IList<string>> txtRecords = default;
            Optional<IList<string>> aRecords = default;
            Optional<IList<string>> alternateCNameRecords = default;
            Optional<IList<string>> alternateTxtRecords = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("isHostnameAlreadyVerified"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isHostnameAlreadyVerified = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("customDomainVerificationTest"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            customDomainVerificationTest = property0.Value.GetString().ToDnsVerificationTestResult();
                            continue;
                        }
                        if (property0.NameEquals("customDomainVerificationFailureInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            customDomainVerificationFailureInfo = JsonSerializer.Deserialize<ResponseError>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("hasConflictOnScaleUnit"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            hasConflictOnScaleUnit = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("hasConflictAcrossSubscription"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            hasConflictAcrossSubscription = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("conflictingAppResourceId"u8))
                        {
                            conflictingAppResourceId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("cNameRecords"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            cNameRecords = array;
                            continue;
                        }
                        if (property0.NameEquals("txtRecords"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            txtRecords = array;
                            continue;
                        }
                        if (property0.NameEquals("aRecords"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            aRecords = array;
                            continue;
                        }
                        if (property0.NameEquals("alternateCNameRecords"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            alternateCNameRecords = array;
                            continue;
                        }
                        if (property0.NameEquals("alternateTxtRecords"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            alternateTxtRecords = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new CustomHostnameAnalysisResult(id, name, type, systemData.Value, Optional.ToNullable(isHostnameAlreadyVerified), Optional.ToNullable(customDomainVerificationTest), customDomainVerificationFailureInfo.Value, Optional.ToNullable(hasConflictOnScaleUnit), Optional.ToNullable(hasConflictAcrossSubscription), conflictingAppResourceId.Value, Optional.ToList(cNameRecords), Optional.ToList(txtRecords), Optional.ToList(aRecords), Optional.ToList(alternateCNameRecords), Optional.ToList(alternateTxtRecords), kind.Value);
        }
    }
}
