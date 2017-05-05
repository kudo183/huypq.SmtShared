namespace huypq.SmtShared
{
    public interface IUserClaimDto : IDto
    {
        int UserID { get; set; }
        string Claim { get; set; }
    }
}
