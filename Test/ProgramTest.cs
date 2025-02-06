using System;
using Xunit;
using VigenereEncrypt;

public class VigenereCipherTests
{
    [Fact]
    public void EncryptTest()
    {
        string text = "HELLO, WORLD!";
        string expectedEncryptedText = "NSZOQ, KRVRR!";
        string key = "GoodCode";

        string actualEncryptedText = VigenereCipher.Encrypt(text, key);

        Assert.Equal(expectedEncryptedText, actualEncryptedText);
    }

    [Fact]
    public void DecryptTest()
    {
        string text = "NSZOQ, KRVRR!";
        string expectedDecryptedText = "HELLO, WORLD!";
        string key = "GoodCode";

        string actualDecryptedText = VigenereCipher.Decrypt(text, key);

        Assert.Equal(expectedDecryptedText, actualDecryptedText);
    }

    [Fact]
    public void EncryptDecryptTest()
    {
        string text = "HELLO, WORLD!";
        string key = "GoodCode";
        string encryptedText = VigenereCipher.Encrypt(text, key);
        string decryptedText = VigenereCipher.Decrypt(encryptedText, key);

        Assert.Equal(text, decryptedText);
    }
}
