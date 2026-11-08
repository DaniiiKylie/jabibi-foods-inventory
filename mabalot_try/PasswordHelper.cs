using System;
using System.Security.Cryptography;

namespace mabalot_try
{
    // Stores "PBKDF2$iterations$salt$hash", never the password itself.
    public static class PasswordHelper
    {
        private const string Label = "PBKDF2";
        private const int Iterations = 10000;
        private const int SaltBytes = 16;
        private const int HashBytes = 32;

        public static string HashPassword(string password)
        {
            byte[] salt = new byte[SaltBytes];

            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(salt);
            }

            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iterations))
            {
                byte[] hash = pbkdf2.GetBytes(HashBytes);
                return $"{Label}${Iterations}${Convert.ToBase64String(salt)}${Convert.ToBase64String(hash)}";
            }
        }

        public static bool VerifyPassword(string password, string storedHash)
        {
            try
            {
                string[] parts = storedHash.Split('$');

                if (parts.Length != 4 || parts[0] != Label)
                    return false;

                int iterations = int.Parse(parts[1]);
                byte[] salt = Convert.FromBase64String(parts[2]);
                byte[] originalHash = Convert.FromBase64String(parts[3]);

                using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations))
                {
                    byte[] newHash = pbkdf2.GetBytes(originalHash.Length);

                    // Compare every byte even after a mismatch, so the time taken does not show how close a guess was.
                    int difference = 0;

                    for (int i = 0; i < newHash.Length; i++)
                    {
                        difference |= newHash[i] ^ originalHash[i];
                    }

                    return difference == 0;
                }
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
