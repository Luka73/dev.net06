using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entities;
using Projeto01.Controls;

namespace Projeto01
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Atribuição de Valores
            //instâncias
            Autor autor1 = new Autor();
            autor1.Livros = new List<Livro>();

            Livro livro1 = new Livro();
            livro1.Autor = new Autor();

            //setando valores do autor
            autor1.IdAutor = 1;
            autor1.Nome = "Tolkien";

            //setando valores dos livros
            livro1.IdLivro = 1;
            livro1.Titulo = "Senhor dos Aneis";
            livro1.Resumo = "Livro da trilogia Senhor dos Aneis";
            livro1.Autor = autor1; 

            //instânciar já setando os valores do livro2
            Livro livro2 = new Livro(2, "O Hobbit", "Livro da Saga do Hobbit");
            livro2.Autor = autor1;

            //relacionando o autor aos livros
            autor1.Livros.Add(livro1);
            autor1.Livros.Add(livro2);

            Console.WriteLine("\nDADOS DO AUTOR:\n");
            Console.WriteLine("\tId........: " + autor1.IdAutor);
            Console.WriteLine("\tNome......: " + autor1.Nome);

            Console.WriteLine("\nDADOS DOS LIVROS:\n");

            foreach (Livro i in autor1.Livros)
            {
                Console.WriteLine("\tId.........: " + i.IdLivro);
                Console.WriteLine("\tTítulo.....: " + i.Titulo);
                Console.WriteLine("\tResumo.....: " + i.Resumo);
                Console.WriteLine("\tAutor......: " + i.Autor.Nome);
                Console.WriteLine("---------------------------------");
            }
            #endregion

            //Exportando Autores
            try
            {
                AutorControle autorControle = new AutorControle();
                autorControle.ExportarParaCsv(autor1);

                Console.WriteLine("\nDados de Autor gravados com sucesso!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao exportar Autor: " + e.Message);
            }

            //Exportando Livros
            try
            {
                LivroControle livroControle = new LivroControle();
                livroControle.ExportarParaTxt(livro1);
                livroControle.ExportarParaTxt(livro2);

                Console.WriteLine("\nDados de Livros gravados com sucesso!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao exportar Livros: " + e.Message);
            }


            Console.ReadKey();
        }
    }
}
