using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text;

namespace Manipulando_arquivos
{
    internal class Program
    {
        static void Main(string[] args)
        {

                
                StreamWriter escritor = new StreamWriter("C:\\Estudos c#\\Test1.txt");// Criando o arquivo .TXT
                escritor.WriteLine("Diogo");// escrevendo dentro do arquivo
                escritor.Close();
               
                Console.WriteLine("Arquivo Gerado com sucesso!");
          
                Console.ReadLine();
        }
    }
}
