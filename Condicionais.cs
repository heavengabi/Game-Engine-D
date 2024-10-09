// Condicionais são estruturas que permite que um bloco de código seja executado se obedecer uma determinada condição
using System;

    class Condicionais
    
    {

        static void Main (string[] args){
        
            bool TemCarteira = true;
            bool MaiorIdade = 29 >= 18;
          
    
            //SE EU TENHO CARTEIRA

        if (TemCarteira && MaiorIdade ){

        //BLOCO DE CODIGO A SER EXECUTADO SE A CONDIÇÃO FOR VERDADEIRA

        Console.WriteLine("você pode dirigir.");
        } else if (!TemCarteira && MaiorIdade){
        Console.WriteLine ("Voce é maior de idade, mas nao tem carteira. Portanto, nao pode dirigir");
        }
    
         else {
            Console.WriteLine ("Voce nao pode dirigir.");
    }
  string nacionalidade = "brasileiro";
        
        if (nacionalidade == "brasileiro"){
            Console.WriteLine("E aí cpx");
        } else if (nacionalidade == "americano"){
            Console.WriteLine("Você disse petróleo?");
        } else if (nacionalidade == "russo"){
            Console.WriteLine("Cade os ucranianos?");
        } else {
            Console.WriteLine("Nacionalidade não encontrada.");
        }
        

        switch (nacionalidade){

            case "brasileiro":
                Console.WriteLine("E aí cpx");
            break;

            case "americano":
                Console.WriteLine("Você disse petróleo?");
            break;

            case "russo":
                Console.WriteLine("Cade os ucranianos?");
            break;

            default:
                Console.WriteLine("Nacionalidade não encontrada.");
            break;
        }




        // Usando switch, crie uma variavel chamada meuTime
        //faça um switch com cada case representando um time, e imprima algo diferente para cada um
        // nao esqueça do default


        
        
    }
    }