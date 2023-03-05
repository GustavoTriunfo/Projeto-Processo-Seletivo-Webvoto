using System.Text;

namespace Lacuna.Dev.Ingresso.LacunaGenetics.Application.Extensions
{
    public static class EncodeExtension
    {
        public static string ExecuteEncode( this string msg)
        {
            byte[] dados = Encoding.ASCII.GetBytes(msg);
            string base64 = Convert.ToBase64String(dados);
            return base64;
        }
    }
}
