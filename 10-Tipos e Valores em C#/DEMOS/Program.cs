using static System.Console;

public class Program
{
    /*//Demo 6.1 - Busca por pessoa
    static bool EncontrarPessoa(List<Pessoa> pessoas, Pessoa pessoa)
    {
        foreach (var item in pessoas)
        {
            if(item.Nome = pessoa.Nome)
            {
                return true;
            }
        }
        return false;
    }
   public static void Main()
   {
        List <Pessoa> pessoas = new List<Pessoa>()
        {
           new Pessoa(){Nome = "Ricardo"},
           new Pessoa(){Nome = "José"},
           new Pessoa(){Nome = "Maria"},
           new Pessoa(){Nome = "Fabiana"},
           new Pessoa(){Nome = "Eduardo"},
        };

        WriteLine("Digite a pessoa que gostaria de localizar:");
        var nome = ReadLine();
        var pessoa = new Pessoa(){Nome = nome};
        var encontrado = EncontrarPessoa(pessoas, pessoa);
        if(encontrado)
        {
            WriteLine("Pessoa localizada!");
        }
        else
        {
            WriteLine("Pessoa não localizada");
        }
    }*/


    /*//Demo 6 não funciono no meu ambiente, não consigui achar o erro
    static int EncontrarNumero(int[] numeros, int numero)
    {
        for (int i = 0; i < numeros.Length; i++)
        {
            if(numeros[i] = numero)
            return i;
         }
         return -1;
     }
    public static void Main()
    {
        int[] numeros = new int[]{0,2,4,6,8};
        WriteLine($"Digite o número que gostaria de encontrar");
        var numero = int.Parse((ReadLine());
        var idxEncontrado = EncontrarNumero(numeros, numero);

        if(idxEncontrado >0)
        {
             WriteLine($"O número digitado está na posição {idxEncontrado}");
        }
       else
       {
           WriteLine("O número digitado não foi encontrado");
       }
    }*/

   /*//DEMO 5, ALTEROU O ARRAY DE Nº PARES PARA UM ARRAY DE IMPARES.
    static void MudarParaImpar(int[] pares)
    {
        for (int i = 0; i < pares.Length; i++)
        {
            pares[i] = pares[i] + 1;
         }
     }
    public static void Main()
    {
        int[] pares = new int[]{0,2,4,6,8};

        MudarParaImpar(pares);

         WriteLine($"Os impares {string.Join(",", pares)}");
    }*/


    /*///4.1 - O exercicio pedia para devolver o nome alterado o código da Demo não faz isso e não tem outro
    //video corrigindo isso, o único jeito q consegui fazer foi usando a estrutura PESSOA, mas não sei se está
    //correto, poderia tentar usar um return, mas o exercicio diz q o metódo tem que ser void. 
     static void TrocarNome(Pessoa p1, string nomeNovo)
        {
           p1.Nome = nomeNovo;
        }

        public static void Main()
        {
            Pessoa p1 = new Pessoa();
            p1.Nome = "Luciane";
            
            TrocarNome(p1, "Cristina");

            Console.WriteLine($"O novo nome é {p1.Nome}");
        }*/

   /* //4 - NÃO HOUVE A TROCA DO NOME, POIS A TROCA OCORREU APENAS DENTRO DO MÉTODO TROCARNOME QUE É VOID E
    //NÃO RETORNOU, QUANDO O METODO MORREU, MORREU A ALTERAÇÃO TB. 
     static void TrocarNome(string nome, string nomeNovo)
        {
            nome = nomeNovo;
        }

        public static void Main()
        {
            string nome = "Luciane";
            
            TrocarNome(nome, "Cristina");

            Console.WriteLine($"O novo nome é {nome}");
        }*/

     /*//3.3 NESSA DEMO FOI REALIZADO POR STRUCT QUE É VALUE TYPE, DESSA VEZ HOUVE A ALTERAÇÃO, POIS O RETURN
    //DO METODO TROCARNOME GARANTE QUE O VALOR ALTERADO SEJA PASSADO PRA A MAIN. E AO ATRIBUIR P1=TROCARNOME 
    //RECEBEU O NOVO VALOR
    static StructPessoa TrocarNome(StructPessoa p1, string nomeNovo)
        {
            p1.Nome = nomeNovo;
            return p1;
        }
    public static void Main()
    {
        StructPessoa p1 = new StructPessoa
        {
            Documento = "1234",
            Idade = 30,
            Nome = "Ricardo"
        };
            
        var p2 = p1;

       p1 = TrocarNome(p1, "João");

        Console.WriteLine($@"
        Nome do p1 {p1.Nome}
        Nome do p1 {p2.Nome}
        ");
    } */

