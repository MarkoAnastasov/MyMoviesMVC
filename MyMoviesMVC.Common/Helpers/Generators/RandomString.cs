using System;

namespace MyMoviesMVC.Common.Helpers
{
    public static class RandomString
    {
        public static string GenerateRandomString(int stringCharsLength)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[stringCharsLength];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(stringChars.Length)];
            }

            return new string(stringChars);
        }
    }
}
