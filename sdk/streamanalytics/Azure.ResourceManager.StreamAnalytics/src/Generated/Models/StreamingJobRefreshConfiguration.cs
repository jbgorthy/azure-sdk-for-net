// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> The refresh parameters for any/all updatable user defined functions present in the job config. </summary>
    public partial class StreamingJobRefreshConfiguration
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

        /// <summary> Initializes a new instance of <see cref="StreamingJobRefreshConfiguration"/>. </summary>
        public StreamingJobRefreshConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StreamingJobRefreshConfiguration"/>. </summary>
        /// <param name="pathPattern"> The blob path pattern. Not a regular expression. It represents a pattern against which blob names will be matched to determine whether or not they should be included as input or output to the job. See https://docs.microsoft.com/en-us/rest/api/streamanalytics/stream-analytics-input or https://docs.microsoft.com/en-us/rest/api/streamanalytics/stream-analytics-output for a more detailed explanation and example. </param>
        /// <param name="dateFormat"> The date format. Wherever {date} appears in pathPattern, the value of this property is used as the date format instead. </param>
        /// <param name="timeFormat"> The time format. Wherever {time} appears in pathPattern, the value of this property is used as the time format instead. </param>
        /// <param name="refreshInterval"> The refresh interval. </param>
        /// <param name="refreshType"> This property indicates which data refresh option to use, Blocking or Nonblocking. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StreamingJobRefreshConfiguration(string pathPattern, string dateFormat, string timeFormat, string refreshInterval, DataRefreshType? refreshType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            PathPattern = pathPattern;
            DateFormat = dateFormat;
            TimeFormat = timeFormat;
            RefreshInterval = refreshInterval;
            RefreshType = refreshType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The blob path pattern. Not a regular expression. It represents a pattern against which blob names will be matched to determine whether or not they should be included as input or output to the job. See https://docs.microsoft.com/en-us/rest/api/streamanalytics/stream-analytics-input or https://docs.microsoft.com/en-us/rest/api/streamanalytics/stream-analytics-output for a more detailed explanation and example. </summary>
        public string PathPattern { get; set; }
        /// <summary> The date format. Wherever {date} appears in pathPattern, the value of this property is used as the date format instead. </summary>
        public string DateFormat { get; set; }
        /// <summary> The time format. Wherever {time} appears in pathPattern, the value of this property is used as the time format instead. </summary>
        public string TimeFormat { get; set; }
        /// <summary> The refresh interval. </summary>
        public string RefreshInterval { get; set; }
        /// <summary> This property indicates which data refresh option to use, Blocking or Nonblocking. </summary>
        public DataRefreshType? RefreshType { get; set; }
    }
}
