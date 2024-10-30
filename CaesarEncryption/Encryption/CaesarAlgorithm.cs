using CaesarEncryption.Utilities;

namespace CaesarEncryption;

public class CaesarAlgorithm : IEncryption
{
    public string Encrypt(string text, int shift)
    {
        var encryptedMessage = text
            .Select(character => AlphabetConfig.Alphabet.IndexOf(character))
            .Select(index => (index + shift) % AlphabetConfig.AlphabetLength)
            .Aggregate("", (current, newIndex) => current + AlphabetConfig.Alphabet[newIndex]);
        return encryptedMessage;
    }

    public string Decrypt(string text, int shift)
    {
        var decryptedMessage = text
            .Select(character => AlphabetConfig.Alphabet.IndexOf(character))
            .Select(index => (index - shift + AlphabetConfig.AlphabetLength) % AlphabetConfig.AlphabetLength)
            .Aggregate("", (current, newIndex) => current + AlphabetConfig.Alphabet[newIndex]);

        return decryptedMessage;
    }
}