using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Prototipov1.Helpers
{
    public class Validacoes
    {

        public static bool IsValidEmail(string email)
        {
            // Definir a expressão regular para validar o formato do e-mail
            string pattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";

            // Criar um objeto Regex com a expressão regular
            Regex regex = new Regex(pattern);

            // Testar se o e-mail corresponde ao padrão
            return regex.IsMatch(email);
        }

        public static bool IsValidTelefone(string telefone)
        {
            // Definir a expressão regular para validar o formato do telefone
            string pattern = @"^\d{10,11}$";

            // Criar um objeto Regex com a expressão regular
            Regex regex = new Regex(pattern);

            // Testar se o e-mail corresponde ao padrão
            telefone = LimparNumeros(telefone);
            return regex.IsMatch(telefone);
        }

        public static string LimparNumeros(string input)
        {
            // Utilizar expressão regular para manter apenas os dígitos
            string pattern = @"[^\d]";
            Regex regex = new Regex(pattern);
            return regex.Replace(input, "");
        }

        public static string ValidaData(string dataBrasileira)
        {
            DateTime data;
            if (DateTime.TryParseExact(dataBrasileira, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out data))
            {
                // Converter a data para uma string no formato ISO (yyyy-MM-dd)
                string dataFormatoISO = data.ToString("yyyy-MM-dd");
                return dataFormatoISO;
            }
            else
            {
                string textoErro = String.Format("Insira uma data válida!");
                throw new ArgumentException(textoErro);
            }
        }

    }
}
