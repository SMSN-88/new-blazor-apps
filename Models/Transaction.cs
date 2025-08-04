namespace NewBlazorApps.Models
{
    public class Transaction
    {
        public Guid Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public bool? IsIncome { get; set; }
        public DateTime Date { get; set; }
    }
}
