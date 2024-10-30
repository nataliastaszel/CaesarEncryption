namespace CaesarEncryption;

public interface IUserConsoleInteraction
{
    void DisplayOptions();

    int ChooseOperation();

    string GetMessage();

    int GetEncryptionKey();
}