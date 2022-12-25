using System;
namespace Financial.Services.OpenBank.Core.Domain
{
    public class Account
    {
        private Guid id;
        private Guid userId;
        private decimal amount;

        public Account()
        {
        }

        public Guid Id { get => id; set => id = value; }

        public Guid UserId { get => userId; set => userId = value; }

        public decimal Amount { get => amount; private set => amount = value; }
    }
}
