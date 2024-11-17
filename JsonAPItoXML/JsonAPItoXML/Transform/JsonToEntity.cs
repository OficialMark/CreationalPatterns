using JsonAPItoXML.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace JsonAPItoXML.Transform
{
    internal class JsonToEntity
    {
        public static List<T> Transform<T>(string responseBody, string entidade)
        {
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = false };
            if (entidade == "aluno")
            {
                return JsonSerializer.Deserialize<List<Aluno>>(responseBody, options) as List<T>;
            }

            if (entidade == "disciplina")
            {
                return JsonSerializer.Deserialize<List<Disciplina>>(responseBody, options) as List<T>;
            }

            if (entidade == "matricula")
            {
                return JsonSerializer.Deserialize<List<Matricula>>(responseBody, options) as List<T>;
            }

            return null;
        }
    }
}
