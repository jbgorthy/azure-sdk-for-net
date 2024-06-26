// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MigrationDiscoverySap.Models
{
    /// <summary> The SAP instance specific configuration data. </summary>
    public partial class ConfigurationDetail
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ConfigurationDetail"/>. </summary>
        internal ConfigurationDetail()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ConfigurationDetail"/>. </summary>
        /// <param name="saps"> Provide the SAPS for each server of the SAP system. This should be a non-zero value. For example, 1000. </param>
        /// <param name="cpu"> Provide the CPU value of the server. For example, 16, 32 etc. </param>
        /// <param name="cpuType"> Provide the CPU architecture type of the server. For example, Xeon Platinum 8171M, Xeon E5-2673 v3. </param>
        /// <param name="cpuInMhz"> Provide the CPU clock speed of the server in MHz. This should be a non-zero value. For example, 2100. </param>
        /// <param name="ram"> Provide the RAM of the server. This should be a non-zero value. For example, 256. </param>
        /// <param name="hardwareManufacturer"> Provide the HW manufacturer company of the server.  For example, Microsoft Corporation. </param>
        /// <param name="model"> Specify if the Hardware is a physical server or virtual machine. </param>
        /// <param name="totalDiskSizeGB"> Provide the total disk volume capacity in GB. Add the disk volume for each individual disks and provide the total sum in this field. </param>
        /// <param name="totalDiskIops"> Provide the total disk IOPS capacity. Add the disk volume for each individual disk and provide the sum total in this field. </param>
        /// <param name="databaseType"> The database of this is a server instance. Applicable only if SAP instance type for this server instance is 'DB'. </param>
        /// <param name="targetHanaRamSizeGB"> Provide the target HANA database size you need. Applicable only if SAP instance type for this server instance is 'DB' and you are migrating an AnyDb database to SAP S/4HANA. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ConfigurationDetail(int? saps, int? cpu, string cpuType, int? cpuInMhz, int? ram, string hardwareManufacturer, string model, int? totalDiskSizeGB, int? totalDiskIops, SapDiscoveryDatabaseType? databaseType, int? targetHanaRamSizeGB, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Saps = saps;
            Cpu = cpu;
            CpuType = cpuType;
            CpuInMhz = cpuInMhz;
            Ram = ram;
            HardwareManufacturer = hardwareManufacturer;
            Model = model;
            TotalDiskSizeGB = totalDiskSizeGB;
            TotalDiskIops = totalDiskIops;
            DatabaseType = databaseType;
            TargetHanaRamSizeGB = targetHanaRamSizeGB;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Provide the SAPS for each server of the SAP system. This should be a non-zero value. For example, 1000. </summary>
        public int? Saps { get; }
        /// <summary> Provide the CPU value of the server. For example, 16, 32 etc. </summary>
        public int? Cpu { get; }
        /// <summary> Provide the CPU architecture type of the server. For example, Xeon Platinum 8171M, Xeon E5-2673 v3. </summary>
        public string CpuType { get; }
        /// <summary> Provide the CPU clock speed of the server in MHz. This should be a non-zero value. For example, 2100. </summary>
        public int? CpuInMhz { get; }
        /// <summary> Provide the RAM of the server. This should be a non-zero value. For example, 256. </summary>
        public int? Ram { get; }
        /// <summary> Provide the HW manufacturer company of the server.  For example, Microsoft Corporation. </summary>
        public string HardwareManufacturer { get; }
        /// <summary> Specify if the Hardware is a physical server or virtual machine. </summary>
        public string Model { get; }
        /// <summary> Provide the total disk volume capacity in GB. Add the disk volume for each individual disks and provide the total sum in this field. </summary>
        public int? TotalDiskSizeGB { get; }
        /// <summary> Provide the total disk IOPS capacity. Add the disk volume for each individual disk and provide the sum total in this field. </summary>
        public int? TotalDiskIops { get; }
        /// <summary> The database of this is a server instance. Applicable only if SAP instance type for this server instance is 'DB'. </summary>
        public SapDiscoveryDatabaseType? DatabaseType { get; }
        /// <summary> Provide the target HANA database size you need. Applicable only if SAP instance type for this server instance is 'DB' and you are migrating an AnyDb database to SAP S/4HANA. </summary>
        public int? TargetHanaRamSizeGB { get; }
    }
}
