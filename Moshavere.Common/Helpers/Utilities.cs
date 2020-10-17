using System;
using System.Collections.Generic;
using System.Text;

namespace Moshavere.Common.Helpers
{
    public class Utilities
    {
        public static void CreatePasswordHash(string Password,out byte[] PasswordHash,out byte[] PasswordSalt)
        {
            using (var hmac=new System.Security.Cryptography.HMACSHA512())
            {
                PasswordSalt = hmac.Key;
                PasswordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(Password));

            }
        }

        public static bool VerifyPasswordHash(string Password, byte[] PasswordHash, byte[] PasswordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(PasswordSalt))
            {
                var ComputeHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(Password));
                for (int i = 0; i < ComputeHash.Length; i++)
                {
                    if (ComputeHash[i] != PasswordHash[i])
                        return false;
                   
                }

            }
            return true;
        }
    }
}
