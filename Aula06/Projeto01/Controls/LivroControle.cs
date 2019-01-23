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
    public class LivroControle : ILivroControle
    {
        public void ExportarParaTxt(Livro livro)
        {
            using (StreamWriter sw = new StreamWriter("c:\\temp\\livros.txt", true))
            {
                sw.WriteLine("Id do Livro......: " + livro.IdLivro);
                sw.WriteLine("Título...........: " + livro.Titulo);
                sw.WriteLine("Resumo...........: " + livro.Resumo);
                sw.WriteLine("Autor............: " + livro.Autor.Nome);
            }
        }
    }
}
