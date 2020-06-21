using MicroRabbit.Banking.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Banking.Domain.Interfaces
{
    public class IAccountRepository
    {
        IEnumerable<Account> GetAccounts();
    }
}
