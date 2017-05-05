﻿using huypq.SmtShared;
using System.ComponentModel;

namespace huypq.SmtSharedTest
{
    [ProtoBuf.ProtoContract]
    public partial class SmtUserDto : IUserDto, INotifyPropertyChanged
    {
        System.DateTime oCreateDate;
        string oEmail;
        int oID;
        long oCreateTime;
        long oLastUpdateTime;
        string oPasswordHash;
        int oTenantID;
        long oTokenValidTime;
        bool oIsLocked;
        string oUserName;

        System.DateTime _CreateDate;
        string _Email;
        int _ID;
        long _CreateTime;
        long _LastUpdateTime;
        string _PasswordHash;
        int _TenantID;
        long _TokenValidTime;
        bool _IsLocked;
        string _UserName;

        [ProtoBuf.ProtoMember(1)]
        public System.DateTime CreateDate { get { return _CreateDate; } set { _CreateDate = value; OnPropertyChanged(); } }
        [ProtoBuf.ProtoMember(2)]
        public string Email { get { return _Email; } set { _Email = value; OnPropertyChanged(); } }
        [ProtoBuf.ProtoMember(3)]
        public int ID { get { return _ID; } set { _ID = value; OnPropertyChanged(); } }
        [ProtoBuf.ProtoMember(4)]
        public long LastUpdateTime { get { return _LastUpdateTime; } set { _LastUpdateTime = value; OnPropertyChanged(); } }
        [ProtoBuf.ProtoMember(5)]
        public string PasswordHash { get { return _PasswordHash; } set { _PasswordHash = value; OnPropertyChanged(); } }
        [ProtoBuf.ProtoMember(6)]
        public int TenantID { get { return _TenantID; } set { _TenantID = value; OnPropertyChanged(); } }
        [ProtoBuf.ProtoMember(7)]
        public long TokenValidTime { get { return _TokenValidTime; } set { _TokenValidTime = value; OnPropertyChanged(); } }
        [ProtoBuf.ProtoMember(8)]
        public string UserName { get { return _UserName; } set { _UserName = value; OnPropertyChanged(); } }
        [ProtoBuf.ProtoMember(9)]
        public bool IsLocked { get { return _IsLocked; } set { _IsLocked = value; OnPropertyChanged(); } }
        [ProtoBuf.ProtoMember(10)]
        public int State { get; set; }
        [ProtoBuf.ProtoMember(11)]
        public long CreateTime { get { return _CreateTime; } set { _CreateTime = value; OnPropertyChanged(); } }

        public void SetCurrentValueAsOriginalValue()
        {
            oCreateDate = CreateDate;
            oEmail = Email;
            oID = ID;
            oCreateTime = CreateTime;
            oLastUpdateTime = LastUpdateTime;
            oPasswordHash = PasswordHash;
            oTenantID = TenantID;
            oTokenValidTime = TokenValidTime;
            oUserName = UserName;
            oIsLocked = IsLocked;
        }

        public void Update(object obj)
        {
            var dto = obj as SmtUserDto;
            if (dto == null)
            {
                return;
            }

            CreateDate = dto.CreateDate;
            Email = dto.Email;
            LastUpdateTime = dto.LastUpdateTime;
            PasswordHash = dto.PasswordHash;
            TenantID = dto.TenantID;
            TokenValidTime = dto.TokenValidTime;
            UserName = dto.UserName;
            IsLocked = dto.IsLocked;
        }

        public bool HasChange()
        {
            return (oCreateDate != CreateDate)
            || (oEmail != Email)
            || (oID != ID)
            || (oCreateTime != CreateTime)
            || (oLastUpdateTime != LastUpdateTime)
            || (oPasswordHash != PasswordHash)
            || (oTenantID != TenantID)
            || (oTokenValidTime != TokenValidTime)
              || (oIsLocked != IsLocked)
            || (oUserName != UserName);
        }
        
        public event PropertyChangedEventHandler PropertyChanged;
        public virtual void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
