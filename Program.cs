using System;
using System.Collections.Generic;
using System.Linq;

namespace ATM
{
    class CardHolder
    {
        string CardNum;
        int pin;
        string Name;
        Double balance;

        public CardHolder(string CardNum, int pin,string Name, Double balance )
        {
            this.CardNum = CardNum;
            this.pin = pin;
            this.Name = Name;
            this.balance = balance;
        }

        public string getNum()
        {
            return CardNum;
        }
        public int getPin()
        {
            return pin;
        }
        public string getname()
        {
            return Name;
        }
       
        public double getBalance()
        {
            return balance;
        }
        //set function
        public void setNum(string newCardNum)
        {
            CardNum = newCardNum;
        }
        public void setpin(int newPin)
        {
            pin = newPin;
        }
        public void setname(string newName)
        {
            Name = newName;
        }
       
        public void setBalance(double newBalance)
        {
            balance = newBalance;
        }


        static void Main(string[] args)
        {
            void PrintOption()
            {

                Console.WriteLine("Please choose from one of the following Options.. ");
                Console.WriteLine("1.  Deposit");
                Console.WriteLine("2.  Withdraw");
                Console.WriteLine("3.  Balance");
                Console.WriteLine("4.  Exit");

            }
            void deposit(CardHolder currentUser)
            {
                Console.WriteLine("How Mouch Money Do You Want to Deposit ? ");
                double deposit = Double.Parse(Console.ReadLine());
                currentUser.setBalance(deposit+currentUser.getBalance());
                Console.WriteLine("Thank you for your Money. ");
                Console.WriteLine("   Your Total Money Is :" + currentUser.getBalance()+"  ");
            }
            void withdrow(CardHolder currentUser)
            {
                Console.WriteLine("Enter Withdrow  Moeny : ");
                double withdrawal = Double.Parse(Console.ReadLine());
                if(currentUser.getBalance() < withdrawal)
                {
                    Console.WriteLine("Insufficient Balance :(  ");

                }
                else
                {
                    currentUser.setBalance(currentUser.getBalance() - withdrawal);
                    Console.WriteLine("Your Last Money Is : )" + currentUser.getBalance());
                }
             
                
            }

            void balance(CardHolder currentUser)
            {
                Console.WriteLine(" current balance : " + currentUser.getBalance());
            }

            List<CardHolder> cardHolder = new List<CardHolder>();
            cardHolder.Add(new CardHolder("30230100012687", 1234, "Khushi",  50000));
            cardHolder.Add(new CardHolder("30230200012678", 1234, "Khushbu",  60000));

            Console.WriteLine("Welcome :) ");
            Console.WriteLine("Please Enter Your Card No. :" );
            string debitCardNum = "";
            CardHolder currentUser;
            while(true)
            {
              
                    debitCardNum = Console.ReadLine();
                    currentUser = cardHolder.FirstOrDefault(a => a.CardNum == debitCardNum);
                    if(currentUser != null)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("Card no. Invalid ");
                    }
               
            }
            Console.WriteLine("Please Enter Your Pin No. : ");
            int UserPin = 0;
            while (true)
            {
                try
                {
                    UserPin = int.Parse(Console.ReadLine());

                    if (currentUser.getPin() == UserPin)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("Invalid Pin. Please Try Again ");
                    }
                }
                catch
                {
                    Console.Write(" Invalid Pin ");
                }
            }
            Console.WriteLine(" Welcome  " + currentUser.getname() + " :)");
            int option = 0;
            do
            {
                PrintOption();
                try
                {
                    option = int.Parse(Console.ReadLine());

                }
                catch { }
                if (option == 1)
                {
                    deposit(currentUser);
                }
                else if(option == 2)
                {
                    withdrow(currentUser);
                }
                else if(option == 3)
                {
                    balance(currentUser);
                }
                else if(option == 4)
                {
                    break;
                }
                else
                {
                    option = 0;
                }

            } while (option != 4);
            Console.WriteLine("ThankYou :)");

        }
    }
}
