using JsonAPItoXML.model.Singleton;
using JsonAPItoXML.model;
using JsonAPItoXML.Sink;
using JsonAPItoXML.Transform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace JsonAPItoXML.Process
{
    internal class EntityEndpointToXML
    {
        public static async Task Process<T>()
        {
            HttpClient client = WebService.GetInstance().GetClient();
            string entidade = typeof(T).Name.ToLower();

            EntityEndpointToJson entityToJson = new EntityEndpointToJson();
            string responseBody = await entityToJson.GetJsonAsync(client, entidade);
            List<T> lista = JsonToEntity.Transform<T>(responseBody, entidade);

            ClassToXML.Execute<T>(lista);
        }
    }
}
