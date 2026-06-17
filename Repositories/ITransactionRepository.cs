using BudgetApi.Dtos;
using BudgetApi.Models;

namespace BudgetApi.Repositories;

public interface ITransactionRepository
{
    Task<IEnumerable<Transaction>> GetAllAsync();
    Task<Transaction?> GetByIdAsync(string id);
    Task<Transaction> AddTransactionAsync(Transaction transaction);
    Task<Transaction> UpdateTransactionAsync(string id, Transaction transaction);
    Task<bool> DeleteTransactionAsync(string id);
}