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

        float fixedExchange;
        float fixedExchangeGoldToSilver = 2.3f;
        float fixedExchangeGoldToPlatinum = 1.3f;
        float fixedExchangeSilverToGold = 1 / 2.3f;
        float fixedExchangeSilverToPlatinum = 0.5f;
        float fixedExchangePlatinumToSilver = 1 / 0.5f;
        float fixedExchangePlatinumToGold = 1 / 1.3f;

        float goldMoney = 73;
        float silverMoney = 8;
        float platinumMoney = 12;

        float selectedCurrency;
        float secondCurrency;

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
                    fixedExchange = fixedExchangeGoldToSilver;
                    selectedCurrency = goldMoney;
                    secondCurrency = silverMoney;

                    Converter(ref selectedCurrency, ref secondCurrency, fixedExchange);

                    goldMoney = selectedCurrency;
                    silverMoney = secondCurrency;
                    break;

                case CommandForExchangeSilverToGold:
                    fixedExchange = fixedExchangeSilverToGold;
                    selectedCurrency = silverMoney;
                    secondCurrency = goldMoney;

                    Converter(ref selectedCurrency, ref secondCurrency, fixedExchange);

                    silverMoney = selectedCurrency;
                    goldMoney = secondCurrency;           
                    break;

                case CommandForExchangeGoldToPlatinum:
                    fixedExchange = fixedExchangeGoldToPlatinum;
                    selectedCurrency = goldMoney;
                    secondCurrency = platinumMoney;

                    Converter(ref selectedCurrency, ref secondCurrency, fixedExchange); 

                    goldMoney = selectedCurrency;
                    platinumMoney = secondCurrency;                   
                    break;

                case CommandForExchangePlatinumToGold:
                    fixedExchange = fixedExchangePlatinumToGold;
                    selectedCurrency = platinumMoney;
                    secondCurrency = goldMoney;

                    Converter(ref selectedCurrency, ref secondCurrency, fixedExchange);

                    platinumMoney = selectedCurrency;
                    goldMoney = secondCurrency;                    
                    break;

                case CommandForExchangeSilverToPlatinum:
                    fixedExchange = fixedExchangeSilverToPlatinum;
                    selectedCurrency = silverMoney;
                    secondCurrency = platinumMoney;

                    Converter(ref selectedCurrency, ref secondCurrency, fixedExchange);

                    silverMoney = selectedCurrency;
                    platinumMoney = secondCurrency;                    
                    break;

                case CommandForExchangePlatinumToSilver:
                    fixedExchange = fixedExchangePlatinumToSilver;
                    selectedCurrency = platinumMoney;
                    secondCurrency = silverMoney;

                    Converter(ref selectedCurrency, ref secondCurrency, fixedExchange);

                    platinumMoney = selectedCurrency;
                    silverMoney = secondCurrency;                    
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
    static void Converter(ref float selectedCurrency, ref float secondCurrency, float fixedExchange)
    {
        float userInputAmountCurrency;
        float convertedAmount;

        Console.WriteLine("Enter the amount of currency");
        userInputAmountCurrency = float.Parse(Console.ReadLine());

        if (ParseError(selectedCurrency, userInputAmountCurrency))
        {
            convertedAmount = userInputAmountCurrency * fixedExchange;
            secondCurrency += convertedAmount;
            selectedCurrency -= userInputAmountCurrency;
        }
    }
    static bool ParseError(float availableCurrency, float requestedAmount)
    {
        if (availableCurrency < requestedAmount || requestedAmount < 0)
        {
            Console.WriteLine("There are not enough funds to exchange or the requested amount is invalid.");
            return false;
        }
        return true;
    }
}
