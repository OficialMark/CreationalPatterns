using JsonAPItoXML.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace JsonAPItoXML.Transform
{
    internal class JsonToAluno
    {
        public static List<Aluno> Transform(string responseBody)
        {
            var options = new JsonSerializerOptions {PropertyNameCaseInsensitive = false};
            return JsonSerializer.Deserialize<List<Aluno>>(responseBody, options);
        }
}
}
