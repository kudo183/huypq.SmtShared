using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace huypq.SmtShared
{
    [ProtoBuf.ProtoContract]
    public class PagingResultDto<T>
    {
        [ProtoBuf.ProtoMember(1)]
        public int TotalItemCount { get; set; }
        [ProtoBuf.ProtoMember(2)]
        public int PageIndex { get; set; }
        [ProtoBuf.ProtoMember(3)]
        public int PageCount { get; set; }
        [ProtoBuf.ProtoMember(4)]
        public List<T> Items { get; set; }
        [ProtoBuf.ProtoMember(5)]
        public long LastUpdateTime { get; set; }
        [ProtoBuf.ProtoMember(6)]
        public string ErrorMsg { get; set; }
        [ProtoBuf.ProtoMember(7)]
        public int PageSize { get; set; }

        public PagingResultDto()
        {
            Items = new List<T>();
        }
    }
}
