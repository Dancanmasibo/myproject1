using myproject1.Data;

namespace myproject1.Data
{
    public class ExpenseDto
    {
        public string ExpenseId { get; set; }
        public string category { get; set; }
        public string description { get; set; }
        public decimal amount { get; set; }
        public DateTime date { get; set; } = DateTime.Now;
    }
}