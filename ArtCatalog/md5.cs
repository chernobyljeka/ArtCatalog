using System.Security.Cryptography;
using System.Text;

namespace ArtCatalog
{
    class md5
    {
        public string HashMD5(string Source)
        {
            byte[] hash = Encoding.ASCII.GetBytes(Source);
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] hashenc = md5.ComputeHash(hash);
            string result = "";
            foreach (var b in hashenc)
            {
                result += b.ToString("x2");
            }
            return result;
        }
    }
}
