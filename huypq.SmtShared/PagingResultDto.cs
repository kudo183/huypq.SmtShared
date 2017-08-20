using System.Collections.Generic;

namespace huypq.SmtShared
{
    [Newtonsoft.Json.JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    [ProtoBuf.ProtoContract]
    public class PagingResultDto<T>
    {
        [Newtonsoft.Json.JsonProperty]
        [ProtoBuf.ProtoMember(1)]
        public int TotalItemCount { get; set; }
        [Newtonsoft.Json.JsonProperty]
        [ProtoBuf.ProtoMember(2)]
        public int PageIndex { get; set; }
        [Newtonsoft.Json.JsonProperty]
        [ProtoBuf.ProtoMember(3)]
        public int PageCount { get; set; }
        [Newtonsoft.Json.JsonProperty]
        [ProtoBuf.ProtoMember(4)]
        public List<T> Items { get; set; }
        [Newtonsoft.Json.JsonProperty]
        [ProtoBuf.ProtoMember(5)]
        public long LastUpdateTime { get; set; }

        public PagingResultDto()
        {
            Items = new List<T>();
        }
    }
}
