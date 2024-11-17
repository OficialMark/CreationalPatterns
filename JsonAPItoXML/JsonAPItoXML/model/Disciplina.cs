using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonAPItoXML.model
{
    public class Disciplina
    {
        public string id { get; set; }
        public string nome { get; set;}
        public string descricao { get; set; }

        public void ToString() 
        { 
             Console.WriteLine($"Id: {id}, Nome: {nome}, Descricao: {descricao}");
        }
    }
}
