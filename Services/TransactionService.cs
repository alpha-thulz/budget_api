using budget_api.Dtos;
using budget_api.Models;
using budget_api.Repositories;

namespace budget_api.Services;

public class TransactionService(ITransactionRepository repository) : ITransactionService
{
    public async Task<IEnumerable<Transaction>> GetAllTransactionsAsync(DateOnly? start, DateOnly? end)
    {
        if (start == null) return await repository.GetAllAsync();
        
        end ??= DateOnly.FromDateTime(DateTime.Now);
        var transactions = await repository.GetAllAsync();
        return transactions.Where(trans => trans.TransactionDate >= start && trans.TransactionDate <= end);
    }

    public async Task<Transaction?> GetTransactionByIdAsync(string id)
    {
        return await repository.GetByIdAsync(id);
    }

    public async Task<bool> AddTransactionAsync(TransactionDto dto)
    {
        var transaction = new Transaction
        {
            Guid = Guid.NewGuid().ToString(),
            Description = dto.Description,
            Amount = dto.Amount,
            Name = dto.Name,
            TransactionDate = dto.TransactionDate,
            CategoryDefinition = dto.CategoryDefinition
        };

        await repository.AddTransactionAsync(transaction);

        return true;
    }

    public async Task<(bool, string?)> UpdateTransactionByIdAsync(string id, TransactionDto dto)
    {
        var transaction = new Transaction
        {
            Guid = id,
            Name = dto.Name,
            Description = dto.Description,
            Amount = dto.Amount,
            UpdatedAt = DateTime.UtcNow,
            TransactionDate = dto.TransactionDate,
            CategoryDefinition = dto.CategoryDefinition,
            // TransactionType = dto.TransactionType,
            // CategoryGroup = dto.CategoryGroup,
            // Category = dto.Category,
        };

        try
        {
            await repository.UpdateTransactionAsync(id, transaction);
            return (true, null);
        }
        catch (KeyNotFoundException e)
        {
            return (false, e.Message);
        } 
    }

    public async Task<bool> DeleteTransactionByIdAsync(string id)
    {
        return await repository.DeleteTransactionAsync(id);
    }
}