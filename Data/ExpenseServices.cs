using myproject1.Respositories;
using myproject1.Data;
namespace myproject1.Data
{
    public class ExpenseServices
    {
        // Dependency injection of the ExpenseRepo
        private readonly ExpenseRepo _expenseRepo;
        //reference to the database context
        private readonly MyDbcontex _db;
        //constructor to initialize the ExpenseRepo and database context
        public ExpenseServices(MyDbcontex db)
        {
            _db = db;
            _expenseRepo = new ExpenseRepo(_db);
        }
        //CRUD operations for Expense entity
        //metod to go through the expense repo to get all expenses
        public IEnumerable<Expense> GetAllExpenses()
        {
            return _expenseRepo.GetAllExpenses();
        }  //assynchronous method to get all expenses
        public async Task<IEnumerable<Expense>> GetAllExpensesAsync()
        {
            return await _expenseRepo.GetAllExpensesAsync();
        }
        //method to get specific expense by id
        public Expense GetExpenseById(string id)
        {
            return _expenseRepo.GetExpenseById(id);
        }
        //asynchronous method to get specific expense by id
        public async Task<Expense> GetExpenseByIdAsync(string id)
        {
            return await Task.Run(() => _expenseRepo.GetExpenseById(id));
        }
        //method to add new expense
        public Expense addExpense(Expense expense)
        {
            return _expenseRepo.addExpense(expense);
        }
        //asynchronous method to add new expense
        public async Task<Expense> addExpenseAsync(Expense expense)
        {
            return await _expenseRepo.addExpenseAsync(expense);
        }
        //method to update existing expense
        public Expense updateExpense(Expense expenseWithChanges)
        {
            return _expenseRepo.updateExpense(expenseWithChanges);
        }
        //asynchronous method to update existing expense
        public async Task<Expense> updateExpenseAsync(Expense expenseWithChanges)
        {
            return await _expenseRepo.updateExpenseAsync(expenseWithChanges);
        }
        //method to delete expense by id
        public Expense deleteExpense(string id)
        {
            return _expenseRepo.deleteExpense(id);
        }
        //async method
        public  async Task<Expense> deleteExpenseAsync(string id)
        {
            return await _expenseRepo.deleteExpenseAsync(id);
        }

    }
}
