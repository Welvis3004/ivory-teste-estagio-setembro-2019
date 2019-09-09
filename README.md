# ivory-teste-estagio-setembro-2019
Avaliação para vaga de estágio da Empresa Ivory IT.

<h2><b>QUESTÃO 01 - Análise</b></h2>
    
```
class Program
    {
        static void Main(string[] args)
        {
            int numero = 5;
            int resultado;

            resultado = Calcular(numero);

            Console.WriteLine("Resultado: {0}", resultado);
            Console.ReadKey();
        }

        static int Calcular(int numero)
        {
            int resultado;
            if (numero <= 1)
            {
                return (1);
            }
            else
            {
                resultado = numero * Calcular(numero--);
                return (resultado);
            }
        }
    }
```
<b>Objetivo do programa:</b> Calculo fatorial de um numero inteiro.

<b>Execução:</b> O programa recebe um numero inteiro como entrada e retorna o resultado do calculo de seu fatorial.

<b>Resultado exibido me tela:</b>

``'System.StackOverflowException: 'Exception of type 'System.StackOverflowException' was thrown.'``

<b>Erro:</b> Há um erro na recursividade da função Calcular().
No else da função Calcular(), o decremento do numero ocorre após a chamada da função,
O que sempre leva o mesmo numero inteiro inifitamente como parametro da função. No caso, sempre será enviado o parametro INTEIRO 5.
Causando assim o erro acima, overflow (Estouro de memória).

<b>Erros de codificação:</b> Segundo as dicas: <a href="https://github.com/ivory-it/ivoryit-testeestagio-detetive/wiki/Padronização-codificação">Dicas Ivory.</a>
A função <i>'if'</i> possui um espaçamento entre o <i>'('.</i> Necessário remove-lo.

<b>Solução para o Programa:</b> Como solução, proponho o decremento da variavel <i>'numero'</i> seja feito antes da chamada da função Calcular().
Dessa forma abaixo:
```
resultado = numero * Calcular(--numero);
```
