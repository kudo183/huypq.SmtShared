namespace huypq.SmtShared
{
    public interface SmtIDto
    {
        int ID { get; }
        int TenantID { get; set; }
        int State { get; set; }

        bool HasChange();
    }
}
