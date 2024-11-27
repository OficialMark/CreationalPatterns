using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonAPItoXML.model
{
    public class Matricula
    {
        public string id { get; set;}
        public int alunoId { get; set;}
        public int disciplinaId { get; set;}

        public void toString() 
        { 
             Console.WriteLine($"Id: {id}, AlunoId: {alunoId}, DisciplinaId: {disciplinaId}");
        }

        public Matricula Clone()
        {
            return new Matricula()
            {
                id = this.id,
                alunoId = this.alunoId,
                disciplinaId = this.disciplinaId
            };
        }
    }
}
