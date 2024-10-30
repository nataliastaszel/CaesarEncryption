using CaesarEncryption.Utilities;

namespace CaesarEncryption;

public class UserConsoleInteraction: IUserConsoleInteraction
{
    public void DisplayOptions()
    {
        Console.WriteLine(
            "Program szyfrujący i deszyfrujący tekst za pomocą Szyfru Cezara (uwzględniając polski alfabet)");

        Console.WriteLine("Wybierz opcję:");
        Console.WriteLine("1 - Szyfrowanie");
        Console.WriteLine("2 - Deszyfrowanie");
    }

    public int ChooseOperation()
    {
        do
        {
            DisplayOptions();
            var answer = Console.ReadLine();
            if (answer.Length > 0 && answer is "1" or "2")
            {
                return int.Parse(answer);
            }
        } while (true);
    }
    
    public string GetMessage()
    {
        do
        {
            Console.WriteLine("Podaj tekst:");
            var message = Console.ReadLine().ToUpper();
            if (message.Length > 0 && message.All(char.IsLetter))
            {
                return message;
            }
        } while (true);
    }

    public int GetEncryptionKey()
    {
        do
        {
            Console.WriteLine("Podaj klucz szyfrowania czyli ilość przesunięć(max - długość polskiego alfabetu):");
            var encryptionKey = Console.ReadLine();
            if (encryptionKey.Length > 0 && encryptionKey.All(char.IsDigit) &&
                int.Parse(encryptionKey) <= AlphabetConfig.AlphabetLength)
            {
                return int.Parse(encryptionKey);
            }
        } while (true);
    }

}