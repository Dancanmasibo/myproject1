using Microsoft.EntityFrameworkCore;
using myproject1.Data;

namespace myproject1.Respositories
{
    public class ExpenseRepo
    {
        private readonly MyDbcontex _db;
        public ExpenseRepo(MyDbcontex db)
        {
            _db = db;
        }
        // Implement CRUD operations for Expense entity
        //.to show data
        public IEnumerable<Expense> GetAllExpenses()
        {
            List<Expense> listResult;
            listResult = _db.Expenses.ToList();//db expenses assign to list of expenses

            return listResult;//returns the result of the query as a list of Expense objects
        }
        //assynchronous method to view expenses to the database

        public async Task<IEnumerable<Expense>> GetAllExpensesAsync()
        {
            List<Expense> listResult;
            listResult = await _db.Expenses.ToListAsync();
            return listResult;
        }
        //ExpenseId parameter to get specific expense
        public Expense GetExpenseById(string id)
        {
            Expense expense = _db.Expenses.FirstOrDefault<Expense>(e => e.ExpenseId == id);
            //check if expense is null
            if (expense == null)
            {
                expense = new Expense();
            }
            return expense;
        }
        //insert data to the database
        public Expense addExpense(Expense expense)
        {
            _db.Expenses.Add(expense);
            _db.SaveChanges();
            return expense;
        }
        //async method to insert data to the database
        public async Task<Expense> addExpenseAsync(Expense expense)
        {
            _db.Expenses.Add(expense);
            await _db.SaveChangesAsync();
            return expense;
        }
        //to update data from the database
        public Expense updateExpense(Expense expenseWithChanges)
        {
            Expense expense = _db.Expenses.FirstOrDefault<Expense>(e => e.ExpenseId == expenseWithChanges.ExpenseId);
            if (expense == null)
            {
                throw new Exception($"Expense with id {expenseWithChanges.ExpenseId} not found.");
            }
            else
            {
                _db.Expenses.Update(expenseWithChanges);
                _db.SaveChanges();
            }
            return expense;
        }
        //async method to update data from the database
        public async Task<Expense> updateExpenseAsync(Expense expenseWithChanges)
        {
            Expense expense = await _db.Expenses.FirstOrDefaultAsync<Expense>(e => e.ExpenseId == expenseWithChanges.ExpenseId);
            if (expense == null)
            {
                throw new Exception($"Expense with id {expenseWithChanges.ExpenseId} not found.");
            }
            else
            {
                _db.Expenses.Update(expenseWithChanges);
                await _db.SaveChangesAsync();
            }
            return expense;
        }
        //to delete data from the database
        public Expense deleteExpense(string id)
        {
            Expense expense = _db.Expenses.FirstOrDefault<Expense>(e => e.ExpenseId == id);
            if (expense == null)
            {
                throw new Exception($"Expense with id {id} not found.");
            }
            else
            {
                _db.Expenses.Remove(expense);
                _db.SaveChanges();
            }
            return expense;
        }
        //async method to delete data from the database
        public async Task<Expense> deleteExpenseAsync(string id)
        {
            Expense expense = await _db.Expenses.FirstOrDefaultAsync<Expense>(e => e.ExpenseId == id);
            if (expense == null)
            {
                throw new Exception($"Expense with id {id} not found.");
            }
            else
            {
                _db.Expenses.Remove(expense);
                await _db.SaveChangesAsync();
            }
            return expense;
        }
    }
}
