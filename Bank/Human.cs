using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Human
    {
        private string _name;
        private string _numberScore;
        private int _money;
        private bool _isHave = false;
        int a = '-';
        public void GetNumber()
        {
            Console.WriteLine($"Ваш номер счёта - {_numberScore}");
        }

        public void DeleteNumber(Bank1 bank, Human hum)
        {
            if (_isHave == true)
            {
                _isHave = false;
                bank.CloseScore(hum, bank);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("У вас нет счёта в банке");
                Console.WriteLine();
            }
        }

        public int GetMoney()
        {
            return _money;
        }
        public int AmountOfMoney()
        {
            Console.WriteLine("Введите количество ваших денег.");
            string money1 = Console.ReadLine();
            int money = int.Parse(money1);
            _money = money;
            return _money;
        }
        public int Deposit()
        {
            _money = _money - 2000;
            _isHave = true;
            Console.WriteLine();
            Console.WriteLine($"Денег осталось {_money}");
            Console.WriteLine();
            return _money;
        }

        public int TopUpAccount()
        {
            string upAccount = Console.ReadLine();
            int upAccount1 = int.Parse(upAccount);
            if (_money >= upAccount1 & upAccount1! > 0)
            {
                _money = _money - upAccount1;
                Console.WriteLine("Вы пополнили счёт");
                return upAccount1;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"Вы ввели некоректную сумму или у вас нет столько денег");
                Console.WriteLine();
            }
            return 0;
        }

        public int WitchDrawMoney(Bank1 bank)
        {
            string a = Console.ReadLine();
            int b = int.Parse(a);
            if (bank.GetAccountMoney() < b)
            {
                Console.WriteLine("На вашем счету недостаточно средств");
            }
            else if (bank.GetAccountMoney() >= b)
            {
                if (bank.GetAccountMoney() != 0 & b! > 0)
                {
                    _money = _money + b;
                    return b;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"Введите коректную сумму");
                    Console.WriteLine();
                }

            }

            return 0;
        }
        public string SetName()
        {
            if (_isHave == true)
            {
                Console.WriteLine("У вас уже есть счёт в банке");
                return _name;
            }
            else
            {
                Console.WriteLine("Введите ваше имя");
                string name = Console.ReadLine();
                _name = name;
                return _name;
            }
        }
        public string GetName()
        {
            return _name;
        }
        public int TakeMoney(Bank1 bank)
        {
            _money = _money + bank.GetAccountMoney();
            Console.WriteLine();
            Console.WriteLine($"Деньги со счёта вернулись, количество ваших денег - {_money}");
            return _money;
        }
        public bool IsHave()
        {
            return _isHave;
        }
    }
}

