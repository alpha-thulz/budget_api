namespace budget_api.Exceptions;

public class TransactionNotFoundException(string message) : Exception(message);