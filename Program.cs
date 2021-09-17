using System.Runtime.InteropServices;
using System.Reflection.Metadata;
using System.Net.Http.Headers;
using System.Collections.Concurrent;
using System.Runtime.Serialization;
using System.Runtime.Intrinsics.X86;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Data;
using System;

namespace Bankapp
{
    public  class Program
    {
        static void Main(string[] args)
        {
            Accounts accountDetails = new Accounts();
            accountDetails.createAccount("Alabi Ayo","30114731208", 2000);

            accountDetails.createAccount("Ola Juwon","30114731209", 2000);

            accountDetails.createAccount("Toye Tomi","30114731220", 2000);

            accountDetails.createAccount("Dare Adekoya","30114731221", 2000);

            accountDetails.createAccount("Adeyemi Leah","30114731210", 2000);

            int userInput;


         do
            {
                Console.WriteLine("Welcome to Tito'S bank application!!");

                Console.WriteLine("What will you like to do?");

                Console.WriteLine("Kindly pick from the following options");

                Console.WriteLine(" press 1 for DEPOSIT");

                Console.WriteLine("press 2 for WITHDRAWAL");

                Console.WriteLine("press 3 for ACCOUNT DETAILS");

                Console.WriteLine("press 4 to DELETE ACCOUNT");

                userInput = int.Parse(Console.ReadLine());


                if(userInput == 1)
                {


                    Console.WriteLine("DEPOSIT");
                    Console.WriteLine("Please input your name. ");
                    var inputName = Console.ReadLine();
                    Console.WriteLine("Please input the amount you want to deposit ");
                    var amountDeposited = int.Parse(Console.ReadLine());
                    var res = accountDetails.deposit(inputName, amountDeposited);
                    if(res == true)
                    {
                        Console.WriteLine("Your Amount has been deposited succesfully");
                    ;
                    }else
                    {
                        Console.WriteLine("Deposit failed");
                    }
                    Console.Read();
                    Console.Read();

                }
                else if(userInput == 2)
                {

                    Console.WriteLine("WITHDRAWAL");
                    Console.WriteLine("Please input your name. ");
                    var name = Console.ReadLine();
                    Console.WriteLine("Please input the amount you want to withdraw ");
                    var amount = int.Parse(Console.ReadLine());
                    var wtd = accountDetails.Withdraw(name, amount);

                    if(wtd == 0)
                    {
                        Console.WriteLine("insufficient fund");
                    }
                    else if(wtd == -1)
                    {
                        Console.WriteLine("insufficient fund");
                    }
                    else
                    {
                        Console.WriteLine("your account balance is:" + wtd);
                    }
                     Console.Read();
                     Console.Read();

                }
                else if(userInput == 3)
                {

                    Console.WriteLine("ACCOUNT DETAILS");
                    Console.WriteLine("Please input your name. ");


                    var userName = Console.ReadLine();

                    var result = accountDetails.getUserAccount(userName);

                    Console.WriteLine("Name:" + result.name);

                    Console.WriteLine("phoneNumber: " + result.phoneNumber);

                    Console.WriteLine("accountBalance: " + result.accountBalance);

                    Console.WriteLine("accountnumber: " + result.accountNumber);

                }
                else if(userInput == 0)
                {

                    Console.WriteLine("DELETE ACCOUNT");
                    Console.WriteLine("Please input your name. ");
                    Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("You have not chosen any option");
                }
                    Console.Read();
                    Console.Read();

            } while(userInput != 0);




        }  
    }
}