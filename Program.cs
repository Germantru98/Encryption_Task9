using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption_Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataPharser dp = new DataPharser();
            Encryptor encryptor = new Encryptor();
            var message = dp.getMessage();
            Console.Write("Введите пароль: ");
            var pass = Console.ReadLine();
            var encryptedMessageByPass = encryptor.Encrypt(message, pass);
            Console.WriteLine("Зашифрованное сообщение {0}", encryptedMessageByPass);
            Console.WriteLine("Расшифрованное сообщение {0}", encryptor.Decrypt(encryptedMessageByPass, pass));
        }
    }
}
