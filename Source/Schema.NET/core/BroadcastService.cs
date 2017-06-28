namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A delivery service through which content is provided via broadcast over the air or online.
    /// </summary>
    [DataContract]
    public partial class BroadcastService : Service
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BroadcastService";

        /// <summary>
        /// The media network(s) whose content is broadcast on this station.
        /// </summary>
        [DataMember(Name = "broadcastAffiliateOf", Order = 304)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Organization>? BroadcastAffiliateOf { get; set; }

        /// <summary>
        /// The name displayed in the channel guide. For many US affiliates, it is the network name.
        /// </summary>
        [DataMember(Name = "broadcastDisplayName", Order = 305)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? BroadcastDisplayName { get; set; }

        /// <summary>
        /// The organization owning or operating the broadcast service.
        /// </summary>
        [DataMember(Name = "broadcaster", Order = 306)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<Organization>? Broadcaster { get; set; }

        /// <summary>
        /// The timezone in &lt;a href="http://en.wikipedia.org/wiki/ISO_8601"&gt;ISO 8601 format&lt;/a&gt; for which the service bases its broadcasts
        /// </summary>
        [DataMember(Name = "broadcastTimezone", Order = 307)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? BroadcastTimezone { get; set; }

        /// <summary>
        /// A broadcast service to which the broadcast service may belong to such as regional variations of a national channel.
        /// </summary>
        [DataMember(Name = "parentService", Order = 308)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<BroadcastService>? ParentService { get; set; }

        /// <summary>
        /// The type of screening or video broadcast used (e.g. IMAX, 3D, SD, HD, etc.).
        /// </summary>
        [DataMember(Name = "videoFormat", Order = 309)]
        [JsonConverter(typeof(ValuesConverter))]
        public Values<string>? VideoFormat { get; set; }
    }
}