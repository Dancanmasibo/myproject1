using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace myproject1.Data
{
    [Table("Expenses")]
    public class Expense
    {
        [Key]
        public string ExpenseId { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string category { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string description { get; set; }
        [Column(TypeName = "double(10)")]
        public decimal amount { get; set; }
        public DateTime date { get; set; } = DateTime.Now;
    }
   
}


