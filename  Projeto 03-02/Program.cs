namespace MeuSegundoApp;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Digite um número: ");
        var escolha = int.Parse(Console.ReadLine());


        switch (escolha)
        {
            case 1:

                /*
                OPERAÇÕES MATEMÁTICAS SIMPLES (VARIÁVEIS E OPERADORES)
                CRIE UM PROGRAMA QUE PEÇA AO USUÁRIO DOIS NÚMEROS E EXIBA A SOMA, SUBTRAÇÃO, MULTIPLICAÇÃO E DIVISÃO ENTRE ELES.
                */

                Console.WriteLine("Digite um número: ");
                var numero1 = int.Parse(Console.ReadLine());
                
                Console.WriteLine("Digite outro número: ");
                var numero2 = int.Parse(Console.ReadLine());

                System.Console.WriteLine($@"Soma: {numero1 + numero2}
Subtração: {numero1 - numero2}
Multiplicação: {numero1 * numero2}
Divisão: {(double)numero1 / numero2}");

                Console.Clear();
            
            break;

            case 2:

                /*
                CÁLCULO DE DESCONTO (OPERADORES E CONDICIONAL)PEÇA O VALOR DE UM PRODUTO E A PORCENTAGEM DE DESCONTO.
                CALCULE E EXIBA O VALOR FINAL COM DESCONTO APLICADO.
                */

                System.Console.Write("Digite o valor incial do produto: ");
                double valor = double.Parse(Console.ReadLine());

                System.Console.Write("Digite a porcentagem do desconto: ");
                double desconto = double.Parse(Console.ReadLine());
                
                System.Console.WriteLine($"Valor inicial: {valor}\nValor do desconto: {valor * (desconto/100)}\nValor total: {valor - (valor * (desconto/100))}");

            break;

            case 3:

                /*
                CONTAGEM DE NÚMEROS PARES (LAÇO DE REPETIÇÃO)
                ESCREVA UM PROGRAMA QUE EXIBA TODOS OS NÚMEROS PARES DE 1 A 20 USANDO UM LAÇO FOR.
                */
                
                Console.Clear();

                for (int numero = 0; numero <= 20; numero++)
                {
                    if ((numero % 2) == 0)
                    {
                        System.Console.WriteLine(numero);
                    }
                }

            break;

            case 4:

                /*
                SOMA DOS NÚMEROS DE UM INTERVALO (LAÇO DE REPETIÇÃO E CONDICIONAL)
                PEÇA AO USUÁRIO DOIS NÚMEROS A E B E CALCULE A SOMA DE TODOS OS NÚMEROS ENTRE ELES, INCLUINDO A E B.
                */

                System.Console.Write("Digite o número de início: ");
                var numeroInicial = float.Parse(Console.ReadLine());

                System.Console.Write("Digite o número de parada:");
                var numeroFinal = float.Parse(Console.ReadLine());

                float somaFor = 0;

                for (float numeroFor = numeroInicial; numeroFor <= numeroFinal; numeroFor++)
                {
                    somaFor += numeroFor;
                }

                System.Console.WriteLine($"A soma de todos os números entre {numeroInicial} e {numeroFinal} é {somaFor}");
                

            break;

            case 5:

                /*
                MANIPULAÇÃO DE ARRAYS (ARRAYS E LAÇO DE REPETIÇÃO)
                PEÇA 5 NÚMEROS AO USUÁRIO, ARMAZENE-OS EM UM ARRAY E EXIBA OS VALORES NA ORDEM INVERSA.
                */

                float[] listaNumero = new float[5];

                for (int pos = 0; pos < 5; pos++)
                {
                    Console.Write("Digite um número: ");
                    listaNumero[pos] = float.Parse(Console.ReadLine());
                }

                Console.Clear();

                for (int posInv = 4; posInv > -1; posInv--)
                {
                    Console.WriteLine(listaNumero[posInv]);
                }

            break;

            case 6:

                /*
                BUSCA EM UM ARRAY (ARRAYS E CONDICIONAL)
                PEÇA AO USUÁRIO PARA DIGITAR 5 NÚMEROS E DEPOIS UM NÚMERO ESPECÍFICO PARA BUSCAR NO ARRAY. INFORME SE O
                NÚMERO ESTÁ PRESENTE.
                */

                float[] listaNumero1 = new float[5];

                for (int pos1 = 0; pos1 < 5; pos1++)
                {
                    Console.Write("Digite um número: ");
                    listaNumero1[pos1] = float.Parse(Console.ReadLine());
                }

                System.Console.WriteLine("Digite um número para buscar");
                var numeroBusca = float.Parse(Console.ReadLine());

                for (int posInv1 = 4; posInv1 > -1; posInv1--)
                {
                    if (listaNumero1[posInv1] == numeroBusca)
                    {
                        System.Console.WriteLine($"O número {listaNumero1[posInv1]} está presente no array");
                    }
                }
            
            break;

            case 7:

                /*
                MÉTODO PARA CÁLCULO DE MÉDIA (MÉTODOS E PARÂMETROS)
                CRIE UM MÉTODO QUE RECEBA TRÊS NOTAS E RETORNE A MÉDIA DO ALUNO. NO PROGRAMA PRINCIPAL, PEÇA AS NOTAS AO
                USUÁRIO E USE O MÉTODO PARA EXIBIR A MÉDIA.
                */

                System.Console.Write("Digite uma nota: ");
                var nota1 = float.Parse(Console.ReadLine());
                
                System.Console.Write("Digite mias uma nota:");
                var nota2 = float.Parse(Console.ReadLine());

                System.Console.Write("Digite a ultima nota: ");
                var nota3 = float.Parse(Console.ReadLine());

                Console.Clear();

                System.Console.WriteLine($"A média das notas é {(nota1 + nota2 + nota3) / 3}");

            break;

            case 8:

                /*
                VERIFICAÇÃO DE NÚMERO PRIMO (MÉTODOS E LAÇO DE REPETIÇÃO)
                CRIE UM MÉTODO QUE RECEBA UM NÚMERO E RETORNE SE ELE É PRIMO.
                */

                System.Console.Write("Digite um número: ");
                var primo = double.Parse(Console.ReadLine());

                int contagemPrimo = 0;

                for (int ePrimo = 1; ePrimo <= primo; ePrimo++)
                {
                    if ((primo/ ePrimo) == 1)
                    {
                        contagemPrimo++;
                    }

                    System.Console.WriteLine(contagemPrimo);
                }

                if (contagemPrimo == 1)
                {
                    System.Console.WriteLine($"O número {primo} é primo");
                }
                else
                {
                    System.Console.WriteLine($"O número {primo} não é primo");
                }





            break;

        }
        

    }
}
