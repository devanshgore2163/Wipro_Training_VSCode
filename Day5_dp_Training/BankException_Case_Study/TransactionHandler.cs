using System;
using BankingApp.Exceptions;

namespace BankingApp.Services
{
    public class TransactionHandler
    {
        private decimal balance = 5000;
        private decimal dailyLimit = 2000;

        public void Transfer(decimal amount)
        {
            try
            {
                // Invalid Amount
                if (amount <= 0)
                    throw new InvalidAmountException("Amount must be greater than zero.");

                // Daily Limit
                if (amount > dailyLimit)
                    throw new DailyLimitExceededException("Daily transfer limit exceeded.");

                // Insufficient Balance
                if (amount > balance)
                    throw new InsufficientBalanceException("Insufficient account balance.");

                // Success
                balance -= amount;
                Console.WriteLine("Transfer successful!");
                Console.WriteLine("Remaining Balance: " + balance);
            }
            catch (InvalidAmountException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (DailyLimitExceededException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (InsufficientBalanceException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unknown Error: " + ex.Message);
            }
        }
    }
}
