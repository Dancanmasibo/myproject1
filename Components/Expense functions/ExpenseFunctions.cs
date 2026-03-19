using myproject1.Data;
namespace myproject1.Components.Expense_functions
{
    public interface IExpenseFunctions
    {
            public Task<decimal> GetTotalExpensesForMonth(int month, int year);
            public Task<decimal> GetTotalExpensesForYear(int year);
            public Task<decimal> GetAverageMonthlyExpensesForYear(int year);
    }
}
