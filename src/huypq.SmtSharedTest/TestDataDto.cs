using huypq.SmtShared;
using System.ComponentModel;

namespace huypq.SmtSharedTest
{
    [ProtoBuf.ProtoContract]
    public partial class TestDataDto : SmtIDto, INotifyPropertyChanged
    {
        string oData;
        int oID;
        long oCreateTime;
        long oLastUpdateTime;
        int oTenantID;

        string _Data;
        int _ID;
        long _CreateTime;
        long _LastUpdateTime;
        int _TenantID;

        [ProtoBuf.ProtoMember(1)]
        public string Data { get { return _Data; } set { _Data = value; OnPropertyChanged(); } }
        [ProtoBuf.ProtoMember(2)]
        public int ID { get { return _ID; } set { _ID = value; OnPropertyChanged(); } }
        [ProtoBuf.ProtoMember(3)]
        public long CreateTime { get { return _CreateTime; } set { _CreateTime = value; OnPropertyChanged(); } }
        [ProtoBuf.ProtoMember(4)]
        public long LastUpdateTime { get { return _LastUpdateTime; } set { _LastUpdateTime = value; OnPropertyChanged(); } }
        [ProtoBuf.ProtoMember(5)]
        public int TenantID { get { return _TenantID; } set { _TenantID = value; OnPropertyChanged(); } }
        [ProtoBuf.ProtoMember(6)]
        public int State { get; set; }

        public void SetCurrentValueAsOriginalValue()
        {
            oData = Data;
            oID = ID;
            oCreateTime = CreateTime;
            oLastUpdateTime = LastUpdateTime;
            oTenantID = TenantID;
        }

        public bool HasChange()
        {
            return (oData != Data)
            || (oID != ID)
            || (oCreateTime != CreateTime)
            || (oLastUpdateTime != LastUpdateTime)
            || (oTenantID != TenantID);
        }

        public void Update(object obj)
        {
            var dto = obj as TestDataDto;
            if (dto == null)
            {
                return;
            }
            
            Data = dto.Data;
            LastUpdateTime = dto.LastUpdateTime;
            TenantID = TenantID;
        }

        object _UserIDSources;
        [Newtonsoft.Json.JsonIgnore]
        public object UserIDSources { get { return _UserIDSources; } set { _UserIDSources = value; OnPropertyChanged(); } }

        public event PropertyChangedEventHandler PropertyChanged;
        public virtual void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
            RaiseDependentPropertyChanged(name);
        }

        partial void RaiseDependentPropertyChanged(string basePropertyName);
    }
}
