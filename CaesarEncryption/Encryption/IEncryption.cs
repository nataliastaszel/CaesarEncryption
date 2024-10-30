namespace CaesarEncryption;

public interface IEncryption
{
    string Encrypt(string text, int shift);

    string Decrypt(string text, int shift);
}