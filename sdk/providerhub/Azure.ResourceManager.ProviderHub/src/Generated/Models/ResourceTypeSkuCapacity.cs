// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ProviderHub.Models
{
    /// <summary> The ResourceTypeSkuCapacity. </summary>
    public partial class ResourceTypeSkuCapacity
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

        /// <summary> Initializes a new instance of <see cref="ResourceTypeSkuCapacity"/>. </summary>
        /// <param name="minimum"></param>
        public ResourceTypeSkuCapacity(int minimum)
        {
            Minimum = minimum;
        }

        /// <summary> Initializes a new instance of <see cref="ResourceTypeSkuCapacity"/>. </summary>
        /// <param name="minimum"></param>
        /// <param name="maximum"></param>
        /// <param name="default"></param>
        /// <param name="scaleType"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ResourceTypeSkuCapacity(int minimum, int? maximum, int? @default, ResourceTypeSkuScaleType? scaleType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Minimum = minimum;
            Maximum = maximum;
            Default = @default;
            ScaleType = scaleType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ResourceTypeSkuCapacity"/> for deserialization. </summary>
        internal ResourceTypeSkuCapacity()
        {
        }

        /// <summary> Gets or sets the minimum. </summary>
        public int Minimum { get; set; }
        /// <summary> Gets or sets the maximum. </summary>
        public int? Maximum { get; set; }
        /// <summary> Gets or sets the default. </summary>
        public int? Default { get; set; }
        /// <summary> Gets or sets the scale type. </summary>
        public ResourceTypeSkuScaleType? ScaleType { get; set; }
    }
}
