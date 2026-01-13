using System;

namespace BankingApp.Exceptions
{
    // Invalid Amount Exception
    public class InvalidAmountException : Exception
    {
        public InvalidAmountException(string message) : base(message) { }
    }

    // Insufficient Balance Exception
    public class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException(string message) : base(message) { }
    }

    // Daily Limit Exception
    public class DailyLimitExceededException : Exception
    {
        public DailyLimitExceededException(string message) : base(message) { }
    }
}
