using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entities;
using Projeto01.Interfaces;
using System.IO;

namespace Projeto01.Controls
{
    public class AutorControle : IAutorControle
    {
        public void ExportarParaCsv(Autor autor)
        {
            using (StreamWriter sw = new StreamWriter("c:\\temp\\autores.csv", true))
            {
                sw.WriteLine($"{autor.IdAutor};{autor.Nome}");
            }
        }
    }
}
