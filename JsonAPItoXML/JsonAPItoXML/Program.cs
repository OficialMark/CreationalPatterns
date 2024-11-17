using JsonAPItoXML.model;
using JsonAPItoXML.Process;

namespace JsonAPItoXML
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            await EntityEndpointToXML.Process<Aluno>();
            await EntityEndpointToXML.Process<Disciplina>();
            await EntityEndpointToXML.Process<Matricula>();
        }
    }
}