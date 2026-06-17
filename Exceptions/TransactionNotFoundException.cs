namespace BudgetApi.Exceptions;

public class TransactionNotFoundException(string message) : Exception(message);