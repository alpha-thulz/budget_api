using BudgetApi.Dtos;
using BudgetApi.Models;

namespace BudgetApi.Services;

public interface ITransactionService
{
    Task<IEnumerable<Transaction>> GetAllTransactionsAsync(DateOnly? start, DateOnly? end);
    Task<Transaction?> GetTransactionByIdAsync(string id);
    Task<bool> AddTransactionAsync(TransactionDto transaction);
    Task<(bool, string?)> UpdateTransactionByIdAsync(string id, TransactionDto transaction);
    Task<bool> DeleteTransactionByIdAsync(string id);
}