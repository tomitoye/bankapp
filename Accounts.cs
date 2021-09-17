using System.Buffers.Text;
using System.Threading.Tasks;
using System.Reflection.Metadata;
using System.Security.AccessControl;
using System.Data.SqlTypes;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Globalization;
using System;
using System.Linq;

namespace Bankapp
{
    public class Accounts
    {
        List<Accounts> accountsDatabase = new List<Accounts>();

        Random random = new Random();

        public string name {get; set;}

        public string phoneNumber {get; set;}

        public double accountBalance {get; set;}

        public string accountNumber {get; set;}

        public bool createAccount(string accountName, string phoneNum,double acctBal)
        {
            var model = new Accounts{
                    name = accountName,
                    phoneNumber = phoneNum,
                    accountBalance = acctBal,
                    accountNumber = "30" + random.Next(12345678, 99999999)
            };

            accountsDatabase.Add(model);

            return true;
        }


        public Accounts getUserAccount(string acctName)
        {
           var user = accountsDatabase.FirstOrDefault(x => x.name == acctName);
           return user;
        }

        public bool deposit(string name, int amount)
        {
            var user = accountsDatabase.FirstOrDefault(x => x.name == name);
            user.accountBalance = user.accountBalance + amount;
            accountsDatabase.Add(user);
            return true;
        }

        public double Withdraw(string name, int amount){
            var user = accountsDatabase.FirstOrDefault(x => x.name == name);
            if(user.accountBalance <= 0){
                return 0;
            }

            if(user.accountBalance < amount){
                return -1;
            }

            return user.accountBalance = user.accountBalance - amount;
        }

    }  
}