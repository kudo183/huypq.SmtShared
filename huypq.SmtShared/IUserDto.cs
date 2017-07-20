using System;

namespace huypq.SmtShared
{
    public interface IUserDto : IDto
    {
        bool IsLocked { get; set; }
        DateTime CreateDate { get; set; }
        string Email { get; set; }
        string UserName { get; set; }
        string PasswordHash { get; set; }
        long TokenValidTime { get; set; }
    }
}
