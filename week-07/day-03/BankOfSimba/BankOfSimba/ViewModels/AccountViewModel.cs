using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankOfSimba.Models;

namespace BankOfSimba.ViewModels
{
    public class AccountViewModel
    {
        public List<BankAccounts> BankAccountList { get; set; } = new List<BankAccounts>();

        public void AddNewAccount(BankAccounts newAccount)
        {
            BankAccountList.Add(newAccount);
        }
    }
}
