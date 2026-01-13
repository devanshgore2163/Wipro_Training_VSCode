using System;
using Banking.Exceptions;

namespace Banking.Services
{
    public class TransctionHandler
    {
        private decimal balance = 5000;
        private decimal dailylimit = 2000;
        public void transfer(decimal amount)
        {
            try
            {
                if (amount <= 0)
                {
                    throw new InvalidTransactionAmountException("Transaction amount must be greater than zero.");
                }
                if (amount > balance)
                {
                    throw new InsufficientBalanceException("Insufficient balance for the transaction.");
                }
                if (amount > dailylimit)
                {
                    throw new LimitExceededException("Transaction amount exceeds daily limit.");
                }

                balance -= amount;
                Console.WriteLine($"Transaction of {amount} successful. Remaining balance: {balance}");
            }
            catch (InvalidTransactionAmountException ex)
            {
                Console.WriteLine($"Invalid Transaction: {ex.Message}");
            }
            catch (InsufficientBalanceException ex)
            {
                Console.WriteLine($"Insufficient Balance: {ex.Message}");
            }
            catch (LimitExceededException ex)
            {
                Console.WriteLine($"Limit Exceeded: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }
    }
}
