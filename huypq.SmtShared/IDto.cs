namespace huypq.SmtShared
{
    public interface IDto
    {
        int ID { get; set; }
        int TenantID { get; set; }
        int State { get; set; }
        long CreateTime { get; set; }
        long LastUpdateTime { get; set; }
    }
}
