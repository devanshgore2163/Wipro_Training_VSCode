using System;

namespace Banking.Exceptions
{

    public class InvalidTransactionAmountException : Exception
    {
        public InvalidTransactionAmountException(string message):base(message){}
    }
    public class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException(string message):base(message){}
    }
    public class LimitExceededException : Exception
    {
        public LimitExceededException(string message):base(message){}
    }

}