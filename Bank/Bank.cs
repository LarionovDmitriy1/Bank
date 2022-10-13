using Bank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Bank1
    {
        private string _bankName;
        private int _accountMoney;
        private int _min;
        private int _interestOnDeposit;
        private bool _scoreCheck = false;
        public Bank1()
        {
            _interestOnDeposit = 5;
            _min = 2000;
        }
        public bool OpenScore(Human hum)
        {
            if (_scoreCheck == true)
            {
                Console.WriteLine("У вас уже есть счёт");
                return _scoreCheck;
            }
            else if (_scoreCheck == false)
            {
                if (hum.AmountOfMoney() < 2000)
                {
                    Console.WriteLine();
                    Console.WriteLine("Нехватает денег для открытия счёта");
                    Console.WriteLine();
                    return false;
                }
                else
                {
                    Console.WriteLine("Начальный взнос для открытия счёта 2000, вы уверены что хотите открыть счёт?");
                    Console.WriteLine("1. Да");
                    Console.WriteLine("2. Нет");
                    string confrimed = Console.ReadLine();
                    int confirmed1 = int.Parse(confrimed);
                    if (confirmed1 == 1)
                    {
                        hum.Deposit();
                        GetNumber(hum);
                        _accountMoney = _accountMoney + 2000;
                        _scoreCheck = true;
                        return _scoreCheck;
                    }


                    else if (confirmed1 == 2)
                    {
                        _scoreCheck = false;
                        return _scoreCheck;
                    }
                }
            }
            return false;
        }

        public void TopUpAccount(Human hum)
        {
            if (_scoreCheck == true)
            {
                Console.WriteLine();
                Console.WriteLine("Введите количество денег, которые вы хотите положить на этот счёт");
                Console.WriteLine();
                _accountMoney = _accountMoney + hum.TopUpAccount();
                Console.WriteLine($"На вашем счету - {_accountMoney}");
                Console.WriteLine($"Денег на руках - {hum.GetMoney()}");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("У вас нет счёта в банке");
                Console.WriteLine();
            }
        }

        public void ScoreInfo()
        {
            if (_scoreCheck == true)
            {
                Console.WriteLine();
                Console.WriteLine($"Номер вашего счёта - {SetNumberScore()}");
                Console.WriteLine($"Денег на счету - {_accountMoney}");
                Console.WriteLine($"Процент по вкладу - 5%");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("У вас нет счёта в банке");
                Console.WriteLine();
            }
        }

        public void CloseScore(Human hum, Bank1 bank)
        {
            if (_scoreCheck == true)
            {
                if (_accountMoney == 0)
                {
                    _scoreCheck = false;
                    _accountMoney = 0;
                    Console.WriteLine();
                    Console.WriteLine("Счёт закрыт");
                    Console.WriteLine();
                }
                else
                {
                    hum.TakeMoney(bank);
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("У вас нет счёта в банке");
                Console.WriteLine();
            }
        }

        public void WithdrawMoney(Human hum, Bank1 bank)
        {
            if (_scoreCheck == true)
            {
                Console.WriteLine();
                Console.WriteLine("Введите количество денег, которые вы хотите снять с этого счёта");
                Console.WriteLine();

                _accountMoney = _accountMoney - hum.WitchDrawMoney(bank);
                Console.WriteLine($"На вашем счету - {_accountMoney}");
                Console.WriteLine($"Денег на руках - {hum.GetMoney()}");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("У вас нет счёта в банке");
                Console.WriteLine();
            }
        }

        public void AmmountPerYear()
        {
            if (_scoreCheck == true)
            {
                int month = _accountMoney * _interestOnDeposit / 100;
                int year = _accountMoney + month * 12;
                Console.WriteLine();
                Console.WriteLine($"через год ваш счёт будет составлять - {year}");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("У вас нет счёта в банке");
                Console.WriteLine();
            }
        }
        public string SetNumberScore()
        {

            string score = "6666666";
            return score;
        }
        public void GetNumber(Human hum)
        {
            Console.WriteLine($"Номер вашего счёта - {SetNumberScore()}");
            Console.WriteLine($"Имя владельца счёта - {hum.GetName()}");
            Console.WriteLine();
        }
        public int GetAccountMoney()
        {
            return _accountMoney;
        }
        public string SetNameBank()
        {
            _bankName = "Tinkoff";
            return _bankName;
        }
    }
}

