namespace Lacuna.Dev.Ingresso.LacunaGenetics.Application.Extensions
{
    public static class DecodeExtension
    {
    public static string ExecuteDecode(this string base64)
        {
            byte[] dados = Convert.FromBase64String(base64);
            string msg = System.Text.ASCIIEncoding.ASCII.GetString(dados);
            return msg;
        }
       

    }
}
