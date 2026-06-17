using budget_api.Dtos;
using budget_api.Models;

namespace budget_api.Services;

public interface ITransactionService
{
    Task<IEnumerable<Transaction>> GetAllTransactionsAsync(DateOnly? start, DateOnly? end);
    Task<Transaction?> GetTransactionByIdAsync(string id);
    Task<bool> AddTransactionAsync(TransactionDto transaction);
    Task<(bool, string?)> UpdateTransactionByIdAsync(string id, TransactionDto transaction);
    Task<bool> DeleteTransactionByIdAsync(string id);
}