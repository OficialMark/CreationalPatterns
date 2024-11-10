using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;
using System.Runtime.CompilerServices;
using JsonAPItoXML.model;
using JsonAPItoXML.Transform;
using JsonAPItoXML.model.Singleton;

namespace JsonAPItoXML
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            await GetUsersAsync();
        }

        public static async Task GetUsersAsync()
        {
            HttpClient client = WebService.GetInstance().GetClient();
            string entidade = "aluno";

            EntityEndpointToJson entityToJson = new EntityEndpointToJson();
            string responseBody = await entityToJson.GetJsonAsync(client, entidade);
            List<Aluno> alunos =JsonToAluno.Transform(responseBody);
            Console.WriteLine(responseBody);

            foreach(Aluno aluno in alunos)
            {
                aluno.toString();
            }
        }
    }
}