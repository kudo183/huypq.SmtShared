namespace huypq.SmtShared
{
    public interface SmtIDto
    {
        int ID { get; set; }
        int TenantID { get; set; }
        int State { get; set; }
        long LastUpdateTime { get; set; }
        bool HasChange();
        void SetCurrentValueAsOriginalValue();
    }
}
