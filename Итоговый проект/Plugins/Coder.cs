using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Итоговый_проект
{
    class Coder
    {
        public string Coding(string Text1)
        {
            int len2 = Text1.Length;
            RSACryptoServiceProvider rsaCryptoServiceProvider = new RSACryptoServiceProvider(len2);
            
            int keySize = len2 / 8;
            byte[] bytes = Encoding.UTF32.GetBytes(Text1);

            int maxLength = keySize - 4;
            int dataLength = bytes.Length;
            int iterations = dataLength / maxLength;
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i <= iterations; i++)
            {
                byte[] tempBytes = new byte[(dataLength - maxLength * i > maxLength) ? maxLength : dataLength - maxLength * i];
                Buffer.BlockCopy(bytes, maxLength * i, tempBytes, 0, tempBytes.Length);
                byte[] encryptedBytes = rsaCryptoServiceProvider.Encrypt(tempBytes, true);

                Array.Reverse(encryptedBytes);

                stringBuilder.Append(Convert.ToBase64String(encryptedBytes));
            }
            return stringBuilder.ToString();

        }

        public string UnCoding(string Text2)
        {
            int len = Text2.Length;
            RSACryptoServiceProvider rsaCryptoServiceProvider = new RSACryptoServiceProvider(len);
            int base64BlockSize = ((len / 2) % 3 != 0) ? (((len / 8) / 3) * 4) + 4 : ((len / 8) / 3) * 4;
            int iterations = Text2.Length / base64BlockSize;
            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < iterations; i++)
            {
                byte[] encryptedBytes = Convert.FromBase64String(Text2.Substring(base64BlockSize * i, base64BlockSize));
                Array.Reverse(encryptedBytes);
                arrayList.AddRange(rsaCryptoServiceProvider.Decrypt(encryptedBytes, true));
            }
            return Encoding.UTF32.GetString(arrayList.ToArray(Type.GetType("System.Byte")) as byte[]);

        }
    }
}
