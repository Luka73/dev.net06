using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto02.Entities;
using Projeto02.Interfaces;
using System.IO;
using System.Xml;

namespace Projeto02.Controls
{
    public class ProdutoControle : IControle<Produtos>
    {
        public void ExportarParaCsv(Produtos obj)
        {
            using (StreamWriter sw = new StreamWriter("c:\\temp\\produtos.csv", true))
            {
                sw.WriteLine($"{obj.IdProduto};{obj.Nome};{obj.Preco}");
            }
        }

        public void ExportarParaTxt(Produtos obj)
        {
            using (StreamWriter sw = new StreamWriter("c:\\temp\\produtos.txt", true))
            {
                sw.WriteLine("Id.......: " + obj.IdProduto);
                sw.WriteLine("Nome.....: " + obj.Nome);
                sw.WriteLine("Preço....: " + obj.Preco);
                sw.WriteLine("-------------");
            }
        }

        public void ExportarParaXml(Produtos obj)
        {
            using (XmlWriter xml = XmlWriter.Create("c:\\temp\\produtos.xml"))
            {
                xml.WriteStartDocument();

                xml.WriteStartElement("produtos");
                xml.WriteElementString("idproduto", obj.IdProduto.ToString());
                xml.WriteElementString("nome", obj.Nome);
                xml.WriteElementString("preco", obj.Preco.ToString());
                xml.WriteEndElement();
            }
        }
    }
}
