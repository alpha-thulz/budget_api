using BudgetApi.Dtos;
using BudgetApi.Models;
using BudgetApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace BudgetApi.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class TransactionController(ITransactionService transactionService) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Transaction>>> GetAllTransactions(DateOnly? start = null, DateOnly? end = null)
    {
        return Ok(await transactionService.GetAllTransactionsAsync(start, end));
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Transaction>> GetTransactionById(string id)
    {
        return Ok(await transactionService.GetTransactionByIdAsync(id));
    }

    [HttpPost]
    public async Task<ActionResult> AddTransaction(TransactionDto transactionDto)
    {
        var isCreated = await transactionService.AddTransactionAsync(transactionDto);
        
        return isCreated ? Created() : BadRequest("Failed to create transaction");
    }

    [HttpPut("{id}")]
    public async Task<ActionResult> UpdateTransaction(string id, TransactionDto transactionDto)
    {
        var (isSuccess, message) = await transactionService.UpdateTransactionByIdAsync(id, transactionDto);
        
        return isSuccess ? Accepted() : BadRequest(message);
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteTransaction(string id)
    {
        var isSuccess = await transactionService.DeleteTransactionByIdAsync(id);

        return isSuccess ? Accepted() : BadRequest("Deletion failed");
    }
}