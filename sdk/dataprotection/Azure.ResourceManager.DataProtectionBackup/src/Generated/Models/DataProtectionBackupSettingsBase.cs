// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary>
    /// BackupParameters base
    /// Please note <see cref="DataProtectionBackupSettingsBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="DataProtectionBackupSettings"/>.
    /// </summary>
    public abstract partial class DataProtectionBackupSettingsBase
    {
        /// <summary> Initializes a new instance of DataProtectionBackupSettingsBase. </summary>
        protected DataProtectionBackupSettingsBase()
        {
        }

        /// <summary> Initializes a new instance of DataProtectionBackupSettingsBase. </summary>
        /// <param name="objectType"> Type of the specific object - used for deserializing. </param>
        internal DataProtectionBackupSettingsBase(string objectType)
        {
            ObjectType = objectType;
        }

        /// <summary> Type of the specific object - used for deserializing. </summary>
        internal string ObjectType { get; set; }
    }
}
