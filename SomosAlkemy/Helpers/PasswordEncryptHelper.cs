using System.Security.Cryptography;
using System.Text;

namespace SomosAlkemy.Helpers
{
    public static class PasswordEncryptHelper
    {
        public static string EncryptPassword(string password)
        {
            var salt = CreateSalt();
            string saltAndPwd = String.Concat(password, salt);
            var sha256 = SHA256.Create();
            var encoding = new ASCIIEncoding();
            var stream = Array.Empty<byte>();
            var sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(saltAndPwd));
            for (int i = 0; i < stream.Length; i++)
            {
                sb.AppendFormat("{0:x2}", stream[i]);
            }
            return sb.ToString();
        }

        public static string CreateSalt()
        {
            var salt = "SomosAlkemy";
            byte[] saltBytes;
            string saltStr;
            saltBytes = ASCIIEncoding.ASCII.GetBytes(salt);
            long XORED = 0x00;

            foreach (byte x in saltBytes)
            {
                XORED = XORED ^ x;
            }

            Random random = new Random(Convert.ToInt32(XORED));
            saltStr = random.Next().ToString();
            saltStr += random.Next().ToString();
            saltStr += random.Next().ToString();
            saltStr += random.Next().ToString();
            saltStr += random.Next().ToString();
            return saltStr;
        }
    }
}
