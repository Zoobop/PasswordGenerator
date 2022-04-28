public static class PasswordGenerator
{
    private static readonly string _alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
    private static readonly string _numbers = "0123456789";
    private static readonly string _symbols = "~!@#$%^&*?><`_+-=";
    
    private const int DefaultLength = 12;
    
    public static string Generate(int length = DefaultLength)
    {
        var password = string.Empty;
        for (var i = 0; i < length; i++)
        {
            var selector = Random.Shared.Next(0, 2);
            password += selector switch
            {
                1 => GetRandomNumber(),
                2 => GetRandomSymbol(),
                _ => GetRandomLetter()
            };
        }

        return password;
    }

    private static char GetRandomLetter() => _alphabet[Random.Shared.Next(0, _alphabet.Length - 1)];
    private static char GetRandomNumber() => _numbers[Random.Shared.Next(0, _numbers.Length - 1)];
    private static char GetRandomSymbol() => _alphabet[Random.Shared.Next(0, _symbols.Length - 1)];
}