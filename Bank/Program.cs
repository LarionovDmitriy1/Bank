using Bank;
using System;
Human hum = new Human();
Bank1 bank = new Bank1();
while (true)
{
    Menu();
}
void Menu()
{
    Console.WriteLine();
    Console.WriteLine($"Меню банка {bank.SetNameBank()}");
    Console.WriteLine();
    Console.WriteLine("1. Открыть Счёт");
    Console.WriteLine("2. Пополнить счёт");
    Console.WriteLine("3. Посмотреть информацию по счёту");
    Console.WriteLine("4. Закрыть счёт");
    Console.WriteLine("5. Снять деньги");
    Console.WriteLine("6. Расчитать сумму, которая будет на счету через год");
    string a = Console.ReadLine();
    int menu = int.Parse(a);
    if (menu == 1)
    {
        hum.SetName();
        Console.WriteLine();
        Console.WriteLine("Начальный взнос для открытия счёта 2000");
        Console.WriteLine();
        bank.OpenScore(hum);
    }
    else if (menu == 2)
    {
        bank.TopUpAccount(hum);
    }
    else if (menu == 3)
    {
        bank.ScoreInfo(hum);
    }
    else if (menu == 4)
    {
        hum.DeleteNumber(bank, hum);
    }
    else if (menu == 5)
    {
        bank.WithdrawMoney(hum, bank);
    }
    else if (menu == 6)
    {
        bank.AmmountPerYear(hum);
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Ошибка, такого пункта нет");
        Console.WriteLine();
    }
}