using budget_api.Exceptions;
using budget_api.Models;

namespace budget_api.Repositories;

public class TransactionRepository : ITransactionRepository
{
    private readonly List<Transaction> _transactions = [];
    
    public async Task<IEnumerable<Transaction>> GetAllAsync()
    {
        return await Task.FromResult(_transactions.ToList());
    }

    public async Task<Transaction?> GetByIdAsync(string id)
    {
        var transaction = _transactions.FirstOrDefault(x => x.Guid == id);
        
        if (transaction is null) throw new TransactionNotFoundException(id);
        
        return await Task.FromResult(transaction);
    }

    public async Task<Transaction> AddTransactionAsync(Transaction dto)
    {
        var guid = Guid.NewGuid().ToString();
        var transaction = new Transaction
        {
            Guid = guid,
            Name = dto.Name,
            Description = dto.Description,
            Amount = dto.Amount,
            CategoryDefinition = dto.CategoryDefinition,
            // TransactionType = dto.TransactionType,
            // Category = dto.Category,
            // CategoryGroup = dto.CategoryGroup,
        };

        _transactions.Add(transaction);

        return await Task.FromResult(transaction);
    }

    public async Task<Transaction> UpdateTransactionAsync(string id, Transaction dto)
    {
        var index = _transactions.FindIndex(transaction => transaction.Guid == id);

        if (index < 0) throw new TransactionNotFoundException(id);

        var update = _transactions[index];

        update.Name = dto.Name;
        update.Description = dto.Description;
        update.Amount = dto.Amount;
        update.UpdatedAt = dto.UpdatedAt;
        update.TransactionDate = dto.TransactionDate;
        update.CategoryDefinition = dto.CategoryDefinition;
        // update.TransactionType = dto.TransactionType;
        // update.Category = dto.Category;
        // update.CategoryGroup = dto.CategoryGroup;
        
        return await Task.FromResult(dto);
    }

    public async Task<bool> DeleteTransactionAsync(string id)
    {
        var transaction = await GetByIdAsync(id);

        if (transaction is null) return await Task.FromResult(false);

        _transactions.Remove(transaction);
        return await Task.FromResult(true);
    }
}