using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using myproject1.Components.Pages;

namespace myproject1.Data
{
    [Table("Expenses")]
    public class Expense:BaseModel
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        //public int ExpenseId { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string category { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string description { get; set; }

        [Precision(18, 2)]
        public decimal amount { get; set; }

        public DateTime date { get; set; } = DateTime.Now;

    }

 
}

