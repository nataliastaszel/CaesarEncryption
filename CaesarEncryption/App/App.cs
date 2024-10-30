namespace CaesarEncryption;

public class App
{
    private readonly IEncryption _encryption;
    private readonly IUserConsoleInteraction _userConsoleInteraction;

    public App(IEncryption encryption, IUserConsoleInteraction userConsoleInteraction)
    {
        _encryption = encryption;
        _userConsoleInteraction = userConsoleInteraction;
    }

    public void Run()
    {
        var choice = _userConsoleInteraction.ChooseOperation();
        if (choice == 1)
        {
            string encryptedMessage = _encryption.Encrypt(
                _userConsoleInteraction.GetMessage(),
                _userConsoleInteraction.GetEncryptionKey());
            Console.WriteLine($"Zaszyfrowana wiadomość to: {encryptedMessage}");
        }


        else
        {
            string decryptedMessage = _encryption.Decrypt(
                _userConsoleInteraction.GetMessage(),
                _userConsoleInteraction.GetEncryptionKey());
            Console.WriteLine($"Odszyfrowana wiadomość to: {decryptedMessage}");
        }
    }
}