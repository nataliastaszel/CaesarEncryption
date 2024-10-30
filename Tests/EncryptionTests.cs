using CaesarEncryption;

namespace Tests;

public class Tests
{
    private IEncryption _encryptor;

    [SetUp]
    public void Setup()
    {
        _encryptor = new CaesarAlgorithm();
    }

    [TestCase("KOT", 3, "MQW")]
    [TestCase("KOT", 0, "KOT")]
    [TestCase("ZŹŻ", 3, "AĄB")]
    public void Encrypt_ShallReturnEncryptedMessage_ForValidParameters(string text, int shift, string expectedMessage)
    {
        string result = _encryptor.Encrypt(text, shift);

        Assert.AreEqual(expectedMessage, result);
    }

    [TestCase("MQW", 3, "KOT")]
    [TestCase("MQW", 0, "MQW")]
    [TestCase("AĄB", 3, "ZŹŻ")]
    public void Decrypt_ShallReturnDecryptedMessage_ForValidParameters(string text, int shift, string expectedMessage)
    {
        string result = _encryptor.Decrypt(text, shift);

        Assert.AreEqual(expectedMessage, result);
    }
}