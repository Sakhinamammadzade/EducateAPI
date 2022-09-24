using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Core.Security.Hashing
{
    public class HashingHelper
    {
        public static void HashPassword(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using var hash = new HMACSHA512();
            passwordSalt = hash.Key;
            passwordHash = hash.ComputeHash(Encoding.UTF8.GetBytes(password));

        }

        public static bool Verify(string VerifyPassword, byte[] passwordHash, byte[] passwordSalt)
        {
            using var hash = new HMACSHA512(passwordSalt);
            var hashedPassword = hash.ComputeHash(Encoding.UTF8.GetBytes(VerifyPassword));
            for (int i = 0; i < hashedPassword.Length; i++)
            {
                if (hashedPassword[i] != passwordHash[i])
                {
                    return false;
                }
            }

            return true;
        }


    }
}
