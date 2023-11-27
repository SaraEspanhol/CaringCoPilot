using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipov1.Helpers
{
    internal class HashandSalt
    {
        public static string HashPassword(string senha, string senha2, out string salt)
        {
            if (senha != senha2)
            {
                string textoErro = String.Format("As senhas não coincidem!");
                throw new ArgumentException(textoErro);
            }

            // Gerar um salt aleatório
            byte[] saltBytes = new byte[32];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(saltBytes);
            }
            salt = Convert.ToBase64String(saltBytes);

            // Concatenar senha com salt e calcular o hash
            string saltedPassword = senha + salt;
            byte[] hashedBytes = new Rfc2898DeriveBytes(saltedPassword, Encoding.UTF8.GetBytes(salt), 10000, HashAlgorithmName.SHA256).GetBytes(32);

            // Retornar o hash e o salt como strings concatenadas
            return Convert.ToBase64String(hashedBytes) + ":" + salt;
        }

        public static bool VerifyPassword(string password, string storedHashAndSalt)
        {
            // Separar o hash e o salt da string armazenada
            string[] parts = storedHashAndSalt.Split(':');
            if (parts.Length != 2)
            {
                return false; // Formato inválido
            }

            string storedHash = parts[0];
            string storedSalt = parts[1];

            // Concatenar senha com salt e calcular o hash
            string saltedPassword = password + storedSalt;
            byte[] hashedBytes = new Rfc2898DeriveBytes(saltedPassword, Encoding.UTF8.GetBytes(storedSalt), 10000, HashAlgorithmName.SHA256).GetBytes(32);

            // Comparar o hash calculado com o hash armazenado
            string calculatedHash = Convert.ToBase64String(hashedBytes);
            return storedHash.Equals(calculatedHash);
        }
    }
}
