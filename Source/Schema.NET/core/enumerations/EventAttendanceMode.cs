namespace Schema.NET
{
    using System.Runtime.Serialization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// An EventAttendanceModeEnumeration value is one of potentially several modes of organising an event, relating to whether it is online or offline.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EventAttendanceMode
    {
        /// <summary>
        /// An event that is conducted as a combination of both offline and online modes.
        /// </summary>
        [EnumMember(Value = "https://schema.org/MixedEventAttendanceMode")]
        MixedEventAttendanceMode,

        /// <summary>
        /// an event that is primarily conducted offline.
        /// </summary>
        [EnumMember(Value = "https://schema.org/OfflineEventAttendanceMode")]
        OfflineEventAttendanceMode,

        /// <summary>
        /// an event that is primarily conducted online.
        /// </summary>
        [EnumMember(Value = "https://schema.org/OnlineEventAttendanceMode")]
        OnlineEventAttendanceMode,
    }
}
