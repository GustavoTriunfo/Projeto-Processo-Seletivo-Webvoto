using Lacuna.Dev.Ingresso.LacunaGenetics.Abstraction;
using Lacuna.Dev.Ingresso.LacunaGenetics.Application.Extensions;
using Lacuna.Dev.Ingresso.LacunaGenetics.Entities;
using Lacuna.Dev.Ingresso.LacunaGenetics.Entities.Request;
using Lacuna.Dev.Ingresso.LacunaGenetics.Entities.Response;
using Lacuna.Dev.Ingresso.LacunaGenetics.Services;

namespace Lacuna.Dev.Ingresso.LacunaGenetics.UseCase
{
    public class OperationsDNAUseCase : IOperationsDNAUseCase
    {
        public void Execute()
        {
            Console.WriteLine("Início - Execute");
            //Criar usuario Exercicio Item 2.1
            CreateUser();

            //Pegar token Exercicio Item 2.2
            string token = GetToken();

            //Pegar job Exercicio Item 2.3
            var job = GetOperation(token);

            //Executar Operacao
            ExecuteOperation(job, token);
            Console.WriteLine("Fim - Execute");
        }
        private void CreateUser()
        {
            Console.WriteLine("Inicio - Cadastrando usuário");
            var request = new RequestUser() { username = "SteveClark", email = "email@.com", password = "senha@123" };
            var response = new ResponseUser();
            ConsumerAPIService<RequestUser, ResponseUser> consumerAPI = new ConsumerAPIService<RequestUser, ResponseUser>();
            response = consumerAPI.ConnectToApi(request, response);
            Console.WriteLine("Fim - Cadastrando usuário");
        }
        private string GetToken()
        {
            Console.WriteLine("Início - Recuperando Token");
            var request = new RequestToken() { username = "SteveClark", password = "senha@123" };
            var response = new ResponseToken();
            ConsumerAPIService<RequestToken, ResponseToken> consumerAPI = new ConsumerAPIService<RequestToken, ResponseToken>();
            response = consumerAPI.ConnectToApi(request, response);

            Console.WriteLine("Fim - Recuperando Token");
            return response.accessToken;
        }
        private Job GetOperation(string accessToken)
        {
            Console.WriteLine("Início - Recuperando Operacao");
            var request = new RequestOperation();
            var response = new ResponseOperation();
            ConsumerAPIService<RequestOperation, ResponseOperation> consumerAPI = new ConsumerAPIService<RequestOperation, ResponseOperation>();
            response = consumerAPI.ConnectToApi(request, response, accessToken);
            Console.WriteLine("Fim - Recuperando Operacao");
            return response.job;
        }
        private void ExecuteOperation(Job job, string accessToken)
        {
            Console.WriteLine("Início - Executa Operacao");
            var response = new Response();
            if (job.type.Equals("DecodeStrand"))
            {
                var request = new RequestDecoded() { strand = job.strandEncoded.ExecuteDecode() };
                ConsumerAPIService<RequestDecoded, Response> consumerAPI = new ConsumerAPIService<RequestDecoded, Response>();
                response = consumerAPI.ConnectToApi(request, response, accessToken, job.id);
            }
            else if (job.type == "EncodeStrand")
            {
                var request = new RequestEncoded() { strandEncoded = job.strand.ExecuteEncode() };
                ConsumerAPIService<RequestEncoded, Response> consumerAPI = new ConsumerAPIService<RequestEncoded, Response>();
                response = consumerAPI.ConnectToApi(request, response, accessToken, job.id);
            }
            else if (job.type == "CheckGene")
            {
                string fita = job.strandEncoded.ExecuteDecode();
                string gene = job.geneEncoded.ExecuteDecode();
                var request = new RequestGene() { isActivated = VerifyOperationGeneService.VerifyGene(fita, gene) };
                ConsumerAPIService<RequestGene, Response> consumerAPI = new ConsumerAPIService<RequestGene, Response>();
                response = consumerAPI.ConnectToApi(request, response, accessToken, job.id);
            }
            Console.WriteLine(response.code);
            Console.WriteLine(response.message);
            Console.WriteLine("Fim - Executa Operacao");
        }
    }
}
