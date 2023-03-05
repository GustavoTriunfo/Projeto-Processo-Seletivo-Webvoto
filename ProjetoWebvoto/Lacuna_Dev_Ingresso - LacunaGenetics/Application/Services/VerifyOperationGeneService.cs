namespace Lacuna.Dev.Ingresso.LacunaGenetics.Services
{
    public static class VerifyOperationGeneService
    {
        public static bool VerifyGene(string fita, string gene)
        {

            int selecaoLimite = gene.Length / 2;
            try
            {
                for (int i = 0; i <= gene.Length; i++)
                {
                    string textoExtraido = gene.Substring(i, selecaoLimite);

                    if (fita.Contains(textoExtraido))
                        return true;

                }

            }
            catch
            {
                return false;
            }
            return false;


        }
    }
}
