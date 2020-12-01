using System;
using System.Collections.Generic;
using System.Text;

namespace Day3
{
    
    public class Bank
    {
        private double totalBankMoney;
        public string bankName;
        public string welcomeText = "Hello customer!";

        public Bank(string name, double cashForStart)
        {
            Name = name;
            TotalCash = cashForStart;
        }

        private string Name
        {
            get 
            { 
                return bankName;
            }
            set 
            {
                bankName = value;
            }
        }
        private double TotalCash
        {
            get
            {
                return totalBankMoney;
            }
            set
            {
                totalBankMoney = value;
            }
        }
    }
}
