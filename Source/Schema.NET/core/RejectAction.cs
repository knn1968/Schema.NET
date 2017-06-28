namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The act of rejecting to/adopting an object.
    /// Related actions:
    ///
    /// AcceptAction: The antonym of RejectAction.
    /// </summary>
    [DataContract]
    public partial class RejectAction : AllocateAction
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "RejectAction";
    }
}