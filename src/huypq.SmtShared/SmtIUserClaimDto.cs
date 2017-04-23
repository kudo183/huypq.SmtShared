namespace huypq.SmtShared
{
    public interface SmtIUserClaimDto : SmtIDto
    {
        int UserID { get; set; }
        string Claim { get; set; }
    }
}
