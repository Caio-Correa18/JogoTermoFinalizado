using System.Data.Common;
using System.Xml.Serialization;

namespace TermoLib
{


    public class Letra
    {
        public Letra(char caracter, char cor)
        {
            Caracter = caracter;
            Cor = cor;
        }
        
        public char Caracter;
        public char Cor;

    }

    public class Termo
    {

        public List<string> palavras;
        public string palavraSorteada;
        public List<List<Letra>> tabuleiro;
        public Dictionary<char, char> teclado;
        public int palavraAtual;
        public bool jogoFinalizado = false;
        public bool checaPalavraValido = false;

        public Termo()
        {
            CarregaPalavras("Palavras.txt");
            SorteiaPalavra();
            palavraAtual = 1;
            tabuleiro = new List<List<Letra>>();
            teclado = new Dictionary<char, char>();
            for(int i = 65; i <= 90; i++)
            {
                // Cinza = Não digitado | Verde = Posição correta
                // Amarelo = na palavra | Preto = não faz parte
                teclado.Add((char)i, 'C');
            }
        }

        public void CarregaPalavras(string fileName)
        {
            palavras = File.ReadAllLines(fileName).ToList();

        }

        public void SorteiaPalavra()
        {
            Random rdn = new Random();
            var index = rdn.Next(0, palavras.Count() - 1);
            palavraSorteada = palavras[index];
        }

        public int ChecaPalavra(string palavra)
        {
            int ret = 0;
            
            if(palavra.Length != 5)
            {
                Console.WriteLine("Número inválido de letras");
                ret = 0;

            }
            else
            {
                ret = 1;
            }


            if (palavra == palavraSorteada)
            {
                jogoFinalizado = true;
            }

            //Adicionando palavra na matriz do tabuleiro

            if(ret == 1)
            {
                var palavraTabuleiro = new List<Letra>();
                char cor;
                for (int i = 0; i < palavra.Length; i++)
                {

                    if (palavra[i] == palavraSorteada[i])
                    {
                        cor = 'V';
                    }
                    else if (palavraSorteada.Contains(palavra[i]))
                    {
                        cor = 'A';
                    }
                    else
                    {
                        cor = 'C';
                    }
                    palavraTabuleiro.Add(new Letra(palavra[i], cor));
                    teclado[palavra[i]] = cor;

                }
                tabuleiro.Add(palavraTabuleiro);
                palavraAtual++;

            }
            

            return ret;
        }

        public void resetTermo()
        {

        }


    }
}
