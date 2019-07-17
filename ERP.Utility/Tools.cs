using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Text;

namespace ERP.Utility
{
    public static class Tools
    {
        public static bool EmailCheck(string email)
        {
            return new EmailAddressAttribute().IsValid(email);
        }
        //using System.Security.Cryptography;
        public static string HashPassword(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }


        //public static bool PasswordCheck(string passwordInput, string passwordDB)
        //{
        //    string hashOfInput = HashPassword(passwordInput);

        //    // Create a StringComparer an compare the hashes.
        //    StringComparer comparer = StringComparer.OrdinalIgnoreCase;

        //    if (0 == comparer.Compare(hashOfInput, passwordDB))
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}


        ///howtoUse Password Check
        /// if (VerifyMd5Hash(md5Hash, source, hash))
        //{
        //    Console.WriteLine("The hashes are the same.");
        //}
        //else
        //{
        //    Console.WriteLine("The hashes are not same.");
        //}
    }
}
