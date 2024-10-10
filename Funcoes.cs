using System;
namespace Teste
{
    class Program
    {
              public void calculaAreaR (int baseR,int alturaR) {

            int areaR = baseR * alturaR;
            Console.WriteLine(areaR);
       
        int baseR = 5;
        int alturaR = 10;
        int areaR = baseR*alturaR;
        Console.WriteLine(areaR);
     }
        static void Main(string [] args )
        {
        
        Funcao meuObj = new Funcao();
        
        meuObj.calculaAreaR();
  

        }

    }
}
