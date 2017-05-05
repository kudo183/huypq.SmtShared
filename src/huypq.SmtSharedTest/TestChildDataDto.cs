using huypq.SmtShared;
using System.ComponentModel;

namespace huypq.SmtSharedTest
{
    [ProtoBuf.ProtoContract]
    public partial class TestChildDataDto : IDto, INotifyPropertyChanged
    {
        long oCreateTime;
        string oData;
        int oID;
        long oLastUpdateTime;
        int oTenantID;
        int oTestDataID;

        long _CreateTime;
        string _Data;
        int _ID;
        long _LastUpdateTime;
        int _TenantID;
        int _TestDataID;

        [ProtoBuf.ProtoMember(1)]
        public long CreateTime { get { return _CreateTime; } set { _CreateTime = value; OnPropertyChanged(); } }
        [ProtoBuf.ProtoMember(2)]
        public string Data { get { return _Data; } set { _Data = value; OnPropertyChanged(); } }
        [ProtoBuf.ProtoMember(3)]
        public int ID { get { return _ID; } set { _ID = value; OnPropertyChanged(); } }
        [ProtoBuf.ProtoMember(4)]
        public long LastUpdateTime { get { return _LastUpdateTime; } set { _LastUpdateTime = value; OnPropertyChanged(); } }
        [ProtoBuf.ProtoMember(5)]
        public int TenantID { get { return _TenantID; } set { _TenantID = value; OnPropertyChanged(); } }
        [ProtoBuf.ProtoMember(6)]
        public int TestDataID { get { return _TestDataID; } set { _TestDataID = value; OnPropertyChanged(); } }
        [ProtoBuf.ProtoMember(7)]
        public int State { get; set; }

        public void SetCurrentValueAsOriginalValue()
        {
            oCreateTime = CreateTime;
            oData = Data;
            oID = ID;
            oLastUpdateTime = LastUpdateTime;
            oTenantID = TenantID;
            oTestDataID = TestDataID;
        }

        public void Update(object obj)
        {
            var dto = obj as TestChildDataDto;
            if (dto == null)
            {
                return;
            }
            
            Data = dto.Data;
            LastUpdateTime = dto.LastUpdateTime;
            TenantID = dto.TenantID;
            TestDataID = dto.TestDataID;
        }

        public bool HasChange()
        {
            return (oCreateTime != CreateTime)
            || (oData != Data)
            || (oID != ID)
            || (oLastUpdateTime != LastUpdateTime)
            || (oTenantID != TenantID)
            || (oTestDataID != TestDataID);
        }

        object _TestDataIDSources;

        [Newtonsoft.Json.JsonIgnore]
        public object TestDataIDSources { get { return _TestDataIDSources; } set { _TestDataIDSources = value; OnPropertyChanged(); } }

        public event PropertyChangedEventHandler PropertyChanged;
        public virtual void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
