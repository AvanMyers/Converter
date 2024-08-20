using System;

namespace Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string ComandConvertRubToUsd = "1";
            const string ComandConvertRubToEur = "2";
            const string ComandConvertUsdToRub = "3";
            const string ComandConvertUsdToEur = "4";
            const string ComandConvertEurToRub = "5";
            const string ComandConvertEurToUsd = "6";
            const string ComandExit = "7";

            float rublesInWallet;
            float dollarsInWallet;
            float euroInWallet;
            float exchangeCurrncyCount;
            int rubToUsd = 1;
            int rubToEur = 2;
            int usdToRub = 10;
            int usdToEuro = 5;
            int eurToRub = 11;
            int eurToUsd = 6;
            bool isOpen = true;
            string consolComand;

            Console.WriteLine("Здравствуйте. Здесь вы можете обменять валюты");
            Console.WriteLine("Введите количество ваших рублей");
            rublesInWallet = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите количество ваших долларов");
            dollarsInWallet = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите количество ваших евро");
            euroInWallet = Convert.ToSingle(Console.ReadLine());

            string balance = "У вас на счету" + Convert.ToString(rublesInWallet) + "рублей,"
                + Convert.ToString(dollarsInWallet) + "долларов," + Convert.ToString(euroInWallet) + "евро";

            Console.WriteLine($"{ComandConvertRubToUsd}: Перевод рублей в доллары\n \n" +
                $"{ComandConvertRubToEur}: Перевод рублей в евро\n \n" +
                $"{ComandConvertUsdToRub}: Перевод долларов в рубли\n \n" +
                $"{ComandConvertUsdToEur}: Перевод долларов в евро\n \n" +
                $"{ComandConvertEurToRub}: Перевод евро в рубли\n \n" +
                $"{ComandConvertEurToUsd}: Перевод евро в доллары\n \n" +
                $"{ComandExit}: Выход из программы");
            Console.WriteLine("Введите интересующую вас команду");

            while (isOpen)
            {
                consolComand = Console.ReadLine();

                switch (consolComand)
                {
                    case ComandConvertRubToUsd:
                        Console.WriteLine("Обмен рублей в доллары");
                        exchangeCurrncyCount = Convert.ToSingle(Console.ReadLine());

                        if (rublesInWallet >= exchangeCurrncyCount)
                        {
                            rublesInWallet -= exchangeCurrncyCount;
                            dollarsInWallet += exchangeCurrncyCount * rubToUsd;
                            Console.WriteLine(balance);
                        }
                        else
                        {
                            Console.WriteLine("Недостаточно средств");
                        }
                        break;
                    case ComandConvertRubToEur:
                        Console.WriteLine("Обмен рублей в евро");
                        exchangeCurrncyCount = Convert.ToSingle(Console.ReadLine());

                        if (rublesInWallet >= exchangeCurrncyCount)
                        {
                            rublesInWallet -= exchangeCurrncyCount;
                            euroInWallet += exchangeCurrncyCount * rubToEur;
                            Console.WriteLine(balance);
                        }
                        else
                        {
                            Console.WriteLine("Недостаточно средств");
                        }
                        break;
                    case ComandConvertUsdToRub:
                        Console.WriteLine("Обмен долларов в рубли");
                        exchangeCurrncyCount = Convert.ToSingle(Console.ReadLine());

                        if (dollarsInWallet >= exchangeCurrncyCount)
                        {
                            dollarsInWallet -= exchangeCurrncyCount;
                            rublesInWallet += exchangeCurrncyCount * usdToRub;
                            Console.WriteLine(balance);
                        }
                        else
                        {
                            Console.WriteLine("Недостаточно средств");
                        }
                        break;
                    case ComandConvertUsdToEur:
                        Console.WriteLine("Обмен долларов в евро");
                        exchangeCurrncyCount = Convert.ToSingle(Console.ReadLine());

                        if (dollarsInWallet >= exchangeCurrncyCount)
                        {
                            dollarsInWallet -= exchangeCurrncyCount;
                            euroInWallet += exchangeCurrncyCount * usdToEuro;
                            Console.WriteLine(balance);
                        }
                        else
                        {
                            Console.WriteLine("Недостаточно средств");
                        }
                        break;
                    case ComandConvertEurToRub:
                        Console.WriteLine("Обмен евро в рубли");
                        exchangeCurrncyCount = Convert.ToSingle(Console.ReadLine());

                        if (euroInWallet >= exchangeCurrncyCount)
                        {
                            euroInWallet -= exchangeCurrncyCount;
                            rublesInWallet += exchangeCurrncyCount * eurToRub;
                            Console.WriteLine(balance);
                        }
                        else
                        {
                            Console.WriteLine("Недостаточно средств");
                        }
                        break;
                    case ComandConvertEurToUsd:
                        Console.WriteLine("Обмен евро в доллары");
                        exchangeCurrncyCount = Convert.ToSingle(Console.ReadLine());

                        if (euroInWallet >= exchangeCurrncyCount)
                        {
                            euroInWallet -= exchangeCurrncyCount;
                            dollarsInWallet += exchangeCurrncyCount * eurToUsd;
                            Console.WriteLine(balance);
                        }
                        else
                        {
                            Console.WriteLine("Недостаточно средств");
                        }
                        break;
                    case ComandExit:
                        Console.WriteLine("Досвидание");
                        isOpen = false;
                        break;
                    default:
                        Console.WriteLine("Нет такой команды");
                        break;

                }
            }
            Console.ReadKey();
        }
    }
}
