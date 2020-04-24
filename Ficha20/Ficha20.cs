using System;
using System.IO;
using System.Collections.Generic;

namespace Ficha20
{
    public class Ficha20
    {//Ficheiros

        #region exercicios ficha 20
        public static void exercicio1()
        {

            ///Cria uma pasta no teu ambiente de trabalho 2. Verifica se uma pasta existe


            string pasta = @"C:\Users\Sofia Cunha\Desktop\PastaFicha20";

            Console.WriteLine(Directory.Exists(pasta));

            ///Cria um ficheiro na pasta que criaste 
            ///4. Escreve uma mensagem no ficheiro. 
            ///5. Lê o conteúdo do ficheiro. Verifica se o conteúdo é o mesmo que foi inserido.

            string ficheiro = @"C:\Users\Sofia Cunha\Desktop\PastaFicha20\ficheiro.txt";

            Console.WriteLine(File.Exists(ficheiro));
            Console.WriteLine(File.ReadAllText(ficheiro));

            ///Apresenta a extensão de um ficheiro
            ///

            string extension = Path.GetExtension(ficheiro);
            Console.WriteLine(extension);


            ///Através de um caminho, obtêm o caminho para a pasta 
            ///8.Através de um caminho, obtêm o nome do ficheiro
            ///

            var caminho1= Path.GetFullPath(pasta);
            var caminho2= Path.GetFileName(ficheiro);
            Console.WriteLine(caminho1);
            Console.WriteLine(caminho2);

            ///Elimina o ficheiro 
            ///10. Elimina a pasta
            ///
            File.Delete(ficheiro);
            Directory.Delete(pasta);

        }

        #endregion
    }
}
