using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace JsonAPItoXML.model
{
    internal class EntityEndpointToJson
    {
        public async Task<string> GetJsonAsync(HttpClient client, string entidade)
        {
            try
            {
                string url = client.BaseAddress + entidade + "s"; // Exemplo: http://localhost:3000/alunos / "s" pois os endpoints estão no plural  
                Console.WriteLine("EntityEndpointToJson: " + url);

                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                return await response.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException e)
            {
                throw new HttpRequestException("Error on request: " + e.Message);
            }
        }
    }
}