    /*//3.3 NESSA DEMO FOI REALIZADO POR STRUCT QUE É VALUE TYPE, PORÉM NÃO HOUVE A MUDANÇA NO NOME RICARDO, UMA
    //VEZ Q A TROCA OCORREU APENAS DENTRO DO METODO TROCARNOME E ELE É VOID O Q NÃO RETORNA RESULTADO, SENDO 
    //ASSIM A ALTERAÇÃO FICOU APENAS NO TROCARNOME E MORREU COM ELE.
    static void TrocarNome(StructPessoa p1, string nomeNovo)
        {
            p1.Nome = nomeNovo;
        }
    public static void Main()
    {
        StructPessoa p1 = new StructPessoa
        {
            Documento = "1234",
            Idade = 30,
            Nome = "Ricardo"
        };
            
        var p2 = p1;

        TrocarNome(p1, "João");

        Console.WriteLine($@"
        Nome do p1 {p1.Nome}
        Nome do p1 {p2.Nome}
        ");
    } */

   /*//DEMO 3.2 - NESSA DEMO FOI CRIADO UM MÉTODO NA CLASSE PESSOA COM O NOME DE CLONE E CHAMA NA LINHA PESSOA 
   //P2 = P1.CLONE, ISSO É PARA DEIXAR O CÓDIGO MAIS LIMPO
    static void TrocarNome(Pessoa p1, string nomeNovo)
        {
            p1.Nome = nomeNovo;
        }
    public static void Main()
    {
        Pessoa p1 = new Pessoa();
        p1.Nome = "Ricardo";
        p1.Idade = 30;
        p1.Documento = "1234";

        Pessoa p2 = p1.Clone();
               
        TrocarNome(p1,"José");

        Console.WriteLine($@"
        O nome de p1 é: {p1.Nome}
        O nome de p2 é: {p2.Nome}
        ");
    } */

    /*//DEMO 3.1 - NESSA DEMO O NOME DE P1 FOI TROCADO E P2 NÃO, PQ FOI CRIADO UMA NOVA ESTRUTURA PARA P2 NA
    //LINHA PESSOA P2 = NEW PESSOA
    static void TrocarNome(Pessoa p1, string nomeNovo)
    {
        p1.Nome = nomeNovo;
    }
    public static void Main()
    {
        Pessoa p1 = new Pessoa();
        p1.Nome = "Ricardo";
        p1.Idade = 30;
        p1.Documento = "1234";

        Pessoa p2 = new Pessoa();
        p2.Documento = p1.Documento;
        p2.Nome = p1.Nome;
        p2.Idade = p1.Idade;
        
        TrocarNome(p1,"José");

        Console.WriteLine($@"
        O nome de p1 é: {p1.Nome}
        O nome de p2 é: {p2.Nome}
        ");
    } */

   /*//DEMO3 - ESSE EXEMPLO ALTEROU O NOME DE P2 E P1, POIS NA LINHA PESSOA P2 = P1 FOI PASSADO APENAS A
   //REFERENCIA DO PONTEIRO
    static void TrocarNome(Pessoa p1, string nomeNovo)
        {
            p1.Nome = nomeNovo;
        }
    public static void Main()
    {
        Pessoa p1 = new Pessoa();
        p1.Nome = "Ricardo";
        p1.Idade = 30;
        p1.Documento = "1234";

        Pessoa p2 = p1;
        
        TrocarNome(p1,"José");

        Console.WriteLine($@"
        O nome de p1 é: {p1.Nome}
        O nome de p2 é: {p1.Nome}
        ");
    } */

    /*//DEMO 2
    static void TrocarNome(Pessoa p1, string nomeNovo)
    {
        p1.Nome = nomeNovo;
    }
    public static void Main()
    {
        Pessoa p1 = new Pessoa();
        p1.Nome = "Ricardo";
        p1.Idade = 30;
        p1.Documento = "1234";

        TrocarNome(p1,"José");

        Console.WriteLine($"O novo nome é : {p1.Nome}");
    }*/

    /*//DEMO 1
    static int Adicionar20(int x)
    {
        return x + 20;
    }
    public static void Main()
    {
        int a = 2;
        a = Adicionar20(a);
        Console.WriteLine($"O valor da variável a é: {a}");
    }*/
}
