using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonAPItoXML.model
{
    public class Aluno
    {
        public string id { get; set; }
        public string nome { get; set; }
        public string endereco { get; set; }

        public void toString() 
        { 
             Console.WriteLine($"Id: {id}, Nome: {nome}, Endereco: {endereco}");
        }

        public Aluno Clone() {
            return new Aluno()
            {
                id = this.id,
                nome = this.nome,
                endereco = this.endereco
            };
        }
    }
}
