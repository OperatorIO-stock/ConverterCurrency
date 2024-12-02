namespace ConverterCurrency;

class Program
{
    static void Main(string[] args)
    {
        const string CommandForExchangeGoldToSilver = "/gold to silver";
        const string CommandForExchangeSilverToGold = "/silver to gold";
        const string CommandForExchangeGoldToPlatinum = "/gold to platinum";
        const string CommandForExchangePlatinumToGold = "/platinum to gold";
        const string CommandForExchangeSilverToPlatinum = "/silver to platinum";
        const string CommandForExchangePlatinumToSilver = "/platinum to silver";

        const string CommandExitProgram = "/exit";

        float fixedExchangeGoldToSilver = 2.3f;
        float fixedExchangeGoldToPlatinum = 1.3f;
        float fixedExchangeSilverToGold = 0.46f;
        float fixedExchangeSilverToPlatinum = 0.5f;
        float fixedExchangePlatinumToSilver = 2f;
        float fixedExchangePlatinumToGold = 0.76f;

        float goldMoney = 73;
        float silverMoney = 8;
        float platinumMoney = 12;

        float userInputAmountCurrency;

        bool isProgramWork = true;

        Console.WriteLine("Welcome to converter");
        Console.WriteLine($"List of Commands:\n{CommandForExchangeGoldToSilver}\n{CommandForExchangeSilverToGold}\n{CommandForExchangeGoldToPlatinum}\n" + 
                            $"{CommandForExchangePlatinumToGold}\n{CommandForExchangeSilverToPlatinum}\n{CommandForExchangePlatinumToSilver}\n\n{CommandExitProgram}");

        while(isProgramWork)
        {
            Console.WriteLine($"Your balance:\nGold - [{goldMoney}]\nSilver - [{silverMoney}]\nPlatinum - [{platinumMoney}]");

            switch(Console.ReadLine())
            {
                case CommandForExchangeGoldToSilver:
                    Console.WriteLine("Enter the amount of currency");
                    userInputAmountCurrency = float.Parse(Console.ReadLine());

                    if (goldMoney >= userInputAmountCurrency && userInputAmountCurrency > 0)
                    {
                        silverMoney += userInputAmountCurrency * fixedExchangeGoldToSilver;
                        goldMoney -= userInputAmountCurrency;
                    }
                    else
                    {
                        Console.WriteLine("There are not enough funds to exchange or the requested amount is invalid.");
                    }
                    break;

                case CommandForExchangeSilverToGold:
                    Console.WriteLine("Enter the amount of currency");
                    userInputAmountCurrency = float.Parse(Console.ReadLine());
                    
                    if (silverMoney >= userInputAmountCurrency && userInputAmountCurrency > 0)
                    {
                        goldMoney += userInputAmountCurrency * fixedExchangeSilverToGold;
                        silverMoney -= userInputAmountCurrency;
                    }
                    else
                    {
                        Console.WriteLine("There are not enough funds to exchange or the requested amount is invalid.");
                    }
                    break;           

                case CommandForExchangeGoldToPlatinum:
                    Console.WriteLine("Enter the amount of currency");
                    userInputAmountCurrency = float.Parse(Console.ReadLine());
                    
                    if (goldMoney >= userInputAmountCurrency && userInputAmountCurrency > 0)
                    {
                        platinumMoney += userInputAmountCurrency * fixedExchangeGoldToPlatinum;
                        goldMoney -= userInputAmountCurrency;
                    }
                    else
                    {
                        Console.WriteLine("There are not enough funds to exchange or the requested amount is invalid.");
                    }
                    break;

                case CommandForExchangePlatinumToGold:
                    Console.WriteLine("Enter the amount of currency");
                    userInputAmountCurrency = float.Parse(Console.ReadLine());
                    
                    if (platinumMoney >= userInputAmountCurrency && userInputAmountCurrency > 0)
                    {
                        goldMoney += userInputAmountCurrency * fixedExchangePlatinumToGold;
                        platinumMoney -= userInputAmountCurrency;
                    }
                    else
                    {
                        Console.WriteLine("There are not enough funds to exchange or the requested amount is invalid.");
                    }
                    break;

                case CommandForExchangeSilverToPlatinum:
                    Console.WriteLine("Enter the amount of currency");
                    userInputAmountCurrency = float.Parse(Console.ReadLine());
                    
                    if (silverMoney >= userInputAmountCurrency && userInputAmountCurrency > 0)
                    {
                        platinumMoney += userInputAmountCurrency * fixedExchangeSilverToPlatinum;
                        silverMoney -= userInputAmountCurrency;
                    }
                    else
                    {
                        Console.WriteLine("There are not enough funds to exchange or the requested amount is invalid.");
                    }
                    break;

                case CommandForExchangePlatinumToSilver:
                    Console.WriteLine("Enter the amount of currency");
                    userInputAmountCurrency = float.Parse(Console.ReadLine());
                    
                    if (platinumMoney >= userInputAmountCurrency && userInputAmountCurrency > 0)
                    {
                        silverMoney += userInputAmountCurrency * fixedExchangePlatinumToSilver;
                        platinumMoney -= userInputAmountCurrency;
                    }
                    else
                    {
                        Console.WriteLine("There are not enough funds to exchange or the requested amount is invalid.");
                    }
                    break;

                case CommandExitProgram:
                    Console.Clear();
                    Console.WriteLine("Exiting the program");
                    
                    isProgramWork = false;
                    break;

                default:
                    Console.WriteLine("Not found command");
                    break;
            }
        }
    } 
}
