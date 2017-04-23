using huypq.SmtShared;
using System.ComponentModel;

namespace huypq.SmtSharedTest
{
    [ProtoBuf.ProtoContract]
    public partial class SmtUserClaimDto : SmtIUserClaimDto, INotifyPropertyChanged
    {
        string oClaim;
        int oID;
        long oLastUpdateTime;
        int oTenantID;
        int oUserID;

        string _Claim;
        int _ID;
        long _LastUpdateTime;
        int _TenantID;
        int _UserID;

        [ProtoBuf.ProtoMember(1)]
        public string Claim { get { return _Claim; } set { _Claim = value; OnPropertyChanged(); } }
        [ProtoBuf.ProtoMember(2)]
        public int ID { get { return _ID; } set { _ID = value; OnPropertyChanged(); } }
        [ProtoBuf.ProtoMember(3)]
        public long LastUpdateTime { get { return _LastUpdateTime; } set { _LastUpdateTime = value; OnPropertyChanged(); } }
        [ProtoBuf.ProtoMember(4)]
        public int TenantID { get { return _TenantID; } set { _TenantID = value; OnPropertyChanged(); } }
        [ProtoBuf.ProtoMember(5)]
        public int UserID { get { return _UserID; } set { _UserID = value; OnPropertyChanged(); } }
        [ProtoBuf.ProtoMember(6)]
        public int State { get; set; }

        public void SetCurrentValueAsOriginalValue()
        {
            oClaim = Claim;
            oID = ID;
            oLastUpdateTime = LastUpdateTime;
            oTenantID = TenantID;
            oUserID = UserID;
        }

        public bool HasChange()
        {
            return (oClaim != Claim)
            || (oID != ID)
            || (oLastUpdateTime != LastUpdateTime)
            || (oTenantID != TenantID)
            || (oUserID != UserID);
        }

        object _UserIDSources;
        [Newtonsoft.Json.JsonIgnore]
        public object UserIDSources { get { return _UserIDSources; } set { _UserIDSources = value; OnPropertyChanged(); } }

        public event PropertyChangedEventHandler PropertyChanged;
        public virtual void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
