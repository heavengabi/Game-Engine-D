using System;

class Variaveis
{

static void Main (string[] args){
    //Aqui, criei uma variável de número INTEIRO, com valor 15
    int numero = 15;
    Console.WriteLine(numero);
    Console.WriteLine(numero + 30);
    Console.WriteLine (numero + 10);
    Console.WriteLine(numero + 90);

    //Comentario de uma linha só
    /*
    //Comentário de mais de uma linha
    */
    /*Exercicio 1:VARIÁVEIS
    -Crie um novo arquivo
    -Nomeie ele como Exercicio 1
    -Coloque o código base
    -Crie 4 variaveis, some a primeira com a primeira, a primeira com a segunda, a primeira com a terceira e a primeira com a quarta
    */


    int idade = 16;                                    // NUMERO INTEIRO
    double altura = 1.68;                              // NUMERO COM PONTO FLUTUANTE
    char inicial = 'G';                                 // UM UNICO CARACTERE
    string nome = "Gabriela Silva da Rosa";              // TEXTO
    bool aprovado = true;                              // VERDADEIRO OU FALSO
    
    Console.WriteLine($"Meu nome é {nome}. Tenho {idade} anos.Minha altura é {altura}. Meu nome começa com a letra {inicial}. Estou aprovado na escola?  {aprovado}");
}
}