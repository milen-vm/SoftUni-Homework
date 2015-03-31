namespace ATMWithdrawal
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            WithdrawalMoney("1234567890", "4725", 240m);
            WithdrawalMoney("7589641203", "3695", 1500m);
            WithdrawalMoney("7525771203", "1188", 1500m);
            WithdrawalMoney("7735241203", "0212", 1500m);
        }

        private static void WithdrawalMoney(string cardNumber, string cardPin, decimal amount)
        {
            var atmDb = new ATMEntities();

            using (var dbContextTransaction = atmDb.Database.BeginTransaction())
            {
                try
                {
                    var account = atmDb.CardAccounts
                        .FirstOrDefault(a => a.CardNumber == cardNumber);

                    if (account == null)
                    {
                        var messge = string.Format("Invalid card number: {0}", cardNumber);
                        throw new ArgumentException(messge);
                    }

                    if (account.CardPIN != cardPin)
                    {
                        var messge = string.Format("Invalid pin number: {0}", cardPin);
                        throw new ArgumentException(messge);
                    }

                    if (account.CardCash < amount)
                    {
                        var messge = string.Format("Not enough amount of money!\nAvailability: {0}", account.CardCash);
                        throw new ArgumentException(messge);
                    }

                    account.CardCash = account.CardCash - amount;
                    atmDb.SaveChanges();
                    dbContextTransaction.Commit();
                    Console.WriteLine("Withdrawal is successfull.\nRemaining amount: {0}", account.CardCash);

                    SaveTransactionHistory(cardNumber, amount);
                }
                catch (ArgumentException ae)
                {

                    dbContextTransaction.Rollback();
                    Console.WriteLine("Error: " + ae.Message);
                }
                finally
                {
                    Console.WriteLine();
                }
            }
        }

        private static void SaveTransactionHistory(string cardNumber, decimal amount)
        {
            var atmDb = new ATMEntities();

            var newTransaction = new TransactionHistory()
            {
                CardNumber = cardNumber,
                TransactionDate = DateTime.Now,
                Amount = amount
            };

            atmDb.TransactionHistories.Add(newTransaction);
            atmDb.SaveChanges();
        }
    }
}
